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
        public IActionResult Get()
        {
            return Ok($"[{DateTime.UtcNow:O}] API is running...");
        }

        [HttpPost]
        [Route("SendEmailBySMTP")]
        public async Task<IActionResult> SendEmailBySMTP(SendEmailBySMTPInput input)
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
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[SendEmailBySMTP] Error: {ex.Message}");

                return Problem(
                    detail: ex.Message,
                    statusCode: StatusCodes.Status500InternalServerError,
                    title: "Unexpected Error"
                );
            }
        }
    }
}
