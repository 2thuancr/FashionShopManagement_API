using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ApiRequests
{
    public class ApiRequestPaginationInput
    {
        public int Page { get; set; } = 1; // Trang hiện tại
        public int PageSize { get; set; } = 10; // Kích thước trang
    }
}
