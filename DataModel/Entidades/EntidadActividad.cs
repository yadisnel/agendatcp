namespace Agenda.ModeloDatos.Entidades
{
    
    public class EntidadActividad: EntidadAbs
    {
        private short _CodigoActividad;
        private string _nombre;
        private string _descripcion;
        private bool _esRegimenSimplificado;
        private string _nombreInterno;

        public EntidadActividad()
        {
            _CodigoActividad = -1;
            _nombre = "";
            _descripcion = "";
            _esRegimenSimplificado = false;
            _nombreInterno = "";
        }

        public short CodigoActividad 
        {
            get { return _CodigoActividad; }
            set { _CodigoActividad = value; OnPropertyChanged("CodigoActividad");}
        }       
        public string Nombre 
        {
            get { return _nombre; }
            set { _nombre = value; OnPropertyChanged("Nombre"); }
        }
        public string NombreInterno
        {
            get { return _nombreInterno; }
            set { _nombreInterno = value; OnPropertyChanged("NombreInterno"); }
        }

        public string Descripcion 
        {
            get { return _descripcion; }
            set { _descripcion = value; OnPropertyChanged("Descripcion"); } 
        }
        public bool EsRegimenSimplificado 
        {
            get { return _esRegimenSimplificado; }
            set { _esRegimenSimplificado = value; OnPropertyChanged("EsRegimenSimplificado"); } 
        }
        public override string ToString()
        {
            return Nombre;
        }
    }   
}
