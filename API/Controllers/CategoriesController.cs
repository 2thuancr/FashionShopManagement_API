using BUS;
using DTO.ApiResponses;
using DTO.Categories;
using DTO.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ILogger<CategoriesController> _logger;
        public CategoriesController(ILogger<CategoriesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("GetAllCategories")]
        public ActionResult<ApiResponse<List<Categories>>> GetAllCategories()
        {
            try
            {
                List<Categories> listCategories = CategoriesBUS.Instance.GetAllCategories();

                var response = new ApiResponse<List<Categories>>
                {
                    IsSuccess = true,
                    Data = listCategories,
                    Message = "Success",
                    ErrorCode = null
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[GetAllCategories] Error: {ex.Message}");

                return StatusCode(StatusCodes.Status500InternalServerError, new ApiResponse<List<Categories>>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    ErrorCode = "INTERNAL_SERVER_ERROR",
                    ExceptionDetail = ex.Message,
                });
            }
        }

        [HttpGet]
        [Route("SearchCategories")]
        public ActionResult<ApiResponse<List<Categories>>> SearchCategories(string name)
        {
            try
            {
                List<Categories> listCategories = CategoriesBUS.Instance.SearchCategories(name);

                var response = new ApiResponse<List<Categories>>
                {
                    IsSuccess = true,
                    Data = listCategories,
                    Message = "Success",
                    ErrorCode = null
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[SearchCategories] Error: {ex.Message}");

                var response = new ApiResponse<List<Categories>>
                {
                    IsSuccess = true,
                    Message = ex.Message,
                    ErrorCode = "INTERNAL_SERVER_ERROR",
                    ExceptionDetail = ex.Message
                };
                return StatusCode(StatusCodes.Status500InternalServerError, response);

            }
        }

        [HttpGet]
        [Route("GetCategoryById")]
        public ActionResult<ApiResponse<Categories>> GetCategoryById(int id)
        {
            try
            {
                Categories categories = CategoriesBUS.Instance.GetCategoryById(id);

                var response = new ApiResponse<Categories>
                {
                    IsSuccess = true,
                    Data = categories,
                    Message = "Success",
                    ErrorCode = null
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[GetCategoryById] Error: {ex.Message}");

                var response = new ApiResponse<Categories>
                {
                    IsSuccess = true,
                    Message = ex.Message,
                    ErrorCode = "INTERNAL_SERVER_ERROR",
                    ExceptionDetail = ex.Message
                };
                return StatusCode(StatusCodes.Status500InternalServerError, response);

            }
        }
    }
}
