using System;
using System.Collections;
using System.Data;
using System.Reflection;
using Agenda.ModeloDatos.Datos;
using Agenda.ModeloDatos.Configuracion;
using Agenda.ModuloExc.Excepciones;

namespace Agenda.ModeloDatos.Dao
{
    public abstract class DaoAbs
    {
        protected readonly ConexionAbs _conexion;
        
        public DaoAbs()
        { 
            try
            {
                var parametrosConexion = ConfiguracionSistema.GetConfig().GetParametrosConexionSistema();
                _conexion = new ConexionSQLlite(parametrosConexion);                
            }
            catch (TargetInvocationException)
            {
                throw new ECargarDriverSistema("No se ha podido cargar la conexión del driver del sistema, por favor revise los parámetros de conexión");
            }
        }

        private ArrayList ObtenerParametrosConexion(String nombreOrigenDatos)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando(); 
            var res = new ArrayList();

            var sql = "SELECT id_parametro,f_parametro.id_origen_datos,nombre_parametro,valor_parametro";
            sql += " FROM f_parametro INNER JOIN f_origen_datos ON f_parametro.id_origen_datos = f_origen_datos.id_origen_datos";
            sql += " WHERE f_origen_datos.nombre_origen_datos = @0";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@0", DbType.String);
            param1.Value = nombreOrigenDatos;
            comando.Parameters.Add(param1);

            var lector = comando.ExecuteReader();
            while (lector.Read())
            {
                res.Add(new ParametroConexion(lector.GetString(lector.GetOrdinal("nombre_parametro")),lector.GetString(lector.GetOrdinal("valor_parametro"))));
            }
            _conexion.CerrarConexion();
            return res;           
        }
        protected String ObtenerNombreDriverConexion(String nombreOrigenDatos)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();
           
            const string sql = "SELECT nombre_driver_conexion FROM f_origen_datos WHERE nombre_origen_datos = @0";
            comando.CommandText = String.Format(sql);
            var param1 = _conexion.CrearParametro("@0", DbType.String);
            param1.Value = nombreOrigenDatos;
            comando.Parameters.Add(param1);

            var lector = comando.ExecuteReader();
            if (!lector.HasRows)
                throw new ENoExisteOrigenDeDatos("No está configurado un origen de datos con este nombre: " +
                                                 nombreOrigenDatos);
            lector.Read();
            _conexion.CerrarConexion();
            return lector.GetString(lector.GetOrdinal("nombre_driver_conexion"));
        }
        protected String ObtenerValorVariable(String nombre)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();
           
            const string sql = "SELECT valor FROM f_variable WHERE nombre_variable = @0";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@0", DbType.String);
            param1.Value = nombre;
            comando.Parameters.Add(param1);

            var lector = comando.ExecuteReader();                
            if (lector.HasRows)
            {
                lector.Read();
                _conexion.CerrarConexion();
                return lector.GetString(lector.GetOrdinal("valor"));
            }
            throw new EAccesoDatosNoSeHaEncontradoLaVariable("La variable '" + nombre + "' no existe en el sistema.");            
        }
        protected bool ExisteVariable(String nombre)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT nombre_variable FROM f_variable WHERE nombre_variable = @0";
            comando.CommandText = String.Format(sql);

            var paramNombre = _conexion.CrearParametro("@0", DbType.String);
            paramNombre.Value = nombre;
            comando.Parameters.Add(paramNombre);

            var lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                _conexion.CerrarConexion();
                return true;
            }
            _conexion.CerrarConexion();
            return false;
        }
        protected void CambiarValorVariable(String nombre, String valor)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();
            
            if (ExisteVariable(nombre))
            {
                const string sql = "UPDATE  f_variable SET valor = @1 WHERE nombre_variable = @0";
                comando.CommandText = String.Format(sql);

                var paramNombre = _conexion.CrearParametro("@0", DbType.String);
                paramNombre.Value = nombre;
                var paramValor = _conexion.CrearParametro("@1", DbType.String);
                paramValor.Value = valor;
                comando.Parameters.Add(paramNombre);
                comando.Parameters.Add(paramValor);
                comando.ExecuteNonQuery();
            }
            else
            {
                _conexion.CerrarConexion();
                throw new EErrorEnAccesoDatos("No se puede cambiar el valor de la variable '" + nombre + "' porque esta no existe.");
            }           
        }       
    }
}
