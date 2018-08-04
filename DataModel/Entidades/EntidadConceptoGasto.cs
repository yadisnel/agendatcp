namespace Agenda.ModeloDatos.Entidades
{
    public class EntidadConceptoGasto: EntidadAbs
    {        
        private string _nombre;
        private bool _esDeducible;             
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; OnPropertyChanged("Nombre"); }
        }
        public bool EsDeducible
        {
            get { return _esDeducible; }
            set { _esDeducible = value; OnPropertyChanged("EsDeducible"); }
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
