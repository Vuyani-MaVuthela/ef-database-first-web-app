using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ef_database_first_web_app.Data;
using ef_database_first_web_app.Models;

namespace ef_database_first_web_app.Pages.Shared.Products
{
    public class IndexModel : PageModel
    {
        private readonly ef_database_first_web_app.Data.ContosoPizzaContext _context;

        public IndexModel(ef_database_first_web_app.Data.ContosoPizzaContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Product = await _context.Products.ToListAsync();
            }
        }
    }
}
