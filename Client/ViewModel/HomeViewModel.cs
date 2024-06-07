using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.ViewModel
{
    public class HomeViewModel
    {
        public string Username { get; set; }
        public HomeViewModel() { 
            if(Model.Data.korisnik==null)
            {
                Username = "Neuspesno logovanje!";
            }
            else
            {
                Username=Model.Data.korisnik.Username;
            }
        }
    }
}
