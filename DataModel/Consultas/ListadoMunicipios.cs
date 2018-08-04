using System.Collections.ObjectModel;
using Agenda.ModeloDatos.Entidades;
using Agenda.ModeloDatos.Dao;

namespace Agenda.ModeloDatos.Consultas
{
    public class ListadoMunicipios : ObservableCollection<EntidadMunicipio>
    {
        public void RecargarElementos(int pCodigoProvincia)
        {
            Clear();
            var municipios = new DaoMunicipio().ObtenerTodosLosMunicipios(pCodigoProvincia);
            foreach (EntidadMunicipio munic in municipios)
            {
                Add(munic);
            }
        }
        public void RecargarElementosConTodos(int pCodigoProvincia)
        {
            Clear();
            EntidadMunicipio em = new EntidadMunicipio();
            em.Nombre = "Todos";
            Add(em);
            var municipios = new DaoMunicipio().ObtenerTodosLosMunicipios(pCodigoProvincia);
            foreach (EntidadMunicipio munic in municipios)
            {
                Add(munic);
            }
        }
        public void RecargarElementosUnicamenteConTodos()
        {
            Clear();
            EntidadMunicipio em = new EntidadMunicipio();
            em.Nombre = "Todos";
            Add(em);
        }
    }
}

