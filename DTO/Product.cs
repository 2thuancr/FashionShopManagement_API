using System;
using System.Data;

namespace DTO
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }
        public string Image { get; set; }
         
        public string Description { get; set; }
        public Product() { }

        public Product(string name, decimal price, decimal discount, string category, int quantity, string size, string image, string description)
        {
            this.Name = name;
            this.Price = price;
            this.Discount = discount;
            this.Category = category;
            this.Quantity = quantity;
            this.Size = size;
            this.Image = image;
            Description = description;
        }
        public Product(int id, string name, decimal price, decimal discount, string category, int quantity, string size, string image, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Discount = discount;
            this.Category = category;
            this.Quantity = quantity;
            this.Size = size;
            this.Image = image;
            this.Description = description;
        }

        public Product(DataRow row)
        {
            try
            {
                this.Id = Convert.ToInt32(row["Id"]);
                this.Name = Convert.ToString(row["Name"]);
                this.Price = Convert.ToDecimal(row["Price"]);
                this.Discount = Convert.ToDecimal(row["Discount"]);
                this.Category = Convert.ToString(row["Category"]);
                this.Quantity =Convert.ToInt32(row["Quantity"]);
                this.Size = Convert.ToString(row["Size"]);
                this.Image = Convert.ToString(row["Image"]);
                this.Description = Convert.ToString(row["Description"]);
            }
            catch 
            {

            }
        }
    }
}