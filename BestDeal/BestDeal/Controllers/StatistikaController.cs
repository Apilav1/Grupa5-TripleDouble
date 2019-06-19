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
    public class StatistikaController : Controller
    {
        private readonly IArtikli _artikliApp;
        private readonly ITipovi _tipoviApp;
        private readonly IKorpa _korpeApp;
        private readonly BestDealContext _context;


        public StatistikaController(BestDealContext context, IArtikli artikliApp, ITipovi tipoviApp, IKorpa korpaApp)
        {
            _context = context;
            _artikliApp = artikliApp;
            _tipoviApp = tipoviApp;
            _korpeApp = korpaApp;
        }

        public IActionResult Index()
        {
            return View(new StatistikaViewModel
            {
                artikli = _artikliApp.artikliApp,
                trenutniTip = _tipoviApp.tipoviApp.FirstOrDefault().Ime,
                korpe = _korpeApp.korpaApp,
                brojAdmina = 1,
                brojKorisnika = _context.IdentityUser.Count(),
                recenzije = _context.Recenzija
            });
        }
    }
}