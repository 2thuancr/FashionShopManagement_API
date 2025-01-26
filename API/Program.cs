using DTO.Accounts;
using DTO.ApiResponses;
using Microsoft.AspNetCore.Mvc;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

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

            // Redirect root ("/") đến Swagger UI
            app.MapGet("/", context =>
            {
                context.Response.Redirect("/swagger");
                return Task.CompletedTask;
            });

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
