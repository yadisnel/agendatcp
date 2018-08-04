using System;

namespace Agenda.ModuloExc.Excepciones
{
    public class ECargarFicheroConfig : Exception
    {
        public ECargarFicheroConfig(String pMensaje)
            : base(pMensaje)
        {

        }
    }
}
