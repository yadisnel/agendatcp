using Agenda.ModeloDatos.Entidades;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Linq;

namespace Agenda.ModuloDialogos.Dialogos
{
    public partial class DialogoAdicionarModificarConceptoGasto
    {
        //public EntidadConceptoGasto ConceptoGasto { get; set; }
        //private bool _esOperacionModificar = false;

        public DialogoAdicionarModificarConceptoGasto()
        {
            InitializeComponent();
        //    ControlBarraTitulo.ClickCerrar += BotonCerrar_Click;
        //    ControlBarraTitulo.ClickMinimizar += BotonMinimizarVentana_Click;
        //    ControlBarraTitulo.MouseLeftButtonDown += ControlBarraTitulo_MouseLeftButtonDown;
        //    BotonAceptar.Click += BotonAceptar_Click;
        //    ConceptoGasto = new EntidadConceptoGasto();
        //    DataContext = ConceptoGasto;
        }
        //public void ConfigurarDialogo(bool esOperacionModificar)
        //{
        //    _esOperacionModificar = esOperacionModificar;
        //    if (esOperacionModificar)
        //    {
        //        ControlBarraTitulo.Titulo = "Modificar concepto de gasto";
        //        BotonAceptar.Content = "Modificar";
        //    }
        //    else
        //    {
        //        ControlBarraTitulo.Titulo = "Adicionar nuevo concepto de gasto";
        //        BotonAceptar.Content = "Adicionar";
        //    }
        //    Title = ControlBarraTitulo.Titulo;
        //}
        //private void ValidarComponentes()
        //{
        //    string aux = TextBoxNombreConceptoGasto.Text;
        //    TextBoxNombreConceptoGasto.Text = "";
        //    TextBoxNombreConceptoGasto.Text = aux;
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

        //void BotonCerrar_Click(object sender, RoutedEventArgs e)
        //{
        //    DialogResult = false;
        //}

        //void BotonMinimizarVentana_Click(object sender, RoutedEventArgs e)
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
