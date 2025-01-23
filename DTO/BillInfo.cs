using System;
using System.Data;

namespace DTO
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

        public BillInfo(int id, int billID, int productID, int amount, decimal price, decimal discount, decimal campaignDiscountPercent, decimal totalProductPrice)
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
            try 
            {
                this.ID = Convert.ToInt32(row["Id"]);
                this.BillID = Convert.ToInt32(row["billID"]);
                this.ProductID = Convert.ToInt32(row["productID"]);
                this.Amount = Convert.ToInt32(row["amount"]);
                this.Discount = Convert.ToDecimal(row["discount"]);
                this.Price = Convert.ToDecimal(row["price"]);
                this.CampaignDiscountPercent = Convert.ToDecimal(row["campaignDiscountPercent"]);
                this.TotalProductPrice = Convert.ToDecimal(row["totalProductPrice"]);
            }
            catch
            {

            }
           
        }
    }
}