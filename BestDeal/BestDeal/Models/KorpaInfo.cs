using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.Models
{
    public class KorpaInfo:Korpa
    {
        int idKorpe;
        Artikal a;
        int kolicinaArtikla;

        public KorpaInfo()
        {
        }

        public KorpaInfo(Artikal a, int kolicinaArtikla)
        {
            this.A = a;
            this.KolicinaArtikla = kolicinaArtikla;
        }

        public Artikal A { get => a; set => a = value; }
        public int KolicinaArtikla { get => kolicinaArtikla; set => kolicinaArtikla = value; }

        public int IdKorpe1 { get => idKorpe; set => idKorpe = value; }
    }
}
