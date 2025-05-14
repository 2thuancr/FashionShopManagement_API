using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Bills
{
    public class BillGetOrderHistoryRequest
    {
        public int CustomerId { get; set; }
        public DateTime? FromDate { get; set; } = DateTime.Now.AddDays(-30);
        public DateTime? ToDate { get; set; } = DateTime.Now;
        public int Status { get; set; } = 0;
        public string PaymentMethod { get; set; } = "COD";
    }
}
