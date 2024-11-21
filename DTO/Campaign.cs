using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Campaign
    {
        public Campaign() { }

        public int CampaignId { get; set; }

        public string Name { get; set; }

        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public decimal DiscountPercentage { get; set; }
        public int MinimumQuantity { get; set; }
        public int ProductId { get; set; }

        public Campaign(int campaignId, string name, DateTime startdate, DateTime enddate, decimal discountPercentage,
                        int minimumQuantity, int productId)
        {
            this.CampaignId = campaignId;
            this.Name = name;
            this.Startdate = startdate;
            this.Enddate = enddate;
            this.DiscountPercentage = discountPercentage;
            this.MinimumQuantity = minimumQuantity;
            this.ProductId = productId;
        }
        public Campaign(DataRow row)
        {
            try
            {
                this.CampaignId = Convert.ToInt32(row["campaignId"]);
                this.Name = Convert.ToString(row["name"]);
                this.Startdate = Convert.ToDateTime(row["startdate"]);
                this.Enddate = Convert.ToDateTime(row["enddate"]);
                this.DiscountPercentage = Convert.ToDecimal(row["discountPercentage"]);
                this.MinimumQuantity = Convert.ToInt32(row["minimumQuantity"]);
                this.ProductId = Convert.ToInt32(row["productId"]);
            }
            catch
            {

            }
        }
    }
}
