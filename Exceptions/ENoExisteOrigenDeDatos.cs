using System;

namespace Agenda.ModuloExc.Excepciones
{
    public class ENoExisteOrigenDeDatos : Exception
    {
        public ENoExisteOrigenDeDatos(String pNombre)
            : base(pNombre)
        {

        }
    }
}
