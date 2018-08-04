namespace Agenda.ModeloDatos.Entidades
{
    public class EntidadConceptoIngreso: EntidadAbs
    {       
        private string _nombre;
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
