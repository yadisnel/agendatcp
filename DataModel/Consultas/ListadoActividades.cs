using System.Collections.ObjectModel;
using Agenda.ModeloDatos.Dao;
using Agenda.ModeloDatos.Entidades;

namespace Agenda.ModeloDatos.Consultas
{
    // Create the collection of Order objects

    public class ListadoActividades : ObservableCollection<EntidadActividad>
    {
        public void RecargarElementos()
        {
            Clear();
            var actividads = new DaoActividad().ObtenerTodosLosElementos();
            foreach (EntidadAbs actividad in actividads)
            {
                Add(actividad as EntidadActividad);
            }
        }
    }
}

