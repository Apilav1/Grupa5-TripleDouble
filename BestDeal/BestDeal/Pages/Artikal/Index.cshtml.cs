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
    public class IndexModel : PageModel
    {
        private readonly BestDeal.Models.BestDealContext _context;

        public IndexModel(BestDeal.Models.BestDealContext context)
        {
            _context = context;
        }

        public IList<Artikal> Artikal { get;set; }

        public async Task OnGetAsync()
        {
            Artikal = await _context.Artikal.ToListAsync();
        }
    }
}
