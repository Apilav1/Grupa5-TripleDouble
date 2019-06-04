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
       List<KorpaInfo> artikliKolicina;
        int idKorpe;
        public Korpa()
        {
        }

        public Korpa(int idKorpe, List<KorpaInfo> artikliKolicina)
        {
            IdKorpe = idKorpe;
            ArtikliKolicina = artikliKolicina;
        }



        //public List<Tuple<Artikal, Recenzija, double>> PodaciOArtiklima { get => podaciOArtiklima; set => podaciOArtiklima = value; }

        [Key]
        public int IdKorpe { get => idKorpe; set => idKorpe = value; }
        public List<KorpaInfo> ArtikliKolicina { get => artikliKolicina; set => artikliKolicina = value; }

        public void DodajArtikla(Artikal artikal, int kolicina)
        {
            ArtikliKolicina.Add(new KorpaInfo(artikal, kolicina));
        }
    }
}
