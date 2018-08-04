using Agenda.ModeloDatos.Entidades;
using Agenda.ModuloExc.Excepciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Agenda.ModeloDatos.Dao
{
    public class DaoProvincia : DaoAbs, InterfazAcceso
    {
        public short ObtenerProximoCodigoProvincia()
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT MAX(provincia.codigo_provincia) as maxcodigo FROM provincia";
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

            const string sql = "SELECT * FROM provincia WHERE codigo_provincia = @1";
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

            const string sql = "SELECT * FROM provincia WHERE codigo_provincia = @1";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = id;

            comando.Parameters.Add(param1);

            var lector = comando.ExecuteReader();

            if (lector.Read())
            {
                var codigoProvincia = lector.GetInt16(lector.GetOrdinal("codigo_provincia"));
                var nombre = lector.GetString(lector.GetOrdinal("nombre"));

                var miProvincia = new EntidadProvincia { CodigoProvincia = codigoProvincia, Nombre = nombre };
                lector.Close();
                _conexion.CerrarConexion();
                return miProvincia;
            }
            lector.Close();
            _conexion.CerrarConexion();
            throw new EErrorEnAccesoDatosObjetoNoEncontrado("La provincia solicitada no pudo ser encontrada");
        }

        public void ActualizarElemento(int id, EntidadAbs objeto)
        {  
            if (objeto == null) throw new ArgumentNullException("El parámetro 'objeto' no puede ser nulo.");
            if (!(objeto.GetType().Equals(typeof(EntidadProvincia)))) throw new ArgumentException("El parámetro 'objeto' debe ser del tipo " + typeof(EntidadProvincia).ToString());

            var provincia = objeto as EntidadProvincia;

            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "UPDATE provincia SET codigo_provincia = @1, nombre = @2 WHERE codigo_provincia = @3";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = provincia.CodigoProvincia;
            var param2 = _conexion.CrearParametro("@2", DbType.String);
            param2.Value = provincia.Nombre;
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
            if (!(objeto.GetType().Equals(typeof(EntidadProvincia)))) throw new ArgumentException("El parámetro 'objeto' debe ser del tipo " + typeof(EntidadProvincia).ToString());
            var provincia = objeto as EntidadProvincia;

            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "INSERT INTO provincia (codigo_provincia,nombre) VALUES (@1,@2)";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = provincia.CodigoProvincia;
            var param2 = _conexion.CrearParametro("@2", DbType.String);
            param2.Value = provincia.Nombre;         

            comando.Parameters.Add(param1);
            comando.Parameters.Add(param2);
           
            comando.ExecuteNonQuery();
            _conexion.CerrarConexion(); 
        }

        public void EliminarElemento(int id)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "DELETE FROM provincia WHERE codigo_provincia = @1";
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

            const string sql = "DELETE FROM provincia";
            comando.CommandText = String.Format(sql);

            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }

        public LinkedList<EntidadAbs> ObtenerTodosLosElementos()
        {
            var listado = new LinkedList<EntidadAbs>();
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM provincia;";
            comando.CommandText = String.Format(sql);

            var lector = comando.ExecuteReader();

            while (lector.Read())
            {
                var codigoProvincia = lector.GetInt16(lector.GetOrdinal("codigo_provincia"));
                var nombre = lector.GetString(lector.GetOrdinal("nombre"));

                var miProvincia = new EntidadProvincia { CodigoProvincia = codigoProvincia, Nombre = nombre };

                listado.AddLast(miProvincia);
            }
            lector.Close();
            _conexion.CerrarConexion();
            return listado;
        }
    }
}
