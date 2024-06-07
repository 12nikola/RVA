using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Client.ViewModel
{
    public class CRUDUserViewModel 
    {

        public string Error { get; set; }

        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; } 
        public string? Role { get; set; }

        public Visibility Visibility { get; set; }

        public CRUDUserViewModel()
        {
            if (Model.Data.IsLoggedIn())
            {
                Visibility = Visibility.Collapsed;
                Error = "You are not logged in, so you don't have permision to see content of this page!";
            }
            else
            {
                if (!Model.Data.IsAdmin())
                {
                    Visibility = Visibility.Collapsed;
                    Error = "You don't have a role of an admin!";
                }
                else
                {
                    Visibility = Visibility.Visible;
                    Error = "";
                }
            }
        }

        public void AddAdmin()
        {
            Admin admin = new Admin()
            {
                Username = Username,
                Password = Password,
                Ime = Ime,
                Prezime=Prezime,
                Uloga = 0,
            };
            Error = Model.Data.service.AddAdmin(admin);
        }

        public void AddVezbac()
        {
            Gledalac gledalac = new Gledalac()
            {
                Username = Username,
                Password = Password,
                Ime = Ime,
                Prezime=Prezime,
                Uloga = 1,
            };
            Error = Model.Data.service.AddGledalac(gledalac);
        }
    }
}
