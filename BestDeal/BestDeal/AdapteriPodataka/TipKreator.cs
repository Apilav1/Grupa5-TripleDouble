using BestDeal.Interfaces;
using BestDeal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.AdapteriPodataka
{
    public class TipKreator:ITipovi
    {
        List<Tip> listaTipova = new List<Tip>{new Tip { Ime = "Laptopi", idTipa = 1 },
                    new Tip { Ime = "Mobiteli", idTipa = 2 },
                    new Tip { Ime = "Računari", idTipa = 3 },
                    new Tip { Ime = "Računarska oprema", idTipa = 4 } };
        public IEnumerable<Tip> tipoviApp
        {
           
            get {
                return listaTipova;
            }
        }
        public Tip vratiTip(string nazivTipa)
        {
            foreach (Tip t in listaTipova) if (t.Ime.Equals(nazivTipa)) return t;
            return null; //FLAG
        }
    }
}
