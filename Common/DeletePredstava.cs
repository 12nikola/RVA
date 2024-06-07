using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class DeletePredstava : ICommand
    {
        public Predstava predstava;

        public DeletePredstava() { }
        ~DeletePredstava() { }

        public DeletePredstava(Predstava predstava)
        {
            this.predstava = predstava;
        }
        public string Execute(int id, IService service)
        {
            var korisnik = new Admin();
            korisnik.ID = id;
            korisnik.Uloga = 0;
            return service.DeletePredstava(korisnik, predstava);        
        }

        public string Execute1(int id, IService service)
        {
            var korisnik = new Gledalac();
            korisnik.ID = id;
            korisnik.Uloga = 0;
            return service.DeletePredstava(korisnik, predstava);
        }

        public string Unexecute(int id, IService service)
        {
            predstava.ID = 0;
            return service.AddPredstavaAdmin(id, predstava);
        }

        public string Unexecute1(int id, IService service)
        {
            predstava.ID=0;
            return service.AddPredstavaGledalac(id, predstava);
        }
    }
}
