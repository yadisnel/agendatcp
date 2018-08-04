using System;

namespace Agenda.ModuloExc.Excepciones
{
    public class EAccesoDatosNoSePudoHacerRollBack : Exception
    {
        public EAccesoDatosNoSePudoHacerRollBack(String pMensaje)
            : base(pMensaje)
        {

        }
    }
}
