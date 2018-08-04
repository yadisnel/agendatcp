using System;

namespace Agenda.ModuloExc.Excepciones
{
    public class EAccesoDatosNoSeHaEncontradoLaVariable : Exception
    {
        public EAccesoDatosNoSeHaEncontradoLaVariable(String pMensaje)
            : base(pMensaje)
        {

        }
    }
}
