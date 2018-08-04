using System;
using System.Data;
using System.Collections.Generic;
using Agenda.ModuloExc.Excepciones;
using Agenda.ModeloDatos.Entidades;
using System.Data.Common;

namespace Agenda.ModeloDatos.Dao
{
    public class DaoProducto : DaoAbs, InterfazAcceso
    {
        public bool ExisteElemento(int id)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM producto WHERE  codigo_producto = @1;";
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
        public bool ContieneProductos()
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM producto;";
            comando.CommandText = String.Format(sql);            

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
        public bool ExisteProductoConNombreIgualDiferenteCodigo(string pNombreProducto, int pCodigoProducto)
        {
            _conexion.AbrirConexion();
            DbDataReader lector;
            using (var comando = _conexion.CrearComando())
            {
                const string sql = "SELECT *  FROM producto WHERE nombre = @1 AND codigo_producto <> @2;";
                comando.CommandText = String.Format(sql);

                var param1 = _conexion.CrearParametro("@1", DbType.String);
                param1.Value = pNombreProducto;
                var param2 = _conexion.CrearParametro("@2", DbType.Int32);
                param2.Value = pCodigoProducto;               
                comando.Parameters.Add(param1);
                comando.Parameters.Add(param2);               
                lector = comando.ExecuteReader();
            }

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
        public bool ExisteProductoConIgualNombre(string pNombreProducto)
        {
            _conexion.AbrirConexion();
            DbDataReader lector;
            using (var comando = _conexion.CrearComando())
            {
                const string sql = "SELECT *  FROM producto WHERE nombre = @1;";
                comando.CommandText = String.Format(sql);

                var param1 = _conexion.CrearParametro("@1", DbType.String);
                param1.Value = pNombreProducto;
                comando.Parameters.Add(param1);
                lector = comando.ExecuteReader();
            }

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

            const string sql = "SELECT * FROM producto WHERE codigo_producto = @1";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = id;

            comando.Parameters.Add(param1);

            var lector = comando.ExecuteReader();

            if (lector.Read())
            {
                var codigoProducto = lector.GetInt16(lector.GetOrdinal("codigo_producto"));               
                var nombre = lector.GetString(lector.GetOrdinal("nombre"));
                var precio = lector.GetFloat(lector.GetOrdinal("precio"));               
                var descripcion = lector.GetString(lector.GetOrdinal("descripcion"));

                var miProducto = new EntidadProducto
                {
                    CodigoProducto= codigoProducto,                  
                    Nombre = nombre,
                    Precio = precio,                   
                    Descripcion = descripcion                    
                };
                return miProducto;
            }
            lector.Close();
            _conexion.CerrarConexion();
            throw new EErrorEnAccesoDatosObjetoNoEncontrado("El objeto no pudo ser encontrado");
        }     
        public void ActualizarElemento(int id, EntidadAbs objeto)
        {           
            if (objeto == null) throw new ArgumentNullException("El parámetro 'objeto' no puede ser nulo.");
            if (!(objeto.GetType() == typeof(EntidadProducto))) throw new ArgumentException("El parámetro 'objeto' debe ser del tipo " + typeof(EntidadProducto).ToString());

            var producto = objeto as EntidadProducto;
           
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "UPDATE producto SET codigo_producto = @1,nombre = @2,precio = @3,descripcion = @4 WHERE  codigo_producto = @5";
            comando.CommandText = String.Format(sql);
            
            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = producto.CodigoProducto;            
            var param2 = _conexion.CrearParametro("@2", DbType.String);
            param2.Value = producto.Nombre;
            var param3 = _conexion.CrearParametro("@3", DbType.Double);
            param3.Value = producto.Precio;            
            var param4 = _conexion.CrearParametro("@4", DbType.String);
            param4.Value = producto.Descripcion;
            var param5 = _conexion.CrearParametro("@5", DbType.Int32);
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
            if (!(objeto.GetType() == typeof(EntidadProducto))) throw new ArgumentException("El parámetro 'objeto' debe ser del tipo " + typeof(EntidadProducto).ToString());

            var producto = objeto as EntidadProducto;

            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "INSERT INTO  producto (codigo_producto,nombre,precio,descripcion)  VALUES(@1,@2,@3,@4)";
            comando.CommandText = String.Format(sql);

            var param1 = _conexion.CrearParametro("@1", DbType.Int32);
            param1.Value = producto.CodigoProducto;            
            var param2 = _conexion.CrearParametro("@2", DbType.String);
            param2.Value = producto.Nombre;
            var param3 = _conexion.CrearParametro("@3", DbType.Double);
            param3.Value = producto.Precio;           
            var param4 = _conexion.CrearParametro("@4", DbType.String);
            param4.Value = producto.Descripcion;           

            comando.Parameters.Add(param1);
            comando.Parameters.Add(param2);
            comando.Parameters.Add(param3);
            comando.Parameters.Add(param4);
           
            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }
        public short ObtenerProximoCodigoProducto()
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT MAX(producto.codigo_producto) as maxcodigo FROM producto;";
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
            return 1000;
        }
        public void EliminarElemento(int id)
        {
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "DELETE FROM producto WHERE codigo_producto = @1";
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

            const string sql = "DELETE FROM producto";
            comando.CommandText = String.Format(sql);

            comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }
        public LinkedList<EntidadAbs> ObtenerTodosLosElementos()
        {
            var todosLosProductos = new LinkedList<EntidadAbs>();
            _conexion.AbrirConexion();
            var comando = _conexion.CrearComando();

            const string sql = "SELECT * FROM producto";
            comando.CommandText = String.Format(sql);          

            var lector = comando.ExecuteReader();

            while (lector.Read())
            {
                var codigoProducto = lector.GetInt16(lector.GetOrdinal("codigo_producto"));               
                var nombre = lector.GetString(lector.GetOrdinal("nombre"));
                var precio = lector.GetDouble(lector.GetOrdinal("precio"));              
                var descripcion = lector.GetString(lector.GetOrdinal("descripcion"));

                var miProducto = new EntidadProducto
                {
                    CodigoProducto = codigoProducto,                    
                    Nombre = nombre,
                    Precio = precio,                    
                    Descripcion = descripcion
                };
                todosLosProductos.AddLast(miProducto);             
            }
            lector.Close();
            _conexion.CerrarConexion();
            return todosLosProductos;
        }
        public LinkedList<EntidadProducto> ObtenerTodosLosProductos()
        {
            _conexion.AbrirConexion();
            var listado = new LinkedList<EntidadProducto>();
            DbDataReader lector;
            using (var comando = _conexion.CrearComando())
            {               
                const string sql = "SELECT *  FROM producto;";
                comando.CommandText = String.Format(sql);
                lector = comando.ExecuteReader();
            }
            while (lector.Read())
            {
                var codigoProducto = lector.GetInt16(lector.GetOrdinal("codigo_producto"));                
                var nombre = lector.GetString(lector.GetOrdinal("nombre"));                
                var precio = lector.GetDouble(lector.GetOrdinal("precio"));
                var descripcion = lector.GetString(lector.GetOrdinal("descripcion"));
                var miProducto = new EntidadProducto
                {
                    CodigoProducto = codigoProducto,                    
                    Nombre = nombre,
                    Precio = precio,                   
                    Descripcion = descripcion
                };
                listado.AddLast(miProducto);
            }
            lector.Close();
            _conexion.CerrarConexion();
            return listado;
        }
    }
}
