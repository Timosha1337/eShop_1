using Microsoft.AspNetCore.Mvc;

namespace eShop_1.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
