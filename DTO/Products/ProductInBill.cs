using Shared.Helpers;
using System;
using System.Data;

namespace DTO.Products
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
            this.ProductId = Converter.ToInt32(row[" Id"]);
            this.Name = Converter.ToString(row["Name"]);
            this.Amount = Converter.ToInt32(row["Amount"]);
            this.Price = Converter.ToDecimal(row["Price"]);
            this.Discount = Converter.ToDecimal(row["Discount"]);
            this.Category = Converter.ToString(row["Category"]);
            //this.Quantity =Converter.ToInt32(row["Quantity"]);
            this.Size = Converter.ToString(row["Size"]);
            this.Image = Converter.ToString(row["Image"]);
            this.Description = Converter.ToString(row["Description"]);
        }
    }
}