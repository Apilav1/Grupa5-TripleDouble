using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BestDeal.Models
{
    //Hajmo reci da je samo lista artikala i njihovih kolicina za pocetak
    //TODO: Integracija ocjena i svega
    public class Korpa
    {
        //List<Tuple<Artikal, Recenzija, double>> podaciOArtiklima;
        [Required]
        List<Tuple<Artikal, int>> artikliKolicina;

        public Korpa(List<Tuple<Artikal, int>> artikliKolicina)
        {
            this.artikliKolicina = artikliKolicina;
        }


        //public List<Tuple<Artikal, Recenzija, double>> PodaciOArtiklima { get => podaciOArtiklima; set => podaciOArtiklima = value; }
        public Artikal this[int index]
        {
            get
            {
                return artikliKolicina[index].Item1;
            }
        }

        public void DodajArtikla(Artikal artikal, int kolicina)
        {
            artikliKolicina.Add(new Tuple<Artikal, int>(artikal, kolicina));
        }
    }
}
