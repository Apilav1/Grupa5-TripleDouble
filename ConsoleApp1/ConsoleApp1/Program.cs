using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class Program
    {
        public static string dajSHA512(string password)
        {
            byte[] hashiranPassword;
            var data = Encoding.UTF8.GetBytes(password);
            using (SHA512 shaM = new SHA512Managed())
            {
                hashiranPassword = shaM.ComputeHash(data);
            }
            return Encoding.UTF8.GetString(hashiranPassword, 0, hashiranPassword.Length);
        }
        public static void Main(string[] args)
        {
            Korisnik k = new Korisnik("Testo", "Testic", "ttestic1", "nekaSifra");
            bool tacno = false;
            Console.WriteLine("Sifra je: {0}", k.Password);
            while (!tacno)
            {
                Console.Write("Unesi sifru: ");
                string test = Console.ReadLine();
                if (dajSHA512(test) == k.Password)
                {
                    tacno = true;
                    Console.WriteLine("Bravo, pogodili ste!");
                    Console.ReadLine();
                }
            }
            //  CreateWebHostBuilder(args).Build().Run();
        }

    }
}
