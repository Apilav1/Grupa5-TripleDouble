using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BestDeal.Models
{
    //Implementacija decorator patterna kroz nasljeđivanje iz interfejsa i editovanje u konkretnim implementacijama, olaksava shvacanje hijerarhije koda

    public class Obavijest:IObavijest
    {

        string tekstObavijesti;
        int idObavijesti;

        public Obavijest(string tekstObavijesti)
        {
            this.tekstObavijesti = tekstObavijesti;
        }
        [Required]
        public string TekstObavijesti { get => tekstObavijesti; set => tekstObavijesti = value; }
        [Key]
        public int IdObavijesti { get => idObavijesti; set => idObavijesti = value; }

        public void posaljiObavijest(string obavijest)
        {
            //nesto skontati
        }
    }
}
