using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.Models
{
    //Hajmo reci da je samo lista artikala i njihovih kolicina za pocetak
    //TODO: Integracija ocjena i svega
    public class Korpa
    {
        List<Tuple<Artikal, Recenzija, double>> podaciOArtiklima;

        public Korpa(List<Tuple<Artikal, Recenzija, double>> podaciOArtiklima)
        {
            PodaciOArtiklima = podaciOArtiklima;
        }

        public List<Tuple<Artikal, Recenzija, double>> PodaciOArtiklima { get => podaciOArtiklima; set => podaciOArtiklima = value; }
    }
}
