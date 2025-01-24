using BUS;
using DTO;
using DTO.Accounts;
using Microsoft.AspNetCore.Mvc;

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
                    var response = new AccountLoginResponse
                    {
                        IsSuccess = false
                    };
                    return Unauthorized(response);
                }
                else
                {
                    var response = new AccountLoginResponse
                    {
                        IsSuccess = true,
                        UserName = account.UserName,
                        DisplayName = account.DisplayName,
                        TypeID = account.TypeID
                    };
                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
                    return Unauthorized();
                }
                else
                {
                    return Ok(account);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
