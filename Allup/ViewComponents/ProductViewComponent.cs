using Allup.ComponentViewModels.ProductVM;
using Allup.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public ProductViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ProductVM productVM = new ProductVM
            {
                NewArrivals = await _context.Products.Where(c => c.IsDeleted == false && c.IsNewArrival).ToListAsync(),
                BestSellers = await _context.Products.Where(c => c.IsDeleted == false && c.IsBestSeller).ToListAsync(),
                Featured = await _context.Products.Where(c => c.IsDeleted == false && c.IsFeatured).ToListAsync()
            };

           return View(await Task.FromResult(productVM));
        }
    }
}
