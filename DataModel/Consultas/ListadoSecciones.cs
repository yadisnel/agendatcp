using Agenda.ModeloDatos.Entidades;
using System.Collections.ObjectModel;

namespace Agenda.ModeloDatos.Consultas
{
    public class ListadoSecciones : ObservableCollection<EntidadSeccion>
    {
        public void RecargarElementos()
        {
            Clear();
            Add(new EntidadSeccion { Nombre = "Datos Personales" });
            Add(new EntidadSeccion { Nombre = "Datos Laborales" });
            Add(new EntidadSeccion { Nombre = "Seguridad" });   
            Add(new EntidadSeccion { Nombre = "Nomencladores" });                
        }
    }
}
