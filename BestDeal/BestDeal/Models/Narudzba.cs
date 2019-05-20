using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.Models
{
    public class Narudzba : IPlacanje
    {
        //TODO:  treba uvezati sa dostavom i placanjem
        [Key]
        int idNarudzbe;
        Korpa odabraniArtikli;
        DateTime datumVrijemeNarudzbe;
        StanjeNarudzbe stanje;

        public Korpa OdabraniArtikli { get => odabraniArtikli; set => odabraniArtikli = value; }
        public DateTime DatumVrijemeNarudzbe { get => datumVrijemeNarudzbe; set => datumVrijemeNarudzbe = value; }
        internal StanjeNarudzbe Stanje { get => stanje; set => stanje = value; }

        public Narudzba(Korpa odabraniArtikli, DateTime datumVrijemeNarudzbe)
        {
            this.OdabraniArtikli = odabraniArtikli;
            this.DatumVrijemeNarudzbe = datumVrijemeNarudzbe;
        }

        public void placanjeKarticom()
        {

        }

        public void placanjePouzecem()
        {

        }
        void zaprimanje()
        {
            Stanje.zaprimanje();
        }
        void priprema()
        {
            Stanje.priprema();
        }
        void isporuka()
        {
            Stanje.isporuka();
        }
    }
}
