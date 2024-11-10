using System;
using System.Data;

namespace DTO
{
    public class ProductInBill
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public string Category { get; set; }
        //public int Quantity { get; set; }
        public string Size { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public ProductInBill() { }

        public ProductInBill(string name, int amount, 
            decimal price, decimal discount, string category,
            /*int quantity,*/ 
            string size, string image, string description)
        {
            this.Name = name;
            this.Amount = amount;
            this.Price = price;
            this.Discount = discount;
            this.Category = category;
            //this.Quantity = quantity;
            this.Size = size;
            this.Image = image;
            Description = description;
        }
        public ProductInBill(int productId, string name, int amount, 
            decimal price, decimal discount, string category, 
            /*int quantity,*/ 
            string size, string image, string description)
        {
            this.ProductId = productId;
            this.Name = name;
            this.Amount = amount;
            this.Price = price;
            this.Discount = discount;
            this.Category = category;
            //this.Quantity = quantity;
            this.Size = size;
            this.Image = image;
            this.Description = description;
        }

        public ProductInBill(DataRow row)
        {
            try
            {
                this.ProductId = Convert.ToInt32(row["Id"]);
                this.Name = Convert.ToString(row["Name"]);
                this.Amount = Convert.ToInt32(row["Amount"]);
                this.Price = Convert.ToDecimal(row["Price"]);
                this.Discount = Convert.ToDecimal(row["Discount"]);
                this.Category = Convert.ToString(row["Category"]);
                //this.Quantity =Convert.ToInt32(row["Quantity"]);
                this.Size = Convert.ToString(row["Size"]);
                this.Image = Convert.ToString(row["Image"]);
                this.Description = Convert.ToString(row["Description"]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}