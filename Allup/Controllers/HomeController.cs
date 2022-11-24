using Allup.DAL;
using Allup.Models;
using Allup.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
               Sliders= await _context.Sliders.Where(s => s.IsDeleted == false).ToListAsync(),
                Categories = await _context.Categories.Where(c => c.IsDeleted == false && c.IsMain == true ).ToListAsync(),
                NewArrivals = await _context.Products.Where(c=>c.IsDeleted==false && c.IsNewArrival).ToListAsync(),
                BestSellers = await _context.Products.Where(c => c.IsDeleted == false && c.IsBestSeller).ToListAsync(),
                Featured = await _context.Products.Where(c => c.IsDeleted == false && c.IsFeatured).ToListAsync()



            };
            return View(homeVM);

        }
    }
}
