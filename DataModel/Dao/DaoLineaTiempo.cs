using Agenda.ModeloDatos.Entidades;
using Agenda.ModuloExc.Excepciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Agenda.ModeloDatos.Dao
{
    public class DaoLineaTiempo : DaoAbs, InterfazAcceso
    {
        public bool ExisteElemento(int id)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM linea_tiempo WHERE codigo_linea_tiempo = @1";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = id;

            comando.Parameters.Add(param1);
            
            var lector = comando.ExecuteReader();

            if (lector.Read())
            {
                lector.Close();
                _conexion.CerrarConexion();
                return true;
            }
            lector.Close();
            _conexion.CerrarConexion();
            return false;
        }
        public EntidadAbs ObtenerElemento(int id)
        {           
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM linea_tiempo INNER JOIN linea_tiempo_año ON linea_tiempo.codigo_linea_tiempo_año = linea_tiempo_año.codigo_linea_tiempo_año WHERE codigo_linea_tiempo = @1";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = id;

            comando.Parameters.Add(param1);

            var lector = comando.ExecuteReader();

            if (lector.Read())
            {
                var codigoLineaTiempo = lector.GetInt16(lector.GetOrdinal("codigo_linea_tiempo"));
                var codigoLineaTiempoAño = lector.GetInt16(lector.GetOrdinal("codigo_linea_tiempo_año"));
                var mes = lector.GetInt16(lector.GetOrdinal("mes"));
                var año = lector.GetInt16(lector.GetOrdinal("año"));
                var miLineaTiempo = new EntidadLineaTiempo { CodigoLineaTiempo = codigoLineaTiempo,CodigoLineaTiempoAño = codigoLineaTiempoAño,Mes = mes, Año = año };
                lector.Close();
                _conexion.CerrarConexion();
                return miLineaTiempo;
            }
            lector.Close();
            _conexion.CerrarConexion();
            throw new EErrorEnAccesoDatosObjetoNoEncontrado("La línea de tiempo no pudo ser encontrada");
        }
        public void ActualizarElemento(int id, EntidadAbs objeto)
        {  
            if (objeto == null) throw new ArgumentNullException("El parámetro 'objeto' no puede ser nulo.");
            if (!(objeto.GetType().Equals(typeof(EntidadLineaTiempo)))) throw new ArgumentException("El parámetro 'objeto' debe ser del tipo " + typeof(EntidadLineaTiempo).ToString());

            var miLineaTiempo = objeto as EntidadLineaTiempo;
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "UPDATE linea_tiempo SET codigo_linea_tiempo = @1,codigo_linea_tiempo_año = @2, mes = @3 WHERE codigo_linea_tiempo = @4";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = miLineaTiempo.CodigoLineaTiempo;
            var param2 = _conexion.CrearParametro("@2", DbType.Int32);
            param2.Value = miLineaTiempo.CodigoLineaTiempoAño;
            var param3 = _conexion.CrearParametro("@3", DbType.Int32);
            param3.Value = miLineaTiempo.Mes;  
            var param4= _conexion.CrearParametro("@4", DbType.Int32);
            param4.Value = id;  

            comando.Parameters.Add(param1);
            comando.Parameters.Add(param2);
            comando.Parameters.Add(param3);
            comando.Parameters.Add(param4); 

            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }
        public void AdicionarNuevoElemento(EntidadAbs objeto)
        {
            if (objeto == null) throw new ArgumentNullException("objeto");
            if (!(objeto.GetType().Equals(typeof(EntidadLineaTiempo)))) throw new ArgumentException("El parámetro 'objeto' debe ser del tipo " + typeof(EntidadLineaTiempo).ToString());
            var miLinea = objeto as EntidadLineaTiempo;

            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "INSERT INTO linea_tiempo (codigo_linea_tiempo,codigo_linea_tiempo_año,mes) VALUES (@1,@2,@3)";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = miLinea.CodigoLineaTiempo;

            var param2 = _conexion.CrearParametro("@2", DbType.Int32);
            param2.Value = miLinea.CodigoLineaTiempoAño;

            var param3 = _conexion.CrearParametro("@3", DbType.Int32);
            param3.Value = miLinea.Mes;         


            comando.Parameters.Add(param1);
            comando.Parameters.Add(param2);
            comando.Parameters.Add(param3);
           
            comando.ExecuteNonQuery();
            _conexion.CerrarConexion(); 
        }
        public void EliminarElemento(int id)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "DELETE FROM linea_tiempo WHERE codigo_linea_tiempo = @1";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = id;

            comando.Parameters.Add(param1);

            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }
        public void EliminarTodosLosElementos()
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "DELETE FROM linea_tiempo";
            comando.CommandText = String.Format(sql);

            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }
        public LinkedList<EntidadAbs> ObtenerTodosLosElementos()
        {
            var listado = new LinkedList<EntidadAbs>();
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM linea_tiempo INNER JOIN linea_tiempo_año ON linea_tiempo.codigo_linea_tiempo_año = linea_tiempo_año.codigo_linea_tiempo_año ORDER BY linea_tiempo_año.año,linea_tiempo.mes ASC";
            comando.CommandText = String.Format(sql);

            var lector = comando.ExecuteReader();

            while (lector.Read())
            {
                var codigoLineaTiempo = lector.GetInt16(lector.GetOrdinal("codigo_linea_tiempo"));
                var codigoLineaTiempoAño = lector.GetInt16(lector.GetOrdinal("codigo_linea_tiempo_año"));
                var mes = lector.GetInt16(lector.GetOrdinal("mes"));
                var año = lector.GetInt16(lector.GetOrdinal("año"));
                var miLineaTiempo = new EntidadLineaTiempo { CodigoLineaTiempo = codigoLineaTiempo, CodigoLineaTiempoAño = codigoLineaTiempoAño, Mes = mes, Año = año };
                listado.AddLast(miLineaTiempo);
            }
            lector.Close();
            _conexion.CerrarConexion();
            return listado;
        }       
    }
}
