using BUS;
using DTO.ApiResponses;
using DTO.Bills;
using Microsoft.AspNetCore.Mvc;
using System;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BillsController : ControllerBase
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
                    return BadRequest(new ApiResponse<BillCreateRequest>
                    {
                        IsSuccess = false,
                        Message = "Tạo hóa đơn thất bại.",
                        ErrorCode = "BILL_CREATION_FAILED",
                    });
                }

                var response = new ApiResponse<Bill>
                {
                    IsSuccess = true,
                    Data = bill,
                    Message = "Tạo hóa đơn thành công.",
                    ErrorCode = null
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[Create] Error: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<BillCreateRequest>
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
