using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class LogInKorisnik
    {
        private string username;
        private string password;

        public LogInKorisnik(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        LogInKorisnik() { }

        ~LogInKorisnik() { }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
