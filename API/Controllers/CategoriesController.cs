using BUS;
using DTO.Accounts;
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
        [Route("list")]
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
        [Route("search")]
        public ActionResult<ApiResponse<List<Categories>>> SearchCategories(CategoriesSearchRequest request)
        {
            try
            {
                List<Categories> listCategories = CategoriesBUS.Instance.SearchCategories(request);

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
        [Route("{id}")]
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

        [HttpPost]
        [Route("create")]
        public ActionResult<ApiResponse<CategoriesInsertResponse>> InsertCategory(CategoriesInsertRequest request)
        {
            try
            {
                CategoriesInsertResponse result = CategoriesBUS.Instance.InsertCategory(request);

                var response = new ApiResponse<CategoriesInsertResponse>
                {
                    IsSuccess = true,
                    Data = result,
                    Message = "Success",
                    ErrorCode = null
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[InsertCategory] Error: {ex.Message}");

                var response = new ApiResponse<CategoriesInsertResponse>
                {
                    IsSuccess = true,
                    Message = ex.Message,
                    ErrorCode = "INTERNAL_SERVER_ERROR",
                    ExceptionDetail = ex.Message
                };
                return StatusCode(StatusCodes.Status500InternalServerError, response);

            }
        }

        [HttpPut]
        [Route("update/{id}")]
        public ActionResult<ApiResponse<CategoriesUpdateResponse>> UpdateCategory(int id, CategoriesUpdateRequest request)
        {
            try
            {
                CategoriesUpdateResponse result = CategoriesBUS.Instance.UpdateCategory(id, request);

                var response = new ApiResponse<CategoriesUpdateResponse>
                {
                    IsSuccess = true,
                    Data = result,
                    Message = "Success",
                    ErrorCode = null
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[UpdateCategory] Error: {ex.Message}");

                var response = new ApiResponse<CategoriesUpdateResponse>
                {
                    IsSuccess = true,
                    Message = ex.Message,
                    ErrorCode = "INTERNAL_SERVER_ERROR",
                    ExceptionDetail = ex.Message
                };
                return StatusCode(StatusCodes.Status500InternalServerError, response);

            }
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public ActionResult<ApiResponse<CategoriesDeleteResponse>> DeleteCategory(int id)
        {
            try
            {
                var request = new CategoriesDeleteRequest
                {
                    id = id,
                };
                CategoriesDeleteResponse result = CategoriesBUS.Instance.DeleteCategory(request);

                var response = new ApiResponse<CategoriesDeleteResponse>
                {
                    IsSuccess = true,
                    Data = result,
                    Message = "Success",
                    ErrorCode = null
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[DeleteCategory] Error: {ex.Message}");

                var response = new ApiResponse<CategoriesDeleteResponse>
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
