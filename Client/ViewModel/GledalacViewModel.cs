using Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Client.ViewModel
{
    public class GledalacViewModel
    {
        public static List<Gledalac> Gledalac { get; set; }
        private Gledalac gl;
        public Gledalac Gl
        {
            get { return gl; }
            set
            {
                gl = value;
            }
        }

        private string fullnameGL;

        public string FullnameGL
        {
            get { return fullnameGL; }
            set
            {
                fullnameGL = value;
            }
        }

        private DateTime lastChangeGL;

        public DateTime LastChangeGL
        {
            get { return lastChangeGL; }
            set
            {
                lastChangeGL = value;
            }
        }

        public Visibility Visible { get; set; }
        public string Error { get; set; }

        public ICommand? AddGledalac { get; set; }
        public ICommand? ChangeGledalac { get; set; }
        public ICommand? AppyChangeGledalac { get; set; }
        public ICommand? DeleteGledalac { get; set; }
        public ICommand? RefreshGledalac { get; set; }

        public GledalacViewModel()
        {
            if (Model.Data.IsLoggedIn())
            {
                Visible = Visibility.Collapsed;
                Error = "You are not logged in, so you don't have permision to see content of this page!";
            }
            else
            {
                if (!Model.Data.IsAdmin())
                {
                    Visible = Visibility.Collapsed;
                    Error = "You don't have a role of an admin!";
                }
                else
                {
                    Visible = Visibility.Visible;
                    Error = "";
                }
            }
            try
            {
                GetTrenere();
            }
            catch
            {

            }
        }

        private void GetTrenere()
        {
            Gledalac = new List<Gledalac>();

            foreach (var gledalac in Model.Data.service.GetGledalacs())
            {
                Gledalac.Add(gledalac);
            }
        }

        public bool CanUseT() => Gl != null;

        private void CreateT()
        {
            var gledalac = new Gledalac
            {
                Uloga = 1,
                Ime = FullnameGL,
            };
            if (gledalac.Ime == null || gledalac.Ime == "")
                Error = "Ime field can't be empty!";
            else
            {
                Error = Model.Data.service.AddGledalac(gledalac);
                Gledalac.Add(gledalac);
            }
            MessageBox.Show(Error);
        }

        private void ChangeT()
        {
            //Error = InternalData.Data.service.DeleteAdmin(SelektovaniTrener);
            //MessageBox.Show(Error);
            FullnameGL = Gl.Ime;
        }

        private void ApplyChange()
        {

        }

        private void DeleteT()
        {
            Error = Model.Data.service.DeleteGledalac(Gl);
            MessageBox.Show(Error);
            Gledalac.Remove(gl);
        }

        private void RefreshT()
        {
            GetTrenere();
        }
    }
}
