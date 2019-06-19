using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.IdentityModel.Protocols;
using System.Data.SqlClient;
using System.Text;
using System.Diagnostics;
using BestDeal.AdapteriPodataka;

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
        static int id = 100;
        int idArtikla = 110;
        [ScaffoldColumn(false)]
        private List<Recenzija> recenzije=new List<Recenzija>();

        public Artikal()
        {
           id++;
             Debug.WriteLine("dodijelio id {0}", Program.lastArtikalId);
             idArtikla = Program.lastArtikalId;
             Program.lastArtikalId++;
        }

        public Artikal(double cijenaArtikla, int idArtikla)
        {
            CijenaArtikla = cijenaArtikla;
            this.idArtikla = idArtikla;
           idArtikla = Program.lastArtikalId;
            Program.lastArtikalId++;
        }
        String tippp;
        [System.ComponentModel.DisplayName("Naziv tipa artikla")]
        public String tipNaziv {
            get
            {
                return tippp;
            }
            set
            {
            
                tippp = value;
               Tip tip = new Tip();
                tip.Ime = value;
                Program.lastTipId++;
                tip.idTipa = Program.lastTipId;
                TipArtikla = tip;
            }
            }
        //TODO: Ovdje bi mozda bio koristan flyweight large-scale jer slike mogu biti velike u slucaju nekoliko hiljada artikala
        //public Image SlikaArtikla { get; }
        [Required]
        public Tip TipArtikla
        {
            get => tipArtikla;
            set
            {
                /*
                  //ako postoji tip ne treba dodavati novi
                foreach (Tip t in Tipovi.getInstance().ListaTipova.ToList())
                    if (t.Equals(value)) tipArtikla = value;
                    else
                    {
                       // Program.lastTipId++;
                      //  tipArtikla.idTipa = Program.lastTipId;
                tipArtikla = value;
                //ako je dodan tip koji ne postoji u listi tipova, automatski se azurira ta lista
                Tipovi.getInstance().ListaTipova.Add(value);
            }*/
            tipArtikla = value;
            }
        }
        [Required(ErrorMessage ="This field is required.")]
        [System.ComponentModel.DisplayName("Naziv artikla")]
        public string NazivArtikla { get => nazivArtikla; set => nazivArtikla = value; }
      
        [Required(ErrorMessage = "This field is required.")]
        [System.ComponentModel.DisplayName("Cijena artikla")]
        public double CijenaArtikla { get => cijenaArtikla; set => cijenaArtikla = value; }
        [ScaffoldColumn(false)]
        [System.ComponentModel.DisplayName("Ocjena artikla")]
        public double OcjenaArtikla { get => ocjenaArtikla; }// set => ocjenaArtikla = value; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdArtikla { get => idArtikla; set => idArtikla = value; }
        [Required(ErrorMessage = "This field is required.")]
        [System.ComponentModel.DisplayName("Kratki opis")]
        public string KratkiOpis { get => kratkiOpis; set => kratkiOpis = value; }
        [Required(ErrorMessage = "This field is required.")]
        [System.ComponentModel.DisplayName("Detaljni opis")]
        public string DetaljniOpis { get => detaljniOpis; set => detaljniOpis = value; }
        [Required(ErrorMessage = "This field is required.")]
        [System.ComponentModel.DisplayName("URL slike")]
        public string URLSlike1 { get => URLSlike; set => URLSlike = value; }
        [Required(ErrorMessage = "This field is required.")]
        [System.ComponentModel.DisplayName("URL male slike")]
        public string URLMaleSlike1 { get => URLMaleSlike; set => URLMaleSlike = value; }
        public List<Recenzija> Recenzije { get => recenzije; set => recenzije = value; }

        public void DodajRecenziju(string tekstRecenzije, double ocjenaArtikla)
        {
            Recenzije.Add(new Recenzija(tekstRecenzije, OcjenaArtikla));
     
            IzracunajOcjenu();
        }

       public void IzracunajOcjenu()
        {
            double suma = 0.0;

            foreach (Recenzija recenzija in Recenzije)
            {
                suma += recenzija.OverallRating;
            }

            ocjenaArtikla = suma / Recenzije.Count;
        }
      


    }
}
