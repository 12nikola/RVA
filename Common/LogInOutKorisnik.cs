using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class LogInOutKorisnik
    {
        public Admin LogInAdmin(LogInKorisnik korisnik, IService service)
        {
            return service.FindAdmin(korisnik);
        }

        public Gledalac LogInGledalac(LogInKorisnik korisnik, IService service)
        {
            return service.FindGledalac(korisnik);
        }

        public void Logout(string username, IService service)
        {
            service.LogOut(username);
        }
    }
}
