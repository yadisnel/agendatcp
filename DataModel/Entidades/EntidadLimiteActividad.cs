namespace Agenda.ModeloDatos.Entidades
{
    
    public class EntidadLimiteActividad: EntidadAbs
    {
        private int _codigoLimiteActividad;
        private short _CodigoActividad;
        private short _codigoLineaTiempo;
        private short _codigoMunicipio;
        private double _cuotaMensualMinima;
        private double _gastoMaximo;      
       
        public EntidadLimiteActividad()
        {
        }
        public int CodigoLimiteActividad
        {
            get { return _codigoLimiteActividad; }
            set { _codigoLimiteActividad = value; OnPropertyChanged("CodigoLimiteactividad"); }
        } 
        public short CodigoActividad 
        {
            get { return _CodigoActividad; }
            set { _CodigoActividad = value; OnPropertyChanged("CodigoActividad");}
        }
        public short CodigoMunicipio
        {
            get { return _codigoMunicipio; }
            set { _codigoMunicipio = value; OnPropertyChanged("CodigoMunicipio"); }
        }
        public short CodigoLineaTiempo
        {
            get { return _codigoLineaTiempo; }
            set { _codigoLineaTiempo = value; OnPropertyChanged("CodigoLineaTiempo"); }
        }
        public double CuotaMensualMinima
        {
            get { return _cuotaMensualMinima; }
            set { _cuotaMensualMinima = value; OnPropertyChanged("CuotaMensualMinima"); }
        }
        public double GastoMaximo
        {
            get { return _gastoMaximo; }
            set { _gastoMaximo = value; OnPropertyChanged("GastoMaximo"); }
        }       
    }   
}
