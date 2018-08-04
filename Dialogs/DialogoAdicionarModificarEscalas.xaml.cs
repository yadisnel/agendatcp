using Agenda.ModeloDatos.Entidades;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Linq;
using Agenda.ModeloDatos.Consultas;

namespace Agenda.ModuloDialogos.Dialogos
{
    public partial class DialogoAdicionarModificarEscalas
    {
        //public EntidadEscala Escala { get; set; }
        public DialogoAdicionarModificarEscalas()
        {
            InitializeComponent();
            //ControlBarraTitulo.ClickCerrar += ControlBarraTituloBotonCerrar_Click;
            //ControlBarraTitulo.ClickMinimizar += ControlBarraTituloBotonMinimizarVentana_Click;
            //ControlBarraTitulo.OcultarBotonMaximizar = true;
            //ControlBarraTitulo.MouseLeftButtonDown += ControlBarraTitulo_MouseLeftButtonDown;
            //BotonAceptar.Click += BotonAceptar_Click;
            //Escala = new EntidadEscala();
            //DataContext = Escala;           
        }       
        //public void ConfigurarDialogo(bool esOperacionModificar)
        //{
        //    if (esOperacionModificar)
        //    {
        //        this.Title = "Modificar escala";                
        //        this.BotonAceptar.Content = "Modificar";
        //    }
        //    else
        //    {
        //        this.Title = "Adicionar escala";               
        //        this.BotonAceptar.Content = "Adicionar";
        //    }
        //    this.ControlBarraTitulo.Titulo = this.Title;
        //}       
        //private void ValidarComponentes()
        //{
        //    string aux = TextBoxDesde.Text;
        //    TextBoxDesde.Text = "";
        //    TextBoxDesde.Text = aux;

        //    aux = TextBoxHasta.Text;
        //    TextBoxHasta.Text = "";
        //    TextBoxHasta.Text = aux;

        //    aux = TextBoxPorciento.Text;
        //    TextBoxPorciento.Text = "";
        //    TextBoxPorciento.Text = aux;
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
