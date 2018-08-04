using Agenda.ModeloDatos.Entidades;
using Agenda.ModuloExc.Excepciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Agenda.ModeloDatos.Dao
{
    public class DaoMunicipio : DaoAbs, InterfazAcceso
    {
        public short ObtenerProximoCodigoMunicipio()
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT MAX(municipio.codigo_municipio) as maxcodigo FROM municipio";
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
        public bool ExisteElemento(int id)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM municipio WHERE codigo_municipio = @1";
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

            const string sql = "SELECT * FROM municipio WHERE codigo_municipio = @1";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = id;
            comando.Parameters.Add(param1);

            var lector = comando.ExecuteReader();

            if (lector.Read())
            {
                var codigoMunicipio = lector.GetInt16(lector.GetOrdinal("codigo_municipio"));
                var codigoProvincia = lector.GetInt16(lector.GetOrdinal("codigo_provincia"));
                var nombre = lector.GetString(lector.GetOrdinal("nombre"));

                var miMunicipio = new EntidadMunicipio {CodigoMunicipio = codigoMunicipio, CodigoProvincia = codigoProvincia, Nombre = nombre };
                lector.Close();
                _conexion.CerrarConexion();
                return miMunicipio;
            }
            lector.Close();
            _conexion.CerrarConexion();
            throw new EErrorEnAccesoDatosObjetoNoEncontrado("El municipio solicitado no pudo ser encontrado");
        }
        public void ActualizarElemento(int id, EntidadAbs objeto)
        {  
            if (objeto == null) throw new ArgumentNullException("El parámetro 'objeto' no puede ser nulo.");
            if (!(objeto.GetType() == typeof(EntidadMunicipio))) throw new ArgumentException("El parámetro 'objeto' debe ser del tipo " + typeof(EntidadMunicipio).ToString());

            var municipio = objeto as EntidadMunicipio;

            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "UPDATE municipio SET codigo_municipio = @1, codigo_provincia = @2, nombre = @3 WHERE codigo_municipio = @4";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            if (municipio != null)
            {
                param1.Value = municipio.CodigoMunicipio;
                var param2 = _conexion.CrearParametro("@2", DbType.Int32);
                param2.Value = municipio.CodigoProvincia;
                var param3 = _conexion.CrearParametro("@3", DbType.String);
                param3.Value = municipio.Nombre;
                var param4 = _conexion.CrearParametro("@4", DbType.Int32);
                param4.Value = id;  

                comando.Parameters.Add(param1);
                comando.Parameters.Add(param2);
                comando.Parameters.Add(param3);
                comando.Parameters.Add(param4);
            }

            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }

        public void AdicionarNuevoElemento(EntidadAbs objeto)
        {
            if (objeto == null) throw new ArgumentNullException("El parámetro 'objeto' no puede ser nulo.");
            if (!(objeto.GetType().Equals(typeof(EntidadMunicipio)))) throw new ArgumentException("El parámetro 'objeto' debe ser del tipo " + typeof(EntidadMunicipio).ToString());

            var municipio = objeto as EntidadMunicipio;

            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "INSERT INTO municipio (codigo_municipio,codigo_provincia,nombre) VALUES (@1,@2,@3)";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = municipio.CodigoMunicipio;
            var param2 = _conexion.CrearParametro("@2", DbType.Int32);
            param2.Value = municipio.CodigoProvincia;
            var param3 = _conexion.CrearParametro("@3", DbType.String);
            param3.Value = municipio.Nombre;  

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

            const string sql = "DELETE FROM municipio WHERE codigo_municipio = @1";
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

            const string sql = "DELETE FROM n_provincia";
            comando.CommandText = String.Format(sql);

            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }

        public LinkedList<EntidadAbs> ObtenerTodosLosElementos()
        {
            var listado = new LinkedList<EntidadAbs>();
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM municipio;";
            comando.CommandText = String.Format(sql);

            var lector = comando.ExecuteReader();

            while (lector.Read())
            {
                var codigoMunicipio = lector.GetInt16(lector.GetOrdinal("codigo_municipio"));
                var codigoProvincia = lector.GetInt16(lector.GetOrdinal("codigo_provincia"));
                var nombre = lector.GetString(lector.GetOrdinal("nombre"));
                var miMunicipio = new EntidadMunicipio { CodigoMunicipio = codigoMunicipio,CodigoProvincia = codigoProvincia, Nombre = nombre };

                listado.AddLast(miMunicipio);
            }
            lector.Close();
            _conexion.CerrarConexion();
            return listado;
        }
        public LinkedList<EntidadMunicipio> ObtenerTodosLosMunicipios(int pCodigoProvincia)
        {
            var listado = new LinkedList<EntidadMunicipio>();
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM municipio WHERE codigo_provincia = @1;";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = pCodigoProvincia;
            comando.Parameters.Add(param1);

            var lector = comando.ExecuteReader();

            while (lector.Read())
            {
                var codigoMunicipio = lector.GetInt16(lector.GetOrdinal("codigo_municipio"));
                var codigoProvincia = lector.GetInt16(lector.GetOrdinal("codigo_provincia"));
                var nombre = lector.GetString(lector.GetOrdinal("nombre"));
                var miMunicipio = new EntidadMunicipio { CodigoMunicipio = codigoMunicipio, CodigoProvincia = codigoProvincia, Nombre = nombre };
                listado.AddLast(miMunicipio);
            }
            lector.Close();
            _conexion.CerrarConexion();
            return listado;
        }
    }
}
