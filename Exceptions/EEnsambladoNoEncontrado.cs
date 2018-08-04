using System;

namespace Agenda.ModuloExc.Excepciones
{
    public class EEnsambladoNoEncontrado : Exception
    {
        public EEnsambladoNoEncontrado(String pNombre)
            : base("El ensamblado no ha sido encontrado." + pNombre)
        {

        }
    }
}
