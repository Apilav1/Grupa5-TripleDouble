using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BestDeal.Models;
using Microsoft.AspNetCore.Authorization;
using BestDeal.ViewModels;
using Microsoft.AspNetCore.Http;

namespace BestDeal.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArtikli _artikli;
        public HomeController(IArtikli artikli)
        {
            _artikli = artikli;
        }
        public ViewResult Index()
        {
            var pocetnaVM = new HomeViewModel
            {
                odabraniArtikli = _artikli.artikliApp
            };
            return View(pocetnaVM);
        }

        /*  //[Authorize(Roles ="Admin")]
          public IActionResult Privacy()
          {
              return View();
          }

          [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
          public IActionResult Error()
          {
              return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
          }
      }*/
    }
}
