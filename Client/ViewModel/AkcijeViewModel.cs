using Client.Model;
using Client.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Action = Client.Model.Action;

namespace Client.ViewModel
{
    public class AkcijeViewModel
    {
        public static List<Action>? akcije { get; set; }
        public AkcijeViewModel()
        {
            akcije = new List<Action>();
            if (!Model.Data.IsLoggedIn())
            {
                Load();
            }
        }

        private void Load()
        {
            string filename = "../../../log.txt";
            while (IsFileReady(filename))
            {
                Read(filename);
                break;
            }
        }

        private static bool IsFileReady(string filename)
        {
            try
            {
                using (FileStream inputStream = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.None))
                    return inputStream.Length > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void Read(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {

            }
        }
    }
}
