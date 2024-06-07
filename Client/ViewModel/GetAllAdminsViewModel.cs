using Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Client.ViewModel
{
    public class GetAllAdminsViewModel
    {
        public static List<Admin>? admin { get; set; }
        private Admin admini;
        public Admin Admini
        {
            get { return admini; }
            set { admini = value; }
        }

        public static List<Gledalac>? gledalac { get; set; }
        private Gledalac gledaoci;
        public Gledalac Gledaoci
        {
            get { return gledaoci; }
            set { gledaoci = value; }
        }
        public string? Error { get; set; }
        public Visibility visible { get; set; }
        public string? username { get { return username; } set { username = value; } }

        public GetAllAdminsViewModel()
        {
            if(Model.Data.IsLoggedIn())
            {
                visible = Visibility.Collapsed;
                Error = "You are not logged in";
            }
            else
            {
                if(!Model.Data.IsAdmin())
                {
                    visible = Visibility.Collapsed;
                    Error = "You don't have a role of an admin";
                }
                else
                {
                    visible=Visibility.Visible;
                    Error = "";
                }
            }
            try
            {
                
            }
            catch
            {

            }
        }

        public void GetAdmins()
        {
            Admini=new Admin();
            foreach(var admin in Model.Data.service.GetAdmins())
            {
                Admini.Equals(admin);
            }
        }

        public void GetGledaoci()
        {
            Gledaoci = new Gledalac();
            foreach (var gledalac in Model.Data.service.GetAdmins())
            {
                Gledaoci.Equals(gledalac);
            }
        }
    }
}
