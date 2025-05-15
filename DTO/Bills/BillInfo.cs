using Shared.Helpers;
using System;
using System.Data;

namespace DTO.Bills
{
    public class BillInfo
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int Amount { get; set; }

        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        public decimal CampaignDiscountPercent { get; set; }
        public decimal TotalProductPrice { get; set; }
        public BillInfo() { }

        public BillInfo(DataRow row)
        {
            this.Id = Converter.ToInt32(row["Id"]);
            this.BillId = Converter.ToInt32(row["billID"]);
            this.ProductId = Converter.ToInt32(row["productID"]);
            this.Amount = Converter.ToInt32(row["amount"]);
            this.Discount = Converter.ToDecimal(row["discount"]);
            this.Price = Converter.ToDecimal(row["price"]);
            this.CampaignDiscountPercent = Converter.ToDecimal(row["campaignDiscountPercent"]);
            this.TotalProductPrice = Converter.ToDecimal(row["totalProductPrice"]);
        }
    }
}