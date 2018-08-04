using Agenda.ModeloDatos.Entidades;
using Agenda.ModuloExc.Excepciones;
using System;
using System.Collections.Generic;
using System.Data;

namespace Agenda.ModeloDatos.Dao
{
    public class DaoEscalaProgresiva : DaoAbs, InterfazAcceso
    {        
        public bool ExisteElemento(int id)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM escala_progresiva WHERE codigo_escala_progresiva = @1";
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

            const string sql = "SELECT * FROM escala_progresiva INNER JOIN linea_tiempo_año ON escala_progresiva.codigo_linea_tiempo_año = linea_tiempo_año.codigo_linea_tiempo_año WHERE codigo_escala_progresiva = @1";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = id;
            comando.Parameters.Add(param1);

            var lector = comando.ExecuteReader();

            if (lector.Read())
            {
                var codigoEscalaProgresiva = lector.GetInt16(lector.GetOrdinal("codigo_escala_progresiva"));
                var codigoLineaTiempoAño = lector.GetInt16(lector.GetOrdinal("codigo_linea_tiempo_año"));
                var año = lector.GetInt16(lector.GetOrdinal("año"));
                var desde = lector.GetFloat(lector.GetOrdinal("desde"));
                var hasta = lector.GetFloat(lector.GetOrdinal("hasta"));
                var porciento = lector.GetFloat(lector.GetOrdinal("porciento"));


                var miEscala = new EntidadEscala { CodigoEscala = codigoEscalaProgresiva,CodigoLineaTiempoAño = codigoLineaTiempoAño, Año = año, Desde = desde, Hasta = hasta, Porciento = porciento };
                lector.Close();
                _conexion.CerrarConexion();
                return miEscala;
            }
            lector.Close();
            _conexion.CerrarConexion();
            throw new EErrorEnAccesoDatosObjetoNoEncontrado("La actividad no pudo ser encontrada");
        }
        public short ObtenerProximoCodigoEscala()
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT MAX(escala_progresiva.codigo_escala_progresiva) as maxcodigo FROM escala_progresiva";
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
            if (!(objeto.GetType() == typeof(EntidadEscala))) throw new ArgumentException("El parámetro 'objeto' debe ser del tipo " + typeof(EntidadEscala).ToString());

            var escala = objeto as EntidadEscala;

            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "UPDATE escala_progresiva SET codigo_escala_progresiva = @1,codigo_linea_tiempo_año  = @2, desde = @3,hasta = @4, porciento = @5 WHERE codigo_escala_progresiva = @6";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = escala.CodigoEscala;
            var param2 = _conexion.CrearParametro("@2", DbType.Int32);
            param2.Value = escala.CodigoLineaTiempoAño;
            var param3 = _conexion.CrearParametro("@3", DbType.Double);
            param3.Value = escala.Desde;
            var param4 = _conexion.CrearParametro("@4", DbType.Double);
            param4.Value = escala.Hasta;
            var param5 = _conexion.CrearParametro("@5", DbType.Double);
            param5.Value = escala.Porciento;
            var param6= _conexion.CrearParametro("@6", DbType.Int32);
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
            if (!(objeto.GetType() == typeof(EntidadEscala))) throw new ArgumentException("El parámetro 'objeto' debe ser del tipo " + typeof(EntidadEscala).ToString());

            var escala = objeto as EntidadEscala;

            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "INSERT INTO escala_progresiva (codigo_escala_progresiva,codigo_linea_tiempo_año,desde,hasta,porciento) VALUES (@1,@2,@3,@4,@5)";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = escala.CodigoEscala;
            var param2 = _conexion.CrearParametro("@2", DbType.Int32);
            param2.Value = escala.CodigoLineaTiempoAño;
            var param3 = _conexion.CrearParametro("@3", DbType.Double);
            param3.Value = escala.Desde;
            var param4 = _conexion.CrearParametro("@4", DbType.Double);
            param4.Value = escala.Hasta;
            var param5 = _conexion.CrearParametro("@5", DbType.Double);
            param5.Value = escala.Porciento;

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

            const string sql = "DELETE FROM escala_progresiva WHERE codigo_escala_progresiva = @1";
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

            const string sql = "DELETE FROM escala_progresiva";
            comando.CommandText = String.Format(sql);

            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }
        public LinkedList<EntidadAbs> ObtenerTodosLosElementos()
        {
            var listado = new LinkedList<EntidadAbs>();
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();
            const string sql = "SELECT * FROM escala_progresiva INNER JOIN linea_tiempo_año ON escala_progresiva.codigo_linea_tiempo_año = linea_tiempo_año.codigo_linea_tiempo_año ORDER BY desde ASC;";
            comando.CommandText = String.Format(sql);
            var lector = comando.ExecuteReader();
            while (lector.Read())
            {
                var codigoEscalaProgresiva = lector.GetInt16(lector.GetOrdinal("codigo_escala_progresiva"));
                var codigoLineaTiempoAño = lector.GetInt16(lector.GetOrdinal("codigo_linea_tiempo_año"));
                var año = lector.GetInt16(lector.GetOrdinal("año"));
                var desde = lector.GetDouble(lector.GetOrdinal("desde"));
                var hasta = lector.GetDouble(lector.GetOrdinal("hasta"));
                var porciento = lector.GetDouble(lector.GetOrdinal("porciento"));
                var miEscala = new EntidadEscala { CodigoEscala = codigoEscalaProgresiva, CodigoLineaTiempoAño = codigoLineaTiempoAño, Año=año, Desde = desde, Hasta = hasta, Porciento = porciento };
                listado.AddLast(miEscala);
            }
            lector.Close();
            _conexion.CerrarConexion();
            return listado;
        }
        public LinkedList<EntidadEscala> ObtenerTodosLasEscalasDeCodigoLineaTiempoAño(int pcodigoLineaTiempoAño)
        {
            var listado = new LinkedList<EntidadEscala>();
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();
            const string sql = "SELECT * FROM escala_progresiva INNER JOIN linea_tiempo_año ON escala_progresiva.codigo_linea_tiempo_año = linea_tiempo_año.codigo_linea_tiempo_año WHERE linea_tiempo_año.codigo_linea_tiempo_año = @1 ORDER BY desde ASC;";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = pcodigoLineaTiempoAño;
            comando.Parameters.Add(param1);

            var lector = comando.ExecuteReader();
            while (lector.Read())
            {
                var codigoEscalaProgresiva = lector.GetInt16(lector.GetOrdinal("codigo_escala_progresiva"));
                var año = lector.GetInt16(lector.GetOrdinal("año"));
                var codigoLineaTiempoAño = lector.GetInt16(lector.GetOrdinal("codigo_linea_tiempo_año"));
                var desde = lector.GetDouble(lector.GetOrdinal("desde"));
                var hasta = lector.GetDouble(lector.GetOrdinal("hasta"));
                var porciento = lector.GetDouble(lector.GetOrdinal("porciento"));
                var miEscala = new EntidadEscala { CodigoEscala = codigoEscalaProgresiva,CodigoLineaTiempoAño = codigoLineaTiempoAño, Año = año, Desde = desde, Hasta = hasta, Porciento = porciento };
                listado.AddLast(miEscala);
            }
            lector.Close();
            _conexion.CerrarConexion();
            return listado;
        }
        public LinkedList<EntidadLineaTiempoAño> ObtenerTodosLosAños()
        {
            var listado = new LinkedList<EntidadLineaTiempoAño>();
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();
            const string sql = "SELECT codigo_linea_tiempo_año,año FROM escala_progresiva INNER JOIN linea_tiempo_año ON escala_progresiva.codigo_linea_tiempo_año = linea_tiempo_año.codigo_linea_tiempo_año GROUP BY  codigo_linea_tiempo_año,año ORDER BY año ASC;";
            comando.CommandText = String.Format(sql);
            var lector = comando.ExecuteReader();
            while (lector.Read())
            {
                var año = lector.GetInt16(lector.GetOrdinal("año"));
                var codigoLineaTiempoAño = lector.GetInt16(lector.GetOrdinal("codigo_linea_tiempo_año"));
                var miAño = new EntidadLineaTiempoAño {CodigoLineaTiempoAño= codigoLineaTiempoAño, Año = año };
                listado.AddLast(miAño);
            }
            lector.Close();
            _conexion.CerrarConexion();
            return listado;
        }
        public bool ExisteRangoDesdeEscalaNuevaIgualRangoDesdeEscalaExistente(EntidadEscala escalaNueva)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM escala_progresiva INNER JOIN linea_tiempo_año ON escala_progresiva.codigo_linea_tiempo_año = linea_tiempo_año.codigo_linea_tiempo_año WHERE desde = @1 AND codigo_escala_progresiva <> @2 AND linea_tiempo_año.año = @3";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Double);
            param1.Value = escalaNueva.Desde;
            comando.Parameters.Add(param1);

            var param2 = _conexion.CrearParametro("@2", DbType.Int32);
            param2.Value = escalaNueva.CodigoEscala;
            comando.Parameters.Add(param2);

            var param3 = _conexion.CrearParametro("@3", DbType.Int32);
            param3.Value = escalaNueva.Año;
            comando.Parameters.Add(param3);

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
        public bool ExisteRangoHastaEscalaNuevaIgualRangoHastaEscalaExistente(EntidadEscala escalaNueva)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM escala_progresiva INNER JOIN linea_tiempo_año ON escala_progresiva.codigo_linea_tiempo_año = linea_tiempo_año.codigo_linea_tiempo_año WHERE hasta = @1 AND codigo_escala_progresiva <> @2  AND linea_tiempo_año.año = @3";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Double);
            param1.Value = escalaNueva.Hasta;
            comando.Parameters.Add(param1);

            var param2 = _conexion.CrearParametro("@2", DbType.Int32);
            param2.Value = escalaNueva.CodigoEscala;
            comando.Parameters.Add(param2);

            var param3 = _conexion.CrearParametro("@3", DbType.Int32);
            param3.Value = escalaNueva.Año;
            comando.Parameters.Add(param3);

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
        public bool ExisteRangoDesdeEscalaNuevaIgualRangoHastaEscalaExistente(EntidadEscala escalaNueva)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM escala_progresiva INNER JOIN linea_tiempo_año ON escala_progresiva.codigo_linea_tiempo_año = linea_tiempo_año.codigo_linea_tiempo_año WHERE hasta = @1 AND codigo_escala_progresiva <> @2   AND linea_tiempo_año.año = @3";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Double);
            param1.Value = escalaNueva.Desde;
            comando.Parameters.Add(param1);

            var param2 = _conexion.CrearParametro("@2", DbType.Int32);
            param2.Value = escalaNueva.CodigoEscala;
            comando.Parameters.Add(param2);

            var param3 = _conexion.CrearParametro("@3", DbType.Int32);
            param3.Value = escalaNueva.Año;
            comando.Parameters.Add(param3);

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
        public bool ExisteRangoHastaEscalaNuevaIgualRangoDesdeEscalaExistente(EntidadEscala escalaNueva)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM escala_progresiva INNER JOIN linea_tiempo_año ON escala_progresiva.codigo_linea_tiempo_año = linea_tiempo_año.codigo_linea_tiempo_año WHERE desde = @1 AND codigo_escala_progresiva <> @2 AND linea_tiempo_año.año = @3";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Double);
            param1.Value = escalaNueva.Hasta;
            comando.Parameters.Add(param1);

            var param2 = _conexion.CrearParametro("@2", DbType.Int32);
            param2.Value = escalaNueva.CodigoEscala;
            comando.Parameters.Add(param2);

            var param3 = _conexion.CrearParametro("@3", DbType.Int32);
            param3.Value = escalaNueva.Año;
            comando.Parameters.Add(param3);

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
        public bool ExisteRangoHastaEscalaNuevaDentroRangoEscalaExistente(EntidadEscala escalaNueva)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM escala_progresiva INNER JOIN linea_tiempo_año ON escala_progresiva.codigo_linea_tiempo_año = linea_tiempo_año.codigo_linea_tiempo_año WHERE desde < @1 AND hasta > @1 AND codigo_escala_progresiva <> @2 AND linea_tiempo_año.año = @3";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Double);
            param1.Value = escalaNueva.Hasta;
            comando.Parameters.Add(param1);

            var param2 = _conexion.CrearParametro("@2", DbType.Int32);
            param2.Value = escalaNueva.CodigoEscala;
            comando.Parameters.Add(param2);

            var param3 = _conexion.CrearParametro("@3", DbType.Int32);
            param3.Value = escalaNueva.Año;
            comando.Parameters.Add(param3);

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
        public bool ExisteRangoDesdeEscalaNuevaDentroRangoEscalaExistente(EntidadEscala escalaNueva)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM escala_progresiva INNER JOIN linea_tiempo_año ON escala_progresiva.codigo_linea_tiempo_año = linea_tiempo_año.codigo_linea_tiempo_año WHERE @1 > desde AND @1 < hasta AND codigo_escala_progresiva <> @2  AND linea_tiempo_año.año = @3";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Double);
            param1.Value = escalaNueva.Desde;
            comando.Parameters.Add(param1);

            var param2 = _conexion.CrearParametro("@2", DbType.Int32);
            param2.Value = escalaNueva.CodigoEscala;
            comando.Parameters.Add(param2);

            var param3 = _conexion.CrearParametro("@3", DbType.Int32);
            param3.Value = escalaNueva.Año;
            comando.Parameters.Add(param3);

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
        public bool ExisteRangoEscalaNuevaDentroRangoEscalaExistente(EntidadEscala escalaNueva)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM escala_progresiva INNER JOIN linea_tiempo_año ON escala_progresiva.codigo_linea_tiempo_año = linea_tiempo_año.codigo_linea_tiempo_año WHERE @1 > desde AND @2 < hasta AND codigo_escala_progresiva <> @3 AND linea_tiempo_año.año = @4";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Double);
            param1.Value = escalaNueva.Desde;            

            var param2 = _conexion.CrearParametro("@2", DbType.Double);
            param2.Value = escalaNueva.Hasta;

            var param3 = _conexion.CrearParametro("@3", DbType.Int32);
            param3.Value = escalaNueva.CodigoEscala;

            var param4 = _conexion.CrearParametro("@4", DbType.Int32);
            param4.Value = escalaNueva.Año;
            comando.Parameters.Add(param4);

            comando.Parameters.Add(param1);
            comando.Parameters.Add(param2);
            comando.Parameters.Add(param3);

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
    }
}
