using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Agenda.ModeloDatos.Entidades;
using Agenda.ModeloDatos.Dao;

namespace Agenda.ModeloDatos.Consultas
{
    // Create the collection of Order objects

    public class ListadoConceptosIngresos : ObservableCollection<EntidadConceptoIngreso>
    {
        public void RecargarElementos()
        {
            Clear();
            EntidadConceptoIngreso ci = new EntidadConceptoIngreso();
            ci.Nombre = "Ventas de productos o servicios";
            Add(ci);
        }
    }
}

