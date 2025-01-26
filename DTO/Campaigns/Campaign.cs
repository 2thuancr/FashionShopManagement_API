using Shared.Helpers;
using System;
using System.Data;

namespace DTO.Campaigns
{
    public class Campaign
    {
        public Campaign() { }

        public int CampaignId { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal DiscountPercentage { get; set; }
        public int MinimumQuantity { get; set; }
        public int ProductId { get; set; }
        public int StaffId { get; set; }

        public Campaign(int campaignId, string name, DateTime startdate, DateTime enddate, decimal discountPercentage,
                        int minimumQuantity, int productId, int staffId)
        {
            this.CampaignId = campaignId;
            this.Name = name;
            this.StartDate = startdate;
            this.EndDate = enddate;
            this.DiscountPercentage = discountPercentage;
            this.MinimumQuantity = minimumQuantity;
            this.ProductId = productId;
            this.StaffId = staffId;
        }

        public Campaign(DataRow row)
        {
            this.CampaignId = Converter.ToInt32(row["campaignId"]);
            this.Name = Converter.ToString(row["name"]);
            this.StartDate = Converter.ToDateTime(row["startdate"]);
            this.EndDate = Converter.ToDateTime(row["enddate"]);
            this.DiscountPercentage = Converter.ToDecimal(row["discountPercentage"]);
            this.MinimumQuantity = Converter.ToInt32(row["minimumQuantity"]);
            this.ProductId = Converter.ToInt32(row["productId"]);
            this.StaffId = Converter.ToInt32(row["staffId"]);
        }
    }
}
