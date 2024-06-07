using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CRUDPredstava
    {
        public UndoRedo ur;
        public CRUDPredstava()
        {
            ur= new UndoRedo();
        }

        ~CRUDPredstava() { }

        public string AddPredstavaAdmin(int adminId, IService service, Predstava predstava)
        {
            string message = "";
            return message;
        }

        public List<Gledalac> GetGledalacs(IService service)
        {
            return service.GetGledalacs();
        }

        public string DeletePredstava(Korisnik korisnik, Predstava predstava, IService service)
        {
            string message = "";
            return message;
        }

        public List<Predstava> GetPredstave(Admin admin, IService service)
        {
            return service.GetPredstavas(admin);
        }

        public List<Predstava> GetPredstave(Gledalac gledalac, IService service)
        {
            return service.GetPredstavas(gledalac);
        }

        public string AddPredstavaGledalac(int gledalacId, IService service, Predstava predstava)
        {
            string message = "";
            return message;
        }
        public string Redo()
        {
            return ur.Redo();
        }

        public string Undo()
        {
           return ur.Undo();
        }
    }
}
