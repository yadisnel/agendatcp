using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Agenda.ModeloDatos.Entidades;
using Agenda.ModeloDatos.Consultas;
using Agenda.ModeloDatos.Validaciones;

namespace Agenda.ModuloDialogos.Dialogos
{
    public partial class DialogoAdicionarModificarTrabajador
    {       
        //private readonly ListadoSexos _sexos = new ListadoSexos();
        //public EntidadTcp DatosTcp { get; set; }
        //public bool EsOperacionModificar { get; set; }

        public DialogoAdicionarModificarTrabajador()
        {
            InitializeComponent();
            //DatosTcp = new EntidadTcp();
            //this.DataContext = DatosTcp;
            //EsOperacionModificar = false;

            //ControlBarraTitulo.ClickCerrar += ControlBarraTitulo_ClickCerrar;
            //ControlBarraTitulo.MouseLeftButtonDown += ControlBarraTitulo_MouseLeftButtonDown;
            //ControlBarraTitulo.ClickMinimizar += ControlBarraTitulo_ClickMinimizar;                     
            //BotonAdicionar.Click +=botonAdicionar_Click;
            //ControlBarraTitulo.OcultarBotonMaximizar = true;
            //_sexos.RecargarElementos();
            //ComboBoxSexo.ItemsSource = _sexos;    
        }

        //public void ConfigurarDialogo(bool esOperacionModificar)
        //{
        //    this.EsOperacionModificar = esOperacionModificar;
        //    if (esOperacionModificar)
        //    {
        //        this.Title = "Modificar trabajador";               
        //        this.BotonAdicionar.Content = "Modificar";
        //        BotonAdicionar.Content = "Modificar";
        //    }
        //    else
        //    {
        //        this.Title = "Adicionar trabajador";
        //        this.BotonAdicionar.Content = "Adicionar";
        //    }
        //    this.ControlBarraTitulo.Titulo = this.Title;

        //}
        //void ControlBarraTitulo_ClickMinimizar(object sender, RoutedEventArgs e)
        //{
        //    WindowState = WindowState.Minimized;
        //}

        //void ControlBarraTitulo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    DragMove();
        //}

        //void ControlBarraTitulo_ClickCerrar(object sender, RoutedEventArgs e)
        //{
        //    Close();
        //}
        //public void ConfigurarParaPrimeraConfiguracion()
        //{  
        //    this.Title = "Registrar sus datos personales";
        //    this.BotonAdicionar.Content = "Registrar";
        //    this.ControlBarraTitulo.Titulo = this.Title;           
        //}    
        //void ActivarValidaciones()
        //{
        //    var valorNombreTrabajador = TextBoxNombreApellidos.Text;
        //    TextBoxNombreApellidos.Text = "";
        //    TextBoxNombreApellidos.Text = valorNombreTrabajador;

        //    var valorNit = TextBoxNit.Text;
        //    TextBoxNit.Text = "";
        //    TextBoxNit.Text = valorNit;

        //    var valorSexo = ComboBoxSexo.Text;
        //    ComboBoxSexo.Text = "";
        //    ComboBoxSexo.Text = valorSexo;
        //}
        //void botonAdicionar_Click(object sender, RoutedEventArgs e)
        //{
        //    ActivarValidaciones();
        //    if (DialogoEsValido(this))
        //    {                
        //        DialogResult = true;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Por favor corrija los datos que están marcados como no válidos");
        //    }
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
