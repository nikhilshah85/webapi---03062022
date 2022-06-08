using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using productswebapi.Model;
namespace productswebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        Products pObj = new Products(); //dependency will be used here instead


        [HttpGet]
        [Route("plist")]
        public IActionResult GetallProducts()
        {
            return Ok(pObj.GetAllProducts());
        }

        [HttpGet]
        [Route("plis/{id}")]
        public IActionResult GetProductById(int id)
        {
            return Ok(pObj.GetProductById(id));
        }

    }
}
