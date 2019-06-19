using BestDeal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.ViewModels
{
    public class StatistikaViewModel
    {
        public Artikal artikal { get; set; }
        public IEnumerable<Artikal> artikli { get; set; }
        public string trenutniTip { get; set; }
        public int brojKorisnika { get; set; }
        public int brojAdmina { get; set; }
        public IEnumerable<Recenzija> recenzije { get; set; }
        public IEnumerable<Korpa> korpe{get; set; }
    }
}
