using BUS;
using DAO;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("GetAllProducts")]
        public List<Product> GetAllProducts()
        {
            try
            {
                List<Product> listProducts = ProductBUS.Instance.GetAllProduct();
                return listProducts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("SearchProductByName")]
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
                List<Product> listProducts = ProductBUS.Instance.SearchProductByName(name);
                return listProducts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        [Route("GetProductById")]
        public Product GetProductById(int id)
        {
            if (id <= 0)
            {
                //throw new ArgumentNullException("name");
                throw new Exception("Lỗi tìm kiếm");
            }

            try
            {
                Product product = ProductBUS.Instance.GetProductById(id);
                return product;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
