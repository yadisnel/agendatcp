namespace Agenda.ModeloDatos.Entidades
{
    public class EntidadProvincia : EntidadAbs
    {
        private short _codigoProvincia;

        private string _nombre;

        public short CodigoProvincia
        {
            get { return _codigoProvincia; }
            set { _codigoProvincia = value; OnPropertyChanged("CodigoProvincia"); }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; OnPropertyChanged("Nombre"); }
        }

        public override string ToString()
        {
            return Nombre;
        }        
    }
}
