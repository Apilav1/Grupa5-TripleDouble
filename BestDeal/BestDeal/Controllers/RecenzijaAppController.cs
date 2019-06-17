using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestDeal.Interfaces;
using BestDeal.Models;
using BestDeal.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BestDeal.Controllers
{
    public class RecenzijaAppController : Controller
    {
        private readonly IRecenzije _recenzijeApp;
        private readonly IArtikli _artikliApp;
        public RecenzijaAppController(IRecenzije recenzije, IArtikli artikli)
        {
            _recenzijeApp = recenzije;
            _artikliApp = artikli;
        }

        public ViewResult List(string artikal)
        {
            string _artikal = artikal;
            IEnumerable<Recenzija> recenzijeR;
            Artikal sadasnjiArtikal;
            //WriteErrorLog(tip);
            if (string.IsNullOrEmpty(artikal))
            {
                //nema te opcije
                sadasnjiArtikal= _artikliApp.artikliApp.FirstOrDefault();
                recenzijeR = _recenzijeApp.recenzijeApp;
            }
            else
            {
                recenzijeR = _recenzijeApp.recenzijeApp.Where(p => p.IdArtikla.Equals(artikal)).OrderBy(p => p.IdRecenzije);
                sadasnjiArtikal = _artikliApp.artikliApp.Where(a => a.IdArtikla.Equals(artikal)).FirstOrDefault();
            }
            return View(new RecenzijaViewModel
            {
                trenutniArtikal=sadasnjiArtikal,
                recenzije = recenzijeR
            });
        }
    }
}
