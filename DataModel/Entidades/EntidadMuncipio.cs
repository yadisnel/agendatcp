namespace Agenda.ModeloDatos.Entidades
{
    public class EntidadMunicipio: EntidadAbs
    {
        private short _codigoMunicipio;
        private short _codigoProvincia;
        private string _nombre;

        public short CodigoMunicipio
        {
            get { return _codigoMunicipio; }
            set { _codigoMunicipio = value; OnPropertyChanged("CodigoMunicipio"); }
        }

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
