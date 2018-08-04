using Agenda.ModeloDatos.Entidades;
using Agenda.ModuloExc.Excepciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Agenda.ModeloDatos.Dao
{
    public class DaoLimiteActividad : DaoAbs, InterfazAcceso
    {
        public int ObtenerProximoCodigoLimiteActividad()
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT MAX(limite_actividad.codigo_limite_actividad) as maxcodigo FROM limite_actividad";
            comando.CommandText = String.Format(sql);

            var lector = comando.ExecuteReader();
            if (lector.Read())
            {
                var ordinal = lector.GetOrdinal("maxcodigo");
                if (!lector.IsDBNull(ordinal))
                {
                    var codigo = lector.GetInt32(ordinal);
                    lector.Close();
                    _conexion.CerrarConexion();
                    return ++codigo;
                }
            }
            lector.Close();
            _conexion.CerrarConexion();
            return 0;
        }
        private int ObtenerProximoCodigoLimiteActividadPrivado()
        {            
            var comando = _conexion.CrearComando();
            const string sql = "SELECT MAX(limite_actividad.codigo_limite_actividad) as maxcodigo FROM limite_actividad";
            comando.CommandText = String.Format(sql);

            var lector = comando.ExecuteReader();
            if (lector.Read())
            {
                var ordinal = lector.GetOrdinal("maxcodigo");
                if (!lector.IsDBNull(ordinal))
                {
                    var codigo = lector.GetInt32(ordinal);
                    lector.Close();
                    return ++codigo;
                }
            }
            lector.Close();           
            return 0;
        }
        public bool ExisteElemento(int id)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM limite_actividad WHERE codigo_limite_actividad = @1";
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
        public bool ExisteLimiteActividadMesLineaTiempo(EntidadLicencia licenciaUso, EntidadLineaTiempo linea)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM (limite_actividad INNER JOIN (linea_tiempo INNER JOIN linea_tiempo_año ON linea_tiempo.codigo_linea_tiempo_año = linea_tiempo_año.codigo_linea_tiempo_año)  ON limite_actividad.codigo_linea_tiempo =  linea_tiempo.codigo_linea_tiempo) WHERE codigo_actividad = @1 AND limite_actividad.codigo_linea_tiempo = @2";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int16);
            param1.Value = licenciaUso.CodigoActividad;
            var param2 = _conexion.CrearParametro("@2", DbType.Int32);
            param2.Value = linea.CodigoLineaTiempo;

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

            const string sql = "SELECT * FROM limite_actividad WHERE codigo_limite_actividad = @1";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = id;
            comando.Parameters.Add(param1);

            var lector = comando.ExecuteReader();

            if (lector.Read())
            {
                var CodigoLimiteactividad = lector.GetInt32(lector.GetOrdinal("codigo_limite_actividad"));
                var CodigoActividad = lector.GetInt16(lector.GetOrdinal("codigo_actividad"));
                var codigoMunicipio = lector.GetInt16(lector.GetOrdinal("codigo_municipio"));
                var codigoLineaTiempo = lector.GetInt16(lector.GetOrdinal("codigo_linea_tiempo"));
                var cuotaMensualMinima = lector.GetDouble(lector.GetOrdinal("cuota_mensual"));
                var gastoMaximo = lector.GetDouble(lector.GetOrdinal("gasto_maximo"));
                var miLimite = new EntidadLimiteActividad 
                {
                    CodigoLimiteActividad=CodigoLimiteactividad,
                    CodigoActividad= CodigoActividad, 
                    CodigoLineaTiempo = codigoLineaTiempo,
                    CodigoMunicipio = codigoMunicipio, 
                    CuotaMensualMinima = cuotaMensualMinima, 
                    GastoMaximo = gastoMaximo                   
                };
                lector.Close();
                _conexion.CerrarConexion();
                return miLimite;
            }
            lector.Close();
            _conexion.CerrarConexion();
            throw new EErrorEnAccesoDatosObjetoNoEncontrado("El límite solicitado no pudo ser encontrado");
        }
        public void ActualizarElemento(int id, EntidadAbs objeto)
        {  
            if (objeto == null) throw new ArgumentNullException("El parámetro 'objeto' no puede ser nulo.");
            if (!(objeto.GetType() == typeof(EntidadLimiteActividad))) throw new ArgumentException("El parámetro 'objeto' debe ser del tipo " + typeof(EntidadLimiteActividad).ToString());
            var limite = objeto as EntidadLimiteActividad;
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();
            const string sql = "UPDATE limite_actividad SET codigo_limite_actividad = @1, codigo_actividad = @2, codigo_municipio = @3,codigo_linea_tiempo=@4,cuota_mensual_minima = @5, gasto_maximo = @6 WHERE codigo_limite_actividad = @7";
            comando.CommandText = String.Format(sql);
            if (limite != null)
            {
                var param1 = _conexion.CrearParametro("@1", DbType.Int32);
                param1.Value = limite.CodigoLimiteActividad;
                var param2 = _conexion.CrearParametro("@2", DbType.Int32);
                param2.Value = limite.CodigoActividad;
                var param3 = _conexion.CrearParametro("@3", DbType.Int32);
                param3.Value = limite.CodigoMunicipio;
                var param4 = _conexion.CrearParametro("@4", DbType.Int32);
                param4.Value = limite.CodigoLineaTiempo;

                var param5 = _conexion.CrearParametro("@5", DbType.Double);
                param5.Value = limite.CuotaMensualMinima;
                var param6 = _conexion.CrearParametro("@6", DbType.Double);
                param6.Value = limite.GastoMaximo;

                var param7 = _conexion.CrearParametro("@7", DbType.Int32);
                param7.Value = limite.CodigoLimiteActividad;

                comando.Parameters.Add(param1);
                comando.Parameters.Add(param2);
                comando.Parameters.Add(param3);
                comando.Parameters.Add(param4);
                comando.Parameters.Add(param5);
                comando.Parameters.Add(param6);
                comando.Parameters.Add(param7);               
            }

            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }
        public void AdicionarNuevoElemento(EntidadAbs objeto)
        {
            if (objeto == null) throw new ArgumentNullException("El parámetro 'objeto' no puede ser nulo.");
            if (!(objeto.GetType().Equals(typeof(EntidadMunicipio)))) throw new ArgumentException("El parámetro 'objeto' debe ser del tipo " + typeof(EntidadMunicipio).ToString());

            var limite = objeto as EntidadLimiteActividad;

            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "INSERT INTO limite_actividad (codigo_limite_actividad, codigo_actividad, codigo_municipio, codigo_linea_tiempo, cuota_mensual_minima, gasto_maximo) VALUES (@1,@2,@3,@4,@5,@6)";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = limite.CodigoLimiteActividad;
            var param2 = _conexion.CrearParametro("@2", DbType.Int32);
            param2.Value = limite.CodigoActividad;
            var param3 = _conexion.CrearParametro("@3", DbType.Int32);
            param3.Value = limite.CodigoMunicipio;
            var param4 = _conexion.CrearParametro("@4", DbType.Int32);
            param4.Value = limite.CodigoLineaTiempo;

            var param5 = _conexion.CrearParametro("@5", DbType.Double);
            param5.Value = limite.CuotaMensualMinima;
            var param6 = _conexion.CrearParametro("@6", DbType.Double);
            param6.Value = limite.GastoMaximo;

            comando.Parameters.Add(param1);
            comando.Parameters.Add(param2);
            comando.Parameters.Add(param3);
            comando.Parameters.Add(param4);
            comando.Parameters.Add(param5);
            comando.Parameters.Add(param6);                    
           
            comando.ExecuteNonQuery();
            _conexion.CerrarConexion(); 
        }
        public void EliminarElemento(int id)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "DELETE FROM limite_actividad WHERE codigo_limite_actividad = @1";
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
            const string sql = "DELETE FROM limite_actividad";
            comando.CommandText = String.Format(sql);
            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }
        public LinkedList<EntidadAbs> ObtenerTodosLosElementos()
        {
            var listado = new LinkedList<EntidadAbs>();
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM limite_actividad;";
            comando.CommandText = String.Format(sql);
            var lector = comando.ExecuteReader();

            while (lector.Read())
            {
                var CodigoLimiteactividad = lector.GetInt32(lector.GetOrdinal("codigo_limite_actividad"));
                var CodigoActividad = lector.GetInt16(lector.GetOrdinal("codigo_actividad"));
                var codigoMunicipio = lector.GetInt16(lector.GetOrdinal("codigo_municipio"));
                var codigoLineaTiempo = lector.GetInt16(lector.GetOrdinal("codigo_linea_tiempo"));
                var cuotaMensualMinima = lector.GetDouble(lector.GetOrdinal("cuota_mensual"));
                var gastoMaximo = lector.GetDouble(lector.GetOrdinal("gasto_maximo"));
                var miLimite = new EntidadLimiteActividad
                {
                    CodigoLimiteActividad = CodigoLimiteactividad,
                    CodigoActividad = CodigoActividad,
                    CodigoLineaTiempo = codigoLineaTiempo,
                    CodigoMunicipio = codigoMunicipio,
                    CuotaMensualMinima = cuotaMensualMinima,
                    GastoMaximo = gastoMaximo
                };
                listado.AddLast(miLimite);
            }
            lector.Close();
            _conexion.CerrarConexion();
            return listado;
        }
        public EntidadLimiteActividad ObtenerLimiteDeActividad(EntidadLicencia actividad,EntidadMunicipio municipio,EntidadLineaTiempo linea)
        {            
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM limite_actividad WHERE codigo_actividad = @1 AND codigo_municipio = @2 AND codigo_linea_tiempo = @3";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = actividad.CodigoActividad;
           
            var param2 = _conexion.CrearParametro("@2", DbType.Int32);
            param2.Value = municipio.CodigoMunicipio;

            var param3 = _conexion.CrearParametro("@3", DbType.Int32);
            param3.Value = linea.CodigoLineaTiempo;

            comando.Parameters.Add(param1);
            comando.Parameters.Add(param2);
            comando.Parameters.Add(param3);

            var lector = comando.ExecuteReader();

            if (lector.Read())
            {
                var CodigoLimiteactividad = lector.GetInt32(lector.GetOrdinal("codigo_limite_actividad"));
                var CodigoActividad = lector.GetInt16(lector.GetOrdinal("codigo_actividad"));
                var codigoMunicipio = lector.GetInt16(lector.GetOrdinal("codigo_municipio"));
                var codigoLineaTiempo = lector.GetInt16(lector.GetOrdinal("codigo_linea_tiempo"));
                var cuotaMensualMinima = lector.GetDouble(lector.GetOrdinal("cuota_mensual"));
                var gastoMaximo = lector.GetDouble(lector.GetOrdinal("gasto_maximo"));
                var miLimite = new EntidadLimiteActividad
                {
                    CodigoLimiteActividad = CodigoLimiteactividad,
                    CodigoActividad = CodigoActividad,
                    CodigoLineaTiempo = codigoLineaTiempo,
                    CodigoMunicipio = codigoMunicipio,
                    CuotaMensualMinima = cuotaMensualMinima,
                    GastoMaximo = gastoMaximo
                };
                return miLimite;
            }
            lector.Close();
            _conexion.CerrarConexion();
            throw new EErrorEnAccesoDatosObjetoNoEncontrado("No se encontró el límite para la actividad: " + actividad.Nombre + " y el municipio: " + municipio.Nombre);
        }
        private bool ExisteLimiteActividadEnMunicipioPrivado(EntidadLimiteActividad limitePatente,EntidadMunicipio municipio,EntidadLineaTiempo linea)
        {           
            var comando = _conexion.CrearComando();
            const string sql = "SELECT * FROM limite_actividad WHERE codigo_actividad = @1 AND codigo_municipio = @2 AND codigo_linea_tiempo = @3";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = limitePatente.CodigoActividad;
           
            var param2 = _conexion.CrearParametro("@2", DbType.Int32);
            param2.Value = municipio.CodigoMunicipio;

            var param3 = _conexion.CrearParametro("@3", DbType.Int32);
            param3.Value = linea.CodigoLineaTiempo;

            comando.Parameters.Add(param1);
            comando.Parameters.Add(param2);
            comando.Parameters.Add(param3);

            var lector = comando.ExecuteReader();

            if (lector.Read())
            {
                lector.Close();
                return true;
            }
            lector.Close();
            return false;
           
        }                       
        public void AdicionarActualizarLimiteActividadTodasLasProvinciasEnInstanteLineaTiempo(EntidadLimiteActividad nuevolimite, EntidadLineaTiempo linea)
        {  
            LinkedList<EntidadAbs> Municipios = new DaoMunicipio().ObtenerTodosLosElementos();
            _conexion.AbrirConexion();
            foreach (EntidadMunicipio em in Municipios)
            {                
                var comando = _conexion.CrearComando();
                if (ExisteLimiteActividadEnMunicipioPrivado(nuevolimite, em, linea))
                {
                    const string sql = "UPDATE limite_actividad SET cuota_mensual_minima = @1, gasto_maximo = @2 WHERE codigo_actividad = @3 AND codigo_municipio = @4 AND codigo_linea_tiempo =@5";
                    comando.CommandText = String.Format(sql);
                    var param1 = _conexion.CrearParametro("@1", DbType.Double);
                    param1.Value = nuevolimite.CuotaMensualMinima;
                    var param2= _conexion.CrearParametro("@2", DbType.Double);
                    param2.Value = nuevolimite.GastoMaximo;
                    var param3 = _conexion.CrearParametro("@3", DbType.Int16);
                    param3.Value = nuevolimite.CodigoActividad;
                    var param4 = _conexion.CrearParametro("@4", DbType.Int16);
                    param4.Value = em.CodigoMunicipio;
                    var param5 = _conexion.CrearParametro("@5", DbType.Int32);
                    param5.Value = linea.CodigoLineaTiempo;

                    comando.Parameters.Add(param1);
                    comando.Parameters.Add(param2);
                    comando.Parameters.Add(param3);
                    comando.Parameters.Add(param4);
                    comando.Parameters.Add(param5);                    
                }
                else
                {
                    const string sql = "INSERT INTO limite_actividad (codigo_limite_actividad,codigo_actividad,codigo_municipio,codigo_linea_tiempo,cuota_mensual_minima, gasto_maximo) VALUES (@1,@2,@3,@4,@5,@6)";
                    comando.CommandText = String.Format(sql);
                    var param1 = _conexion.CrearParametro("@1", DbType.Int32);
                    param1.Value = ObtenerProximoCodigoLimiteActividadPrivado();
                    var param2 = _conexion.CrearParametro("@2", DbType.Int32);
                    param2.Value = nuevolimite.CodigoActividad;
                    var param3 = _conexion.CrearParametro("@3", DbType.Int32);
                    param3.Value = em.CodigoMunicipio;
                    var param4 = _conexion.CrearParametro("@4", DbType.Int32);
                    param4.Value = linea.CodigoLineaTiempo;
                    var param5 = _conexion.CrearParametro("@5", DbType.Double);
                    param5.Value = nuevolimite.CuotaMensualMinima;
                    var param6 = _conexion.CrearParametro("@6", DbType.Double);
                    param6.Value = nuevolimite.GastoMaximo;

                    comando.Parameters.Add(param1);
                    comando.Parameters.Add(param2);
                    comando.Parameters.Add(param3);
                    comando.Parameters.Add(param4);
                    comando.Parameters.Add(param5);
                    comando.Parameters.Add(param6);                                      
                }               
                comando.ExecuteNonQuery();
          }
          _conexion.CerrarConexion();  
        }                    
        public void AdicionarActualizarLimiteActividadTodosLosMunicipiosDeUnaProvinciaEnInstanteLineaTiempo(EntidadLimiteActividad nuevolimite, EntidadProvincia provincia, EntidadLineaTiempo linea)
        {  
            LinkedList<EntidadMunicipio> Municipios = new DaoMunicipio().ObtenerTodosLosMunicipios(provincia.CodigoProvincia);
            _conexion.AbrirConexion();
            foreach (EntidadMunicipio em in Municipios)
            {
                var comando = _conexion.CrearComando();
                if (ExisteLimiteActividadEnMunicipioPrivado(nuevolimite, em, linea))
                {
                    const string sql = "UPDATE limite_actividad SET cuota_mensual_minima = @1, gasto_maximo = @2 WHERE codigo_actividad = @3 AND codigo_municipio = @4 AND codigo_linea_tiempo =@5";
                    comando.CommandText = String.Format(sql);
                    var param1 = _conexion.CrearParametro("@1", DbType.Double);
                    param1.Value = nuevolimite.CuotaMensualMinima;
                    var param2 = _conexion.CrearParametro("@2", DbType.Double);
                    param2.Value = nuevolimite.GastoMaximo;
                    var param3 = _conexion.CrearParametro("@3", DbType.Int16);
                    param3.Value = nuevolimite.CodigoActividad;
                    var param4 = _conexion.CrearParametro("@4", DbType.Int16);
                    param4.Value = em.CodigoMunicipio;
                    var param5 = _conexion.CrearParametro("@5", DbType.Int32);
                    param5.Value = linea.CodigoLineaTiempo;

                    comando.Parameters.Add(param1);
                    comando.Parameters.Add(param2);
                    comando.Parameters.Add(param3);
                    comando.Parameters.Add(param4);
                    comando.Parameters.Add(param5); 
                }
                else
                {
                    const string sql = "INSERT INTO limite_actividad (codigo_limite_actividad,codigo_actividad,codigo_municipio,codigo_linea_tiempo,cuota_mensual_minima, gasto_maximo) VALUES (@1,@2,@3,@4,@5,@6)";
                    comando.CommandText = String.Format(sql);
                    var param1 = _conexion.CrearParametro("@1", DbType.Int32);
                    param1.Value = ObtenerProximoCodigoLimiteActividadPrivado();
                    var param2 = _conexion.CrearParametro("@2", DbType.Int32);
                    param2.Value = nuevolimite.CodigoActividad;
                    var param3 = _conexion.CrearParametro("@3", DbType.Int32);
                    param3.Value = em.CodigoMunicipio;
                    var param4 = _conexion.CrearParametro("@4", DbType.Int32);
                    param4.Value = linea.CodigoLineaTiempo;
                    var param5 = _conexion.CrearParametro("@5", DbType.Double);
                    param5.Value = nuevolimite.CuotaMensualMinima;
                    var param6 = _conexion.CrearParametro("@6", DbType.Double);
                    param6.Value = nuevolimite.GastoMaximo;

                    comando.Parameters.Add(param1);
                    comando.Parameters.Add(param2);
                    comando.Parameters.Add(param3);
                    comando.Parameters.Add(param4);
                    comando.Parameters.Add(param5);
                    comando.Parameters.Add(param6); 
                }
                comando.ExecuteNonQuery();                
            }
            _conexion.CerrarConexion();
        }       
        public void AdicionarActualizarLimiteActividadUnMunicipioEnInstanteLineaTiempo(EntidadLimiteActividad nuevolimite, EntidadMunicipio municipio, EntidadLineaTiempo linea)
        {  
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();
            if (ExisteLimiteActividadEnMunicipioPrivado(nuevolimite, municipio, linea))
            {
                const string sql = "UPDATE limite_actividad SET cuota_mensual_minima = @1, gasto_maximo = @2 WHERE codigo_actividad = @3 AND codigo_municipio = @4 AND codigo_linea_tiempo =@5";
                comando.CommandText = String.Format(sql);
                var param1 = _conexion.CrearParametro("@1", DbType.Double);
                param1.Value = nuevolimite.CuotaMensualMinima;
                var param2 = _conexion.CrearParametro("@2", DbType.Double);
                param2.Value = nuevolimite.GastoMaximo;
                var param3 = _conexion.CrearParametro("@3", DbType.Int16);
                param3.Value = nuevolimite.CodigoActividad;
                var param4 = _conexion.CrearParametro("@4", DbType.Int16);
                param4.Value = municipio.CodigoMunicipio;
                var param5 = _conexion.CrearParametro("@5", DbType.Int32);
                param5.Value = linea.CodigoLineaTiempo;

                comando.Parameters.Add(param1);
                comando.Parameters.Add(param2);
                comando.Parameters.Add(param3);
                comando.Parameters.Add(param4);
                comando.Parameters.Add(param5); 
            }
            else
            {
                const string sql = "INSERT INTO limite_actividad (codigo_limite_actividad,codigo_actividad,codigo_municipio,codigo_linea_tiempo,cuota_mensual_minima, gasto_maximo) VALUES (@1,@2,@3,@4,@5,@6)";
                comando.CommandText = String.Format(sql);
                var param1 = _conexion.CrearParametro("@1", DbType.Int32);
                param1.Value = ObtenerProximoCodigoLimiteActividadPrivado();
                var param2 = _conexion.CrearParametro("@2", DbType.Int32);
                param2.Value = nuevolimite.CodigoActividad;
                var param3 = _conexion.CrearParametro("@3", DbType.Int32);
                param3.Value = municipio.CodigoMunicipio;
                var param4 = _conexion.CrearParametro("@4", DbType.Int32);
                param4.Value = linea.CodigoLineaTiempo;
                var param5 = _conexion.CrearParametro("@5", DbType.Double);
                param5.Value = nuevolimite.CuotaMensualMinima;
                var param6 = _conexion.CrearParametro("@6", DbType.Double);
                param6.Value = nuevolimite.GastoMaximo;

                comando.Parameters.Add(param1);
                comando.Parameters.Add(param2);
                comando.Parameters.Add(param3);
                comando.Parameters.Add(param4);
                comando.Parameters.Add(param5);
                comando.Parameters.Add(param6); 
            }          
            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
       }        
    }
}
