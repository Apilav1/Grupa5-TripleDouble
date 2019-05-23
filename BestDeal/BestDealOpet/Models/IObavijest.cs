using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.Models
{
    //bazicni decorator pattern
    interface IObavijest
    {
        string TekstObavijesti { get; set; }

        void posaljiObavijest(string obavijest);
    }
}
