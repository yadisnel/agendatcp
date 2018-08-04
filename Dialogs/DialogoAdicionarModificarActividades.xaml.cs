using Agenda.ModeloDatos.Entidades;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Linq;
using Agenda.ModeloDatos.Consultas;

namespace Agenda.ModuloDialogos.Dialogos
{
    public partial class DialogoAdicionarModificarActividades
    {
        //public EntidadActividad actividad { get; set; } 
        public DialogoAdicionarModificarActividades()
        {
            InitializeComponent();
            //ControlBarraTitulo.ClickCerrar += ControlBarraTituloBotonCerrar_Click;
            //ControlBarraTitulo.ClickMinimizar += ControlBarraTituloBotonMinimizarVentana_Click;
            //ControlBarraTitulo.MouseLeftButtonDown += ControlBarraTitulo_MouseLeftButtonDown;
            //ControlBarraTitulo.OcultarBotonMaximizar = true;
            //BotonAceptar.Click += BotonAceptar_Click;
            //actividad = new EntidadActividad();
            //DataContext = actividad;                     
        }
       
        //public void ConfigurarDialogo(bool EsOperacionModificar)
        //{
        //    if (EsOperacionModificar)
        //    {
        //        this.ControlBarraTitulo.Titulo = "Modificar actividad";
        //        this.Title = ControlBarraTitulo.Titulo;
        //    }
        //    else
        //    {
        //        this.ControlBarraTitulo.Titulo = "Adicionar nueva actividad";
        //        this.Title = ControlBarraTitulo.Titulo;
        //    }
        //}
        //private void ValidarComponentes()
        //{
        //    string aux = TextBoxNombreactividad.Text;
        //    TextBoxNombreactividad.Text = "";
        //    TextBoxNombreactividad.Text = aux;

        //    aux = TextBoxNombreInterno.Text;
        //    TextBoxNombreInterno.Text = "";
        //    TextBoxNombreInterno.Text = aux;

        //    aux = TextBoxDescripcion.Text;
        //    TextBoxDescripcion.Text = "";
        //    TextBoxDescripcion.Text = aux;
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
