using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Agenda.ModeloDatos.Entidades;
using Agenda.ModeloDatos.Dao;

namespace Agenda.ModeloDatos.Consultas
{
    // Create the collection of Order objects

    public class ListadoProvincias : ObservableCollection<EntidadProvincia>
    {
        public void RecargarElementos()
        {
            Clear();
            var provinciasExistentes = new DaoProvincia().ObtenerTodosLosElementos();
            foreach (EntidadProvincia prov in provinciasExistentes)
            {
                Add(prov);
            }
        }
        public void RecargarElementosConTodas()
        {
            Clear();
            EntidadProvincia ep = new EntidadProvincia();
            ep.Nombre = "Todas";
            Add(ep);
            var provinciasExistentes = new DaoProvincia().ObtenerTodosLosElementos();
            foreach (EntidadProvincia prov in provinciasExistentes)
            {
                Add(prov);
            }
        }
    }
}

