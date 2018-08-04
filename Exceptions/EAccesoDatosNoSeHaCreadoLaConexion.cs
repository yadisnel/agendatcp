using System;

namespace Agenda.ModuloExc.Excepciones
{
    public class EAccesoDatosNoSeHaCreadoLaConexion : Exception
    {
        public EAccesoDatosNoSeHaCreadoLaConexion(String pMensaje)
            : base(pMensaje)
        {

        }
    }
}
