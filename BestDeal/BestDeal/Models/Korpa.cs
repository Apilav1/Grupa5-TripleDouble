using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace BestDeal.Models
{
    //Hajmo reci da je samo lista artikala i njihovih kolicina za pocetak
    //TODO: Integracija ocjena i svega
    public class Korpa
    {
        private readonly BestDealContext _context;

        //List<Tuple<Artikal, Recenzija, double>> podaciOArtiklima;
        [Required]
       List<KorpaInfo> artikliKolicina;
        string idKorpe;
        public Korpa()
        {
        }
        string slikaKorpe;
        public Korpa(BestDealContext context)
        {
            _context = context;
        }

        public Korpa(string idKorpe, List<KorpaInfo> artikliKolicina)
        {
            IdKorpe = idKorpe;
            ArtikliKolicina = artikliKolicina;
        }

        public static Korpa DajKorpu(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<BestDealContext>();
            string korpica = session.GetString("idKorpe") ?? Guid.NewGuid().ToString();

            session.SetString("idKorpe", korpica);

            return new Korpa(context) { idKorpe = korpica };
        }

        public void DodajUKorpu(Artikal artikal, int kolicina)
        {
            var elementKorpe =
                    _context.KorpaInfo.SingleOrDefault(
                        s => s.A.IdArtikla == artikal.IdArtikla && s.IdKorpe1 == idKorpe);

            if (elementKorpe == null)
            {
                elementKorpe = new KorpaInfo
                {
                    idKorpe = idKorpe,
                    A = artikal,
                KolicinaArtikla = 1
            };

            _context.KorpaInfo.Add(elementKorpe);
        }
            else
            {
                elementKorpe.KolicinaArtikla++;
            }
            _context.SaveChanges();
        }

        public int IzbaciIzKorpe(Artikal artikal)
        {
            var elementKorpe =
                    _context.KorpaInfo.SingleOrDefault(
                        s => s.A.IdArtikla == artikal.IdArtikla && s.IdKorpe1 == IdKorpe);

            var tempKolicina = 0;

            if (elementKorpe != null)
            {
                if (elementKorpe.KolicinaArtikla > 1)
                {
                    elementKorpe.KolicinaArtikla--;
                    tempKolicina = elementKorpe.KolicinaArtikla;
                }
                else
                {
                    _context.KorpaInfo.Remove(elementKorpe);
                }
            }

            _context.SaveChanges();

            return tempKolicina;
        }

        public List<KorpaInfo> DajNaruceneArtikle()
        {
            return artikliKolicina ??
                   (ArtikliKolicina =
                       _context.KorpaInfo.Where(c => c.IdKorpe1 == idKorpe)
                           .Include(s => s.A)
                           .ToList());
        }

        public void IsprazniKorpu()
        {
            var elementi = _context
                .KorpaInfo
                .Where(cart => cart.IdKorpe1 == idKorpe);

            _context.KorpaInfo.RemoveRange(elementi);

            _context.SaveChanges();
        }

        public decimal DajUkupnuCijenu()
        {
            var total = _context.KorpaInfo.Where(c => c.IdKorpe1 == idKorpe)
                .Select(c => c.A.CijenaArtikla * c.KolicinaArtikla).Sum();
            return (decimal)total;
        }

        //public List<Tuple<Artikal, Recenzija, double>> PodaciOArtiklima { get => podaciOArtiklima; set => podaciOArtiklima = value; }

        [Key]
        public string IdKorpe { get => idKorpe; set => idKorpe = value; }
        public List<KorpaInfo> ArtikliKolicina { get => artikliKolicina; set => artikliKolicina = value; }
        public string SlikaKorpe { get => slikaKorpe; set => slikaKorpe = value; }

        public void DodajArtikl(Artikal artikal, int kolicina)
        {
            ArtikliKolicina.Add(new KorpaInfo(artikal, kolicina));
        }
    }
}
