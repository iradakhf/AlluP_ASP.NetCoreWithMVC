using Allup.DAL;
using Allup.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public  async Task<IActionResult> GetProductModal(int? id)
        {
           Product product = await _context.Products.FirstOrDefaultAsync(p =>p.IsDeleted==false && p.Id == id);
            return PartialView("_ModalPartialView",product);
        }
    }
}
