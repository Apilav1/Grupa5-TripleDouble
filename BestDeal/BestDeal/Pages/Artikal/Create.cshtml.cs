using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BestDeal.Models;

namespace BestDeal.Controllers
{
    public class CreateModel : PageModel
    {
        private readonly BestDeal.Models.BestDealContext _context;

        public CreateModel(BestDeal.Models.BestDealContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Artikal Artikal { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Artikal.Add(Artikal);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}