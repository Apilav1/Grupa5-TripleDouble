using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace BestDeal.Models
{
    public class Artikal
    {
        private Tip tipArtikla;
        double cijenaArtikla;
        //TODO: Mozda lista recenzija umjesto specificne ocjene artikla, ljepse izgleda
        double ocjenaArtikla;
        int idArtikla;
        [ScaffoldColumn(false)]
        private List<Recenzija> recenzije;

        public Artikal(Image slikaArtikla, Tip tipArtikla, double cijenaArtikla)//, double ocjenaArtikla)
        {
            this.SlikaArtikla = slikaArtikla;
            this.tipArtikla = tipArtikla;
            this.cijenaArtikla = cijenaArtikla;
           // this.ocjenaArtikla = ocjenaArtikla;
        }

        public Artikal(double cijenaArtikla, int idArtikla)
        {
            CijenaArtikla = cijenaArtikla;
            IdArtikla = idArtikla;
        }

        //TODO: Ovdje bi mozda bio koristan flyweight large-scale jer slike mogu biti velike u slucaju nekoliko hiljada artikala
        public Image SlikaArtikla { get; }
        [Required]
        public Tip TipArtikla { get => tipArtikla;
            set
            {
                //ako postoji tip ne treba dodavati novi
                foreach (Tip t in Tipovi.getInstance().ListaTipova)
                    if (t.Equals(value)) tipArtikla = value;
                else
                    {
                        tipArtikla = value;
                        //ako je dodan tip koji ne postoji u listi tipova, automatski se azurira ta lista
                        Tipovi.getInstance().ListaTipova.Add(value);
                    }
            }
        }
        [Required]
        public double CijenaArtikla { get => cijenaArtikla; set => cijenaArtikla = value; }
        [ScaffoldColumn(false)]
        public double OcjenaArtikla { get => ocjenaArtikla; } //set => ocjenaArtikla = value; }
        [Key]
        public int IdArtikla { get => idArtikla; set => idArtikla = value; }


        public void DodajRecenziju(string tekstRecenzije, double ocjenaArtikla, List<double> specificneOcjene)
        {
            recenzije.Add(new Recenzija(tekstRecenzije, specificneOcjene));
     
            IzracunajOcjenu();
        }

        void IzracunajOcjenu()
        {
            double suma = 0.0;

            foreach(Recenzija recenzija in recenzije)
            {
                suma += recenzija.OverallRating;
            }

            ocjenaArtikla = suma / recenzije.Count;
        }
       
    }
}
