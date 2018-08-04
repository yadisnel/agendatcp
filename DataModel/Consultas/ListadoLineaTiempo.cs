using System.Collections.ObjectModel;
using Agenda.ModeloDatos.Dao;
using Agenda.ModeloDatos.Entidades;

namespace Agenda.ModeloDatos.Consultas
{
    public class ListadoLineaTiempo : ObservableCollection<EntidadLineaTiempo>
    {        
        public void RecargarTodosLosTiempos()
        {
            Clear();
            var tiempos = new DaoLineaTiempo().ObtenerTodosLosElementos();
            foreach (EntidadLineaTiempo unTiempo in tiempos)
            {
                Add(unTiempo);
            }
        }
        public void RecargarTodosLosTiemposHastaMesAño(int hastaMes,int hastaAño)
        {
            Clear();
            var tiempos = new DaoLineaTiempo().ObtenerTodosLosElementos();
            foreach (EntidadLineaTiempo unTiempo in tiempos)
            {
                if ((unTiempo.Año < hastaAño) || (unTiempo.Año == hastaAño && unTiempo.Mes <= hastaMes))
                {
                    Add(unTiempo);
                }
                if (unTiempo.Año > hastaAño) break;
            }
        } 
    }  
}

