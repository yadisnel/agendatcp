using Agenda.ModeloDatos.Entidades;
using Agenda.ModuloExc.Excepciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Agenda.ModeloDatos.Dao
{
    public class DaoLineaTiempoAño : DaoAbs, InterfazAcceso
    {
        public bool ExisteElemento(int id)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM linea_tiempo_año WHERE codigo_linea_tiempo_año = @1";
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

            const string sql = "SELECT * FROM linea_tiempo_año WHERE codigo_linea_tiempo_año = @1";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = id;

            comando.Parameters.Add(param1);

            var lector = comando.ExecuteReader();

            if (lector.Read())
            {
                var codigoLineaTiempoAño = lector.GetInt16(lector.GetOrdinal("codigo_linea_tiempo_año"));
                var año = lector.GetInt16(lector.GetOrdinal("año"));
                var miLineaTiempoAño = new EntidadLineaTiempoAño { CodigoLineaTiempoAño = codigoLineaTiempoAño, Año = año };
                lector.Close();
                _conexion.CerrarConexion();
                return miLineaTiempoAño;
            }
            lector.Close();
            _conexion.CerrarConexion();
            throw new EErrorEnAccesoDatosObjetoNoEncontrado("La línea de tiempo de año no pudo ser encontrada");
        }
        public void ActualizarElemento(int id, EntidadAbs objeto)
        {  
            if (objeto == null) throw new ArgumentNullException("El parámetro 'objeto' no puede ser nulo.");
            if (!(objeto.GetType().Equals(typeof(EntidadLineaTiempoAño)))) throw new ArgumentException("El parámetro 'objeto' debe ser del tipo " + typeof(EntidadLineaTiempoAño).ToString());

            var miLineaTiempo = objeto as EntidadLineaTiempoAño;
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "UPDATE linea_tiempo_año SET codigo_linea_tiempo_año = @1, año = @2 WHERE codigo_linea_tiempo_año = @3";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = miLineaTiempo.CodigoLineaTiempoAño;
            var param2 = _conexion.CrearParametro("@2", DbType.Int32);
            param2.Value = miLineaTiempo.Año;
            var param3 = _conexion.CrearParametro("@3", DbType.Int32);
            param3.Value = id;  

            comando.Parameters.Add(param1);
            comando.Parameters.Add(param2);
            comando.Parameters.Add(param3);      

            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }
        public void AdicionarNuevoElemento(EntidadAbs objeto)
        {
            if (objeto == null) throw new ArgumentNullException("objeto");
            if (!(objeto.GetType().Equals(typeof(EntidadLineaTiempoAño)))) throw new ArgumentException("El parámetro 'objeto' debe ser del tipo " + typeof(EntidadLineaTiempoAño).ToString());
            var miLinea = objeto as EntidadLineaTiempoAño;

            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "INSERT INTO linea_tiempo_año (codigo_linea_tiempo_año,año) VALUES (@1,@2)";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = miLinea.CodigoLineaTiempoAño;

            var param2 = _conexion.CrearParametro("@2", DbType.Int32);
            param2.Value = miLinea.Año;         

            comando.Parameters.Add(param1);
            comando.Parameters.Add(param2);
           
            comando.ExecuteNonQuery();
            _conexion.CerrarConexion(); 
        }
        public void EliminarElemento(int id)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "DELETE FROM linea_tiempo_año WHERE codigo_linea_tiempo_año = @1";
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

            const string sql = "DELETE FROM linea_tiempo_año";
            comando.CommandText = String.Format(sql);

            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }
        public LinkedList<EntidadAbs> ObtenerTodosLosElementos()
        {
            var listado = new LinkedList<EntidadAbs>();
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM linea_tiempo_año;";
            comando.CommandText = String.Format(sql);

            var lector = comando.ExecuteReader();

            while (lector.Read())
            {
                var codigoLineaTiempoAño = lector.GetInt16(lector.GetOrdinal("codigo_linea_tiempo_año"));
                var año = lector.GetInt16(lector.GetOrdinal("año"));
                var miLineaTiempo = new EntidadLineaTiempoAño { CodigoLineaTiempoAño = codigoLineaTiempoAño, Año = año };
                listado.AddLast(miLineaTiempo);
            }
            lector.Close();
            _conexion.CerrarConexion();
            return listado;
        }
    }
}
