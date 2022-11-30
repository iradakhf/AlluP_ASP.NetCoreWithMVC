using Allup.DAL;
using Allup.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Allup.ViewModels.Basket;

namespace Allup.Controllers
{
    public class BasketController : Controller
    {
        private readonly AppDbContext _context;

        public BasketController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> AddToBasket(int? id)
        {
            if (id == null)
            {
                return BadRequest("id null ola bilmez");
            }
            Product product = await _context.Products.FirstOrDefaultAsync(p => p.IsDeleted == false && p.Id == id);

            if (!await _context.Products.AnyAsync(p=>p.IsDeleted == false && p.Id ==id))
            {
                return NotFound("Id Yanlisdir");
            }

            string basket = HttpContext.Request.Cookies["basket"];
            List<BasketVM> products = null;
            if (!string.IsNullOrWhiteSpace(basket))
            {
                products = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
                BasketVM basketVM = products.Find(p => p.Id == id);
                if (basketVM!=null)
                {
                    basketVM.Count += 1;
                }
                else
                {
                    basketVM = new BasketVM
                    {
                        Id = (int)id,
                        Count = 1
                    };
                    products.Add(basketVM);
                }
            }
            else
            {
               products = new List<BasketVM>();
                BasketVM basketVM = new BasketVM
                {
                    Id = (int)id,
                    Count = 1
                };
                products.Add(basketVM);
               
               
            }
                 basket = JsonConvert.SerializeObject(products);
                HttpContext.Response.Cookies.Append("basket",basket);
            foreach (BasketVM item in products)
            {
                product = await _context.Products.FirstOrDefaultAsync(p => p.IsDeleted == false && p.Id == item.Id);
                item.Title = product.Title;
                item.Image = product.MainImage;
                item.Price = product.DiscountedPrice > 0 ? product.DiscountedPrice : product.Price;
                item.ExTax = product.ExTax;
            }
            return PartialView("_BasketCartPartial", products);
        }

        public async Task<IActionResult> DeleteFromBasket(int? id)
        {
            if (id == null)
            {
                return BadRequest();

            }
            Product product = await _context.Products.FirstOrDefaultAsync(p => p.IsDeleted == false && p.Id == id);
           if(product !=null)
            {
                return NotFound();
            }
            string basket = HttpContext.Request.Cookies["basket"];
            List<BasketVM> products = null;
            if (!string.IsNullOrWhiteSpace(basket))
            {
                products = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
                BasketVM basketVM = products.Find(p=>p.Id==id);
                if (basketVM != null)
                {
                    products.Remove(basketVM);
                }
                else
                {
                    return NotFound();
                }
            }
            basket = JsonConvert.SerializeObject(products);
            HttpContext.Response.Cookies.Append("basket",basket);

            foreach (BasketVM basketVM in products)
            {
                product = await _context.Products.FirstOrDefaultAsync(p => p.Id == basketVM.Id);
                basketVM.Image = product.MainImage;
                basketVM.Price = product.DiscountedPrice > 0 ? product.DiscountedPrice : product.Price;
                basketVM.ExTax = product.ExTax;
                basketVM.Title = product.Title;
            }

            return PartialView("_BasketCartPartial", products);

        }
        public async Task<IActionResult> GetBasketContent()
        {
          string pro =  HttpContext.Request.Cookies["basket"];
            List<BasketVM> products = JsonConvert.DeserializeObject<List<BasketVM>>(pro);
            return Json(products);
          
        }
    }
}
