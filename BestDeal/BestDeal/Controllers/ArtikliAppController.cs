using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestDeal.Interfaces;
using BestDeal.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BestDeal.Controllers
{
    public class ArtikliAppController : Controller
    {
        private readonly ITipovi _tipoviApp;
        private readonly IArtikli _artikliApp;

        public ArtikliAppController(ITipovi tipovi, IArtikli artikli)
        {
            _tipoviApp = tipovi;
            _artikliApp = artikli;
        }

        public ViewResult List()
        {
            ViewBag.Name = "Testara";
            ArtikliViewModel vm = new ArtikliViewModel();
            vm.artikli = _artikliApp.artikliApp;
            vm.trenutniTip = "NekiTip";
            return View(vm);
        }
    }
}