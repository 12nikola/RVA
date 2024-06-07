using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Karta
    {
        private int id;
        private DateTime datum;
        private int cena;
        private Biletarnica biletarnica;
        public Karta() { }
        ~Karta() { }

        public int ID { get; set; }
        public DateTime Datum { get { return datum; } set { datum = value; } }
        public Biletarnica Biletarnica { get { return biletarnica; } set { biletarnica = value; } }

        public int Cena { get { return cena; } set {  cena = value; } }
    }
}
