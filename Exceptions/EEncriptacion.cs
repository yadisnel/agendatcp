using System;

namespace Agenda.ModuloExc.Excepciones
{
    public class EEncriptacion : Exception
    {
        public EEncriptacion(String pMensaje)
            : base(pMensaje)
        {

        }
    }
}
