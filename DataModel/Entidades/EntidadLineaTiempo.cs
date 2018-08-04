namespace Agenda.ModeloDatos.Entidades
{
    public class EntidadLineaTiempo : EntidadAbs
    {
        short _codigoLineaTiempo;
        short _codigoLineaTiempoAño;
        short _mes;
        short _año;

        private string[] Meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        public short CodigoLineaTiempo
        {
            get { return _codigoLineaTiempo; }
            set { _codigoLineaTiempo = value; OnPropertyChanged("CodigoLineaTiempo"); }
        }
        public short CodigoLineaTiempoAño
        {
            get { return _codigoLineaTiempoAño; }
            set { _codigoLineaTiempoAño = value; OnPropertyChanged("CodigoLineaTiempoAño"); }
        }
        public short Mes
        {
            get { return _mes; }
            set { _mes = value; OnPropertyChanged("Mes"); }
        }
        public short Año
        {
            get { return _año; }
            set { _año = value; OnPropertyChanged("Año"); }
        }
        public override string ToString()
        {
            return Meses[_mes-1] + "-"+_año.ToString();
        }        
    }
}
