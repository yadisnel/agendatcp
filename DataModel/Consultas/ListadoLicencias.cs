using System.Collections.ObjectModel;
using Agenda.ModeloDatos.Dao;
using Agenda.ModeloDatos.Entidades;
using System.Collections.Generic;

namespace Agenda.ModeloDatos.Consultas
{
    // Create the collection of Order objects

    public class ListadoLicencias : ObservableCollection<EntidadLicencia>
    {
        public void RecargarElementos(EntidadTcp tcp)
        {
            Clear();
            var elementos = new DaoLicencia().ObtenerLicenciasDeTcp(tcp);
            foreach (EntidadLicencia ent in elementos)
            {
                this.Add(ent);
            }
        }
    }
}

