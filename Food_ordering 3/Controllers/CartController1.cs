using Microsoft.AspNetCore.Mvc;

namespace Food_ordering_3.Controllers
{
    public class CartController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
