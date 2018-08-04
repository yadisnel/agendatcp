using System;
using System.ComponentModel;

namespace Agenda.ModeloDatos.Entidades
{
    public abstract class EntidadAbs: INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(String info)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(info));
        }
    }
}
