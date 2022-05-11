using eShop_1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eShop_1.Controllers
{
    public class BrandController : Controller
    {
        private readonly AppDbContext _contex;
        public BrandController(AppDbContext context)
        {
            _contex = context;
        }
        public async Task<IActionResult> Index()
        {
            var allBrands = await _contex.Brands.ToListAsync();
            return View();
        }
    }
}
