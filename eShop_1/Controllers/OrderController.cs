﻿using eShop_1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eShop_1.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _contex;
        public OrderController(AppDbContext context)
        {
            _contex = context;
        }
        public async Task<IActionResult> Index()
        {
            var allOrders = await _contex.Orders.ToListAsync();
            return View();
        }
    }
}
