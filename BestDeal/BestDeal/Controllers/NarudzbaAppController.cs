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
    public class NarudzbaAppController : Controller
    {
        private readonly IKorpa _korpa;

        public NarudzbaAppController(IKorpa korpa)
        {
            _korpa = korpa;
        }

        public ViewResult Placanje(string korpa)
        {
            string _korpica = korpa;
            Narudzba narudzbaN;
            Korpa nasaKorpa;
            //WriteErrorLog(tip);
            if (string.IsNullOrEmpty(korpa))
            {
                //nema te opcije
                return View("Views/PogresnaCesta.cshtml");
            }
            else
            {
                nasaKorpa = _korpa.korpaApp.Where(k => k.IdKorpe.Equals(_korpica)).FirstOrDefault();
            }
            return View(new NarudzbaViewModel
            {
                korpa = nasaKorpa
            });
        }
    }
}