using Agenda.ModeloDatos.Entidades;
using Agenda.ModuloExc.Excepciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Agenda.ModeloDatos.Dao
{
    public class DaoActividad : DaoAbs, InterfazAcceso
    {        
        public bool ExisteElemento(int id)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM actividad WHERE codigo_actividad = @1";
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

            const string sql = "SELECT * FROM actividad WHERE codigo_actividad = @1";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = id;
            comando.Parameters.Add(param1);

            var lector = comando.ExecuteReader();

            if (lector.Read())
            {
                var CodigoActividad = lector.GetInt16(lector.GetOrdinal("codigo_actividad"));
                var nombre = lector.GetString(lector.GetOrdinal("nombre"));
                var nombreInterno = lector.GetString(lector.GetOrdinal("nombre_interno"));
                var descripcion = lector.GetString(lector.GetOrdinal("descripcion"));
                var esRegimenSimplificado = lector.GetBoolean(lector.GetOrdinal("es_regimen_simplificado"));
                var miActividad = new EntidadActividad 
                { 
                    CodigoActividad = CodigoActividad, 
                    Nombre = nombre,
                    NombreInterno = nombreInterno, 
                    Descripcion = descripcion,
                    EsRegimenSimplificado = esRegimenSimplificado
                };
                lector.Close();
                _conexion.CerrarConexion();
                return miActividad;
            }
            lector.Close();
            _conexion.CerrarConexion();
            throw new EErrorEnAccesoDatosObjetoNoEncontrado("La Actividad no pudo ser encontrada");
        }
        public short ObtenerProximoCodigoActividad()
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT MAX(actividad.codigo_actividad) as maxcodigo FROM actividad";
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
        public void ActualizarElemento(int id, EntidadAbs objeto)
        {  
            if (objeto == null) throw new ArgumentNullException("El parámetro 'objeto' no puede ser nulo.");
            if (!(objeto.GetType().Equals(typeof(EntidadActividad)))) throw new ArgumentException("El parámetro 'objeto' debe ser del tipo " + typeof(EntidadActividad).ToString());
            var Actividad = objeto as EntidadActividad;
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();
            const string sql = "UPDATE actividad SET codigo_actividad = @1, nombre = @2,nombre_interno = @3, descripcion = @4, es_regimen_simplificado = @5 WHERE codigo_actividad = @6";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = Actividad.CodigoActividad;
            var param2 = _conexion.CrearParametro("@2", DbType.String);
            param2.Value = Actividad.Nombre;
            var param3 = _conexion.CrearParametro("@3", DbType.String);
            param3.Value = Actividad.NombreInterno;
            var param4 = _conexion.CrearParametro("@4", DbType.String);
            param4.Value = Actividad.Descripcion;
            var param5 = _conexion.CrearParametro("@5", DbType.Boolean);
            param5.Value = Actividad.EsRegimenSimplificado;           
            var param6 = _conexion.CrearParametro("@6", DbType.Int32);
            param6.Value = id;

            comando.Parameters.Add(param1);
            comando.Parameters.Add(param2);
            comando.Parameters.Add(param3);
            comando.Parameters.Add(param4);
            comando.Parameters.Add(param5);            
            comando.Parameters.Add(param6);

            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }
        public void AdicionarNuevoElemento(EntidadAbs objeto)
        {
            if (objeto == null) throw new ArgumentNullException("El parámetro 'objeto' no puede ser nulo.");
            if (!(objeto.GetType() == typeof(EntidadActividad))) throw new ArgumentException("El parámetro 'objeto' debe ser del tipo " + typeof(EntidadActividad).ToString());

            var Actividad = objeto as EntidadActividad;

            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "INSERT INTO actividad (codigo_actividad,nombre,nombre_interno,descripcion,es_regimen_simplificado) VALUES (@1,@2,@3,@4,@5)";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = Actividad.CodigoActividad;
            var param2 = _conexion.CrearParametro("@2", DbType.String);
            param2.Value = Actividad.Nombre;
            var param3 = _conexion.CrearParametro("@3", DbType.String);
            param3.Value = Actividad.NombreInterno;
            var param4 = _conexion.CrearParametro("@4", DbType.String);
            param4.Value = Actividad.Descripcion;
            var param5 = _conexion.CrearParametro("@5", DbType.Boolean);
            param5.Value = Actividad.EsRegimenSimplificado;            

            comando.Parameters.Add(param1);
            comando.Parameters.Add(param2);
            comando.Parameters.Add(param3);
            comando.Parameters.Add(param4);
            comando.Parameters.Add(param5);
           
            comando.ExecuteNonQuery();
            _conexion.CerrarConexion(); 
        }
        public void EliminarElemento(int id)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "DELETE FROM actividad WHERE codigo_actividad = @1";
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

            const string sql = "DELETE FROM actividad";
            comando.CommandText = String.Format(sql);

            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }
        public LinkedList<EntidadAbs> ObtenerTodosLosElementos()
        {
            var listado = new LinkedList<EntidadAbs>();
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM actividad;";
            comando.CommandText = String.Format(sql);

            var lector = comando.ExecuteReader();

            while (lector.Read())
            {
                var CodigoActividad = lector.GetInt16(lector.GetOrdinal("codigo_actividad"));
                var nombre = lector.GetString(lector.GetOrdinal("nombre"));
                var nombreInterno = lector.GetString(lector.GetOrdinal("nombre_interno"));
                var descripcion = lector.GetString(lector.GetOrdinal("descripcion"));
                var esRegimenSimplificado = lector.GetBoolean(lector.GetOrdinal("es_regimen_simplificado"));                

                var miActividad = new EntidadActividad 
                { 
                    CodigoActividad = CodigoActividad, 
                    Nombre = nombre, 
                    NombreInterno = nombreInterno, 
                    Descripcion = descripcion, 
                    EsRegimenSimplificado = esRegimenSimplificado
                };
                listado.AddLast(miActividad);
            }
            lector.Close();
            _conexion.CerrarConexion();
            return listado;
        }
    }
}
