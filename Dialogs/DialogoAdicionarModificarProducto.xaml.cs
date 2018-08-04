using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Agenda.ModuloExc.Excepciones;
using Agenda.ModeloDatos.Seguridad;
using Agenda.ModeloDatos.Configuracion;
using Agenda.ModeloDatos.Dao;
using Agenda.ModeloDatos.Entidades;
using Agenda.ModeloDatos.Validaciones;

namespace Agenda.ModuloDialogos.Dialogos
{
    public partial class DialogoAdicionarModificarProducto
    {       
        //private bool EsOperacionModificar = false;       
        public DialogoAdicionarModificarProducto()
        {
            InitializeComponent();
            //ControlBarraTitulo.ClickCerrar += BotonCerrar_Click;
            //ControlBarraTitulo.ClickMinimizar += BotonMinimizarVentana_Click;
            //ControlBarraTitulo.OcultarBotonMaximizar = true;
            //ControlBarraTitulo.MouseLeftButtonDown += ControlBarraTitulo_MouseLeftButtonDown;
            //BotonAdicionar.Click += botonAdicionar_Click;            
        }
        //public void ConfigurarDialogo(bool esOperacionModificar)
        //{
        //    EsOperacionModificar = esOperacionModificar;
        //    if (esOperacionModificar)
        //    {
        //        ControlBarraTitulo.Titulo = "Modificar producto";
        //        BotonAdicionar.Content = "Modificar";                
        //    }
        //    else
        //    {
        //        ControlBarraTitulo.Titulo = "Adicionar producto";
        //        BotonAdicionar.Content = "Adicionar";   
        //    }
        //    Title = ControlBarraTitulo.Titulo;
        //}
        //void botonAdicionar_Click(object sender, RoutedEventArgs e)
        //{            
        //    try
        //    {
        //        var valorNombre = TextBoxNombreProduct.Text;
        //        TextBoxNombreProduct.Text = "";
        //        TextBoxNombreProduct.Text = valorNombre;
        //        var valorPrecio = TextBoxPrecioProducto.Text;
        //        TextBoxPrecioProducto.Text = "";
        //        TextBoxPrecioProducto.Text = valorPrecio;

        //        if (DialogoEsValido(this))
        //        {                    
        //            if (EsOperacionModificar)
        //            {
        //                if (new DaoProducto().ExisteProductoConNombreIgualDiferenteCodigo(TextBoxNombreProduct.Text, ((EntidadProducto)DataContext).CodigoProducto))
        //                {
        //                    MessageBox.Show("Un producto con igual nombre ya está registrado en el sistema. Por favor introduzca otro nombre.");
        //                    return;
        //                }
                        
        //            } 
        //            else if (new DaoProducto().ExisteProductoConIgualNombre(TextBoxNombreProduct.Text))
        //            {
        //                MessageBox.Show("Un producto con igual nombre ya está registrado en el sistema. Por favor introduzca otro nombre.");
        //                return;
        //            }
        //            DialogResult = true;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Por favor corrija los datos que están marcados como no válidos");
        //        }
        //    }
        //    catch (EAccesoDatosNoSePudoConectarConLaBd ex)
        //    {
        //        MessageBox.Show("No se pudo completar la operación debido a un error al acceder a los datos. Por favor revise la configuración de acceso a datos. Detalles del error:" + ex.Message);
        //    }
        //}

        //void ControlBarraTitulo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    DragMove();
        //}

        //void BotonCerrar_Click(object sender, RoutedEventArgs e)
        //{
        //    DialogResult = false;
        //}

        //void BotonMinimizarVentana_Click(object sender, RoutedEventArgs e)
        //{
        //    WindowState = WindowState.Minimized;
        //}

        //private void Titulo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    DragMove();
        //}
        //private static bool DialogoEsValido(DependencyObject node)
        //{
        //    // Check if dependency object was passed
        //    if (node != null)
        //    {
        //        // Check if dependency object is valid.
        //        // NOTE: Validation.GetHasError works for controls that have validation rules attached 

        //        var isValid = !Validation.GetHasError(node);
        //        if (!isValid)
        //        {
        //            // If the dependency object is invalid, and it can receive the focus,
        //            // set the focus
        //            var inputElement = node as IInputElement;
        //            if (inputElement != null) Keyboard.Focus(inputElement);
        //            return false;
        //        }
        //    }
        //    // If this dependency object is valid, check all child dependency objects
        //    return node == null || LogicalTreeHelper.GetChildren(node).OfType<DependencyObject>().All(DialogoEsValido);
        //    // All dependency objects are valid
        //}
    }
}
