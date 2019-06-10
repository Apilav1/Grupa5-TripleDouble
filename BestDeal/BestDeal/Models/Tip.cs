using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BestDeal.Models
{
    //klasa koja omogucava dodavanje tipova
    public class Tip
    {
        public Tip()
        {
        }
        //TODO:Moguce opcije nekog IDa ili liste specificnih polja koju ima svaki tip (radi razlicitih detalja kod recenzija i sl.)
        public Tip(string ime)
        {
            Ime = ime;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idTipa { get; set; }
        public string Ime { get;  set; }
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
            return HashCode.Combine(idTipa);
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

