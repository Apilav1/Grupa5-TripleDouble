using BestDeal.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.Components
{
    public class PregledTipovi:ViewComponent
    {
        private readonly ITipovi _tipovi;

        public PregledTipovi(ITipovi tipovi)
        {
            _tipovi = tipovi;
        }
        public IViewComponentResult Invoke()
        {
            var pregled = _tipovi.tipoviApp.OrderBy(p => p.Ime);
            return View(pregled);
        }
    }
}
