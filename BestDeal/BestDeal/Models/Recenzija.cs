using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.Models
{
    public class Recenzija
    {
        string tekstRecenzije;
        double ocjenaArtikla;
        //TODO: specificne ocjene sada iskljucivo ovise o tipu artikla, potrebno je negdje definirati sta su one za koji tip
        List<Tuple<int, double>> specificneOcjene;

        public Recenzija(string tekstRecenzije, double ocjenaArtikla, List<Tuple<int, double>> specificneOcjene)
        {
            this.tekstRecenzije = tekstRecenzije;
            this.ocjenaArtikla = ocjenaArtikla;
            this.specificneOcjene = specificneOcjene;
        }
        //Nemamo property jer ne zelimo dozvoliti promjene
        double dajProsjekPojedinacnihRecenzija(Recenzija r)
        {
            double suma = 0.0;
            for (int i = 0; i < specificneOcjene.Count; i++)
                suma += specificneOcjene[i].Item2;
            return suma / specificneOcjene.Count;
        }
        bool daLiJePozitivnaRecenzija(Recenzija r)
        {
            return (ocjenaArtikla >= 8 && dajProsjekPojedinacnihRecenzija(r)>=8);
        }
    }
}
