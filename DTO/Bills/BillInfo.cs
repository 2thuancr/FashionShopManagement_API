using Shared.Helpers;
using System;
using System.Data;

namespace DTO.Bills
{
    public class BillInfo
    {
        public int ID { get; set; }
        public int BillID { get; set; }
        public int ProductID { get; set; }
        public int Amount { get; set; }

        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        public decimal CampaignDiscountPercent { get; set; }
        public decimal TotalProductPrice { get; set; }
        public BillInfo() { }

        public BillInfo(int id, int billID, int productID, int amount, decimal price, 
            decimal discount, decimal campaignDiscountPercent, decimal totalProductPrice)
        {
            this.ID = id;
            this.BillID = billID;
            this.ProductID = productID;
            this.Amount = amount;
            this.Price = price;
            this.Discount = discount;
            this.CampaignDiscountPercent = campaignDiscountPercent;
            this.TotalProductPrice = totalProductPrice;
        }

        public BillInfo(DataRow row)
        {
            this.ID = Converter.ToInt32(row["Id"]);
            this.BillID = Converter.ToInt32(row["billID"]);
            this.ProductID = Converter.ToInt32(row["productID"]);
            this.Amount = Converter.ToInt32(row["amount"]);
            this.Discount = Converter.ToDecimal(row["discount"]);
            this.Price = Converter.ToDecimal(row["price"]);
            this.CampaignDiscountPercent = Converter.ToDecimal(row["campaignDiscountPercent"]);
            this.TotalProductPrice = Converter.ToDecimal(row["totalProductPrice"]);
        }
    }
}