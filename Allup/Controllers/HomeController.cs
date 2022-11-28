using Allup.DAL;
using Allup.Models;
using Allup.ViewModels.Home;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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


        //public async Task<IActionResult> SetObjectToCookie()
        //{
        //    Product product = await _context.Products.FirstOrDefaultAsync();
        //    string pro = JsonConvert.SerializeObject(product);

        //    HttpContext.Response.Cookies.Append("basket",pro);
        //    return Ok();
        //}
        //public async Task<IActionResult> GetObjectFromCookie()
        //{
        //  string pro=  HttpContext.Request.Cookies["basket"];
        //    return Json(pro);
        //}

        //public async Task<IActionResult> SetCookie()
        //{
        //    HttpContext.Response.Cookies.Append("cookie", "my first session");
        //    return RedirectToAction(nameof(Index));
        //}
        //public async Task<IActionResult> GetCookie()
        //{
        //    return Content(HttpContext.Request.Cookies["cookie"]);
        //}

        //public async Task<IActionResult> SetSession()
        //{
        //    HttpContext.Session.SetString("session", "my first session");
        //    return RedirectToAction(nameof (Index));
        //}
        //public async Task<IActionResult> GetSession()
        //{
        //    HttpContext.Session.GetString("session");
        //    return Content(HttpContext.Session.GetString("session"));
        //}
    }

}
