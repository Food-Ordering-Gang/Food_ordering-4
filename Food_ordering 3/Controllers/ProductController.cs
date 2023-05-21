using Microsoft.AspNetCore.Mvc;

namespace Food_ordering_3.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
