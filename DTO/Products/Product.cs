using Shared.Helpers;
using System;
using System.Data;

namespace DTO.Products
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int? CategoryId { get; set; }
        public string Category { get; set; }

        public Product() { }


        public Product(DataRow row)
        {
            this.Id = Converter.ToInt32(row["Id"]);
            this.Name = Converter.ToString(row["Name"]);
            this.Price = Converter.ToDecimal(row["Price"]);
            this.Brand = Converter.ToString(row["Brand"]);
            this.Discount = Converter.ToDecimal(row["TotalDiscount"]);
            this.Category = Converter.ToString(row["Category"]);
            this.Size = Converter.ToString(row["Size"]);
            this.ImageUrl = Converter.ToString(row["Image"]);
            this.Description = Converter.ToString(row["Description"]);
            this.Status = Converter.ToString(row["Status"]);
            this.CategoryId = Converter.ToInt32Nullable(row["CategoryId"]);
            this.Quantity = Converter.ToInt32(row["Quantity"]);
        }
    }
}