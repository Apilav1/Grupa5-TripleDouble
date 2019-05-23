using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.Models
{
    //Upitno je da li treba implementirati neke posebne klase za specificna stanja narudzbe obzirom da nemamo velike koristi od gomilanja, mada to postuje State pattern
    abstract public class StanjeNarudzbe
    {
        protected Narudzba narudzbica;

        StanjeNarudzbe(Narudzba narudzbica)
        {
            this.narudzbica = narudzbica;
        }
        public abstract void zaprimanje();
        public abstract void priprema();
        public abstract void isporuka();
    }
}
