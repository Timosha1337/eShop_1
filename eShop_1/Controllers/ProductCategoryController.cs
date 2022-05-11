using eShop_1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eShop_1.Controllers
{
    public class ProductCategoryController : Controller
    {
        private readonly AppDbContext _contex;
        public ProductCategoryController(AppDbContext context)
        {
            _contex = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProductCategories = await _contex.ProductCategories.ToListAsync();
            return View();
        }
    }
}
