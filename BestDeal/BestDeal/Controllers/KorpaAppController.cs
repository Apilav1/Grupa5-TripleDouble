using BestDeal.AdapteriPodataka;
using BestDeal.Models;
using BestDeal.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BestDeal.Controllers
{
    public class KorpaAppController : Controller
    {
        private readonly IArtikli _artikliApp;
        private readonly Korpa _korpica;

        public KorpaAppController(IArtikli ak, Korpa k)
        {
            _artikliApp = ak;
            _korpica = k;
        }

        [Authorize]
        public ViewResult Index()
        {
            var items = _korpica.DajNaruceneArtikle();
            _korpica.ArtikliKolicina = items;

            var korpaPogled = new KorpaViewModel
            {
                korpa = _korpica,
                UkupnaCijena = _korpica.DajUkupnuCijenu()
            };
            return View(korpaPogled);
        }

        [Authorize]
        public RedirectToActionResult AddToShoppingCart(int artikalID)
        {
            var odabrani = _artikliApp.odabraniArtikli.FirstOrDefault(p => p.IdArtikla == artikalID);
            if (odabrani != null)
            {
                _korpica.DodajUKorpu(odabrani, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int artikalID)
        {
            var odabrani = _artikliApp.odabraniArtikli.FirstOrDefault(p => p.IdArtikla == artikalID);
            if (odabrani != null)
            {
                _korpica.IzbaciIzKorpe(odabrani);
            }
            return RedirectToAction("Index");
        }

    }
}