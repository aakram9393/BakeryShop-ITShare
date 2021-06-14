using BakeryShop.Data;
using BakeryShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryShop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BakeryShopContext _db;

        public List<Products> Products { get; set; } = new List<Products>();
        public  Products FeaturedProducts { get; set; }
        public IndexModel(BakeryShopContext db) => this._db = db;

        public async Task OnGetAsync()
        {
            Products = await _db.Products.ToListAsync();
            FeaturedProducts = Products.ElementAt(new Random().Next(Products.Count));
        }
    }
}
