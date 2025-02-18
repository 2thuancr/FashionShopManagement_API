using DTO.Products;
using System.Data;

namespace DAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;

        public static ProductDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProductDAO();
                return ProductDAO.instance;
            }
        }

        private ProductDAO() { }

        public DataTable GetAllProduct()
        {
            string query = "SELECT * FROM [dbo].[ViewAllProducts]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetListProductByCategory(string category)
        {
            string query = "USP_GetListProductByCategory @Category";
            var parameters = new object[] { category };

            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public DataTable SearchProductByName(string name)
        {
            string query = string.Format($"SELECT * FROM SearchProducts(N'{name}')");

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetProductById(int id)
        {
            string query = string.Format("USP_GetProductById @id");
            var parameters = new object[] { id };

            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public bool InsertProduct(Product newProduct)
        {
            //string query = string.Format("USP_InsertProduct '@Name', '@Price', '@Discount', '@Category', '@Quantity', '@Size', '@Image', '@Description'");
            string query = $"USP_InsertProduct '{newProduct.Name}', '{newProduct.Price}', '{newProduct.Discount}', '{newProduct.Category}', '{newProduct.Quantity}', '{newProduct.Size}', '{newProduct.Image}', '{newProduct.Description}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateProduct(Product product)
        {
            string query = string.Format("USP_UpdateFood @Id , @Name , @Price, @Discount, @Category , @Quantity, @Size, @Image, @Description");
            var parameters = new object[]
            {
                product.Id,
                product.Name,
                product.Price,
                product.Discount,
                product.Category,
                product.Quantity,
                product.Size,
                product.Image,
                product.Description
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool DeleteProduct(int Id)
        {
            var query = "USP_DeleteProduct @Id";
            var parameters = new object[] { Id };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}