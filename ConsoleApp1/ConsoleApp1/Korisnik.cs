using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Korisnik
    {
        static int generatorID = 1000;
        int idKorisnika;
        string ime;
        string prezime;
        string korisnickoIme;
        string password;

        public Korisnik(string ime, string prezime, string korisnickoIme, string password)
        {
            idKorisnika = generatorID++;
            this.Ime = ime;
            this.Prezime = prezime;
            this.KorisnickoIme = korisnickoIme;
            this.Password = dajSHA512(password);
        }
        //ne smijemo dozvoliti setovanje IDa koji se automatski generira
        public int IdKorisnika { get => idKorisnika; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Password { get => password; set => password = value; }

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
