using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.Models
{
    public class Administrator : Korisnik
    {
        public Administrator(string ime, string prezime, string korisnickoIme, string password) : base(ime, prezime, korisnickoIme, password)
        {
        }
    }
}
