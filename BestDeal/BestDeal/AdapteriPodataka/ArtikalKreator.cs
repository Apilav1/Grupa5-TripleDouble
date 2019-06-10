using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestDeal.Interfaces;
using BestDeal.Models;

namespace BestDeal.AdapteriPodataka
{
    public class ArtikalKreator : IArtikli
    {
        private readonly ITipovi _tipKreator = new TipKreator();
        public IEnumerable<Artikal> artikliApp {
            get
            {
                return new List<Artikal>
                {
                    new Artikal
                    {
                        NazivArtikla="HP 250 G6",
                        CijenaArtikla=700,
                        KratkiOpis="Vrhunski laptop za prosječnog korisnika!",
                        DetaljniOpis="Povežite se sa cijenjenim HP 250 notebook računarima. Završajite poslovne zadatke sa Intel® tehnologijom, osnovnim alatima za saradnju koji su učitani na HP 250. Izdržljiva šasija pomaže zaštiti laptopa od strogosti dana.",
                        URLMaleSlike1="https://static.toiimg.com/photo/60104728/HP-15-BS542TU-2EY84PA-Laptop-Core-i3-6th-Gen4-GB1-TBDOS.jpg",
                        URLSlike1="https://images-na.ssl-images-amazon.com/images/I/81iq991JMEL._SL1500_.jpg",
                        TipArtikla =_tipKreator.vratiTip("Laptopi")
                    },
                    new Artikal
                    {
                        NazivArtikla="LENOVO IdeaPad D330",
                        CijenaArtikla=850,
                        KratkiOpis="Odličan izbor za putovanja!",
                        DetaljniOpis="With up to Intel Pentium® Silver processing, the IdeaPad D330 has real computing power—and all the fun and mobility of a lightweight tablet. From multitasking to connecting with friends online and streaming shows, the D330 gives you the freedom to do more, anywhere.",
                        URLMaleSlike1="https://images-na.ssl-images-amazon.com/images/I/41FYl0JeBtL._SX425_.jpg",
                        URLSlike1="https://www.wootware.co.za/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/f/x/fxpapmt2ez1.jpg",
                        TipArtikla =_tipKreator.vratiTip("Laptopi")
                    }
                };
            }
            set { }
            }
        public IEnumerable<Artikal> odabraniArtikli { get; }

        public Artikal dajArtikalPoID(int idArtikla)
        {
            throw new NotImplementedException();
        }
    }
}
