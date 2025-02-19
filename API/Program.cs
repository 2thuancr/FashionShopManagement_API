using DTO.Accounts;
using DTO.ApiResponses;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            // Đọc cấu hình JWT từ appsettings.json
            var jwtSettings = builder.Configuration.GetSection("JwtSettings");
            var key = Encoding.UTF8.GetBytes(jwtSettings["Secret"]);

            // Add services to the container.

            builder.Services
                .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
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

            builder.Services.AddAuthorization();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    builder => builder.AllowAnyOrigin()
                                      .AllowAnyHeader()
                                      .AllowAnyMethod());
            });

            ConfigDatabase();
            ConfigApiResponse(builder);

            var app = builder.Build();

            app.UseAuthentication();  // Kích hoạt xác thực JWT
            app.UseAuthorization();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseSwagger();
            //    app.UseSwaggerUI();
            //}

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
                //options.RoutePrefix = string.Empty; // Đặt Swagger ở root "/"
            });

            // Cấu hình để tự động redirect tới /swagger
            app.UseRewriter(new RewriteOptions().AddRedirect("^$", "swagger"));

            app.UseHttpsRedirection();

            app.UseCors("AllowAllOrigins");

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }

        public static void ConfigDatabase()
        {
            Account.ConnectionString = Account.connectionStringUser;
            Account.ConnectionName = Account.connectionNameUser;
        }

        public static void ConfigApiResponse(WebApplicationBuilder? builder)
        {
            if (builder == null)
            {
                return;
            }

            builder.Services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = context =>
                {
                    // Sử dụng ValidationProblemDetails của ASP.NET Core
                    var validationProblemDetails = new ValidationProblemDetails(context.ModelState)
                    {
                        //Type = "https://example.com/validation-error",
                        Title = "Validation Error",
                        Status = StatusCodes.Status400BadRequest,
                        Detail = "One or more validation errors occurred.",
                        Instance = context.HttpContext.Request.Path
                    };

                    var exceptionDetail = context.ModelState.Values.SelectMany(e => e.Errors.Select(e => e.ErrorMessage)).ToList();

                    // Bao bọc ValidationProblemDetails trong cấu trúc tùy chỉnh
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
