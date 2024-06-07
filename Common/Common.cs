using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Common : ICommon
    {
        public string AddAdmin(Admin admin)
        {
            return "";
        }

        public string AddBiletarnica(Biletarnica biletarnica)
        {
            return "";
        }

        public string AddGledalac(Gledalac gledalac)
        {
            return "";
        }

        public string ChangeAdmin(Admin admin)
        {
            return "";
        }

        public string ChangeBiletarnica(Biletarnica biletarnica)
        {
            return "";
        }

        public string ChangeGledalac(Gledalac gledalac)
        {
            return "";
        }

        public string DeleteAdmin(Admin admin)
        {
            return "";
        }

        public string DeleteBiletarnica(Biletarnica biletarnica)
        {
            return "";
        }

        public string DeleteGledalac(Gledalac gledalac)
        {
            return "";
        }

        public Admin FindAdmin(LogInKorisnik korisnik)
        {
            return null;
        }

        public Biletarnica FindBiletarnica(Biletarnica biletarnica)
        {
            return null;
        }

        public Gledalac FindGledalac(LogInKorisnik korisnik)
        {
            return null;
        }

        public List<Admin> GetAdmins()
        {
            return null;
        }

        public List<Biletarnica> GetBiletarnica()
        {
            return null;
        }

        public List<Gledalac> GetGledalacs()
        {
            return null;
        }

        public List<Korisnik> GetKorisniks()
        {
            return null;
        }

        public Admin LogInAdmin(LogInKorisnik korisnik)
        {
            return null;
        }

        public Gledalac LogInGledalac(LogInKorisnik korisnik)
        {
            return null;
        }

        public void LogOut(string username)
        {
            throw new NotImplementedException();
        }

        public string Redo()
        {
            return "";
        }

        public string searhKorisnik(string type, string input)
        {
            return "";
        }

        public string Undo()
        {
            return "";
        }
    }
}
