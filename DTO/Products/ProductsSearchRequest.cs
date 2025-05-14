using DTO.ApiRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Products
{
    public class ProductsSearchRequest : ApiRequestPaginationInput
    {
        public string Query { get; set; } // Từ khóa tìm kiếm
        public string Brand { get; set; } // Thương hiệu
        public string Size { get; set; } // Kích thước
        public double? MinPrice { get; set; } // Giá tối thiểu
        public double? MaxPrice { get; set; } // Giá tối đa
        public int? CategoryId { get; set; } // Id danh mục sản phẩm
    }
}
