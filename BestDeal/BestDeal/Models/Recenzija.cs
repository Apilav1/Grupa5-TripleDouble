using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BestDeal.Models
{

    public class Recenzija
    {
        [Required]
        int idRecenzije;
        int idArtikla;
        string tekstRecenzije;
        //double ocjenaArtikla;
        //TODO: specificne ocjene sada iskljucivo ovise o tipu artikla, potrebno je negdje definirati sta su one za koji tip
        //List<Tuple<int, double>> specificneOcjene;
        double batteryLifeRating;
        double designRating;
        double performanceRating;
        double overallRating;

        [Required]
        public double BatteryLifeRating { get => batteryLifeRating; set => batteryLifeRating = value; }
        [Required]
        public double DesignRating { get => designRating; set => designRating = value; }
        [Required]
        public double PerformanceRating { get => performanceRating; set => performanceRating = value; }
        [Required]
        public double OverallRating { get => overallRating; set => overallRating = value; }
        [Key]
        public int IdRecenzije { get => idRecenzije; set => idRecenzije = value; }
        public int IdArtikla { get => idArtikla; set => idArtikla = value; }
        public string TekstRecenzije { get => tekstRecenzije; set => tekstRecenzije = value; }

        // public Recenzija(string tekstRecenzije, double ocjenaArtikla, List<Tuple<int, double>> specificneOcjene)

        public Recenzija()
        {
        }

        public Recenzija(string tekstRecenzije2, double overallRating)
        {
            TekstRecenzije = tekstRecenzije2;
            OverallRating = overallRating;
        }

        //Nemamo property jer ne zelimo dozvoliti promjene
        double dajProsjekPojedinacnihRecenzija()
        {
            return (BatteryLifeRating + OverallRating + PerformanceRating + DesignRating) / 4; 
        }
        bool daLiJePozitivnaRecenzija()
        {
            return (OverallRating >= 8 && dajProsjekPojedinacnihRecenzija()>=8);
        }

        double getOverallRating()
        {
            return OverallRating;
        }
    }
}
