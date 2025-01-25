using BUS;
using DTO.Accounts;
using DTO.ApiResponses;
using Microsoft.AspNetCore.Mvc;
using Shared.Helpers;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(AccountLoginRequest request)
        {
            try
            {
                var account = AccountBUS.Instance.Login(request);

                if (account == null)
                {
                    return Unauthorized(default(ApiRepose<AccountLoginResponse>));
                }
                else
                {
                    var data = new AccountLoginResponse
                    {
                        UserName = account.UserName,
                        DisplayName = account.DisplayName,
                        TypeID = account.TypeID
                    };
                    var response = new ApiRepose<AccountLoginResponse>(isSuccess: true, data);
                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                return Problem(
                    detail: ex.Message,
                    statusCode: StatusCodes.Status500InternalServerError,
                    title: "Unexpected Error"
                );
            }
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(AccountCustomerRegisterRequest request)
        {
            try
            {
                var account = AccountBUS.Instance.RegisterCustomerAccount(request);
                if (account == null)
                {
                    return BadRequest(default(ApiRepose<AccountGenerateOtpRequest>));
                }
                else
                {
                    var otpRequest = new AccountGenerateOtpRequest
                    {
                        UserName = request.UserName
                    };
                    var otpResponse = AccountBUS.Instance.UpdateOTPByUsername(otpRequest);

                    var input = new Shared.Dtos.SendEmailBySMTPInput()
                    {
                        Title = $"OTP xác minh đăng ký tài khoản",
                        Content = $"Xin chào {request.UserName}, đây là mã OTP xác minh đăng ký của bạn: {otpResponse?.OTP}",
                        Recipient = new List<string> { request.Email }
                    };
                    _ = MailHelper.SendEmailBySMTPAsync(input);

                    var data = new AccountCustomerRegisterResponseDto
                    {
                        AccountId = account.AccountId,
                        CustomerId = account.CustomerId,
                        Otp = otpResponse?.OTP,
                        OtpExpiration = otpResponse?.OTPExpiration,
                    };
                    var response = new ApiRepose<AccountCustomerRegisterResponseDto>(isSuccess: true, data);
                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                return Problem(
                    detail: ex.Message,
                    statusCode: StatusCodes.Status500InternalServerError,
                    title: "Unexpected Error"
                );
            }
        }

        [HttpPost]
        [Route("GenerateOtp")]
        public IActionResult GenerateOtp(AccountGenerateOtpRequest request)
        {
            try
            {
                var response = AccountBUS.Instance.UpdateOTPByUsername(request);
                if (response == null)
                {
                    return BadRequest(default(ApiRepose<AccountGenerateOtpResponse>));
                }
                else
                {
                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                return Problem(
                    detail: ex.Message,
                    statusCode: StatusCodes.Status500InternalServerError,
                    title: "Unexpected Error"
                );
            }
        }

        [HttpPost]
        [Route("VerifyOtp")]
        public IActionResult VerifyOtp(AccountVerifyOtpByUserNameRequest request)
        {
            try
            {
                var data = AccountBUS.Instance.VerifyOtpByUserName(request);
                if (data == null)
                {
                    return BadRequest(default(ApiRepose<AccountVerifyOtpByUserNameResponse>));
                }
                else
                {
                    var response = new ApiRepose<AccountVerifyOtpByUserNameResponse>(isSuccess: true, data);
                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                return Problem(
                    detail: ex.Message,
                    statusCode: StatusCodes.Status500InternalServerError,
                    title: "Unexpected Error"
                );
            }
        }
    }
}
