using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BestDeal.Models;

namespace BestDeal.Controllers
{
    public class DeleteModel : PageModel
    {
        private readonly BestDeal.Models.BestDealContext _context;

        public DeleteModel(BestDeal.Models.BestDealContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Artikal Artikal { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Artikal = await _context.Artikal.FirstOrDefaultAsync(m => m.IdArtikla == id);

            if (Artikal == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Artikal = await _context.Artikal.FindAsync(id);

            if (Artikal != null)
            {
                _context.Artikal.Remove(Artikal);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
