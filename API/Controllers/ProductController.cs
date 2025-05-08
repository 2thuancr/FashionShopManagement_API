using API.Interfaces;
using BUS;
using DTO.ApiRequests;
using DTO.ApiResponses;
using DTO.Products;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase, IProductService
    {
        private readonly ILogger<ProductController> _logger;
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("list")]
        public ActionResult<ApiResponse<PagedResult<Product>>> GetAllAsync(ApiRequestPaginationInput input)
        {
            try
            {
                var data = ProductBUS.Instance.GetAllProduct(input);

                var response = new ApiResponse<PagedResult<Product>>
                {
                    IsSuccess = true,
                    Data = data,
                    Message = "Success",
                    ErrorCode = null
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[GetAllAsync] Error: {ex.Message}");

                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<List<Product>>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    ErrorCode = "INTERNAL_SERVER_ERROR",
                    ExceptionDetail = ex.Message,
                });
            }
        }

        [HttpPost]
        [Route("search")]
        public ActionResult<ApiResponse<PagedResult<Product>>> SearchAndFilterAsync(ProductsSearchRequest request)
        {
            try
            {
                var data = ProductBUS.Instance.SearchAndFilterProducts(request);

                var response = new ApiResponse<PagedResult<Product>>
                {
                    IsSuccess = true,
                    Data = data,
                    Message = "Success",
                    ErrorCode = null
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[SearchAndFilterAsync] Error: {ex.Message}");

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
        public ActionResult<ApiResponse<Product>> GetByIdAsync(int id)
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

        [HttpGet]
        [Route("by-category/{categoryId}")]
        public ActionResult<ApiResponse<List<Product>>> GetByCategoryAsync(int categoryId)
        {
            try
            {
                List<Product> listProducts = ProductBUS.Instance.GetByCategory(categoryId);

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
                _logger.LogError(ex, $"[GetByCategoryAsync] Error: {ex.Message}");

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
        [Route("{id}/related")]
        public ActionResult<ApiResponse<List<Product>>> GetRelatedAsync(int id)
        {
            try
            {
                List<Product> listProducts = ProductBUS.Instance.GetRelatedProducts(id);

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
                _logger.LogError(ex, $"[GetRelatedProducts] Error: {ex.Message}");

                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<List<Product>>
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
