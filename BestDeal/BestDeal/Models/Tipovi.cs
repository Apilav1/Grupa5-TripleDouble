using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.Models
{
    //Ove klase ce sadržavati sve tipove artikala, međutim ne želimo da se oni statički gomilaju pa pravimo opciju za dinamičko dodavanje tipova na ispravan OOP način

    //klasa tipovi ce biti urađena preko Singleton patterna jer nam je potrebna isključivo jedna instanca tipova artikala i oni se NE SMIJU mijenjati
    public sealed class Tipovi
    {
        private static Tipovi instancaTipovi; //instanca klase
        List<Tip> listaTipova = new List<Tip>();
        private static readonly object thread = new object();

        public List<Tip> ListaTipova { get => listaTipova; set => listaTipova = value; }

        private Tipovi()
        {
            //Privatni pocetni tip na koji se kasnije mogu dodavati novi kroz klasu Tip
            Tip Generalni = new Tip("Generalno");
            listaTipova.Add(Generalni);
        }
        public static Tipovi getInstance()
        {
            if (instancaTipovi == null)
            {
                //thread-safe implementacija da podrzimo multithreading
                lock (thread)
                {
                    if (instancaTipovi == null)
                        instancaTipovi = new Tipovi();
                }
            }
            return instancaTipovi;
        }
    }

    //klasa koja omogucava dodavanje tipova
    public class Tip
    {
        //TODO:Moguce opcije nekog IDa ili liste specificnih polja koju ima svaki tip (radi razlicitih detalja kod recenzija i sl.)
        public Tip(string ime)
        {
            Ime = ime;
        }
        public string Ime { get; private set; }
        public override bool Equals(object obj)
        {
            var other = obj as Tip;
            if (other == null)
            {
                return false;
            }
            return other == this;
        }
        public override int GetHashCode()
        {
            return Ime.GetHashCode();
        }

        public static bool operator ==(Tip Tip1, Tip Tip2)
        {
            if (Object.ReferenceEquals(Tip1, null) && Object.ReferenceEquals(Tip2, null))
                return true;

            if (Object.ReferenceEquals(Tip1, null) || Object.ReferenceEquals(Tip2, null))
                return false;

            return Tip1.Ime == Tip2.Ime;
        }
        public static bool operator !=(Tip Tip1, Tip Tip2)
        {
            return !(Tip1 == Tip2);
        }
    }
}
