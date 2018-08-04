using System;
using System.Data;
using Agenda.ModeloDatos.Seguridad;
using System.Collections.Generic;
using Agenda.ModuloExc.Excepciones;
using Agenda.ModeloDatos.Entidades;

namespace Agenda.ModeloDatos.Dao
{
    public class DaoTcp : DaoAbs, InterfazAcceso
    {
        public bool ExisteElemento(int id)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM tcp WHERE  codigo_tcp = @1;";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.String);
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

            const string sql = "SELECT * FROM tcp WHERE codigo_tcp = @1";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = id;

            comando.Parameters.Add(param1);

            var lector = comando.ExecuteReader();

            if (lector.Read())
            {
                var codigoTCP = lector.GetInt16(lector.GetOrdinal("codigo_tcp"));
                var nombreApellidos = lector.GetString(lector.GetOrdinal("nombre_apellidos"));
                var nit = lector.GetString(lector.GetOrdinal("nit"));               

                var miTcp = new EntidadTcp
                {
                    CodigoTcp= codigoTCP,
                    NombreApellidos = nombreApellidos,
                    Nit = nit                    
                };
                return miTcp;
            }
            lector.Close();
            _conexion.CerrarConexion();
            throw new EErrorEnAccesoDatosObjetoNoEncontrado("El objeto no pudo ser encontrado");
        }
        public EntidadTcp ObtenerTcpCliente()
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM tcp WHERE es_cliente = 1";
            comando.CommandText = String.Format(sql);

            var lector = comando.ExecuteReader();

            if (lector.Read())
            {
                var codigoTCP = lector.GetInt16(lector.GetOrdinal("codigo_tcp"));
                var nombreApellidos = lector.GetString(lector.GetOrdinal("nombre_apellidos"));
                var nit = lector.GetString(lector.GetOrdinal("nit"));
                var miTcp = new EntidadTcp
                {
                    CodigoTcp = codigoTCP,
                    NombreApellidos = nombreApellidos,
                    Nit = nit                   
                };
                return miTcp;
            }
            lector.Close();
            _conexion.CerrarConexion();
            throw new EErrorEnAccesoDatosObjetoNoEncontrado("El objeto no pudo ser encontrado");
        }
        public void ActualizarElemento(int id, EntidadAbs objeto)
        {           
            if (objeto == null) throw new ArgumentNullException("El parámetro 'objeto' no puede ser nulo.");
            if (!(objeto.GetType().Equals(typeof(EntidadTcp)))) throw new ArgumentException("El parámetro 'objeto' debe ser del tipo " + typeof(EntidadTcp).ToString());

            var tcp = objeto as EntidadTcp;
           
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "UPDATE tcp SET codigo_tcp = @1, nombre_apellidos = @2, nit = @3, WHERE  codigo_tcp = @4";
            comando.CommandText = String.Format(sql);
            
            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = tcp.CodigoTcp;
            var param2 = _conexion.CrearParametro("@2", DbType.String);
            param2.Value = tcp.NombreApellidos;
            var param3 = _conexion.CrearParametro("@3", DbType.String);
            param3.Value = tcp.Nit;            
            var param4 = _conexion.CrearParametro("@4", DbType.Int32);
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
            if (objeto == null) throw new ArgumentNullException("El parámetro 'objeto' no puede ser nulo.");
            if (!(objeto.GetType().Equals(typeof(EntidadTcp)))) throw new ArgumentException("El parámetro 'objeto' debe ser del tipo " + this.GetType().ToString());

            var tcp = objeto as EntidadTcp;
            
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "INSERT INTO tcp (codigo_tcp,nombre_apellidos,nit) VALUES (@1,@2,@3)";
            comando.CommandText = String.Format(sql);
            
            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = tcp.CodigoTcp;
            var param2 = _conexion.CrearParametro("@2", DbType.String);
            param2.Value = tcp.NombreApellidos;
            var param3 = _conexion.CrearParametro("@3", DbType.String);
            param3.Value = tcp.Nit;           

            comando.Parameters.Add(param1);
            comando.Parameters.Add(param2);
            comando.Parameters.Add(param3);                                        

            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }
        public short ObtenerProximoCodigoTcp()
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT MAX(tcp.codigo_tcp) as maxcodigo FROM tcp;";
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
        public void EliminarElemento(int id)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "DELETE FROM tcp WHERE codigo_tcp = @1";
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

            const string sql = "DELETE FROM tcp";
            comando.CommandText = String.Format(sql);

            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }
        public LinkedList<EntidadAbs> ObtenerTodosLosElementos()
        {
            var todosLosTcp = new LinkedList<EntidadAbs>();
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM tcp";
            comando.CommandText = String.Format(sql);

            var lector = comando.ExecuteReader();

            while (lector.Read())
            {
                var codigoTCP = lector.GetInt16(lector.GetOrdinal("codigo_tcp"));
                var nombreApellidos = lector.GetString(lector.GetOrdinal("nombre_apellidos"));
                var nit = lector.GetString(lector.GetOrdinal("nit"));               

                var miTcp = new EntidadTcp
                {
                    CodigoTcp = codigoTCP,
                    NombreApellidos = nombreApellidos,
                    Nit = nit                   
                };
                todosLosTcp.AddLast(miTcp);
            }
            lector.Close();
            _conexion.CerrarConexion();
            return todosLosTcp;
        }
    }
}
