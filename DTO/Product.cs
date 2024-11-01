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

        public Product() { }

        public Product(string name, decimal price, decimal discount, string category, int quantity, string size, string image)
        {
            this.Name = name;
            this.Price = price;
            this.Discount = discount;
            this.Category = category;
            this.Quantity = quantity;
            this.Size = size;
            this.Image = image;
        }
        public Product(int id, string name, decimal price, decimal discount, string category, int quantity, string size, string image)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Discount = discount;
            this.Category = category;
            this.Quantity = quantity;
            this.Size = size;
            this.Image = image;
        }

        public Product(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.Name = row["Name"].ToString();
            this.Price = (decimal)row["Price"];
            this.Discount = (decimal)row["Discount"];
            this.Category = (string)row["Category"];
            this.Quantity = (int)row["Quantity"];
            this.Size = (string)row["Size"];
            this.Image = (string)row["Image"];
        }
    }
}