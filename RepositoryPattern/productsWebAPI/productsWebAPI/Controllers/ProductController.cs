using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using productsWebAPI.Repository.ProductsRepository;
namespace productsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductRepository _product;

        public ProductController(IProductRepository product)
        {
            _product = product;
        }


        [HttpGet]
        [Route("plist")]
        public IActionResult GetAllProducts()
        {
            return Ok(_product.GetAllProducts());
        }

        [HttpGet]
        [Route("plist/{id}")]
        public IActionResult GetProductById(int id)
        {
            return Ok(_product.GetProductById(id));
        }

        [HttpGet]
        [Route("plist/available/{para}")]
        public IActionResult GetProductInStock(bool para)
        {
            return Ok(_product.GetAllProductsInStock(para));
        }
    }
}







