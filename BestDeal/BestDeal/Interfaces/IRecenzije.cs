using BestDeal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.Interfaces
{
    public interface IRecenzije
    {
        IEnumerable<Recenzija> recenzijeApp { get; }
    }
}
