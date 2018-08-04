using System.Collections.ObjectModel;
using Agenda.ModeloDatos.Dao;
using Agenda.ModeloDatos.Entidades;

namespace Agenda.ModeloDatos.Consultas
{
    // Create the collection of Order objects

    public class ListadoEscalas : ObservableCollection<EntidadEscala>
    {
        public void RecargarElementos()
        {
            Clear();
            var escalas = new DaoEscalaProgresiva().ObtenerTodosLosElementos();
            foreach (var escala in escalas)
            {
                Add(escala as EntidadEscala);
            }
        }
        public void RecargarElementosDeCodigoLineaTiempoAño(int pCodigoLineaTiempoAño)
        {
            Clear();
            var escalas = new DaoEscalaProgresiva().ObtenerTodosLasEscalasDeCodigoLineaTiempoAño(pCodigoLineaTiempoAño);
            foreach (var escala in escalas)
            {
                Add(escala as EntidadEscala);
            }
        }
    }
}

