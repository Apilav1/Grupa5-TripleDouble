using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.Models
{

    public interface IPretraga
    {
         List <Artikal> pretragaPoTipu(Tip t);
        List<Artikal> pretragaPoSpecifikaciji();
        List<Artikal> pretragaPoCijeni(double cijena);
        List<Artikal> pretragapoOcjeni(double ocjena);
        List<Artikal> pretragaPoVremenuIsporuke(DateTime isporuka);
        List<Artikal> pretragaPoDostupnosti(bool dostupno);
    }
}
