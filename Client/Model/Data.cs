using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class Data
    {
        public static ICommon service { get; set; }
       
        public static Korisnik korisnik {  get; set; }
        public static bool IsLoggedIn() => korisnik == null;

        public static bool IsAdmin() => korisnik.Uloga == 0;
    }
}
