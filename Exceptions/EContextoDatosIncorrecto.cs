using System;

namespace Agenda.ModuloExc.Excepciones
{
    public class EContextoDatosIncorrecto : Exception
    {
        public EContextoDatosIncorrecto(String pNombre)
            : base(pNombre)
        {

        }
    }
}
