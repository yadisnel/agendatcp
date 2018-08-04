using System.Runtime.InteropServices;
using Agenda.ModeloDatos.Entidades;
using Agenda.ModuloExc.Excepciones;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Agenda.ModeloDatos.Dao
{
    public class DaoVariable : DaoAbs
    {
       public bool EsPrimeraConfiguracion()
       {          
           _conexion.AbrirConexion();
           var comando = _conexion.CrearComando();

           const string sql = "SELECT * FROM variable WHERE es_hecha_configuracion_inicio = 1";
           comando.CommandText = String.Format(sql);

           var lector = comando.ExecuteReader();

           if (lector.Read())
           {
               lector.Close();
               _conexion.CerrarConexion();
               return false;
           }
           lector.Close();
           _conexion.CerrarConexion();
           return true;
       }
       public void RegistrarPrimeraConfiguracion()
       {
           bool existenVariables = ExistenVariables();
           _conexion.AbrirConexion();
           var comando = _conexion.CrearComando();
           string sql = "";
           if (!existenVariables)
           {
               sql = "INSERT INTO variable (es_hecha_configuracion_inicio) VALUES (1)";
           }
           else
           {
               sql = "UPDATE variable  SET es_hecha_configuracion_inicio =1";
           }
           comando.CommandText = String.Format(sql);
           comando.ExecuteNonQuery();
           _conexion.CerrarConexion();
       }
       private bool ExistenVariables()
       {
           _conexion.AbrirConexion();
           var comando = _conexion.CrearComando();

           const string sql = "SELECT * FROM variable";
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
    }
}
