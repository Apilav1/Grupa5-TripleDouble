using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BestDeal.Models;

namespace BestDeal.Controllers
{
    public class EditModel : PageModel
    {
        private readonly BestDeal.Models.BestDealContext _context;

        public EditModel(BestDeal.Models.BestDealContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Artikal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtikalExists(Artikal.IdArtikla))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ArtikalExists(int id)
        {
            return _context.Artikal.Any(e => e.IdArtikla == id);
        }
    }
}
