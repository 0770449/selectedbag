using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using selectedbag.Models;

namespace selectedbag.Pages_Bags
{
    public class IndexModel : PageModel
    {
        private readonly selectedbagContext _context;

        public IndexModel(selectedbagContext context)
        {
            _context = context;
        }

        public IList<Bag> Bag { get;set; }

        public async Task OnGetAsync()
        {
            Bag = await _context.Bag.ToListAsync();
        }
    }
}
