using eShop_1.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace eShop_1.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _contex;
        public ProductController(AppDbContext context)
        {
            _contex = context;
        }
        public IActionResult Index()
        {
            var date = _contex.Products.ToList();
            return View();
        }
    }
}
