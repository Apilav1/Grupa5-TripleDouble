using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BestDeal.Models
{
    //klasa koja omogucava dodavanje tipova
    public class Tip
    {
        //TODO:Moguce opcije nekog IDa ili liste specificnih polja koju ima svaki tip (radi razlicitih detalja kod recenzija i sl.)
        public Tip(string ime)
        {
            Ime = ime;
        }
        [Required]
        [Key]
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

