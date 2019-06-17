using BestDeal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.ViewModels
{
    public class RecenzijaViewModel
    {
        public IEnumerable<Recenzija> recenzije { get; set; }
        public Artikal trenutniArtikal { get; set; }
    }
}
