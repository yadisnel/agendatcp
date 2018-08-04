using System.Runtime.InteropServices;
using Agenda.ModeloDatos.Entidades;
using Agenda.ModuloExc.Excepciones;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Agenda.ModeloDatos.Dao
{
    public class DaoLicencia : DaoAbs, InterfazAcceso
    {
        public LinkedList<EntidadAbs> ObtenerLicenciasDeTcp(EntidadTcp tcp)
        {
            const string excepcion = "El parámetro 'tcp' no puede ser nulo.";
            if (tcp == null) throw new ArgumentNullException(excepcion);

            var listado = new LinkedList<EntidadAbs>();
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM (licencia INNER JOIN actividad ON licencia.codigo_actividad = actividad.codigo_actividad)  WHERE codigo_tcp = @1";
            comando.CommandText = String.Format(sql);
            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = tcp.CodigoTcp;
            comando.Parameters.Add(param1);

            var lector = comando.ExecuteReader();

            while (lector.Read())
            {
                var codigoLicencia = lector.GetInt16(lector.GetOrdinal("codigo_licencia"));
                var codigoActividad = lector.GetInt16(lector.GetOrdinal("codigo_actividad"));
                var numeroLicencia = lector.GetInt32(lector.GetOrdinal("numero_licencia"));
                var codigoTcp = lector.GetInt16(lector.GetOrdinal("codigo_tcp"));               
                var nombre = lector.GetString(lector.GetOrdinal("nombre"));

                var dpa = new EntidadLicencia
                {
                    CodigoLicencia = codigoLicencia,
                    CodigoActividad = codigoActividad,
                    CodigoTcp = codigoTcp,
                    NumeroLicencia = numeroLicencia,                
                    Nombre = nombre
                };
                listado.AddLast(dpa);
            }
            lector.Close();
            _conexion.CerrarConexion();
            return listado;
        }
        public bool ExisteElemento(int id)
        {   
            var listado = new ArrayList();
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM licencia WHERE codigo_licencia = @1";
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
        public bool ExisteLicenciaConNumero(int numero)
        {
            var listado = new ArrayList();
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM licencia WHERE numero_licencia = @1";
            comando.CommandText = String.Format(sql);
            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = numero;
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
        public bool EsLicencia(int codigoTcp,int CodigoActividad)
        {
            var listado = new ArrayList();
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM licencia WHERE codigo_actividad = @1 AND codigo_tcp = @2";
            comando.CommandText = String.Format(sql);
           
            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = CodigoActividad;
            var param2 = _conexion.CrearParametro("@2", DbType.Int32);
            param2.Value = codigoTcp;
            comando.Parameters.Add(param1);
            comando.Parameters.Add(param2);

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

            const string sql = "SELECT * FROM  (licencia INNER JOIN actividad ON licencia.codigo_actividad = actividad.codigo_actividad)  WHERE codigo_licencia = @1";
            comando.CommandText = String.Format(sql);
            
            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = id;
            comando.Parameters.Add(param1);

            var lector = comando.ExecuteReader();

            if (lector.Read())
            {
                var codigoLicencia = lector.GetInt16(lector.GetOrdinal("codigo_licencia"));
                var CodigoActividad = lector.GetInt16(lector.GetOrdinal("codigo_actividad"));
                var codigoTcp = lector.GetInt16(lector.GetOrdinal("codigo_tcp"));
                var numeroLicencia = lector.GetInt32(lector.GetOrdinal("numero_licencia"));              
                var nombre = lector.GetString(lector.GetOrdinal("nombre"));

                var dpa = new EntidadLicencia
                {
                    CodigoLicencia = codigoLicencia,
                    CodigoActividad = CodigoActividad,
                    CodigoTcp = codigoTcp,
                    NumeroLicencia = numeroLicencia,              
                    Nombre = nombre
                };
                lector.Close();
                _conexion.CerrarConexion();
                return dpa;
            }
            lector.Close();
            _conexion.CerrarConexion();
            throw new EErrorEnAccesoDatosObjetoNoEncontrado("El objeto no ha podido ser encontrado");
        }
        public void ActualizarElemento(int id, EntidadAbs objeto)
        {
            const string excepcion = "El parámetro 'objeto' no puede ser nulo.";
            if (objeto == null) throw new ArgumentNullException(excepcion);
            if (!(objeto.GetType() == typeof(EntidadLicencia))) throw new ArgumentException("El parámetro 'objeto' debe ser del tipo " + typeof(EntidadLicencia).ToString());

            var actividad = objeto as EntidadLicencia;

            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "UPDATE licencia SET codigo_licencia = @1, codigo_actividad = @2, codigo_tcp = @3, numero_licencia = @4  WHERE codigo_licencia = @5";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int16);
            param1.Value = actividad.CodigoLicencia;
            var param2 = _conexion.CrearParametro("@2", DbType.Int16);
            param2.Value = actividad.CodigoActividad;
            var param3 = _conexion.CrearParametro("@3", DbType.Int16);
            param3.Value = actividad.CodigoTcp;
            var param4 = _conexion.CrearParametro("@4", DbType.Int32);
            param4.Value = actividad.NumeroLicencia;  
            var param5 = _conexion.CrearParametro("@5", DbType.Int16);
            param5.Value = id;

            comando.Parameters.Add(param1);
            comando.Parameters.Add(param2);
            comando.Parameters.Add(param3);
            comando.Parameters.Add(param4);
            comando.Parameters.Add(param5);

            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }
        public void AdicionarNuevoElemento(EntidadAbs objeto)
        {
            if (objeto == null) throw new ArgumentNullException("El parámetro 'objeto' no puede ser nulo.");
            if (!(objeto.GetType().Equals(typeof(EntidadLicencia)))) throw new ArgumentException("El parámetro 'objeto' debe ser del tipo " + typeof(EntidadLicencia).ToString());

            var actividad = objeto as EntidadLicencia;
           
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "INSERT INTO licencia (codigo_licencia,codigo_actividad,codigo_tcp,numero_licencia) VALUES (@1,@2,@3,@4)";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int16);
            param1.Value = actividad.CodigoLicencia;
            var param2 = _conexion.CrearParametro("@2", DbType.Int16);
            param2.Value = actividad.CodigoActividad;
            var param3 = _conexion.CrearParametro("@3", DbType.Int16);
            param3.Value = actividad.CodigoTcp;
            var param4 = _conexion.CrearParametro("@4", DbType.Int32);
            param4.Value = actividad.NumeroLicencia;

            comando.Parameters.Add(param1);
            comando.Parameters.Add(param2);
            comando.Parameters.Add(param3);
            comando.Parameters.Add(param4);

            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();            
        }
        public void EliminarElemento(int id)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "DELETE FROM licencia WHERE codigo_licencia = @1";
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

            const string sql = "DELETE FROM licencia";
            comando.CommandText = String.Format(sql);

            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }
        public LinkedList<EntidadAbs> ObtenerTodosLosElementos()
        {
            var listado = new LinkedList<EntidadAbs>();
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM (licencia INNER JOIN actividad ON licencia.codigo_actividad = actividad.codigo_actividad)";
            comando.CommandText = String.Format(sql);          

            var lector = comando.ExecuteReader();

            while (lector.Read())
            {
                var codigoLicencia = lector.GetInt16(lector.GetOrdinal("codigo_licencia"));
                var CodigoActividad = lector.GetInt16(lector.GetOrdinal("codigo_actividad"));
                var codigoTcp = lector.GetInt16(lector.GetOrdinal("codigo_tcp"));
                var numeroLicencia = lector.GetInt32(lector.GetOrdinal("numero_licencia"));
                var nombre = lector.GetString(lector.GetOrdinal("nombre"));
                
                var dpa = new EntidadLicencia
                {
                    CodigoLicencia = codigoLicencia,
                    CodigoActividad = CodigoActividad,
                    CodigoTcp = codigoTcp,
                    NumeroLicencia = numeroLicencia,
                    Nombre = nombre
                };
                listado.AddLast(dpa);
            }
            lector.Close();
            _conexion.CerrarConexion();
            return listado;
        }
        public short ObtenerProximoCodigoLicencia()
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT MAX(licencia.codigo_licencia) as maxcodigo FROM licencia";
            comando.CommandText = String.Format(sql);

            var lector = comando.ExecuteReader();
            if (lector.Read())
            {
                var ordinal = lector.GetOrdinal("maxcodigo");
                if (!lector.IsDBNull(ordinal))
                {
                    var codigo = lector.GetInt16(ordinal);
                    lector.Close();
                    _conexion.CerrarConexion();
                    return ++codigo;
                }
            }
            lector.Close();
            _conexion.CerrarConexion();
            return 0;
        }
    }
}
