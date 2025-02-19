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
        private readonly ILogger<AccountController> _logger;
        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("Register")]
        public ActionResult<ApiResponse<AccountCustomerRegisterResponseDto>> Register(AccountCustomerRegisterRequest request)
        {
            try
            {
                var account = AccountBUS.Instance.RegisterCustomerAccount(request);
                if (account == null)
                {
                    var response = new ApiResponse<AccountCustomerRegisterResponseDto>
                    {
                        IsSuccess = false,
                        Message = "Register failed",
                        ErrorCode = "BAD_REQUEST",
                    };
                    return BadRequest(response);
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
                    var response = new ApiResponse<AccountCustomerRegisterResponseDto>
                    {
                        IsSuccess = true,
                        Message = "Register successfully",
                        ErrorCode = null,
                        Data = data,
                    };
                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[Register] Error while register: {ex.Message}");

                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<AccountCustomerRegisterResponseDto>
                {
                    IsSuccess = false,
                    Message = "Register failed",
                    ErrorCode = "INTERNAL_SERVER_ERROR",
                    ExceptionDetail = ex.Message,
                });
            }
        }

        [HttpPost]
        [Route("UpdatePassword")]
        public ActionResult<ApiResponse<AccountCustomerUpdatePasswordResponseDto>> UpdatePassword(AccountCustomerUpdatePasswordRequest request )
        {
            try
            {
                var account = AccountBUS.Instance.UpdatePassword(request);
                if (account == false)
                {
                    var response = new ApiResponse<AccountCustomerUpdatePasswordResponseDto>
                    {
                        IsSuccess = false,
                        Message = "Update Password failed",
                        ErrorCode = "BAD_REQUEST",
                    };
                    return BadRequest(response);
                }
                else
                {
                    
                    var response = new ApiResponse<AccountCustomerUpdatePasswordResponseDto>
                    {
                        IsSuccess = true,
                        Message = "Update Password successfully",
                        ErrorCode = null,
                        Data = new AccountCustomerUpdatePasswordResponseDto
                        {
                        },
                    };
                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[UpdatePassword] Error while updatePassword: {ex.Message}");

                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<AccountCustomerUpdatePasswordResponseDto>
                {
                    IsSuccess = false,
                    Message = "UpdatePassword failed",
                    ErrorCode = "INTERNAL_SERVER_ERROR",
                    ExceptionDetail = ex.Message,
                });
            }
        }

        [HttpPost]
        [Route("GenerateOtp")]
        public ActionResult<ApiResponse<AccountGenerateOtpResponse>> GenerateOtp(AccountGenerateOtpRequest request)
        {
            try
            {
                var data = AccountBUS.Instance.UpdateOTPByUsername(request);
                if (data == null)
                {
                    var response = new ApiResponse<AccountGenerateOtpResponse>
                    {
                        IsSuccess = false,
                        Message = "Generate OTP failed",
                        ErrorCode = "BAD_REQUEST",
                    };
                    return BadRequest(response);
                }
                else
                {
                    var response = new ApiResponse<AccountGenerateOtpResponse>
                    {
                        IsSuccess = true,
                        Message = "Generate OTP successfully",
                        ErrorCode = null,
                        Data = data,
                    };
                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[GenerateOtp] Error while generate OTP: {ex.Message}");

                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<AccountGenerateOtpResponse>
                {
                    IsSuccess = false,
                    Message = "Generate OTP failed",
                    ErrorCode = "INTERNAL_SERVER_ERROR",
                    ExceptionDetail = ex.Message,
                });
            }
        }

        [HttpPost]
        [Route("VerifyOtp")]
        public ActionResult<ApiResponse<AccountVerifyOtpByUserNameResponse>> VerifyOtp(AccountVerifyOtpByUserNameRequest request)
        {
            try
            {
                var data = AccountBUS.Instance.VerifyOtpByUserName(request);
                if (data == null)
                {
                    var response = new ApiResponse<AccountVerifyOtpByUserNameResponse>
                    {
                        IsSuccess = false,
                        Message = "Verify OTP failed",
                        ErrorCode = "BAD_REQUEST",
                    };
                    return BadRequest(response);
                }
                else
                {
                    var response = new ApiResponse<AccountVerifyOtpByUserNameResponse>
                    {
                        IsSuccess = true,
                        Message = "Verify OTP successfully",
                        ErrorCode = null,
                        Data = data,
                    };
                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[VerifyOtp] Error while verify OTP: {ex.Message}");

                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<AccountVerifyOtpByUserNameResponse>
                {
                    IsSuccess = false,
                    Message = "Verify OTP failed",
                    ErrorCode = "INTERNAL_SERVER_ERROR",
                    ExceptionDetail = ex.Message,
                });
            }
        }
    }
}
