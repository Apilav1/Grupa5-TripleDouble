using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestDeal.Interfaces;
using BestDeal.Models;
using Microsoft.AspNetCore.Mvc;

namespace BestDeal.Controllers
{
    public class NarudzbaAppController : Controller
    {
        private readonly INarudzba _narudzba;
        private readonly Korpa _korpa;

        public NarudzbaAppController(INarudzba narudzba, Korpa korpa)
        {
            _narudzba = narudzba;
            _korpa = korpa;
        }

        public IActionResult Placanje()
        {
            return View();
        }
    }
}