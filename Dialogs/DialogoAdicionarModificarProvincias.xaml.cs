using Agenda.ModeloDatos.Entidades;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Linq;

namespace Agenda.ModuloDialogos.Dialogos
{
    public partial class DialogoAdicionarModificarProvincias
    {
        //public EntidadProvincia Provincia { get; set; }

        public DialogoAdicionarModificarProvincias()
        {
            InitializeComponent();
            //    ControlBarraTitulo.ClickCerrar += ControlBarraTituloBotonCerrar_Click;
            //    ControlBarraTitulo.ClickMinimizar += ControlBarraTituloBotonMinimizarVentana_Click;
            //    ControlBarraTitulo.MouseLeftButtonDown += ControlBarraTitulo_MouseLeftButtonDown;
            //    ControlBarraTitulo.OcultarBotonMaximizar = true;
            //    BotonAceptar.Click += BotonAceptar_Click;
            //    Provincia = new EntidadProvincia();
            //    DataContext = Provincia;
            //    this.Title = ControlBarraTitulo.Titulo;
        }
        //public void ConfigurarDialogo(bool esOperacionModificar)
        //{
        //    if (esOperacionModificar)
        //    {
        //        ControlBarraTitulo.Titulo = "Modificar provincia";
        //        BotonAceptar.Content = "Modificar";
        //    }
        //    else
        //    {
        //        ControlBarraTitulo.Titulo = "Modificar provincia";
        //        BotonAceptar.Content = "Adicionar";
                
        //    }
        //    this.Title = ControlBarraTitulo.Titulo;
            
        //}
        //private void ValidarComponentes()
        //{
        //    string aux = TextBoxNombreactividad.Text;
        //    TextBoxNombreactividad.Text = "";
        //    TextBoxNombreactividad.Text = aux;
        //}
        //void BotonAceptar_Click(object sender, RoutedEventArgs e)
        //{
        //    ValidarComponentes();
        //    if (DialogoEsValido(this) == false)
        //    {
        //        MessageBox.Show("Por favor corrija los datos marcados como no válidos.", "Error en la entrada de datos", MessageBoxButton.OK);
        //        return;
        //    }           
        //    DialogResult = true;           
        //}

        //void ControlBarraTitulo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    DragMove();
        //}

        //void ControlBarraTituloBotonCerrar_Click(object sender, RoutedEventArgs e)
        //{
        //    DialogResult = false;
        //}

        //void ControlBarraTituloBotonMinimizarVentana_Click(object sender, RoutedEventArgs e)
        //{
        //    WindowState = WindowState.Minimized;
        //}

        //private void Titulo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    DragMove();
        //}
        //private bool DialogoEsValido(DependencyObject node)
        //{
        //    // Check if dependency object was passed
        //    if (node != null)
        //    {
        //        // Check if dependency object is valid.
        //        // NOTE: Validation.GetHasError works for controls that have validation rules attached 

        //        var isValid = !Validation.GetHasError(node);
        //        if (isValid)
        //            return LogicalTreeHelper.GetChildren(node).OfType<DependencyObject>().All(DialogoEsValido);
        //        // If the dependency object is invalid, and it can receive the focus,
        //        // set the focus
        //        var element = node as IInputElement;
        //        if (element != null) Keyboard.Focus(element);
        //        return false;
        //    }
        //    // If this dependency object is valid, check all child dependency objects
        //    return LogicalTreeHelper.GetChildren(node).OfType<DependencyObject>().All(DialogoEsValido);
        //    // All dependency objects are valid
        //}
    }
}
