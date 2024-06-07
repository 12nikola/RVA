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
    public class BiletarnicaViewModel
    {
        public static List<Predstava> predstava { get; set; }
        private Predstava sp;
        public Predstava SP
        {
            get { return sp; }
            set
            {
                sp = value;
            }
        }

        public static List<Gledalac> Gledalacs { get; set; }
        private Gledalac sg;
        public Gledalac SG
        {
            get { return sg; }
            set
            {
                sg = value;
                
            }
        }

        public ICommand? CreateBiletarnica { get; set; }
        public ICommand? DeleteBiletarnica { get; set; }
        public ICommand? UndoBiletarnica { get; set; }
        public ICommand? RedoBiletarnica { get; set; }
        public ICommand? Duplicate { get; set; }

        public string Error { get; set; }

        public Visibility Visible { get; set; }


        public BiletarnicaViewModel()
        {

            if (!Model.Data.IsLoggedIn())
                Visible = Visibility.Visible;
            else
            {
                Error = "You need to sign in to see this page!";
                Visible = Visibility.Collapsed;
            }

            GetGledalacs();
            GetPredstava();
        }

        private void DuplicateA()
        {
            Create();
        }

        private void GetGledalacs()
        {
            Gledalacs = new List<Gledalac>();
            foreach (var gledalac in Model.Data.service.GetGledalacs())
            {
                Gledalacs.Add(gledalac);
            }
        }

        private void GetPredstava()
        {
            if (Model.Data.korisnik != null)
            {
                Gledalacs = new List<Gledalac>();
                List<Gledalac> list = new List<Gledalac>();
                if (Model.Data.korisnik.Uloga == 0) { }
                   // list = Model.Data.service.GetAdmin(Model.Data.korisnik as Admin);
                else if (Model.Data.korisnik.Uloga == 1)
                   // list = Model.Data.service.GetGledalacs(Model.Data.korisnik as Gledalac);

                foreach (var predstava in list)
                {
                    //SP.Add(predstava);
                }
            }
        }

        public bool CanUseT() => SP != null;

        public bool CanUseGledalac() => SG != null;

        private void Create()
        {
            Error = null;
            Biletarnica biletarnica = new Biletarnica();

            if (Model.Data.korisnik.Uloga == 0)
            {
                //Error = Model.Data.service.AddAdmin(Model.Data.korisnik.Uloga, biletarnica);
            }
            else
              //  Error = Model.Data.service.AddGledalac(Model.Data.korisnik.Uloga, biletarnica);

            if (Error != null)
                MessageBox.Show(Error);
        }

        private void Delete()
        {
            if (Model.Data.korisnik.Uloga == 0)
             //   Error = Model.Data.service.DeleteAdmin(Model.Data.korisnik as Admin, sg);
            if (Model.Data.korisnik.Uloga == 1)
               // Error = Model.Data.service.DeleteGledalac(Model.Data.korisnik as Gledalac, sg);
            MessageBox.Show(Error);
            //SG.Remove(sg);
        }

        private void Undo()
        {
            Error = Model.Data.service.Undo();
            MessageBox.Show(Error);
        }

        private void Redo()
        {
            Error = Model.Data.service.Redo();
            MessageBox.Show(Error);
        }
    }
}
