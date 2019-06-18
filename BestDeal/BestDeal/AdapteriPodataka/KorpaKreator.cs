using BestDeal.Interfaces;
using BestDeal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.AdapteriPodataka
{
    public class KorpaKreator : IKorpa
    {
        private readonly BestDealContext _context;
        public KorpaKreator(BestDealContext context)
        {
            _context = context;
        }
        public IEnumerable<Korpa> korpaApp => _context.Korpa;
    }
}
