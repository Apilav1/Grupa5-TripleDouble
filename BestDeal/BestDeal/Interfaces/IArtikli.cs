using BestDeal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal
{
    public interface IArtikli
    {
        IEnumerable<Artikal> artikliApp { get; }
        Artikal dajArtikalPoID(int idArtikla);
    }
}
