using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.Models
{
    //Implementacija decorator patterna kroz nasljeđivanje iz interfejsa i editovanje u konkretnim implementacijama, olaksava shvacanje hijerarhije koda

    public class Obavijest:IObavijest
    {
        string tekstObavijesti;

        public Obavijest(string tekstObavijesti)
        {
            this.tekstObavijesti = tekstObavijesti;
        }

        public string TekstObavijesti { get => tekstObavijesti; set => tekstObavijesti = value; }

        public void posaljiObavijest(string obavijest)
        {
            //nesto skontati
        }
    }
}
