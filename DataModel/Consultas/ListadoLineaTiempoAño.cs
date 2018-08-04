using System.Collections.ObjectModel;
using Agenda.ModeloDatos.Dao;
using Agenda.ModeloDatos.Entidades;

namespace Agenda.ModeloDatos.Consultas
{
    public class ListadoLineaTiempoAño : ObservableCollection<EntidadLineaTiempoAño>
    {        
        public void RecargarTodosLosAños()
        {
            Clear();
            var años = new DaoLineaTiempoAño().ObtenerTodosLosElementos();
            foreach (var unAño in años)
            {
                Add(unAño as EntidadLineaTiempoAño);
            }
        }        
    }  
}

