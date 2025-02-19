using BUS;
using DTO.Accounts;
using DTO.ApiResponses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IConfiguration _config;
    private readonly ILogger<AuthController> _logger;

    public AuthController(IConfiguration config, ILogger<AuthController> logger)
    {
        _config = config;
        _logger = logger;
    }

    [HttpPost]
    [Route("Login")]
    public ActionResult<ApiResponse<AccountLoginResponse>> Login(AccountLoginRequest request)
    {
        try
        {
            var account = AccountBUS.Instance.Login(request);

            if (account == null)
            {
                var response = new ApiResponse<AccountLoginResponse>
                {
                    IsSuccess = false,
                    Message = "Login failed",
                    ErrorCode = "UNAUTHORIZED",
                };
                return Unauthorized(response);
            }
            else
            {
                var role = "Customer";
                if (account.TypeID == 1)
                {
                    role = "Staff";
                }
                else if (account.TypeID == 2)
                {
                    role = "Admin";
                }
                var token = GenerateJwtToken(request.UserName, role);
            
                var data = new AccountLoginResponse
                {
                    UserName = account.UserName,
                    DisplayName = account.DisplayName,
                    TypeID = account.TypeID,
                    Token = token,
                };
                var response = new ApiResponse<AccountLoginResponse>
                {
                    IsSuccess = true,
                    Message = "Login successfully",
                    ErrorCode = null,
                    Data = data,
                };
                return Ok(response);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"[Login] Error while login: {ex.Message}");

            return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<AccountLoginResponse>
            {
                IsSuccess = false,
                Message = "Login failed",
                ErrorCode = "INTERNAL_SERVER_ERROR",
                ExceptionDetail = ex.Message,
            });
        }
    }


    private string GenerateJwtToken(string username, string role)
    {
        var jwtSettings = _config.GetSection("JwtSettings");
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Secret"]));

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, username),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.Sub, username),
            new Claim(ClaimTypes.Role, role),
            new Claim("department", "IT"),
            new Claim("permissions", "read"),
            new Claim("permissions", "write")
        };

        var token = new JwtSecurityToken(
            issuer: jwtSettings["Issuer"],
            audience: jwtSettings["Audience"],
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(Convert.ToDouble(jwtSettings["ExpirationMinutes"])),
            signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}

public class LoginModel
{
    public string Username { get; set; }
    public string Password { get; set; }
}
