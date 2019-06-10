using BestDeal.AdapteriPodataka;
using BestDeal.Models;
using BestDeal.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
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

      /*  public static void WriteErrorLog(string strErrorText)
       {
           try
           {
               //DECLARE THE FILENAME FROM THE ERROR LOG
               string strFileName = "errorLog.txt";
               string strPath = "C:\\Users\\Mirza\\Documents\\GitHub\\Grupa5-TripleDouble";
               //WRITE THE ERROR TEXT AND THE CURRENT DATE-TIME TO THE ERROR FILE
               System.IO.File.AppendAllText(strPath + "\\" + strFileName, strErrorText + " - " + DateTime.Now.ToString() + "\r\n");
           }
           catch (Exception ex)
           {
               WriteErrorLog("Error in WriteErrorLog: " + ex.Message);
           }
       }*/

        public RedirectToActionResult DodajKorpa(int artikalID)
        {
           // WriteErrorLog(artikalID.ToString());
            Artikal odabrani = _artikliApp.artikliApp.FirstOrDefault(p => p.IdArtikla == artikalID);
            if (odabrani != null)
            {
                _korpica.DodajUKorpu(odabrani, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult BrisiKorpa(int artikalID)
        {
            var odabrani = _artikliApp.artikliApp.FirstOrDefault(p => p.IdArtikla == artikalID);
            if (odabrani != null)
            {
                _korpica.IzbaciIzKorpe(odabrani);
            }
            return RedirectToAction("Index");
        }

    }
}