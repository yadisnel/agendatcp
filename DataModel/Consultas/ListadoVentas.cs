using System.Collections.ObjectModel;
using Agenda.ModeloDatos.Dao;
using Agenda.ModeloDatos.Entidades;

namespace Agenda.ModeloDatos.Consultas
{
    // Create the collection of Order objects

    public class ListadoVentas : ObservableCollection<EntidadVentaConImporte>
    {        
        public void RecargarVentasDeLicencia(EntidadLicencia Licencia)
        {
            Clear();
            var ventasExistentes = new DaoVenta().ObtenerTodasLasVentasDeLicencia(Licencia);
            foreach (var vent in ventasExistentes)
            {
                Add(vent);
            }
        }   
        public void RecargarTodasLasVentas()
        {
            Clear();
            var ventasExistentes = new DaoVenta().ObtenerTodosLosElementos();
            foreach (var vent in ventasExistentes)
            {
                Add((EntidadVentaConImporte)vent);
            }
        }
    }  
}

