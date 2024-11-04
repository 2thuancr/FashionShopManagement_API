using System;
using System.Collections.Generic;
using System.Data;

using DTO;
using DAO;
using System.Linq;

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

        public List<Product> SearchProductByName(string name)
        {
            if (name == null || name == "")
            {
                //throw new ArgumentNullException("name");
                throw new Exception("Chưa nhập dữ liệu tìm kiếm.");
            }    

            DataTable table;
            try
            {
                table = ProductDAO.Instance.SearchProductByName(name);
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

            List<Product> lstProduct = new List<Product>();
            foreach (DataRow row in table.Rows)
            {
                Product product = new Product(row);
                lstProduct.Add(product);
            }
            return lstProduct.First();
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