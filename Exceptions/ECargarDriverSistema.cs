using System;

namespace Agenda.ModuloExc.Excepciones
{
    public class ECargarDriverSistema : Exception
    {
        public ECargarDriverSistema(String pMensaje)
            : base(pMensaje)
        {

        }
    }
}
