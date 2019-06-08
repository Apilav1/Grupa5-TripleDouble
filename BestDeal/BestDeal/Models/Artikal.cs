using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace BestDeal.Models
{
    public class Artikal
    {
        private string nazivArtikla;
        private string kratkiOpis;
        private string detaljniOpis;
        private string URLSlike;
        private string URLMaleSlike;
        private Tip tipArtikla;
        double cijenaArtikla;
        //TODO: Mozda lista recenzija umjesto specificne ocjene artikla, ljepse izgleda
        double ocjenaArtikla;
        int idArtikla;
        [ScaffoldColumn(false)]
        private List<Recenzija> recenzije=new List<Recenzija>();

        public Artikal()
        {
        }

        public Artikal(double cijenaArtikla, int idArtikla)
        {
            CijenaArtikla = cijenaArtikla;
            IdArtikla = idArtikla;
        }

        //TODO: Ovdje bi mozda bio koristan flyweight large-scale jer slike mogu biti velike u slucaju nekoliko hiljada artikala
        //public Image SlikaArtikla { get; }
        [Required]
        public Tip TipArtikla { get => tipArtikla;
            set
            {
                //ako postoji tip ne treba dodavati novi
                foreach (Tip t in Tipovi.getInstance().ListaTipova.ToList())
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
        [Required]
        public string NazivArtikla { get => nazivArtikla; set => nazivArtikla = value; }
        [Required]
        public string KratkiOpis { get => kratkiOpis; set => kratkiOpis = value; }
        public string DetaljniOpis { get => detaljniOpis; set => detaljniOpis = value; }
        public string URLSlike1 { get => URLSlike; set => URLSlike = value; }
        public string URLMaleSlike1 { get => URLMaleSlike; set => URLMaleSlike = value; }

        public void DodajRecenziju(string tekstRecenzije, double ocjenaArtikla)
        {
            recenzije.Add(new Recenzija(tekstRecenzije, OcjenaArtikla));
     
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
