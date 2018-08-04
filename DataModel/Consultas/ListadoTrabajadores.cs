using System.Collections.ObjectModel;
using Agenda.ModeloDatos.Dao;
using Agenda.ModeloDatos.Entidades;

namespace Agenda.ModeloDatos.Consultas
{
    public class ListadoTrabajadores : ObservableCollection<EntidadTcp>
    {
        public void RecargarElementos()
        {
            Clear();
            var trabajadores = new DaoTcp().ObtenerTodosLosElementos();
            foreach (EntidadTcp miTcp in trabajadores)
            {
                Add(miTcp);
            }
        }
    }    
}

