using System;

namespace Agenda.ModuloExc.Excepciones
{
    public class EErrorEnAccesoDatos : Exception
    {
        public EErrorEnAccesoDatos(String pMensaje)
            : base(pMensaje)
        {

        }
    }
}
