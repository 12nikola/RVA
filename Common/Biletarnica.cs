using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Biletarnica
    {
        
        private int id;
        private string placanje;
        private string ime;
        public Biletarnica()
        {

        }

        ~Biletarnica() { }

        public int ID { get; set; }

        public string Placanje { get; set; }

        public string Ime { get; set; }
    }
}
