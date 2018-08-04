using System;

namespace Agenda.ModeloDatos.Datos
{
    public class ParametroConexion
    {
        public String NombreParametro;
        public String ValorParametro;
        public ParametroConexion(String pNombreParametro, String pValorParametro)
        {
            NombreParametro = pNombreParametro;
            ValorParametro = pValorParametro;
        }
        public String GetNombreParametro()
        {
            return NombreParametro;
        }
        public String GetValorParametro()
        {
            return ValorParametro;
        }
    }
}
