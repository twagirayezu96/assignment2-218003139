using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EComercial.Data;
using EComercial.Models;

namespace EComercial.Pages_Products
{
    public class IndexModel : PageModel
    {
        private readonly EComercial.Data.ProductContext _context;

        public IndexModel(EComercial.Data.ProductContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
