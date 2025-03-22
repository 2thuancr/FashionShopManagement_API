using System.Text;
using DTO.Accounts;
using DTO.ApiResponses;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var configuration = builder.Configuration;

            // Cấu hình Authentication & Authorization
            ConfigureAuthentication(builder.Services, configuration);

            // Cấu hình Swagger
            ConfigureSwagger(builder.Services);

            // Cấu hình CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins", policy =>
                    policy.AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod());
            });

            // Thêm Controllers
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();

            // Cấu hình Database & API Response
            ConfigDatabase();
            ConfigApiResponse(builder);

            var app = builder.Build();

            // Middleware pipeline
            app.UseHttpsRedirection();
            app.UseCors("AllowAllOrigins");
            app.UseAuthentication();
            app.UseAuthorization();

            // Kích hoạt Swagger
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
            });

            // Redirect trang chủ đến Swagger UI
            app.UseRewriter(new RewriteOptions().AddRedirect("^$", "swagger"));

            // Ánh xạ controller
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.Run();
        }

        /// <summary>
        /// Cấu hình JWT Authentication
        /// </summary>
        private static void ConfigureAuthentication(IServiceCollection services, IConfiguration configuration)
        {
            var jwtSettings = configuration.GetSection("JwtSettings");
            var key = Encoding.UTF8.GetBytes(jwtSettings["Secret"]);

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = jwtSettings["Issuer"],
                        ValidAudience = jwtSettings["Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(key)
                    };
                });

            services.AddAuthorization();
        }

        /// <summary>
        /// Cấu hình Swagger với Authentication
        /// </summary>
        private static void ConfigureSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API V1", Version = "v1" });

                // Cấu hình xác thực JWT cho Swagger UI
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "Nhập JWT token vào ô bên dưới (không cần 'Bearer ' prefix)"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] {}
                    }
                });
            });
        }

        /// <summary>
        /// Cấu hình Database
        /// </summary>
        private static void ConfigDatabase()
        {
            Account.ConnectionString = Account.connectionStringUser;
            Account.ConnectionName = Account.connectionNameUser;
        }

        /// <summary>
        /// Cấu hình API Response
        /// </summary>
        private static void ConfigApiResponse(WebApplicationBuilder? builder)
        {
            if (builder == null)
                return;

            builder.Services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = context =>
                {
                    var validationProblemDetails = new ValidationProblemDetails(context.ModelState)
                    {
                        Title = "Validation Error",
                        Status = StatusCodes.Status400BadRequest,
                        Detail = "One or more validation errors occurred.",
                        Instance = context.HttpContext.Request.Path
                    };

                    var exceptionDetail = context.ModelState.Values
                        .SelectMany(e => e.Errors.Select(err => err.ErrorMessage))
                        .ToList();

                    var response = new ApiResponse<ValidationProblemDetails>
                    {
                        IsSuccess = false,
                        Message = "Validation failed",
                        ErrorCode = "VALIDATION_ERROR",
                        ExceptionDetail = string.Join("\n", exceptionDetail),
                        Data = validationProblemDetails
                    };

                    return new BadRequestObjectResult(response)
                    {
                        ContentTypes = { "application/json" }
                    };
                };
            });
        }
    }
}
