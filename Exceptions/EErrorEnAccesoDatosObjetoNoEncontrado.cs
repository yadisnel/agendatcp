using System;

namespace Agenda.ModuloExc.Excepciones
{
    public class EErrorEnAccesoDatosObjetoNoEncontrado : Exception
    {
        public EErrorEnAccesoDatosObjetoNoEncontrado(String pMensaje)
            : base(pMensaje)
        {

        }
    }
}
