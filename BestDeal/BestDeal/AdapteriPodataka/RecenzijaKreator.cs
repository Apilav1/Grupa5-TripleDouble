using BestDeal.Interfaces;
using BestDeal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.AdapteriPodataka
{
    public class RecenzijaKreator:IRecenzije
    {
        private readonly BestDealContext _context;

        public IEnumerable<Recenzija> recenzijeApp => _context.Recenzija;
        public RecenzijaKreator(BestDealContext context)
        {
            _context = context;
        }

    }
}
