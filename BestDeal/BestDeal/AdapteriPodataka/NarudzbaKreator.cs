using BestDeal.Interfaces;
using BestDeal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.AdapteriPodataka
{
    public class NarudzbaKreator : INarudzba
    {
        private readonly BestDealContext _context;
        private readonly Korpa _korpa;

        public NarudzbaKreator(BestDealContext context, Korpa k)
        {
            _context = context;
            _korpa = k;
        }

        public void kreirajNarudzbu(Narudzba na)
        {
            na.DatumVrijemeNarudzbe = DateTime.Now;
            _context.Narudzba.Add(na);

            var naruceniArtikli = na.OdabraniArtikli.ArtikliKolicina;

            foreach (var element in naruceniArtikli)
            {
                var info = new KorpaInfo()
                {
                    KolicinaArtikla = element.KolicinaArtikla,
                    A = element.A,
                    IdKorpe = element.IdKorpe
                };
            }
        }
    }
}
