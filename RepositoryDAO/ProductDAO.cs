using DTO.Products;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

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

        public DataTable GetAllProduct(int page, int pageSize)
        {
            string query = "SELECT * FROM [dbo].[ViewAllProducts] " +
                           "ORDER BY Id " +
                           "OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";

            var sqlParameters = new List<SqlParameter>
            {
                new SqlParameter("@Offset", (page - 1) * pageSize),
                new SqlParameter("@PageSize", pageSize)
            };

            return DataProvider.Instance.ExecuteQuery(query, null, sqlParameters);
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

        public DataTable SearchAndFilterProducts(ProductsSearchRequest input)
        {
            string query = "USP_SearchAndFilterProducts";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@Query", input.Query ?? (object)DBNull.Value),
                new SqlParameter("@Brand", input.Brand ?? (object)DBNull.Value),
                new SqlParameter("@Size", input.Size ?? (object)DBNull.Value),
                new SqlParameter("@MinPrice", input.MinPrice ?? (object)DBNull.Value),
                new SqlParameter("@MaxPrice", input.MaxPrice ?? (object)DBNull.Value),
                new SqlParameter("@CategoryId", input.CategoryId ?? (object)DBNull.Value),
                new SqlParameter("@Page", input.Page),
                new SqlParameter("@PageSize", input.PageSize)
            };

            return DataProvider.Instance.ExecuteQuery(query, null, parameters, isStoredProcedure: true);
        }

        public DataTable GetProductById(int id)
        {
            string query = string.Format("USP_GetProductById @id");
            var parameters = new object[] { id };

            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public DataTable GetRelatedProducts(int productId)
        {
            string query = "USP_GetRelatedProducts";
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@ProductId", productId)
            };

            return DataProvider.Instance.ExecuteQuery(query, null, parameters, isStoredProcedure: true);
        }

        public DataTable GetProductsByCategory(int categoryId)
        {
            string query = "SELECT * FROM Product WHERE CategoryId = @CategoryId";
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@CategoryId", categoryId)
            };

            return DataProvider.Instance.ExecuteQuery(query, null, parameters);
        }

        public bool InsertProduct(Product newProduct)
        {
            //string query = string.Format("USP_InsertProduct '@Name', '@Price', '@Discount', '@Category', '@Quantity', '@Size', '@ImageUrl', '@Description'");
            string query = $"USP_InsertProduct '{newProduct.Name}', '{newProduct.Price}', '{newProduct.Discount}', '{newProduct.Category}', '{newProduct.Quantity}', '{newProduct.Size}', '{newProduct.ImageUrl}', '{newProduct.Description}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateProduct(Product product)
        {
            string query = string.Format("USP_UpdateFood @Id , @Name , @Price, @Discount, @Category , @Quantity, @Size, @ImageUrl, @Description");
            var parameters = new object[]
            {
                product.Id,
                product.Name,
                product.Price,
                product.Discount,
                product.Category,
                product.Quantity,
                product.Size,
                product.ImageUrl,
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