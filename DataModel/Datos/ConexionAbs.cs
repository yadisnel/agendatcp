using System.Data;
using Agenda.ModeloDatos.Seguridad;
using Agenda.ModeloDatos.Configuracion;
using System;
using System.Collections;
using System.Data.Common;

namespace  Agenda.ModeloDatos.Datos
{
    public abstract class ConexionAbs
    {
        protected DbConnection Conexion = null;
        protected ArrayList ParametrosConexion = new ArrayList();
        public ConexionAbs(ArrayList pParametrosConexion)
        {
            ParametrosConexion = pParametrosConexion;
            ConstruirCadenaConexion();
            if (CadCon.Contains("[DIREJEC]"))
            {
               CadCon = CadCon.Replace("[DIREJEC]", ConfiguracionSistema.GetConfig().GetDireccionEjecutable());
            }
        }
        protected String CadCon;
        public abstract void AbrirConexion();
        protected abstract void ConstruirCadenaConexion();
        public abstract void CerrarConexion();   
        public abstract DbCommand CrearComando();
        public abstract DbParameter CrearParametro(String nombre, DbType tipo);
        public abstract DbTransaction ObtenerTransaccion();
        
    }
}
