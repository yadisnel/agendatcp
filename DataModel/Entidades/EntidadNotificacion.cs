namespace Agenda.ModeloDatos.Entidades
{
    public class EntidadNotificacion : EntidadAbs
    {
        private short _codigoNotificacion;
        public short CodigoNotificacion
        {
            get { return _codigoNotificacion; }
            set { _codigoNotificacion = value; OnPropertyChanged("CodigoNotificacion"); }
        }
        //Ayuda,Información,Advertencia,Error
        private string _tipo;
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; OnPropertyChanged("Tipo"); }
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; OnPropertyChanged("Nombre"); }
        }

        private string _descripcion;
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; OnPropertyChanged("Descripcion"); }
        }
        public override string ToString()
        {
            return Nombre;
        }        
    }
}
