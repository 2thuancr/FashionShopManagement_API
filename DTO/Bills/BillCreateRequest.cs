using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Bills
{
    public class BillCreateRequest
    {
        public DateTime? BusinessTime { get; set; } = DateTime.Now;
        public int CustomerId { get; set; }
        public int StaffId { get; set; } = 5;
        public decimal TotalPrice { get; set; } = 0;
        public decimal Discount { get; set; } = 0;
        public int Status { get; set; }
        public List<BillInfoCreateRequest> Items { get; set; }
    }
}
