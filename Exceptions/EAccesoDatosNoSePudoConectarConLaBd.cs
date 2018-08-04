using System;

namespace Agenda.ModuloExc.Excepciones
{
    public class EAccesoDatosNoSePudoConectarConLaBd : Exception
    {
        public EAccesoDatosNoSePudoConectarConLaBd(String pMensaje)
            : base(pMensaje)
        {

        }
    }
}
