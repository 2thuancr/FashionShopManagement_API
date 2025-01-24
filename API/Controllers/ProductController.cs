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
        public IActionResult GetAllProducts()
        {
            try
            {
                List<Product> listProducts = ProductBUS.Instance.GetAllProduct();
                return Ok(listProducts);
            }
            catch (Exception ex)
            {
                return Problem(
                    detail: ex.Message,
                    statusCode: StatusCodes.Status500InternalServerError,
                    title: "Unexpected Error"
                );
            }
        }

        [HttpGet]
        [Route("SearchProductByName")]
        public IActionResult SearchProductByName(string name)
        {
            if (name == null || name == "")
            {
                throw new ArgumentNullException("name is required");
            }

            try
            {
                List<Product> listProducts = ProductBUS.Instance.SearchProductByName(name);
                
                return Ok(listProducts);
            }
            catch (Exception ex)
            {
                return Problem(
                    detail: ex.Message,
                    statusCode: StatusCodes.Status500InternalServerError,
                    title: "Unexpected Error"
                );
            }
        }
        [HttpGet]
        [Route("GetProductById")]
        public IActionResult GetProductById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentNullException("id must greater than 0");
            }

            try
            {
                Product product = ProductBUS.Instance.GetProductById(id);

                return Ok(product);
            }
            catch (Exception ex)
            {
                return Problem(
                    detail: ex.Message,
                    statusCode: StatusCodes.Status500InternalServerError,
                    title: "Unexpected Error"
                );
            }
        }
    }
}
