using Agenda.ModeloDatos.Configuracion;
using Agenda.ModeloDatos.Dao;
using Agenda.ModuloDialogos.Dialogos;
using Agenda.ModeloDatos.Entidades;
using Agenda.Vistas.ModuloConfiguracion;
using Agenda.Vistas.ModuloRegistroGastos;
using Agenda.Vistas.ModuloRegistroIngresos;
using Agenda.Vistas.ModuloReportes;
using Agenda.ModuloAyuda.Paginas;
using Agenda.Vistas.ModuloCentroInformativo;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using Agenda.ModuloAyudaXps.Herramientas;
using Agenda.ModuloExc.Excepciones;
using System;
using Agenda.Controles;

namespace Agenda.Vistas.ModuloPrincipal
{
    public class IDS_MENU_APLICACION
    {
        private static string _ID_MENU_INICIO;
        private static string _ID_MENU_REGISTRO_INGRESOS;
        private static string _ID_MENU_REGISTRO_GASTOS;
        private static string _ID_MENU_REGISTRO_PRODUCTOS;
        private static string _ID_MENU_EMISION_CONFIGURACION;
        private static string _ID_MENU_EMISION_CENTRO_INFORMATIVO;

        public static string ID_MENU_INICIO
        {
            get{return "ID_MENU_INICIO";}
        }

        public static string ID_MENU_REGISTRO_INGRESOS
        {
            get{ return "ID_MENU_REGISTRO_INGRESOS"; }
        }

        public static string ID_MENU_REGISTRO_GASTOS
        {
            get{return "ID_MENU_REGISTRO_GASTOS"; }
        }

        public static string ID_MENU_REGISTRO_PRODUCTOS
        {
            get{return "ID_MENU_REGISTRO_PRODUCTOS"; }
        }

        public static string ID_MENU_CONFIGURACION
        {
            get{return "ID_MENU_CONFIGURACION"; }
        }

        public static string ID_MENU_CENTRO_INFORMATIVO
        {
            get{return "ID_MENU_CENTRO_INFORMATIVO"; }
        }
    }
    public class NOMBRES_MENU_APLICACION
    {
        private static string _MENU_INICIO;
        private static string _MENU_REGISTRO_INGRESOS;
        private static string _MENU_REGISTRO_GASTOS;
        private static string _MENU_REGISTRO_PRODUCTOS;
        private static string _MENU_CONFIGURACION;
        private static string _MENU_CENTRO_INFORMATIVO;

        public static string MENU_INICIO
        {
            get { return "Inicio"; }
        }

        public static string MENU_REGISTRO_INGRESOS
        {
            get { return "Ingresos"; }
        }

        public static string MENU_REGISTRO_GASTOS
        {
            get { return "Gastos"; }
        }

        public static string MENU_REGISTRO_PRODUCTOS
        {
            get { return "Productos"; }
        }

        public static string MENU_CONFIGURACION
        {
            get { return "Configuración"; }
        }

        public static string MENU_CENTRO_INFORMATIVO
        {
            get { return "Centro informativo"; }
        }
    }

    public partial class VentanaPrincipal : Window
    {
        private bool EsMaximizado = false;
        public VentanaPrincipal()
        {
            InitializeComponent();
            //try
            //{
            //    ConfiguracionSistema.GetConfig().CargarConfiguracion();               
            //}
            //catch (ECargarFicheroConfig excep)
            //{
            //    MessageBox.Show(excep.Message);
            //    Application.Current.Shutdown();
            //}
            //catch (EAccesoDatosNoSePudoConectarConLaBd)
            //{
            //    MessageBox.Show("No se pudo conectar a la base de datos. Por favor revise que el archivo de datos 'bcfbd.sdf' existe en la ruta definida en el archivo de configuración 'config.xml' y que este sea accesible. Si el problema persiste contacte al proveedor del sistema.");
            //    Application.Current.Shutdown();
            //}

            //catch (Exception exc)
            //{
            //    MessageBox.Show("Excepcion no controlada de tipo " + exc.GetType().ToString() + " mensaje: " + exc.Message);
            //    Application.Current.Shutdown();
            //}
            //ControlMenuAplicacion.ClickInicio += botonInicio_Click;
            //ControlMenuAplicacion.ClickRegistroIngresos += ControlMenuAplicacion_ClickRegistroIngresos;
            //ControlMenuAplicacion.ClickRegistroGastos += botonRegistroGastos_Click;
            //ControlMenuAplicacion.ClickRegistroProductos += botonRegistroProductos_Click;
            //ControlMenuAplicacion.ClickEmisionReportes += ControlMenuAplicacion_ClickEmisionReportes;
            //ControlMenuAplicacion.ClickConfiguracion += ControlMenuAplicacion_ClickConfiguracion;
            //ControlMenuAplicacion.ClickCentroInformativo += ControlMenuAplicacion_ClickCentroInformativo;
            //ControlMenuAplicacion.ClickAyuda += ControlMenuAplicacion_ClickAyuda; 
            //ControlMenuAplicacion.ClickConfiguracion += botonConfiguracion_Click;
            //ControlMenuAplicacion.ClickRegistroIngresos += botonRegistroIngresos_Click;
            BordeTitulo.MouseLeftButtonDown += BordeTitulo_MouseLeftButtonDown;
            BotonMinimizar.ClickMinimizar += BotonMinimizar_ClickMinimizar;
            BotonCerrar.ClickCerrar += BotonCerrar_ClickCerrar;
            BotonMaximizar.ClickMaximizar += BotonMaximizar_ClickMaximizar;

            //ControlBarraTitulo.ClickCerrar += ControlBarraTitulo_ClickCerrar;
            //ControlBarraTitulo.ClickMaximizar += ControlBarraTitulo_ClickMaximizar;
            //ControlBarraTitulo.ClickMinimizar += ControlBarraTitulo_ClickMinimizar;
            //ControlSeleccionarFechaContable.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(ControlSeleccionarFechaContable_SelectedDateChanged);

            //ControlCambiarActividad.Click += ControlCambiarActividad_Click;   
            //this.ContentRendered += VentanaPrincipal_ContentRendered;
            MenuAplicacion.AdicionarMenu(IDS_MENU_APLICACION.ID_MENU_INICIO,NOMBRES_MENU_APLICACION.MENU_INICIO);
            MenuAplicacion.AdicionarMenu(IDS_MENU_APLICACION.ID_MENU_REGISTRO_INGRESOS, NOMBRES_MENU_APLICACION.MENU_REGISTRO_INGRESOS);
            MenuAplicacion.AdicionarMenu(IDS_MENU_APLICACION.ID_MENU_REGISTRO_GASTOS, NOMBRES_MENU_APLICACION.MENU_REGISTRO_GASTOS);
            MenuAplicacion.AdicionarMenu(IDS_MENU_APLICACION.ID_MENU_REGISTRO_PRODUCTOS, NOMBRES_MENU_APLICACION.MENU_REGISTRO_PRODUCTOS);
            MenuAplicacion.AdicionarMenu(IDS_MENU_APLICACION.ID_MENU_CONFIGURACION, NOMBRES_MENU_APLICACION.MENU_CONFIGURACION);
            MenuAplicacion.AdicionarMenu(IDS_MENU_APLICACION.ID_MENU_CENTRO_INFORMATIVO, NOMBRES_MENU_APLICACION.MENU_CENTRO_INFORMATIVO);
            MenuAplicacion.ClickElemento += MenuAplicacion_ClickElemento;

            RecalcularTamano();
        }

        private void MenuAplicacion_ClickElemento(object sender, EventArgs e)
        {
            string ID_MENU_SELECCIONADO = ((MenuElementArgs)e).IdElemento;
            MessageBox.Show("Hola " + ID_MENU_SELECCIONADO);
        }

        private void BotonMaximizar_ClickMaximizar(object sender, RoutedEventArgs e)
        {
            var AnchoPantalla = SystemParameters.PrimaryScreenWidth;
            var AltoPantalla = SystemParameters.PrimaryScreenHeight;
            gridRaiz.Width = AnchoPantalla;
            gridRaiz.Height = AltoPantalla;

            if (!EsMaximizado)
            {
                EsMaximizado = true;
                WindowState = WindowState.Normal;
                gridRaiz.Width = AnchoPantalla;
                gridRaiz.Height = AltoPantalla;
                Top = 0;
                Left = 0;
            }
            else
            {
                EsMaximizado = false;
                WindowState = WindowState.Normal;
                gridRaiz.Width = AnchoPantalla - 50;
                gridRaiz.Height = AltoPantalla - 50;
                Top = (AltoPantalla - gridRaiz.Height) / 2;
                Left = (AnchoPantalla - gridRaiz.Width) / 2;
            }
        }

        private void BotonCerrar_ClickCerrar(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("¿Desea salir del sistema?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void BotonMinimizar_ClickMinimizar(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void BordeTitulo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        //private void VentanaPrincipal_ContentRendered(object sender, System.EventArgs e)
        //{
        //    LinkedList<EntidadAbs> TodosLosTcp = new DaoTcp().ObtenerTodosLosElementos();
        //    if (TodosLosTcp.Count == 1)
        //    {
        //        EntidadTcp miTcp = (EntidadTcp)TodosLosTcp.First.Value;
        //        LinkedList<EntidadAbs> TodasLasActividades = new DaoLicencia().ObtenerLicenciasDeTcp(miTcp);
        //        if (TodasLasActividades.Count == 1)
        //        {
        //            ConfiguracionSistema.GetConfig().ActualizarDatosActivos((EntidadLicencia)TodasLasActividades.First.Value, miTcp);
        //        }
        //        else
        //        {
        //            DialogoSeleccionarTrabajadorLicencia dlg = new DialogoSeleccionarTrabajadorLicencia();
        //            while (dlg.ShowDialog() == false)
        //            {
        //                var result = MessageBox.Show("La selección de la actividad es indispensable para poder comenzar. ¿Desea posponer el trabajo con el sistema para otro momento?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
        //                if (result == MessageBoxResult.Yes)
        //                {
        //                    Application.Current.Shutdown();
        //                    return;
        //                }
        //                dlg = new DialogoSeleccionarTrabajadorLicencia();
        //            }
        //            ConfiguracionSistema.GetConfig().ActualizarDatosActivos(dlg.LicenciaSeleccionada, dlg.TrabajadorSeleccionado);
        //        }
        //    }
        //    else
        //    {
        //        DialogoSeleccionarTrabajadorLicencia dlg = new DialogoSeleccionarTrabajadorLicencia();
        //        while (dlg.ShowDialog() == false)
        //        {
        //            var result = MessageBox.Show("La selección de la actividad es indispensable para poder trabajar. ¿Desea posponer el trabajo con el sistema para otro momento?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                Application.Current.Shutdown();
        //                return;
        //            }
        //            dlg = new DialogoSeleccionarTrabajadorLicencia();
        //        }
        //        ConfiguracionSistema.GetConfig().ActualizarDatosActivos(dlg.LicenciaSeleccionada, dlg.TrabajadorSeleccionado);
        //    }

        //    EntidadTcp tcpActivo = ConfiguracionSistema.GetConfig().TcpActivo;
        //    EntidadLicencia licenciaUso = ConfiguracionSistema.GetConfig().LicenciaEnUso;
        //    ControlCambiarActividad.Texto = tcpActivo.NombreApellidos + ". " + licenciaUso.Nombre;
        //    NavegarPaginaInicio();
        //}

        // private void ControlCambiarActividad_Click(object sender, RoutedEventArgs e)
        // {
        //     DialogoSeleccionarTrabajadorLicencia dlg = new DialogoSeleccionarTrabajadorLicencia();
        //     if (dlg.ShowDialog() == true)
        //     {
        //         ControlCambiarActividad.Texto = ConfiguracionSistema.GetConfig().TcpActivo.NombreApellidos + ". " + ConfiguracionSistema.GetConfig().LicenciaEnUso.Nombre;
        //     }
        // }      

        // void ControlMenuAplicacion_ClickAyuda(object sender, RoutedEventArgs e)
        // {
        //     ControlMenuAplicacion.SeleccionarBotonAyuda = true;
        //     EspacioTrabajo.NavigationService.RemoveBackEntry();
        //     var paginaPrincipalAyuda = new PaginaPrincipalAyuda();
        //     EspacioTrabajo.Navigate(paginaPrincipalAyuda); 
        // }

        // void ControlMenuAplicacion_ClickCentroInformativo(object sender, RoutedEventArgs e)
        // {
        //     ControlMenuAplicacion.SeleccionarBotonCentroInformativo = true;
        //     EspacioTrabajo.NavigationService.RemoveBackEntry();
        //     var paginaPrincipalCentroInformativo = new PaginaPrincipalCentroInformativo();
        //     EspacioTrabajo.Navigate(paginaPrincipalCentroInformativo); 
        // }

        // void ControlMenuAplicacion_ClickConfiguracion(object sender, RoutedEventArgs e)
        // {
        //     ControlMenuAplicacion.SeleccionarBotonConfiguracion = true;
        //     EspacioTrabajo.NavigationService.RemoveBackEntry();
        //     var paginaPrincipalConfiguracion = new PaginaPrincipalConfiguracion();
        //     EspacioTrabajo.Navigate(paginaPrincipalConfiguracion); 
        // }

        // void ControlMenuAplicacion_ClickEmisionReportes(object sender, RoutedEventArgs e)
        // {
        //     ControlMenuAplicacion.SeleccionarBotonEmisionReportes = true;
        //     EspacioTrabajo.NavigationService.RemoveBackEntry();
        //     var paginaPrincipalEmisionReportes = new PaginaPrincipalReportes();
        //     EspacioTrabajo.Navigate(paginaPrincipalEmisionReportes); 
        // }

        // void ControlMenuAplicacion_ClickRegistroIngresos(object sender, RoutedEventArgs e)
        // {
        //     ControlMenuAplicacion.SeleccionarBotonRegistroIngresos = true;
        //     EspacioTrabajo.NavigationService.RemoveBackEntry();
        //     var paginaPrincipalRegistroIngresos = new PaginaPrincipalRegistroIngresos();
        //     EspacioTrabajo.Navigate(paginaPrincipalRegistroIngresos); 
        // }

        // void ControlBotonAyudaReferenciaGeneral_Click(object sender, RoutedEventArgs e)
        // {
        //     VentanaVisorAyuda va = new VentanaVisorAyuda();
        //     va.AbrirDocumentoXpsDesdeStream("");
        //     va.ShowDialog();
        // }

        // void ControlSeleccionarFechaContable_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        // {
        //     ConfiguracionSistema.GetConfig().FechaContableEnUso = ControlSeleccionarFechaContable.Fecha;           
        // }

        // void ControlBarraTitulo_ClickMinimizar(object sender, RoutedEventArgs e)
        // {
        //     WindowState = WindowState.Minimized;
        // }

       
        void RecalcularTamano()
        {
            var AnchoPantalla = SystemParameters.PrimaryScreenWidth;
            var AltoPantalla = SystemParameters.PrimaryScreenHeight;
            gridRaiz.Width = AnchoPantalla - 50;
            gridRaiz.Height = AltoPantalla - 50;
            Top = (AltoPantalla - gridRaiz.Height) / 2;
            Left = (AnchoPantalla - gridRaiz.Width) / 2;

        }

        // void ControlBarraTitulo_ClickCerrar(object sender, RoutedEventArgs e)
        // {
        //     var result = MessageBox.Show("¿Desea salir del sistema?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
        //     if (result == MessageBoxResult.Yes)
        //     {
        //         Application.Current.Shutdown();
        //     }
        // }

        // void botonRegistroIngresos_Click(object sender, RoutedEventArgs e)
        // {
        //     ControlMenuAplicacion.SeleccionarBotonRegistroIngresos = true;
        //     EspacioTrabajo.NavigationService.RemoveBackEntry();            
        //     var paginaPrincipalRegistroIngresos = new PaginaPrincipalRegistroIngresos();
        //     var paginaInicio = new PaginaInicio();
        //     paginaPrincipalRegistroIngresos.PaginaInicio = paginaInicio;
        //     EspacioTrabajo.Navigate(paginaPrincipalRegistroIngresos);   
        // }

        // void botonRegistroGastos_Click(object sender, RoutedEventArgs e)
        // {
        //     ControlMenuAplicacion.SeleccionarBotonRegistroGastos = true;
        //     EspacioTrabajo.NavigationService.RemoveBackEntry();            
        //     var paginaPrincipalRegistroGastos = new PaginaPrincipalRegistroGastos();
        //     EspacioTrabajo.Navigate(paginaPrincipalRegistroGastos); 
        // }


        // void BotonCambiarActividad_Click(object sender, RoutedEventArgs e)
        // {
        //     NavegarPaginaInicio();
        //     bool Seleccion = false;            
        //     while (!Seleccion)
        //     {
        //         DialogoSeleccionarLicencia dlg = new DialogoSeleccionarLicencia();
        //         if (dlg.ShowDialog() == true)
        //         {                    
        //             ConfiguracionSistema.GetConfig().ActualizarDatosActivos(dlg.Licencia, dlg.TcpActivo);
        //             break;
        //         }
        //         else
        //         {
        //             var result = MessageBox.Show("La selección de la actividad es indispensable para trabajar en el sistema. ¿Desea posponer el trabajo con el sistema para otro momento?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
        //             if (result == MessageBoxResult.Yes)
        //             {
        //                 DialogResult = false;
        //                 return;
        //             }
        //             else
        //             {
        //                 continue;
        //             }
        //         }
        //     }
        // }       

        // void botonConfiguracion_Click(object sender, RoutedEventArgs e)
        // {
        //     ControlMenuAplicacion.SeleccionarBotonConfiguracion = true;
        //     EspacioTrabajo.NavigationService.RemoveBackEntry();
        //     var paginaPrincipalConfiguracion = new PaginaPrincipalConfiguracion();
        //     var paginaInicio = new PaginaInicio();
        //     paginaPrincipalConfiguracion.PaginaInicio = paginaInicio;
        //     EspacioTrabajo.Navigate(paginaPrincipalConfiguracion);   
        // }


        // void botonRegistroProductos_Click(object sender, RoutedEventArgs e)
        // {
        //     ControlMenuAplicacion.SeleccionarBotonRegistroProductos = true;
        //     EspacioTrabajo.NavigationService.RemoveBackEntry();
        //     var pagina = new PaginaPrincipalRegistroProductos();           
        //     EspacioTrabajo.Navigate(pagina);            
        // }
        // void botonInicio_Click(object sender, RoutedEventArgs e)
        // {
        //     ControlMenuAplicacion.SeleccionarBotonInicio = true;
        //     EspacioTrabajo.NavigationService.RemoveBackEntry();            
        //     var Pi = new PaginaInicio();
        //     EspacioTrabajo.Navigate(Pi);            
        // }

        // public void NavegarPaginaInicio()
        // {
        //     ControlMenuAplicacion.SeleccionarBotonInicio = true;
        //     var pi = new PaginaInicio();            
        //     EspacioTrabajo.Navigate(pi);            
        // }
    }
}
