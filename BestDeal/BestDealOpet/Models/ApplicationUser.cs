using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BestDeal.Models
{
    public class ApplicationUser:IdentityUser
    {
        public ApplicationUser()
        {
        }

        public ApplicationUser(string email, string password)
        {
            Email = email;
            PasswordHash = dajSHA512(password);
        }
        
        public ApplicationUser(string id, string userName, string password, string email)
        {
            Id = id;
            UserName = userName;
            PasswordHash = dajSHA512(password);
            Email = email;
        }

        public override string Id { get => base.Id; set => base.Id = value; }
        [Required]
        public override string UserName { get => base.UserName; set => base.UserName = value; }
        [Required]
        public override string PasswordHash { get => base.PasswordHash; set => base.PasswordHash = dajSHA512(value); }
        [Required]
        public override string Email { get => base.Email; set => Email = value; }

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
