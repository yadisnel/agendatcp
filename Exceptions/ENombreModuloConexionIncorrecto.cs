using System;

namespace Agenda.ModuloExc.Excepciones
{
    public class ENombreModuloConexionIncorrecto : Exception
    {
        public ENombreModuloConexionIncorrecto(String pNombre)
            : base(pNombre)
        {

        }
    }
}
