using BestDeal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Artikal> odabraniArtikli { get; set; }
    }
}
