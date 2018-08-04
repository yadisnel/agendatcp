using System;
using System.Data;
using System.Collections.Generic;
using Agenda.ModuloExc.Excepciones;
using Agenda.ModeloDatos.Entidades;
using System.Data.Common;

namespace Agenda.ModeloDatos.Dao
{
    public class DaoVenta : DaoAbs, InterfazAcceso
    {
        public bool ExisteElemento(int id)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM d_ingreso WHERE  codigo_ingreso = @1;";
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
        public bool ContieneVentas(int codigoLicencia)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM venta WHERE  codigo_licencia = @1;";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = codigoLicencia;
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

            const string sql = "SELECT * FROM venta WHERE codigo_venta = @1";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = id;

            comando.Parameters.Add(param1);

            var lector = comando.ExecuteReader();

            if (lector.Read())
            {
                var codigoVenta = lector.GetInt32(lector.GetOrdinal("codigo_venta"));
                var codigoProducto = lector.GetInt16(lector.GetOrdinal("codigo_producto"));
                var codigoLicencia = lector.GetInt16(lector.GetOrdinal("codigo_licencia"));
                var cantidadUnidades = lector.GetInt16(lector.GetOrdinal("cantidad_unidades"));
                var fechaRegistro = lector.GetDateTime(lector.GetOrdinal("fecha_registro"));
                var descripcion = lector.GetString(lector.GetOrdinal("descripcion"));

                var miVenta = new EntidadVentaConImporte
                {
                    CodigoVenta = codigoVenta,
                    CodigoProducto = codigoProducto,
                    CodigoLicencia = codigoLicencia,
                    CantidadUnidades = cantidadUnidades,
                    FechaRegistro = fechaRegistro,
                    Descripcion = descripcion                    
                };
                return miVenta;
            }
            lector.Close();
            _conexion.CerrarConexion();
            throw new EErrorEnAccesoDatosObjetoNoEncontrado("El objeto no pudo ser encontrado");
        }     
        public void ActualizarElemento(int id, EntidadAbs objeto)
        {           
            if (objeto == null) throw new ArgumentNullException("El parámetro 'objeto' no puede ser nulo.");
            if (!(objeto.GetType() == typeof(EntidadVentaConImporte))) throw new ArgumentException("El parámetro 'objeto' debe ser del tipo " + typeof(EntidadVentaConImporte));

            var venta = objeto as EntidadVentaConImporte;
           
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "UPDATE venta SET codigo_venta = @1,codigo_producto = @2,codigo_licencia = @3,cantidad_unidades = @4,fecha_registro = @5,descripcion = @6 WHERE  codigo_venta = @7";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = venta.CodigoVenta;
            var param2 = _conexion.CrearParametro("@2", DbType.Int32);
            param2.Value = venta.CodigoProducto;
            var param3 = _conexion.CrearParametro("@3", DbType.Int32);
            param3.Value = venta.CodigoLicencia;
            var param4 = _conexion.CrearParametro("@4", DbType.Int32);
            param4.Value = venta.CantidadUnidades;
            var param5 = _conexion.CrearParametro("@5", DbType.DateTime);
            param5.Value = venta.FechaRegistro;
            var param6 = _conexion.CrearParametro("@6", DbType.String);
            param6.Value = venta.Descripcion;
            var param7 = _conexion.CrearParametro("@7", DbType.Int32);
            param7.Value = id;

            comando.Parameters.Add(param1);
            comando.Parameters.Add(param2);
            comando.Parameters.Add(param3);
            comando.Parameters.Add(param4);
            comando.Parameters.Add(param5);
            comando.Parameters.Add(param6);
            comando.Parameters.Add(param7);  

            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }
        public void AdicionarNuevoElemento(EntidadAbs objeto)
        {   
            if (objeto == null) throw new ArgumentNullException("El parámetro 'objeto' no puede ser nulo.");
            if (!(objeto.GetType() == typeof(EntidadVentaConImporte))) throw new ArgumentException("El parámetro 'objeto' debe ser del tipo " + typeof(EntidadVentaConImporte));

            var venta = objeto as EntidadVentaConImporte;

            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "INSERT INTO  venta (codigo_venta,codigo_producto,codigo_licencia,cantidad_unidades,fecha_registro,descripcion)  VALUES(@1,@2,@3,@4,@5,@6)";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = venta.CodigoVenta;
            var param2 = _conexion.CrearParametro("@2", DbType.Int32);
            param2.Value = venta.CodigoProducto;
            var param3 = _conexion.CrearParametro("@3", DbType.Int32);
            param3.Value = venta.CodigoLicencia;
            var param4 = _conexion.CrearParametro("@4", DbType.Int32);
            param4.Value = venta.CantidadUnidades;       
            var param5 = _conexion.CrearParametro("@5", DbType.DateTime);
            param5.Value = venta.FechaRegistro;
            var param6 = _conexion.CrearParametro("@6", DbType.String);
            param6.Value = venta.Descripcion;           

            comando.Parameters.Add(param1);
            comando.Parameters.Add(param2);
            comando.Parameters.Add(param3);
            comando.Parameters.Add(param4);
            comando.Parameters.Add(param5);
            comando.Parameters.Add(param6);             
           
            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }
        public int ObtenerProximoCodigoVenta()
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT MAX(venta.codigo_venta) as maxcodigo FROM venta;";
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
        public void EliminarElemento(int id)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "DELETE FROM venta WHERE codigo_venta = @1";
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

            const string sql = "DELETE FROM venta";
            comando.CommandText = String.Format(sql);

            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }
        public LinkedList<EntidadAbs> ObtenerTodosLosElementos()
        {
            var todasLasVentas = new LinkedList<EntidadAbs>();
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM venta INNER JOIN producto ON venta.codigo_producto = producto.codigo_producto";
            comando.CommandText = String.Format(sql);          

            var lector = comando.ExecuteReader();

            while (lector.Read())
            {
                var codigoVenta = lector.GetInt32(lector.GetOrdinal("codigo_venta"));
                var codigoProducto = lector.GetInt16(lector.GetOrdinal("codigo_producto"));
                var cantidadUnidades = lector.GetInt16(lector.GetOrdinal("cantidad_unidades"));
                var codigoLicencia = lector.GetInt16(lector.GetOrdinal("codigo_licencia"));
                var importe = lector.GetInt32(lector.GetOrdinal("precio")); 
                var fechaRegistro = lector.GetDateTime(lector.GetOrdinal("fecha_registro"));
                var descripcion = lector.GetString(lector.GetOrdinal("descripcion"));

                var miVenta = new EntidadVentaConImporte
                {
                    CodigoVenta = codigoVenta,
                    CodigoProducto = codigoProducto,
                    CantidadUnidades = cantidadUnidades, 
                    Importe = importe,
                    CodigoLicencia = codigoLicencia,
                    FechaRegistro = fechaRegistro,
                    Descripcion = descripcion
                };
                todasLasVentas.AddLast(miVenta);             
            }
            lector.Close();
            _conexion.CerrarConexion();
            return todasLasVentas;
        }
        public LinkedList<EntidadVentaConImporte> ObtenerTodasLasVentasDeLicencia(EntidadLicencia licencia)
        {
            _conexion.AbrirConexion();
            var listado = new LinkedList<EntidadVentaConImporte>();
            DbDataReader lector;
            using (var comando = _conexion.CrearComando())
            {
                const string sql = "SELECT *  FROM venta INNER JOIN producto ON venta.codigo_producto = producto.codigo_producto WHERE codigo_licencia = @1;";
                comando.CommandText = String.Format(sql);
                var param1 = _conexion.CrearParametro("@1", DbType.Int32);
                param1.Value = licencia.CodigoLicencia;
                comando.Parameters.Add(param1);
                lector = comando.ExecuteReader();
            }
            while (lector.Read())
            {
                var codigoVenta = lector.GetInt32(lector.GetOrdinal("codigo_venta"));
                var codigoProducto = lector.GetInt16(lector.GetOrdinal("codigo_producto"));
                var cantidadUnidades = lector.GetInt16(lector.GetOrdinal("cantidad_unidades"));
                var codigoLicencia = lector.GetInt16(lector.GetOrdinal("codigo_licencia"));
                var fechaRegistro = lector.GetDateTime(lector.GetOrdinal("fecha_registro"));
                var descripcion = lector.GetString(lector.GetOrdinal("descripcion"));

                var miVenta = new EntidadVentaConImporte
                {
                    CodigoVenta = codigoVenta,
                    CodigoProducto = codigoProducto,
                    CantidadUnidades = cantidadUnidades,
                    CodigoLicencia = codigoLicencia,
                    FechaRegistro = fechaRegistro,
                    Descripcion = descripcion
                };
                listado.AddLast(miVenta);
            }
            lector.Close();
            _conexion.CerrarConexion();
            return listado;
        }
        public LinkedList<EntidadVentaConImporte> ObtenerTodasLasVentasConImporteDeLicencia(EntidadLicencia Licencia)
        {
            _conexion.AbrirConexion();
            var listado = new LinkedList<EntidadVentaConImporte>();
            DbDataReader lector;
            using (var comando = _conexion.CrearComando())
            {
                const string sql = "SELECT *  FROM venta INNER JOIN producto ON venta.codigo_producto = producto.codigo_producto  WHERE codigo_licencia = @1;";
                comando.CommandText = String.Format(sql);
                var param1 = _conexion.CrearParametro("@1", DbType.Int32);
                param1.Value = Licencia.CodigoLicencia;
                comando.Parameters.Add(param1);
                lector = comando.ExecuteReader();
            }
            while (lector.Read())
            {
                var codigoVenta = lector.GetInt32(lector.GetOrdinal("codigo_venta"));
                var codigoProducto = lector.GetInt16(lector.GetOrdinal("codigo_producto"));
                var cantidadUnidades = lector.GetInt16(lector.GetOrdinal("cantidad_unidades"));
                var codigoLicencia = lector.GetInt16(lector.GetOrdinal("codigo_licencia"));
                var importe = lector.GetDouble(lector.GetOrdinal("precio"));
                var nombreProducto = lector.GetString(lector.GetOrdinal("nombre"));
                var fechaRegistro = lector.GetDateTime(lector.GetOrdinal("fecha_registro"));
                var descripcion = lector.GetString(lector.GetOrdinal("descripcion"));

                var miVentaConImporte = new EntidadVentaConImporte
                {
                    CodigoVenta = codigoVenta,
                    CodigoProducto = codigoProducto,
                    CantidadUnidades = cantidadUnidades,
                    CodigoLicencia = codigoLicencia,
                    Importe = importe,
                    NombreProducto  = nombreProducto,
                    FechaRegistro = fechaRegistro,
                    Descripcion = descripcion
                };
                listado.AddLast(miVentaConImporte);
            }
            lector.Close();
            _conexion.CerrarConexion();
            return listado;
        }
        public LinkedList<EntidadVentaConImporte> ObtenerTodasLasVentasConImporte()
        {
            _conexion.AbrirConexion();
            var listado = new LinkedList<EntidadVentaConImporte>();
            DbDataReader lector;
            using (var comando = _conexion.CrearComando())
            {
                const string sql = "SELECT *  FROM venta INNER JOIN producto ON venta.codigo_producto = producto.codigo_producto;";
                comando.CommandText = String.Format(sql);              
                lector = comando.ExecuteReader();
            }
            while (lector.Read())
            {
                var codigoVenta = lector.GetInt32(lector.GetOrdinal("codigo_venta"));
                var codigoProducto = lector.GetInt16(lector.GetOrdinal("codigo_producto"));
                var cantidadUnidades = lector.GetInt16(lector.GetOrdinal("cantidad_unidades"));
                var codigoLicencia = lector.GetInt16(lector.GetOrdinal("codigo_licencia"));
                var importe = lector.GetInt32(lector.GetOrdinal("precio"));
                var fechaRegistro = lector.GetDateTime(lector.GetOrdinal("fecha_registro"));
                var descripcion = lector.GetString(lector.GetOrdinal("descripcion"));

                var miVentaConImporte = new EntidadVentaConImporte
                {
                    CodigoVenta = codigoVenta,
                    CodigoProducto = codigoProducto,
                    CantidadUnidades = cantidadUnidades,
                    CodigoLicencia = codigoLicencia,
                    Importe = importe,
                    FechaRegistro = fechaRegistro,
                    Descripcion = descripcion
                };
                listado.AddLast(miVentaConImporte);
            }
            lector.Close();
            _conexion.CerrarConexion();
            return listado;
        }
        public LinkedList<EntidadVentaConImporte> ObtenerTodasLasVentasConImporteDeLicencia1dia(EntidadLicencia Licencia, DateTime fechaContable)
        {            
            _conexion.AbrirConexion();
            var listado = new LinkedList<EntidadVentaConImporte>();
            DbDataReader lector;
            using (var comando = _conexion.CrearComando())
            {
                const string sql = "SELECT *  FROM venta INNER JOIN producto ON venta.codigo_producto = producto.codigo_producto  WHERE codigo_licencia = @1 AND fecha_registro = @2";
                comando.CommandText = String.Format(sql);
                var param1 = _conexion.CrearParametro("@1", DbType.Int32);
                param1.Value = Licencia.CodigoLicencia;
                comando.Parameters.Add(param1);
                var param2 = _conexion.CrearParametro("@2", DbType.DateTime);
                param2.Value = fechaContable;
                comando.Parameters.Add(param2);                
                lector = comando.ExecuteReader();
            }
            while (lector.Read())
            {
                var codigoVenta = lector.GetInt32(lector.GetOrdinal("codigo_venta"));
                var codigoProducto = lector.GetInt16(lector.GetOrdinal("codigo_producto"));
                var cantidadUnidades = lector.GetInt16(lector.GetOrdinal("cantidad_unidades"));
                var codigoLicencia = lector.GetInt16(lector.GetOrdinal("codigo_licencia"));
                var importe = lector.GetDouble(lector.GetOrdinal("precio"));
                var nombreProducto = lector.GetString(lector.GetOrdinal("nombre"));
                var fechaRegistro = lector.GetDateTime(lector.GetOrdinal("fecha_registro"));
                var descripcion = lector.GetString(lector.GetOrdinal("descripcion"));

                var miVentaConImporte = new EntidadVentaConImporte
                {
                    CodigoVenta = codigoVenta,
                    CodigoProducto = codigoProducto,
                    CantidadUnidades = cantidadUnidades,
                    CodigoLicencia = codigoLicencia,
                    Importe = importe,
                    NombreProducto = nombreProducto,
                    FechaRegistro = fechaRegistro,
                    Descripcion = descripcion
                };
                listado.AddLast(miVentaConImporte);
            }
            lector.Close();
            _conexion.CerrarConexion();
            return listado;
        }
        public LinkedList<EntidadVentaConImporte> ObtenerTodasLasVentasConImporteDeLicenciaUltimosXdias(EntidadLicencia Licencia,DateTime fechaContable,int xDias)
        {
            DateTime fechaMenosXdias = fechaContable.AddDays(xDias);
            _conexion.AbrirConexion();
            var listado = new LinkedList<EntidadVentaConImporte>();
            DbDataReader lector;
            using (var comando = _conexion.CrearComando())
            {
                const string sql = "SELECT *  FROM venta INNER JOIN producto ON venta.codigo_producto = producto.codigo_producto  WHERE codigo_licencia = @1 AND fecha_registro >= @2 AND fecha_registro <= @3";
                comando.CommandText = String.Format(sql);
                var param1 = _conexion.CrearParametro("@1", DbType.Int32);
                param1.Value = Licencia.CodigoLicencia;
                comando.Parameters.Add(param1);
                var param2 = _conexion.CrearParametro("@2", DbType.DateTime);
                param2.Value = fechaMenosXdias;
                comando.Parameters.Add(param2);
                var param3 = _conexion.CrearParametro("@3", DbType.DateTime);
                param3.Value = fechaContable;
                comando.Parameters.Add(param3);
                lector = comando.ExecuteReader();
            }
            while (lector.Read())
            {
                var codigoVenta = lector.GetInt32(lector.GetOrdinal("codigo_venta"));
                var codigoProducto = lector.GetInt16(lector.GetOrdinal("codigo_producto"));
                var cantidadUnidades = lector.GetInt16(lector.GetOrdinal("cantidad_unidades"));
                var codigoLicencia = lector.GetInt16(lector.GetOrdinal("codigo_licencia"));
                var importe = lector.GetDouble(lector.GetOrdinal("precio"));
                var nombreProducto = lector.GetString(lector.GetOrdinal("nombre"));
                var fechaRegistro = lector.GetDateTime(lector.GetOrdinal("fecha_registro"));
                var descripcion = lector.GetString(lector.GetOrdinal("descripcion"));

                var miVentaConImporte = new EntidadVentaConImporte
                {
                    CodigoVenta = codigoVenta,
                    CodigoProducto = codigoProducto,
                    CantidadUnidades = cantidadUnidades,
                    CodigoLicencia = codigoLicencia,
                    Importe = importe,
                    NombreProducto = nombreProducto,
                    FechaRegistro = fechaRegistro,
                    Descripcion = descripcion
                };
                listado.AddLast(miVentaConImporte);
            }
            lector.Close();
            _conexion.CerrarConexion();
            return listado;
        }
        public LinkedList<EntidadVentaConImporte> ObtenerTodasLasVentasConImporteDeLicenciaPeriodo(EntidadLicencia Licencia, DateTime fechaContableDesde, DateTime fechaContableHasta)
        {           
            _conexion.AbrirConexion();
            var listado = new LinkedList<EntidadVentaConImporte>();
            DbDataReader lector;
            using (var comando = _conexion.CrearComando())
            {
                const string sql = "SELECT *  FROM venta INNER JOIN producto ON venta.codigo_producto = producto.codigo_producto  WHERE codigo_licencia = @1 AND fecha_registro >= @2 AND fecha_registro <= @3";
                comando.CommandText = String.Format(sql);
                var param1 = _conexion.CrearParametro("@1", DbType.Int32);
                param1.Value = Licencia.CodigoLicencia;
                comando.Parameters.Add(param1);
                var param2 = _conexion.CrearParametro("@2", DbType.DateTime);
                param2.Value = fechaContableDesde;
                comando.Parameters.Add(param2);
                var param3 = _conexion.CrearParametro("@3", DbType.DateTime);
                param3.Value = fechaContableHasta;
                comando.Parameters.Add(param3);
                lector = comando.ExecuteReader();
            }
            while (lector.Read())
            {
                var codigoVenta = lector.GetInt32(lector.GetOrdinal("codigo_venta"));
                var codigoProducto = lector.GetInt16(lector.GetOrdinal("codigo_producto"));
                var cantidadUnidades = lector.GetInt16(lector.GetOrdinal("cantidad_unidades"));
                var codigoLicencia = lector.GetInt16(lector.GetOrdinal("codigo_licencia"));
                var importe = lector.GetDouble(lector.GetOrdinal("precio"));
                var nombreProducto = lector.GetString(lector.GetOrdinal("nombre"));
                var fechaRegistro = lector.GetDateTime(lector.GetOrdinal("fecha_registro"));
                var descripcion = lector.GetString(lector.GetOrdinal("descripcion"));

                var miVentaConImporte = new EntidadVentaConImporte
                {
                    CodigoVenta = codigoVenta,
                    CodigoProducto = codigoProducto,
                    CantidadUnidades = cantidadUnidades,
                    CodigoLicencia = codigoLicencia,
                    Importe = importe,
                    NombreProducto = nombreProducto,
                    FechaRegistro = fechaRegistro,
                    Descripcion = descripcion
                };
                listado.AddLast(miVentaConImporte);
            }
            lector.Close();
            _conexion.CerrarConexion();
            return listado;
        }

    }
}
