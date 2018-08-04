using System.Collections;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using Agenda.ModeloDatos.Dao;
using Agenda.ModuloExc.Excepciones;
using System.Windows;

namespace Agenda.ModeloDatos.Datos
{
    class ConexionSQLlite : ConexionAbs
    {
        private readonly SQLiteConnection _objCon;
        private bool _estaAbierta;
        public ConexionSQLlite(ArrayList pParametros)
            : base(pParametros)
        {
            _objCon = new SQLiteConnection(CadCon);
            Conexion = _objCon;   
        }
        public override void CerrarConexion()
        {
            if (!_estaAbierta) return;
            _objCon.Close();
            _estaAbierta = false;
        }
        public override void AbrirConexion()
        {            
            try
            {                
                if (_estaAbierta)
                {
                    CerrarConexion();
                }
                _objCon.Open();
                _estaAbierta = true;
            }
            catch (SQLiteException e)
            {   
                throw new EAccesoDatosNoSePudoConectarConLaBd(e.Message);
            }
        }        
        protected override void ConstruirCadenaConexion()
        {
            CadCon  = "";
            for (var i = 0; i < ParametrosConexion.Count; i++)
            {
                var param = (ParametroConexion)ParametrosConexion[i];
                CadCon += param.GetNombreParametro();
                CadCon += "=";
                CadCon += param.GetValorParametro();
                if (i < ParametrosConexion.Count -1) CadCon += ";";
            }
                  
        }
        public override DbCommand CrearComando()
        {           
            return _objCon.CreateCommand();
        }
        public override DbParameter CrearParametro(string nombre, DbType tipo)
        {
            var param = new SQLiteParameter(nombre, tipo);
            return param;
        }
        public override DbTransaction ObtenerTransaccion()
        {
            return _objCon.BeginTransaction();
        }
    }
}
