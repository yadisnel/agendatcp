namespace Agenda.ModeloDatos.Entidades
{
    public class EntidadResumen : EntidadAbs
    {
        
        private static EntidadResumen _objetoEntidad;
        private string _textoResumenUso;
        private EntidadResumen()
        { 
        }
        public static EntidadResumen GetEntidad()
        {
            return _objetoEntidad ?? (_objetoEntidad = new EntidadResumen());
        }

        public string TextoResumenUso
        {
            get { return _textoResumenUso; }
            set { _textoResumenUso = value; OnPropertyChanged("TextoResumenUso"); }
        }
    }
}
