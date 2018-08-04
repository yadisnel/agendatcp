using Agenda.ModeloDatos.Entidades;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Linq;

namespace Agenda.ModuloDialogos.Dialogos
{
    public partial class DialogoAdicionarModificarConceptoIngreso
    {
        //public EntidadConceptoIngreso ConceptoIngreso { get; set; }
        //private bool _esOperacionModificar = false;

        public DialogoAdicionarModificarConceptoIngreso()
        {
            InitializeComponent();
            //    ControlBarraTitulo.ClickCerrar += ControlBarraTituloBotonCerrar_Click;
            //    ControlBarraTitulo.ClickMinimizar += ControlBarraTituloBotonMinimizarVentana_Click;
            //    ControlBarraTitulo.OcultarBotonMaximizar = true;
            //    ControlBarraTitulo.MouseLeftButtonDown += ControlBarraTitulo_MouseLeftButtonDown;
            //    BotonAceptar.Click += BotonAceptar_Click;
            //    ConceptoIngreso = new EntidadConceptoIngreso();
            //    DataContext = ConceptoIngreso;
        }
        //public void ConfigurarDialogo(bool esOperacionModificar)
        //{
        //    _esOperacionModificar = esOperacionModificar;
        //    if (esOperacionModificar)
        //    {
        //        ControlBarraTitulo.Titulo = "Modificar concepto de ingreso";
        //        BotonAceptar.Content = "Modificar";
        //    }
        //    else
        //    {
        //        ControlBarraTitulo.Titulo = "Adicionar nuevo concepto de ingreso";
        //        BotonAceptar.Content = "Adicionar";
        //    }
        //    Title = ControlBarraTitulo.Titulo;
        //}
        //private void ValidarComponentes()
        //{
        //    string aux = TextBoxNombreConceptoIngreso.Text;
        //    TextBoxNombreConceptoIngreso.Text = "";
        //    TextBoxNombreConceptoIngreso.Text = aux;
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
