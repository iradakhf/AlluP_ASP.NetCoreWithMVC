using Allup.DAL;
using Allup.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ProductController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> IndexAsync()
        {
            IEnumerable<Product> products = await _appDbContext.Products
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .Include(p => p.ProductTags)
                .ThenInclude(p => p.Tag)
                .Where(p => p.IsDeleted == false)
                .ToListAsync();
            return View(products);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}
