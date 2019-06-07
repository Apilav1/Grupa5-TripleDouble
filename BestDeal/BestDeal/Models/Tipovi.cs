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
        private static Object thisLock = new Object();
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
}

   
