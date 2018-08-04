using System.Collections.ObjectModel;
using Agenda.ModeloDatos.Entidades;
using Agenda.ModeloDatos.Dao;

namespace Agenda.ModeloDatos.Consultas
{
    // Create the collection of Order objects

    public class ListadoConceptosGastos : ObservableCollection<EntidadConceptoGasto>
    {
        public void RecargarElementos()
        {
            Clear();
            EntidadConceptoGasto cg = new EntidadConceptoGasto();
            cg.Nombre = "";
            Add(cg);
        }
    }
}

