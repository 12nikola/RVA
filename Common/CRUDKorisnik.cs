using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CRUDKorisnik
    {
        public CRUDKorisnik() { }
        ~CRUDKorisnik () { }

        public string CreateAdmin(Admin admin, IService service)
        {
            return service.AddAdmin(admin);
        }

        public string CreateGledalac(Gledalac gledalac, IService service)
        {
            return service.AddGledalac(gledalac);
        }

        public List<Admin> GetAllAdmins(IService service)
        {

            return service.GetAdmins();
        }

        public List<Gledalac> GetGledalacs(IService service)
        {

            return service.GetGledalacs();
        }

        public string DeleteAdmin(Admin admin, IService service)
        {

            return service.DeleteAdmin(admin);
        }

        public string DeleteGledalac(Gledalac gledalac, IService service)
        {

            return service.DeleteGledalac(gledalac);
        }

        public string ChangeAdmin(Admin admin, IService service)
        {

            return service.ChangeAdmin(admin);
        }

        public string ChangeGledalac(Gledalac gledalac, IService service)
        {

            return service.ChangeGledalac(gledalac);
        }

    }
}
