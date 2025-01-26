using DTO.ApiResponses;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;
using Shared.Helpers;

namespace API.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<string> Get()
        {
            return Ok($"[{DateTime.UtcNow:O}] API is running...");
        }

        [HttpPost]
        [Route("SendEmailBySMTP")]
        public async Task<ActionResult<ApiResponse<SendEmailBySMTPOutput>>> SendEmailBySMTP(SendEmailBySMTPInput input)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(input.Title))
                {
                    input.Title = $"SendEmailBySMTP - {DateTime.UtcNow:O}";
                }

                if (string.IsNullOrWhiteSpace(input.Content))
                {
                    input.Content = $"Xin chào, đây là mail test lúc {DateTime.Now}";
                }

                var result = await MailHelper.SendEmailBySMTPAsync(input);
                var response = new ApiResponse<SendEmailBySMTPOutput>
                {
                    Data = result,
                    IsSuccess = result.IsSuccess,
                    Message = result.IsSuccess ? "Send email successfully" : "Send email failed",
                    ErrorCode = result.IsSuccess ? null : "SEND_EMAIL_FAILED"
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[SendEmailBySMTP] Error: {ex.Message}");

                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<SendEmailBySMTPOutput>
                {
                    IsSuccess = false,
                    Message = "Internal server error",
                    ErrorCode = "INTERNAL_SERVER_ERROR",
                    ExceptionDetail = ex.Message,
                });
            }
        }
    }
}
