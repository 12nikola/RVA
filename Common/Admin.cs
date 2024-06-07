using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Admin:Korisnik
    {
        public Admin() { }
        ~Admin() { }

        public override string Ime { get; set; }
        public override string Prezime { get; set; }

        public override string Username { get; set; }

        public override string Password { get; set; }

        public override int ID { get; set; }
        public override int Uloga { get; set; }
    }
}
