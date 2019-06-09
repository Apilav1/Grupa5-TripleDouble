using BestDeal.Models;
using BestDeal.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.Components
{
    public class PregledKorpe:ViewComponent
    {
        private readonly Korpa _korpa;
        public PregledKorpe(Korpa korpa)
        {
            _korpa = korpa;
        }
        public IViewComponentResult Invoke()
        {
            var elementiKorpe = _korpa.DajNaruceneArtikle();//new List<KorpaInfo>() { new KorpaInfo(), new KorpaInfo() };
            _korpa.ArtikliKolicina = elementiKorpe;

            var korpaVM = new KorpaViewModel
            {
                korpa = _korpa,
                UkupnaCijena = _korpa.DajUkupnuCijenu()
            };
            return View(korpaVM);
        }
    }
}
