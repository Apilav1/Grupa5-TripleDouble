using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestDeal.Interfaces;
using BestDeal.Models;
using Microsoft.EntityFrameworkCore;

namespace BestDeal.AdapteriPodataka
{
    public class ArtikalKreator : IArtikli
    {
        //private readonly ITipovi _tipKreator = new TipKreator();
        private readonly BestDealContext _context;

        public IEnumerable<Artikal> artikliApp => _context.Artikal.Include(t => t.TipArtikla);
        public ArtikalKreator(BestDealContext context)
        {
            _context = context;
        }


        public Artikal dajArtikalPoID(int idArtikla)
        {
            foreach (Artikal a in artikliApp) if (a.IdArtikla.Equals(idArtikla)) return a;
            return null;
        }
    }
}