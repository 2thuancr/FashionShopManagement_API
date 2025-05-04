using System;
using System.Collections.Generic;
using System.Data;

using DTO.Products;
using DAO;
using System.Linq;
using DTO.ApiRequests;
using System.Data.SqlClient;

namespace BUS
{
    public class ProductBUS
    {
        private static ProductBUS instance;

        public static ProductBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProductBUS();
                return ProductBUS.instance;
            }
        }

        private ProductBUS() { }

        public List<Product> GetAllProduct()
        {
            DataTable table = new DataTable();
            try
            {
                table = ProductDAO.Instance.GetAllProduct();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<Product> lstProduct = new List<Product>();
            foreach (DataRow row in table.Rows)
            {
                Product product = new Product(row);
                lstProduct.Add(product);
            }
            return lstProduct;
        }

        public List<Product> GetAllProduct(ApiRequestPaginationInput input)
        {
            DataTable table = new DataTable();
            try
            {
                table = ProductDAO.Instance.GetAllProduct(input.Page, input.PageSize);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<Product> lstProduct = new List<Product>();
            foreach (DataRow row in table.Rows)
            {
                Product product = new Product(row);
                lstProduct.Add(product);
            }
            return lstProduct;
        }

        public List<Product> GetListProductByCategory(string category)
        {
            DataTable table;
            try
            {
                table = ProductDAO.Instance.GetListProductByCategory(category);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<Product> lstProduct = new List<Product>();
            foreach (DataRow row in table.Rows)
            {
                Product product = new Product(row);
                lstProduct.Add(product);
            }
            return lstProduct;
        }

        public List<Product> SearchAndFilterProducts(ProductsSearchRequest input)
        {
            DataTable table;
            try
            {
                table = ProductDAO.Instance.SearchAndFilterProducts(input);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<Product> lstProduct = new List<Product>();
            foreach (DataRow row in table.Rows)
            {
                Product product = new Product(row);
                lstProduct.Add(product);
            }
            return lstProduct;
        }

        public Product GetProductById(int id)
        {
            if (id <= 0)
            {
                //throw new ArgumentNullException("name");
                throw new Exception("Lỗi tìm kiếm");
            }

            DataTable table;
            try
            {
                table = ProductDAO.Instance.GetProductById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            Product product = new Product();
            if(table != null && table.Rows.Count > 0)
            {
                product = new Product(table.Rows[0]);
            }
            return product;
        }

        public List<Product> GetRelatedProducts(int productId)
        {
            if (productId <= 0)
            {
                throw new Exception("Lỗi tìm kiếm");
            }

            DataTable table;
            try
            {
                table = ProductDAO.Instance.GetProductById(productId);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<Product> listProducts = new List<Product>();

            foreach (DataRow row in table.Rows)
            {
                Product product = new Product(row);
                listProducts.Add(product);
            }

            return listProducts;
        }

        public List<Product> GetByCategory(int categoryId)
        {
            if (categoryId <= 0)
            {
                throw new Exception("Lỗi tìm kiếm");
            }

            DataTable table;
            try
            {
                table = ProductDAO.Instance.GetProductsByCategory(categoryId);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<Product> listProducts = new List<Product>();

            foreach (DataRow row in table.Rows)
            {
                Product product = new Product(row);
                listProducts.Add(product);
            }

            return listProducts;
        }

        public bool InsertProduct(Product newProduct)
        {
            return ProductDAO.Instance.InsertProduct(newProduct);
        }

        public bool UpdateProduct(Product product)
        {
            return ProductDAO.Instance.UpdateProduct(product);
        }

        public bool DeleteProduct(int id)
        {
            return ProductDAO.Instance.DeleteProduct(id);
        }
    }
}