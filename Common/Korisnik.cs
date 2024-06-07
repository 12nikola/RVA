using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public abstract class Korisnik
    {
        private string ime;
        private string prezime;
        private int id;
        private int uloga;
        private string password;
        private string username;
        public Korisnik() { }
        ~Korisnik() { }

        public abstract string Ime
        {
            get;
            set;
        }

        public abstract string Prezime
        {
            get;
            set;
        }

        [Key]
        public abstract int ID
        {
            get;
            set;
        }

        public abstract int Uloga
        {
            get; set;
        }

        public abstract string Password
        {
            get;
            set;
        }

        public abstract string Username { get; set; }
    }
}
