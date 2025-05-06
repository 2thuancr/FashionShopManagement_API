using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Bills
{
    public class BillInfoCreateRequest
    {
        public int ProductID { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal CampaignDiscountPercent { get; set; }
    }
}
