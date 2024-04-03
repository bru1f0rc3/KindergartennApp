using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace KinderrApp
{
    public class ViewModelKinder : INotifyPropertyChanged
    {
        private Kindergartenn _kinder;

        public event PropertyChangedEventHandler PropertyChanged;

        public Kindergartenn Kinder
        {
            get { return _kinder; }
            set
            {
                if (_kinder != value)
                {
                    _kinder = value;
                    OnPropertyChanged();
                }
            }
        }

        public void UpdateKinder(Kindergartenn updatedKinder)
        {
            Kinder = updatedKinder;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ViewModelKinder()
        {
            Kinder = new Kindergartenn();
        }
    }
}
