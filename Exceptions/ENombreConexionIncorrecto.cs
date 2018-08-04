using System;

namespace Agenda.ModuloExc.Excepciones
{
    public class ENombreConexionIncorrecto : Exception
    {
        public ENombreConexionIncorrecto(String pNombre)
            : base(pNombre)
        {

        }
    }
}
