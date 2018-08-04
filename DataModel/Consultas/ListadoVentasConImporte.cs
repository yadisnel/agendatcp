using System.Collections.ObjectModel;
using Agenda.ModeloDatos.Dao;
using Agenda.ModeloDatos.Entidades;
using System;

namespace Agenda.ModeloDatos.Consultas
{
    // Create the collection of Order objects

    public class ListadoVentasConImporte : ObservableCollection<EntidadVentaConImporte>
    {       
        public void RecargarVentasDeLicencia(EntidadLicencia Licencia)
        {
            Clear();
            var ventasExistentes = new DaoVenta().ObtenerTodasLasVentasConImporteDeLicencia(Licencia);
            foreach (var vent in ventasExistentes)
            {
                Add(vent);
            }
        }   
        public void RecargarTodasLasVentas()
        {
            Clear();
            var ventasExistentes = new DaoVenta().ObtenerTodasLasVentasConImporte();
            foreach (var vent in ventasExistentes)
            {
                Add(vent);
            }
        }
        public void RecargarVentas1Dia(EntidadLicencia Licencia, DateTime fechaContable)
        {
            Clear();
            var ventasExistentes = new DaoVenta().ObtenerTodasLasVentasConImporteDeLicencia1dia(Licencia, fechaContable);
            foreach (var vent in ventasExistentes)
            {
                Add(vent);
            }
        }
        public void RecargarVentasUltimos7dias(EntidadLicencia Licencia,DateTime fechaContable)
        {
            Clear();
            var ventasExistentes = new DaoVenta().ObtenerTodasLasVentasConImporteDeLicenciaUltimosXdias(Licencia, fechaContable,-7);
            foreach (var vent in ventasExistentes)
            {
                Add(vent);
            }
        }
        public void RecargarVentasUltimos30dias(EntidadLicencia Licencia, DateTime fechaContable)
        {
            Clear();
            var ventasExistentes = new DaoVenta().ObtenerTodasLasVentasConImporteDeLicenciaUltimosXdias(Licencia, fechaContable, -30);
            foreach (var vent in ventasExistentes)
            {
                Add(vent);
            }
        }
        public void RecargarVentasPeriodo(EntidadLicencia Licencia, DateTime fechaContableDesde, DateTime fechaContableHasta)
        {
            Clear();
            var ventasExistentes = new DaoVenta().ObtenerTodasLasVentasConImporteDeLicenciaPeriodo(Licencia, fechaContableDesde, fechaContableHasta);
            foreach (var vent in ventasExistentes)
            {
                Add(vent);
            }
        }
    }  
}

