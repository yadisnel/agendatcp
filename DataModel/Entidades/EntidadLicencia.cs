namespace Agenda.ModeloDatos.Entidades
{
    public class EntidadLicencia : EntidadAbs
    {
        private short _codigoLicencia;
        private short _codigoActividad;
        private int _numeroLicencia;
        private short _codigoTcp;  
        private string _nombre;
        public short CodigoLicencia
        {
            get { return _codigoLicencia; }
            set { _codigoLicencia = value; OnPropertyChanged("CodigoLicencia"); }
        }
        public short CodigoActividad
        {
            get { return _codigoActividad; }
            set { _codigoActividad = value; OnPropertyChanged("CodigoActividad"); }
        }
        public int NumeroLicencia
        {
            get { return _numeroLicencia; }
            set { _numeroLicencia = value; OnPropertyChanged("NumeroLicencia"); }
        }
        public short CodigoTcp
        {
            get { return _codigoTcp; }
            set { _codigoTcp = value; OnPropertyChanged("CodigoTcp"); }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; OnPropertyChanged("Nombre"); }
        }
        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
