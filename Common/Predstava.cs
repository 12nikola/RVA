using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Predstava
    {
        private DateTime datum;
        private int id;
        private Biletarnica biletarnica;
        public Predstava() { }
        ~Predstava() { }

        public int ID { get { return id; } set { id = value; } }
        public DateTime Datum { get { return datum; } set { datum = value; } }
        public Biletarnica Biletarnica { get {  return biletarnica; } set { biletarnica = value; } }
    }
}
