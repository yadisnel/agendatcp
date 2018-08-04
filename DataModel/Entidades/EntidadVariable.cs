namespace Agenda.ModeloDatos.Entidades
{
    public class EntidadVariable : EntidadAbs
    {        
        private string _nombre;
        private object _valor;       
       
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; OnPropertyChanged("Nombre"); }
        }
        public object Valor
        {
            get { return _valor; }
            set { _valor = value; OnPropertyChanged("Valor"); }
        } 
    }
}
