using BUS;
using DTO.ApiResponses;
using DTO.Customers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetAllCustomer")]
        public ActionResult<ApiResponse<Customer>> GetAllCustomer()
        {
            try
            {
                var customers = CustomerBUS.Instance.GetAllCustomer();

                if (customers == null || customers.Count == 0)
                {
                    return NotFound(new ApiResponse<Customer>
                    {
                        IsSuccess = false,
                        Message = "Không tìm thấy khách hàng nào.",
                        ErrorCode = "NOT_FOUND"
                    });
                }

                return Ok(new ApiResponse<List<Customer>>
                {
                    IsSuccess = true,
                    Message = "Lấy danh sách khách hàng thành công.",
                    Data = customers
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Có lỗi phát sinh khi lấy dữ liệu!");
                return StatusCode(StatusCodes.Status500InternalServerError, "Có lỗi phát sinh khi lấy dữ liệu!");
            }
        }

        [HttpPost("GetCustomerByPhone")]
        public ActionResult<ApiResponse<Customer>> GetCustomerByPhone(GetCustomerInfoInput request)
        {
            try
            {
                var customers = CustomerBUS.Instance.GetCustomerByPhone(request.PhoneNumber);
                if (customers == null || customers.Count == 0)
                {
                    return NotFound(new ApiResponse<Customer>
                    {
                        IsSuccess = false,
                        Message = "Không tìm thấy khách hàng nào.",
                        ErrorCode = "NOT_FOUND"
                    });
                }
                return Ok(new ApiResponse<List<Customer>>
                {
                    IsSuccess = true,
                    Message = "Lấy danh sách khách hàng thành công.",
                    Data = customers
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Có lỗi phát sinh khi lấy dữ liệu!");
                return StatusCode(StatusCodes.Status500InternalServerError, "Có lỗi phát sinh khi lấy dữ liệu!");
            }
        }

        [HttpPost("GetCustomerInfo")]
        public ActionResult<ApiResponse<CustomerInfo>> GetCustomerInfo(GetCustomerInfoInput request)
        {
            try
            {
                var customerInfo = CustomerBUS.Instance.GetCustomerInfo(request);
                if (customerInfo == null)
                {
                    return NotFound(new ApiResponse<CustomerInfo>
                    {
                        IsSuccess = false,
                        Message = "Không tìm thấy thông tin khách hàng.",
                        ErrorCode = "NOT_FOUND"
                    });
                }
                return Ok(new ApiResponse<CustomerInfo>
                {
                    IsSuccess = true,
                    Message = "Lấy thông tin khách hàng thành công.",
                    Data = customerInfo
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Có lỗi phát sinh khi lấy dữ liệu!");
                return StatusCode(StatusCodes.Status500InternalServerError, "Có lỗi phát sinh khi lấy dữ liệu!");
            }
        }
    }
}
