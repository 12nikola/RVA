using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Baza : INotifyPropertyChanged
    {
        private bool isVisible=false;

        public bool IsVisible { get => isVisible; set => isVisible = value; }

        protected virtual void SetProperty<T>(ref T member, T val)
        {
            if (object.Equals(member, val)) return;

            member = val;
            
        }
        protected virtual void OnPropertyChanged(string propertyName) {
            
        }
        public event PropertyChangedEventHandler? PropertyChanged=delegate { };
    }
}
