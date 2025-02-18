using BUS;
using DTO.ApiResponses;
using DTO.Products;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("list")]
        public ActionResult<ApiResponse<List<Product>>> GetAllProducts()
        {
            try
            {
                List<Product> listProducts = ProductBUS.Instance.GetAllProduct();

                var response = new ApiResponse<List<Product>>
                {
                    IsSuccess = true,
                    Data = listProducts,
                    Message = "Success",
                    ErrorCode = null
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[GetAllProducts] Error: {ex.Message}");

                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<List<Product>>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    ErrorCode = "INTERNAL_SERVER_ERROR",
                    ExceptionDetail = ex.Message,
                });
            }
        }

        [HttpGet]
        [Route("search")]
        public ActionResult<ApiResponse<List<Product>>> SearchProductByName(string name)
        {
            try
            {
                List<Product> listProducts = ProductBUS.Instance.SearchProductByName(name);

                var response = new ApiResponse<List<Product>>
                {
                    IsSuccess = true,
                    Data = listProducts,
                    Message = "Success",
                    ErrorCode = null
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[SearchProductByName] Error: {ex.Message}");

                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<List<Product>>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    ErrorCode = "INTERNAL_SERVER_ERROR",
                    ExceptionDetail = ex.Message,
                });
            }
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<ApiResponse<Product>> GetProductById(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new ApiResponse<Product>
                {
                    IsSuccess = false,
                    Message = "Id must greater than 0",
                    ErrorCode = "INVALID_ID"
                });
            }

            try
            {
                Product product = ProductBUS.Instance.GetProductById(id);

                var response = new ApiResponse<Product>
                {
                    IsSuccess = true,
                    Data = product,
                    Message = "Success",
                    ErrorCode = null
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[GetProductById] Error: {ex.Message}");

                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<Product>
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
