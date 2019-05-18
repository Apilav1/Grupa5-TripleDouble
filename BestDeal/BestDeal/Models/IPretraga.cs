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
        List<Artikal> pretragaPoCijeni(double pocetnaCijena, double krajnjaCijena);
        List<Artikal> pretragapoOcjeni(double minimalnaOcjena);
        List<Artikal> pretragaPoVremenuIsporuke(DateTime isporuka);
        List<Artikal> pretragaPoDostupnosti(bool dostupno);
    }
}
