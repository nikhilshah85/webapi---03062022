using Microsoft.AspNetCore.Mvc;

namespace html_webapi.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Products()
        {
            return View();
        }
    }
}
