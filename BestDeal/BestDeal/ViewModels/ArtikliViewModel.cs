using BestDeal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.ViewModels
{
    public class ArtikliViewModel
    {
        public Artikal artikal { get; set; }
        public IEnumerable<Tip> tipoviBaza { get; set; }
    }
}
