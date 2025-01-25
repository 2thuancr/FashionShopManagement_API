using Shared.Helpers;
using System;
using System.Data;

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
            this.CampaignId = Converter.ToInt32(row["campaignId"]);
            this.Name = Converter.ToString(row["campaignName"]);
            this.StartDate = Converter.ToDateTime(row["startDate"]);
            this.EndDate = Converter.ToDateTime(row["endDate"]);
            this.DiscountPercentage = Converter.ToDecimal(row["discountPercentage"]);
            this.MinimumQuantity = Converter.ToInt32(row["minimumQuantity"]);
            this.ProductId = Converter.ToInt32(row["productId"]);
            this.StaffId = Converter.ToInt32(row["staffId"]);
            this.ProductName = Converter.ToString(row["productName"]);
            this.StaffFullName = Converter.ToString(row["staffFullName"]);
        }
    }
}
