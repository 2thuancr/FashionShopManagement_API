using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ApiResponses
{
    public class PagedResult<T>
    {
        public List<T> Items { get; set; } = new List<T>(); // Danh sách dữ liệu
        public int TotalCount { get; set; }                 // Tổng số item (chưa phân trang)
        public int Page { get; set; }                       // Trang hiện tại
        public int PageSize { get; set; }                   // Kích thước trang

        public int TotalPages => PageSize == 0 ? 0 : (int)Math.Ceiling((double)TotalCount / PageSize); // Số trang tổng cộng
    }
}
