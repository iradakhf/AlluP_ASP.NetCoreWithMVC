using Allup.DAL;
using Allup.Models;
using Allup.ViewModels.ShopVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;
        public ShopController(AppDbContext context)
        {
            _context = context;
        }
       public async Task<IActionResult> Search(int? id, string text)
        {
            IEnumerable<Product> products =
                await _context.Products
                   .Where(
                    p => p.Id !=null ? p.CategoryId == id : true ||
                p.Title.ToLower().Contains(text.ToLower()) ||
                p.Brand.Name.ToLower().Contains(text.ToLower())
                ).ToListAsync();

            List<ProductListVM> productListVMs = new List<ProductListVM>();
            foreach (Product item in products)
            {
                ProductListVM productListVM = new ProductListVM
                {
                    Id = item.Id,
                    Image = item.MainImage,
                    Title = item.Title
                };
            productListVMs.Add(productListVM);
            }
            //if (id != null)
            //{
            //   products=  await _context.Products
            //       .Where(
            //        p => p.CategoryId == id ||
            //    p.Title.ToLower().Contains(text.ToLower()) ||
            //    p.Brand.Name.ToLower().Contains(text.ToLower())
            //    ).ToListAsync();
            //}
            //else
            //{
            //  products=   await _context.Products.
            //        Where(
            //    p=>p.Title.ToLower().Contains(text.ToLower()) ||
            //    p.Brand.Name.ToLower().Contains(text.ToLower())
            //    ).ToListAsync();
            //}
            return PartialView("_SearchPartialView",products);
        }
    }
}
