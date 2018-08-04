using System.Windows;
using System.Windows.Input;
using Agenda.ModuloExc.Excepciones;

namespace Agenda.Vistas.ModuloPrincipal
{
    public partial class VentanaAutenticacion : Window
    {       
        public VentanaAutenticacion()
        {
            InitializeComponent();            
            //BotonCerrar.Click += BotonCerrar_Click;
            //BotonMinimizarVentana.Click += BotonMinimizarVentana_Click;
            //BotonEntrar.Click += BotonEntrar_Click;
            //labelTitulo.MouseLeftButtonDown += labelTitulo_MouseLeftButtonDown;
        }

        //void labelTitulo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    DragMove(); 
        //}

        //void BotonCerrar_Click(object sender, RoutedEventArgs e)
        //{
        //    Application.Current.Shutdown();
        //}

        //void BotonEntrar_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {                
        //        Hide();
        //        /*var Dlg = new DialogoSeleccionactividad();
        //        Dlg.ShowDialog();*/
        //        var vp = new VentanaPrincipal();
        //        vp.NavegarPaginaInicio();
        //        vp.ShowDialog();
        //    }
        //    catch (ECargarFicheroConfig ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        Application.Current.Shutdown();
        //    }
        //    catch (EAccesoDatosNoSePudoConectarConLaBd ex)
        //    {
        //        MessageBox.Show("No se pudo completar la operación debido a un error al acceder a los datos. Por favor revise la configuración de acceso a datos. Detalles del error:" + ex.Message);
        //        Application.Current.Shutdown();
        //    }
        //}

        //void BotonMinimizarVentana_Click(object sender, RoutedEventArgs e)
        //{
        //    WindowState = WindowState.Minimized;
        //}

        //private void Titulo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    DragMove(); 
        //}       
    }
}
