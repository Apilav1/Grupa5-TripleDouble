using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;

namespace BestDeal.Models
{
    public class Artikal
    {
        private Tip tipArtikla;
        double cijenaArtikla;
        double ocjenaArtikla;

        public Artikal(Image slikaArtikla, Tip tipArtikla, double cijenaArtikla, double ocjenaArtikla)
        {
            this.SlikaArtikla = slikaArtikla;
            this.tipArtikla = tipArtikla;
            this.cijenaArtikla = cijenaArtikla;
            this.ocjenaArtikla = ocjenaArtikla;
        }

        public Image SlikaArtikla { get; }

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
        public double CijenaArtikla { get => cijenaArtikla; set => cijenaArtikla = value; }
        public double OcjenaArtikla { get => ocjenaArtikla; set => ocjenaArtikla = value; }
    }
}
