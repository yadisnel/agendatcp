namespace Agenda.ModeloDatos.Entidades
{
    public class EntidadTcp : EntidadAbs
    {
        private short _codigoTcp;
        private string _nombreApellidos;
        private string _nit;           

        public EntidadTcp()
        { 
          _codigoTcp = -1;
          _nombreApellidos = "";
          _nit = "";              
        }
        public short CodigoTcp 
        {
            get {return _codigoTcp;}
            set { _codigoTcp = value; OnPropertyChanged("CodigoTcp"); } 
        }
        public string NombreApellidos
        {
            get { return _nombreApellidos; }
            set { _nombreApellidos = value; OnPropertyChanged("NombreApellidos"); }
        }
        public string Nit
        {
            get { return _nit; }
            set { _nit = value; OnPropertyChanged("Nit"); }
        }       
        public override string ToString()
        {
            return this.NombreApellidos;
        }
    }
}
