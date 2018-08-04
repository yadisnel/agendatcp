using Agenda.ModeloDatos.Dao;
using Agenda.ModeloDatos.Entidades;
using Agenda.ModeloDatos.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda.ModeloDatos.Dao
{
    public interface InterfazAcceso
    {
        bool ExisteElemento(int id);
        EntidadAbs ObtenerElemento(int id);
        void ActualizarElemento(int id, EntidadAbs objeto);
        void AdicionarNuevoElemento(EntidadAbs objeto);
        void EliminarElemento(int id);
        void EliminarTodosLosElementos();
        LinkedList<EntidadAbs> ObtenerTodosLosElementos(); 
    }
}
