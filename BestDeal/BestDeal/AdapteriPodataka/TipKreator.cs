using BestDeal.Interfaces;
using BestDeal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.AdapteriPodataka
{
    public class TipKreator:ITipovi
    {
        private readonly BestDealContext _context;
        public TipKreator(BestDealContext context)
        {
            _context = context;
        }
        public IEnumerable<Tip> tipoviApp => _context.Tip;
        public Tip vratiTip(string nazivTipa)
        {
            foreach (Tip t in tipoviApp) if (t.Ime.Equals(nazivTipa)) return t;
            return null; //FLAG
        }
    }
}
