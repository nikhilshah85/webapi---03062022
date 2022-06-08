using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using html_webapi.Model;
namespace html_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        Products pObj = new Products();

        [HttpGet]
        [Route("plist")]
        public IActionResult GetProducts()
        {
            return Ok(pObj.DisplayProducts());
        }
    }
}
