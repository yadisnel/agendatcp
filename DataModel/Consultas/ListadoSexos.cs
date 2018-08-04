using Agenda.ModeloDatos.Entidades;
using System.Collections.ObjectModel;

namespace Agenda.ModeloDatos.Consultas
{
    // Create the collection of Order objects

    public class ListadoSexos : ObservableCollection<EntidadSexo>
    {
        public void RecargarElementos()
        {
            Clear();
            var masculino = new EntidadSexo {Nombre = "M"};
            var femenino = new EntidadSexo {Nombre = "F"};
            Add(masculino);
            Add(femenino);
        }
    }
}

