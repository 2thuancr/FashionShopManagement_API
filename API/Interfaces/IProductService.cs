using DTO.ApiRequests;
using DTO.ApiResponses;
using DTO.Products;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IProductService
    {
        ActionResult<ApiResponse<Product>> GetByIdAsync(int id);
        ActionResult<ApiResponse<PagedResult<Product>>> GetAllAsync(ApiRequestPaginationInput input);
        ActionResult<ApiResponse<PagedResult<Product>>> SearchAndFilterAsync(ProductsSearchRequest request);
        ActionResult<ApiResponse<List<Product>>> GetByCategoryAsync(int categoryId);
        ActionResult<ApiResponse<List<Product>>> GetRelatedAsync(int id);
    }

}
