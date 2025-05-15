using API.Interfaces;
using BUS;
using DTO.ApiResponses;
using DTO.Bills;
using Microsoft.AspNetCore.Mvc;
using System;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BillsController : ControllerBase, IBillService
    {
        private ILogger<BillsController> _logger;

        public BillsController(ILogger<BillsController> logger)
        {
            _logger = logger;
        }

        [HttpPost("create")]
        public ActionResult<ApiResponse<Bill>> Create([FromBody] BillCreateRequest request)
        {
            if (request == null || request.Items == null || !request.Items.Any())
                return BadRequest("Giỏ hàng trống.");

            try
            {
                var bill = BillBUS.Instance.CreateBill(request);
                if (bill == null)
                {
                    return BadRequest(new ApiResponse<Bill>
                    {
                        IsSuccess = false,
                        Message = "Tạo đơn hàng thất bại.",
                        ErrorCode = "BILL_CREATION_FAILED",
                    });
                }

                var response = new ApiResponse<Bill>
                {
                    IsSuccess = true,
                    Data = bill,
                    Message = "Tạo đơn hàng thành công.",
                    ErrorCode = null
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[Create] Error: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<Bill>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    ErrorCode = "INTERNAL_SERVER_ERROR",   
                    ExceptionDetail = ex.Message,
                });
            }
        }

        [HttpPost("update")]
        public ActionResult<ApiResponse<Bill>> Update([FromBody] BillUpdateRequest request)
        {
            if (request == null || request.Items == null || !request.Items.Any())
                return BadRequest("Giỏ hàng trống.");

            try
            {
                var bill = BillBUS.Instance.UpdateBill(request);
                if (bill == null)
                {
                    return BadRequest(new ApiResponse<Bill>
                    {
                        IsSuccess = false,
                        Message = "Cập nhật đơn hàng thất bại.",
                        ErrorCode = "BILL_CREATION_FAILED",
                    });
                }

                var response = new ApiResponse<Bill>
                {
                    IsSuccess = true,
                    Data = bill,
                    Message = "Cập nhật đơn hàng thành công.",
                    ErrorCode = null
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[Create] Error: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<Bill>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    ErrorCode = "INTERNAL_SERVER_ERROR",
                    ExceptionDetail = ex.Message,
                });
            }
        }

        [HttpPost("remove-product")]
        public ActionResult<ApiResponse<Bill>> RemoveProduct([FromBody] BillUpdateRequest request)
        {
            if (request == null || request.Items == null || !request.Items.Any())
                return BadRequest("Giỏ hàng trống.");

            try
            {
                var bill = BillBUS.Instance.UpdateBill(request);
                if (bill == null)
                {
                    return BadRequest(new ApiResponse<Bill>
                    {
                        IsSuccess = false,
                        Message = "Cập nhật đơn hàng thất bại.",
                        ErrorCode = "BILL_CREATION_FAILED",
                    });
                }

                var response = new ApiResponse<Bill>
                {
                    IsSuccess = true,
                    Data = bill,
                    Message = "Cập nhật đơn hàng thành công.",
                    ErrorCode = null
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[Create] Error: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<Bill>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    ErrorCode = "INTERNAL_SERVER_ERROR",
                    ExceptionDetail = ex.Message,
                });
            }
        }


        [HttpGet("history")]
        public ActionResult<ApiResponse<List<Bill>>> GetHistory(BillGetOrderHistoryRequest request)
        {
            try
            {
                var bills = BillBUS.Instance.GetBillByCustomerId(request.CustomerId);
                if (bills == null || !bills.Any())
                {
                    return NotFound(new ApiResponse<List<Bill>>
                    {
                        IsSuccess = false,
                        Message = "Không tìm thấy đơn hàng nào.",
                        ErrorCode = "BILL_NOT_FOUND",
                    });
                }
                var response = new ApiResponse<List<Bill>>
                {
                    IsSuccess = true,
                    Data = bills,
                    Message = "Lấy danh sách đơn hàng thành công.",
                    ErrorCode = null
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[GetHistory] Error: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<List<Bill>>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    ErrorCode = "INTERNAL_SERVER_ERROR",
                    ExceptionDetail = ex.Message,
                });
            }
        }

        [HttpPost("checkout")]
        public ActionResult<ApiResponse<Bill>> Checkout(Bill request)
        {
            try
            {
                Bill bill = BillBUS.Instance.Checkout(request.Id);
                if (bill == null)
                {
                    return BadRequest(new ApiResponse<Bill>
                    {
                        IsSuccess = false,
                        Message = "Thanh toán thất bại.",
                        ErrorCode = "BILL_CREATION_FAILED",
                    });
                }
                var response = new ApiResponse<Bill>
                {
                    IsSuccess = true,
                    Data = bill,
                    Message = "Thanh toán thành công.",
                    ErrorCode = null
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[Checkout] Error: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<Bill>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    ErrorCode = "INTERNAL_SERVER_ERROR",
                    ExceptionDetail = ex.Message,
                });
            }
        }
    }

}
