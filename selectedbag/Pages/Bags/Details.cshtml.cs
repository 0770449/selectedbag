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
    public class DetailsModel : PageModel
    {
        private readonly selectedbagContext _context;

        public DetailsModel(selectedbagContext context)
        {
            _context = context;
        }

        public Bag Bag { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bag = await _context.Bag.FirstOrDefaultAsync(m => m.ID == id);

            if (Bag == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
