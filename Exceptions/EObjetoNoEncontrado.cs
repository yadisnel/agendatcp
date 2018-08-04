using System;

namespace Agenda.ModuloExc.Excepciones
{
    public class EObjetoNoEncontrado : Exception
    {
        public EObjetoNoEncontrado(String pNombre)
            : base("El objeto no pudo ser encontrado. Nombre del objeto: " + pNombre)
        {

        }
    }
}
