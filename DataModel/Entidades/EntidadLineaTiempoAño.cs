namespace Agenda.ModeloDatos.Entidades
{
    public class EntidadLineaTiempoAño : EntidadAbs
    {
        short _año;
        short _codigoLineaTiempoAño;
        public short CodigoLineaTiempoAño
        {
            get { return _codigoLineaTiempoAño; }
            set { _codigoLineaTiempoAño = value; OnPropertyChanged("CodigoLineaTiempoAño"); }
        }
        public short Año
        {
            get { return _año; }
            set { _año = value; OnPropertyChanged("Año"); }
        }
        public override string ToString()
        {           
            return _año.ToString();
        }        
    }
}
