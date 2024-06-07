using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class KorisnickiServis : IService
    {
        public Logger logger;

        public KorisnickiServis() {
            logger = new Logger();
        }
        ~KorisnickiServis () { }
        public string AddAdmin(Admin admin)
        {
            throw new NotImplementedException();
        }

        public string AddBiletarnica(Biletarnica biletarnica)
        {
            throw new NotImplementedException();
        }

        public string AddGledalac(Gledalac gledalac)
        {
            throw new NotImplementedException();
        }

        public string AddPredstavaAdmin(int adminId, Predstava predstava)
        {
            throw new NotImplementedException();
        }

        public string AddPredstavaGledalac(int gledalacId, Predstava predstava)
        {
            throw new NotImplementedException();
        }

        public string ChangeAdmin(Admin admin)
        {
            throw new NotImplementedException();
        }

        public string ChangeBiletarnica(Biletarnica biletarnica)
        {
            throw new NotImplementedException();
        }

        public string ChangeGledalac(Gledalac gledalac)
        {
            throw new NotImplementedException();
        }

        public string DeleteAdmin(Admin admin)
        {
            throw new NotImplementedException();
        }

        public string DeleteBiletarnica(Biletarnica biletarnica)
        {
            throw new NotImplementedException();
        }

        public string DeleteGledalac(Gledalac gledalac)
        {
            throw new NotImplementedException();
        }

        public string DeletePredstava(Korisnik korisnik, Predstava predstava)
        {
            throw new NotImplementedException();
        }

        public Admin FindAdmin(LogInKorisnik korisnik)
        {
            throw new NotImplementedException();
        }

        public Biletarnica FindBiletarnica(Biletarnica biletarnica)
        {
            throw new NotImplementedException();
        }

        public Gledalac FindGledalac(LogInKorisnik korisnik)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetAdmins()
        {
            throw new NotImplementedException();
        }

        public List<Biletarnica> GetBiletarnica()
        {
            throw new NotImplementedException();
        }

        public List<Gledalac> GetGledalacs()
        {
            throw new NotImplementedException();
        }

        public List<Korisnik> GetKorisniks()
        {
            throw new NotImplementedException();
        }

        public List<Predstava> GetPredstavas(Korisnik korisnik)
        {
            throw new NotImplementedException();
        }

        public void LogOut(string username)
        {
            throw new NotImplementedException();
        }
    }
}
