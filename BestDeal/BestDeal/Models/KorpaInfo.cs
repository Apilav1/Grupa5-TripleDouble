using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestDeal.Models
{
    public class KorpaInfo:Korpa
    {
        string idKorpe;
        Artikal a;
        int kolicinaArtikla;
        int idKomponente;
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

        public string IdKorpe1 { get => idKorpe; set => idKorpe = value; }
        public int IdKomponente { get => idKomponente; set => idKomponente = value; }
    }
}
