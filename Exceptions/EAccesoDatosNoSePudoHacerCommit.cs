using System;

namespace Agenda.ModuloExc.Excepciones
{
    public class EAccesoDatosNoSePudoHacerCommit : Exception
    {
        public EAccesoDatosNoSePudoHacerCommit(String pMensaje)
            : base(pMensaje)
        {

        }
    }
}
