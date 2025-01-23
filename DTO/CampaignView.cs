using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CampaignView
    {
        public CampaignView() { }

        public int CampaignId { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal DiscountPercentage { get; set; }
        public int MinimumQuantity { get; set; }
        public int ProductId { get; set; }
        public int StaffId { get; set; }
        public string ProductName { get; set; }
        public string StaffFullName { get; set; }

        public CampaignView(int campaignId, string name, DateTime startdate, DateTime enddate, decimal discountPercentage,
                        int minimumQuantity, int productId, int staffId, string productName, string staffFullName)
        {
            this.CampaignId = campaignId;
            this.Name = name;
            this.StartDate = startdate;
            this.EndDate = enddate;
            this.DiscountPercentage = discountPercentage;
            this.MinimumQuantity = minimumQuantity;
            this.ProductId = productId;
            this.StaffId = staffId;
            this.ProductName = productName;
            this.StaffFullName = staffFullName;
        }
        public CampaignView(DataRow row)
        {
            try
            {
                this.CampaignId = Convert.ToInt32(row["campaignId"]);
                this.Name = Convert.ToString(row["campaignName"]);
                this.StartDate = Convert.ToDateTime(row["startDate"]);
                this.EndDate = Convert.ToDateTime(row["endDate"]);
                this.DiscountPercentage = Convert.ToDecimal(row["discountPercentage"]);
                this.MinimumQuantity = Convert.ToInt32(row["minimumQuantity"]);
                this.ProductId = Convert.ToInt32(row["productId"]);
                this.StaffId = Convert.ToInt32(row["staffId"]);
                this.ProductName = Convert.ToString(row["productName"]);
                this.StaffFullName = Convert.ToString(row["staffFullName"]);
            }
            catch
            {

            }
        }
    }
}
