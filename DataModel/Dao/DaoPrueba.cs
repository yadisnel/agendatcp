using System;
using System.Data;
using Agenda.ModeloDatos.Seguridad;
using System.Collections.Generic;
using Agenda.ModuloExc.Excepciones;
using Agenda.ModeloDatos.Entidades;
using System.Data.Common;
using System.Collections;
using System.Threading.Tasks;

namespace Agenda.ModeloDatos.Dao
{
    public class DaoPrueba : DaoAbs 
    {        
        public void AdicionarEscalasProgresivas()
        {
            int codigoEscala = 0;
            _conexion.AbrirConexion();
            for (int i = 0; i <= 100; i++)
            {
                var comando1 = _conexion.CrearComando();
                string sql1 = "INSERT INTO n_escala_progresiva (codigo_escala_progresiva,codigo_linea_tiempo_año,desde,hasta,porciento) VALUES (";
                sql1 += codigoEscala.ToString();
                sql1 += ",";
                sql1 += i.ToString();
                sql1 += ",0.01,10000,15)";           
                comando1.CommandText = String.Format(sql1);
                comando1.ExecuteNonQuery();
                codigoEscala++;

                var comando2 = _conexion.CrearComando();
                string sql2 = "INSERT INTO n_escala_progresiva (codigo_escala_progresiva,codigo_linea_tiempo_año,desde,hasta,porciento) VALUES (";
                sql2 += codigoEscala.ToString();
                sql2 += ",";
                sql2 += i.ToString();
                sql2 += ",10000.01,20000,20)";
                comando2.CommandText = String.Format(sql2);
                comando2.ExecuteNonQuery();
                codigoEscala++;

                var comando3 = _conexion.CrearComando();
                string sql3 = "INSERT INTO n_escala_progresiva (codigo_escala_progresiva,codigo_linea_tiempo_año,desde,hasta,porciento) VALUES (";
                sql3 += codigoEscala.ToString();
                sql3 += ",";
                sql3 += i.ToString();
                sql3 += ",20000.01,30000,30)";
                comando3.CommandText = String.Format(sql3);
                comando3.ExecuteNonQuery();
                codigoEscala++;

                var comando4 = _conexion.CrearComando();
                string sql4 = "INSERT INTO n_escala_progresiva (codigo_escala_progresiva,codigo_linea_tiempo_año,desde,hasta,porciento) VALUES (";
                sql4 += codigoEscala.ToString();
                sql4 += ",";
                sql4 += i.ToString();
                sql4 += ",30000.01,50000,40)";
                comando4.CommandText = String.Format(sql4);
                comando4.ExecuteNonQuery();
                codigoEscala++;

                var comando5 = _conexion.CrearComando();
                string sql5= "INSERT INTO n_escala_progresiva (codigo_escala_progresiva,codigo_linea_tiempo_año,desde,hasta,porciento) VALUES (";
                sql5 += codigoEscala.ToString();
                sql5 += ",";
                sql5 += i.ToString();
                sql5 += ",50000.01,999999999,50)";
                comando5.CommandText = String.Format(sql5);
                comando5.ExecuteNonQuery();
                codigoEscala++;
              
            }
            _conexion.CerrarConexion();
        }       
        public void CompletarLimites()
        {
           /*LinkedList<EntidadAbs> Limites =  new DaoLimiteActividad().ObtenerTodosLosElementos();
            _conexion.AbrirConexion();
            foreach (EntidadLimiteActividad limite in Limites)
            {
                var comando = _conexion.CrearComando();
                const string sql = "INSERT INTO limite_actividad(codigo_limite_actividad,codigo_actividad,codigo_municipio,codigo_linea_tiempo,cuota_mensual_minima,gasto_maximo) VALUES (@1,@2,@3,@4,@5,@6)";
                comando.CommandText = String.Format(sql);              
               

                var param1 = _conexion.CrearParametro("@1", DbType.Int32);
                param1.Value = limite.CodigoLimiteactividad;
                
                var param2 = _conexion.CrearParametro("@2", DbType.Int16);
                param2.Value = limite.CodigoActividad;

                var param3 = _conexion.CrearParametro("@3", DbType.Int16);
                param3.Value = limite.CodigoMunicipio;

                var param4 = _conexion.CrearParametro("@4", DbType.Int16);
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
            }
            _conexion.CerrarConexion();*/
        }
    }
}
