using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BestDeal.Models
{
    public class Korisnik
    {
        [ScaffoldColumn(false)]
        static int generatorID = 1000;
        int idKorisnika;
        string ime;
        string prezime;
        string korisnickoIme;
        string password;
        bool registrovan;

        public Korisnik()
        {
            idKorisnika = generatorID++;
            Registrovan = true;
        }

        //TODO: Ovo vjerovatno mora naslijediti IdentityUser kad se rijesi problem No authentication
        public Korisnik(string ime, string prezime, string korisnickoIme, string password)
        {
            idKorisnika = generatorID++;
            this.Ime = ime;
            this.Prezime = prezime;
            this.KorisnickoIme = korisnickoIme;
            this.Password = dajSHA512(password);
        }
        //ne smijemo dozvoliti setovanje IDa koji se automatski generira
        public int IdKorisnika { get => idKorisnika;}
        [Required]
        public string Ime { get => ime; set => ime = value; }
        [Required]
        public string Prezime { get => prezime; set => prezime = value; }
        [Required]
        [Key]
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        [Required]
        public string Password { get => password; set => password = dajSHA512(value); }
        [ScaffoldColumn(false)]
        public bool Registrovan { get => registrovan; set => registrovan = value; }

        //za enkripciju moramo osigurati da sifra nikad nije vidljiva niti spasena u plain text, koristimo najbolju opciju: SHA-512 algoritam
        protected string dajSHA512(string password)
        {
            byte[] hashiranPassword;
            var data = Encoding.UTF8.GetBytes(password);
            using (SHA512 shaM = new SHA512Managed())
            {
                hashiranPassword = shaM.ComputeHash(data);
            }
            return Encoding.UTF8.GetString(hashiranPassword, 0, hashiranPassword.Length);
        }
    }
}
