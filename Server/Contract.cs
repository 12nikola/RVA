using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Contract : IContract
    {
        public Contract() { }
        public string AddKartaAdmin(Admin admin, Karta karta)
        {
            throw new NotImplementedException();
        }

        public string AddKartaGledalac(Gledalac gledalac, Karta karta)
        {
            throw new NotImplementedException();
        }

        public string ChangeAdmin(Admin admin)
        {
            throw new NotImplementedException();
        }

        public string ChangeGledalac(Gledalac gledalac)
        {
            throw new NotImplementedException();
        }

        public string ChangeKorisnikAdmin(Admin admin)
        {
            throw new NotImplementedException();
        }

        public string ChangeKorisnikGledalac(Gledalac gledalac)
        {
            throw new NotImplementedException();
        }

        public string CreateAdmin(Admin admin)
        {
            throw new NotImplementedException();
        }

        public string CreateGledalac(Gledalac gledalac)
        {
            throw new NotImplementedException();
        }

        public string DeleteAdmin(Admin admin)
        {
            throw new NotImplementedException();
        }

        public string DeleteGledalac(Gledalac gledalac)
        {
            throw new NotImplementedException();
        }

        public string DeleteKartaAdmin(int adminID, Karta karta)
        {
            throw new NotImplementedException();
        }

        public string DeleteKartaGledalac(int gledalacID, Karta karta)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetAllAdmins()
        {
            throw new NotImplementedException();
        }

        public List<Gledalac> GetGledalac()
        {
            throw new NotImplementedException();
        }

        public List<Karta> GetKarteAdmin(Admin admin)
        {
            throw new NotImplementedException();
        }

        public List<Karta> GetKarteGledalac(Gledalac gledalac)
        {
            throw new NotImplementedException();
        }

        public Admin LogInAdmin(LogInKorisnik korisnik)
        {
            throw new NotImplementedException();
        }

        public Gledalac LogInGledalac(LogInKorisnik korisnik)
        {
            throw new NotImplementedException();
        }

        public void LogOut(string username)
        {
            throw new NotImplementedException();
        }

        public string Redo()
        {
            throw new NotImplementedException();
        }

        public string SearchUser(string type, string input)
        {
            throw new NotImplementedException();
        }

        public string Undo()
        {
            throw new NotImplementedException();
        }
    }
}
