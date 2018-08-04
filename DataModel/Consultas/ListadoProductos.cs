using System.Collections.ObjectModel;
using Agenda.ModeloDatos.Dao;
using Agenda.ModeloDatos.Entidades;

namespace Agenda.ModeloDatos.Consultas
{
    // Create the collection of Order objects

    public class ListadoProductos : ObservableCollection<EntidadProducto>
    {
        public void RecargarTodosLosProductos()
        {
            Clear();
            var productosExistentes = new DaoProducto().ObtenerTodosLosProductos();
            foreach (EntidadProducto prod in productosExistentes)
            {
                Add(prod);
            }
        }
    }  
}

