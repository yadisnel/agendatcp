using Agenda.ModeloDatos.Datos;
using Agenda.ModeloDatos.Entidades;
using Agenda.ModuloExc.Excepciones;
using Agenda.ModeloDatos.Seguridad;
using System.Collections;
using System.Windows;
using System.Xml;
using System;

namespace Agenda.ModeloDatos.Configuracion
{
    public class ConfiguracionSistema
    {
        private static ConfiguracionSistema _config;
        private readonly ArrayList _parametrosConexionSistema = new ArrayList();
        private const bool ComprobarIntegridadModulos = true;
        private EntidadTcp _tcpActivo;
        private DateTime? _fechaContableEnUso;
        private EntidadLicencia _licenciaEnUso;

        public event EventHandler FechaContableEnUsoHaCambiado;
        public DateTime? FechaContableEnUso 
        {
            get
            { 
                if(_fechaContableEnUso != null)
                {
                    DateTime? date = new DateTime(_fechaContableEnUso.Value.Year, _fechaContableEnUso.Value.Month, _fechaContableEnUso.Value.Day);
                    return date;
                }
                return null;                
            }
            set
            {
                _fechaContableEnUso = value;
                if (FechaContableEnUsoHaCambiado != null)
                {
                    FechaContableEnUsoHaCambiado(this, null);
                }
            }
        }
       
        public EntidadTcp TcpActivo 
        {
            get { return _tcpActivo; }
            set { 
                    _tcpActivo = value;
                    if (TcpActivo != null && LicenciaEnUso != null)
                    {
                        EntidadResumen.GetEntidad().TextoResumenUso = TcpActivo.NombreApellidos + ". " + LicenciaEnUso.Nombre;
                    }                    
                }
        }

        public EntidadLicencia LicenciaEnUso
        {
            get { return _licenciaEnUso; }
            set
            {
                _licenciaEnUso = value;
                if (TcpActivo != null && LicenciaEnUso != null)
                {
                    EntidadResumen.GetEntidad().TextoResumenUso = TcpActivo.NombreApellidos + "." + LicenciaEnUso.Nombre;
                }  
            }
        }
        public void ActualizarDatosActivos(EntidadLicencia licencia, EntidadTcp tcpActivo)
        {
            LicenciaEnUso = licencia;
            TcpActivo = tcpActivo;            
        }

        public  string GetDireccionEjecutable()
        {
            var rutaCompleta = Application.ResourceAssembly.Location;
            var ruta = "";
            for (var i = rutaCompleta.Length - 1; i >= 0; i--)
            {
                var aux = "";
                aux += rutaCompleta[i];
                if (aux != "\\")
                {
                    ruta = rutaCompleta.Substring(0, i - 1);
                }
                else
                {
                    break;
                }
            }
            return ruta;
        }
        public string GetCadenaConexion()
        {
            string CadCon = "";
            for (var i = 0; i < _parametrosConexionSistema.Count; i++)
            {
                var param = (ParametroConexion)_parametrosConexionSistema[i];
                CadCon += param.GetNombreParametro();
                CadCon += "=";
                CadCon += param.GetValorParametro();
                if (i < _parametrosConexionSistema.Count - 1) CadCon += ";";
            }
            return CadCon;
        }
        public void CargarConfiguracion()
        {
            /*string sqliteDBFile = @"D:\Personal\Yady\Bien Con el Fisco 0.581\VersionRelease\datos\bcfbdsq.dbd";
            string connStr = @"data source=" + sqliteDBFile;
            string password = "Elfosds2a123";
            // Query:
            string sql = "SELECT * from tcp;";
            // Connection code:
            SQLiteConnection cnn = null;
            try
            {
                cnn = new SQLiteConnection(connStr);
                cnn.Open();
                cnn.ChangePassword(password);
                SQLiteCommand myCommand = new SQLiteCommand(sql, cnn);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Caught exception: " + e.Message);
            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }*/
            try
            {
                FechaContableEnUso = System.DateTime.Now;
                var doc = new XmlDocument();
                //Cargar el fichero de configuración.
                var rutaFicheroConfig = GetDireccionEjecutable() + "\\" + "config.xml";
                doc.Load(rutaFicheroConfig);
                //Cargar parámetros de conexión a la base de datos.
                var nodoServidorBdFenix = doc.GetElementsByTagName("servidorbd");
                if (nodoServidorBdFenix.Count > 0)
                {
                    var xmlNode = nodoServidorBdFenix.Item(0);
                    if (xmlNode == null) return;
                    var listaParametros = xmlNode.ChildNodes;
                    for (var i = 0; i < listaParametros.Count; i++)
                    {
                        var item = listaParametros.Item(i);
                        if (item == null || item.LocalName != "parametro_conexion") continue;
                        var node = listaParametros.Item(i);
                        if (node != null)
                        {
                            var listaAtributos = node.Attributes;
                            if (listaAtributos != null && listaAtributos.Count == 2)
                            {
                                if (listaAtributos.Item(0).LocalName == "nombre" && listaAtributos.Item(1).LocalName == "valor")
                                {
                                    var nombre = listaAtributos.Item(0).Value;
                                    var valor = listaAtributos.Item(1).Value;
                                    if (nombre == "Password")
                                    {
                                        const string passPhrase = "wer234234$%3*/541asd22@";
                                        const string saltValue = "afaee4e5%^4awdce334sd@";
                                        const string hashAlgorithm = "SHA1";
                                        const int passwordIterations = 2;
                                        const string initVector = "s&dfd*/-.(4$$@#1";
                                        const int keySize = 256;
                                        valor = Criptografia.GetCripto().DesencriptarRijndaelSimple(
                                            valor,
                                            passPhrase,
                                            saltValue,
                                            hashAlgorithm,
                                            passwordIterations,
                                            initVector,
                                            keySize);
                                        _parametrosConexionSistema.Add(new ParametroConexion(nombre, valor));
                                    }
                                    else
                                    {
                                        _parametrosConexionSistema.Add(new ParametroConexion(nombre, valor));
                                    }
                                }
                                else
                                {
                                    throw new ECargarFicheroConfig("Error al cargar fichero de configuración 'config.xml'. Nombre de atributo de parámetro de conexion incorrecto o en orden incorrecto, los atributos deben ser 'nombre' y 'valor'. Valor encontrado: '" + listaAtributos.Item(0).LocalName + "'.");
                                }
                            }
                            else
                            {
                                throw new ECargarFicheroConfig("Error al cargar fichero de configuración 'config.xml'. Cantidad de atributos de parámetro de conexion incorrecto, los atributos deben ser 'nombre' y 'valor'.");
                            }
                        }
                    }
                }
                else
                {
                    throw new ECargarFicheroConfig("Error al cargar fichero de configuración 'config.xml'. No se ha encontrado la configuración de acceso a la base de datos.");
                }
            }
            catch (EEncriptacion)
            {
                throw new ECargarFicheroConfig("No se pudo realizar la desencriptación de la contraseña de la base de datos, por favor consulte el fichero de configuración config.xml");
            }
            catch (System.IO.FileNotFoundException)
            {
                throw new ECargarFicheroConfig("Error al cargar fichero de configuración 'config.xml'. No se ha encontrado el archivo. Revise si el archivo existe en la ruta de instalación del programa. Si el problema persiste, por favor contacte al proveedor del sistema.");
            }
        }         
        public ArrayList GetParametrosConexionSistema()
        {
            return _parametrosConexionSistema;
        }       
        public bool GetComprobarIntegridadModulos()
        {
            return ComprobarIntegridadModulos;
        } 
        public static ConfiguracionSistema GetConfig()
        {
            return _config ?? (_config = new ConfiguracionSistema());
        }
    }
}
