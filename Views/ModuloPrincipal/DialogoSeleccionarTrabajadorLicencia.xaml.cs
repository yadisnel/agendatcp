using Agenda.ModeloVistas.ModuloPrincipal;
using Agenda.ModeloDatos.Dao;
using Agenda.ModeloDatos.Entidades;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace Agenda.Vistas.ModuloPrincipal
{
    public partial class DialogoSeleccionarTrabajadorLicencia
    {
       
        //public ListCollectionView VistaColeccionTrabajadores;
        //public ListCollectionView VistaColeccionLicencias;
        //public EntidadTcp TrabajadorSeleccionado { get; set; }
        //public EntidadLicencia LicenciaSeleccionada { get; set;}
        //DialogoSeleccionarTrabajadorLicenciaModeloVista ModeloVista = new DialogoSeleccionarTrabajadorLicenciaModeloVista();
        public DialogoSeleccionarTrabajadorLicencia()
        {
            InitializeComponent();
                    
            //this.PestanaNuevaActividad.Visibility = Visibility.Collapsed;
           
            //this.DataContext = ModeloVista;
            //ModeloVista.ListaTrabajadores.RecargarElementos();
            //ModeloVista.ListaActividades.RecargarElementos();

            //this.ControlBarraTitulo.MouseLeftButtonDown += ControlBarraTitulo_MouseLeftButtonDown;
            //this.ControlBarraTitulo.ClickCerrar += ControlBarraTitulo_ClickCerrar;
            //this.ControlBarraTitulo.ClickMinimizar += ControlBarraTitulo_ClickMinimizar;
            //this.ControlBarraTitulo.OcultarBotonMaximizar = true;

            
            //this.PestanaNuevaActividad.Click += PestanaNuevaActividad_Click;
            //this.PestanaNuevoTrabajador.Click += PestanaNuevoTrabajador_Click;
            //this.PestanaNuevaActividad.Visibility = Visibility.Collapsed;
          
            //VistaColeccionTrabajadores = (ListCollectionView)CollectionViewSource.GetDefaultView(ModeloVista.ListaTrabajadores);
            //VistaColeccionLicencias = (ListCollectionView)CollectionViewSource.GetDefaultView(ModeloVista.ListaLicencias);                    
            
            //ComboBoxNombreTrabajador.SelectionChanged += ComboBoxNombreTrabajador_SelectionChanged;
            //ComboBoxNombreLicencia.SelectionChanged += ComboBoxNombreLicencia_SelectionChanged;
            //BotonAdicionarNuevoTrabajador.Click += BotonAdicionarNuevoTrabajador_Click;
            //BotonAdicionarNuevaActividad.Click += BotonAdicionarNuevaActividad_Click;

            //this.ComboBoxNombreTrabajador.TextoNoSeleccionado = "Primero seleccione el trabajador por cuenta propia.";
            //this.ComboBoxNombreLicencia.TextoNoSeleccionado = "Luego seleccione una actividad con la cual trabajar.";
            //this.ComboBoxNombreNuevaActividad.TextoNoSeleccionado = "Click aquí para seleccionar una nueva actividad.";
            //this.ComboBoxNombreTrabajador.SelectedIndex = -1;
            //this.ComboBoxNombreLicencia.SelectedIndex = -1;         

            //if (ModeloVista.ListaTrabajadores.Count == 0)
            //{
            //    SeleccionarPestañaNuevoTrabajador();
            //}
            //if (ModeloVista.ListaTrabajadores.Count == 1)
            //{
            //    LinkedList<EntidadAbs> TodosLosTcp = new DaoTcp().ObtenerTodosLosElementos();
            //    EntidadTcp miTcp = (EntidadTcp)TodosLosTcp.First.Value;
            //    ModeloVista.ListaLicencias.RecargarElementos(miTcp);
            //    if (ModeloVista.ListaLicencias.Count == 0)
            //    {
            //        SeleccionarPestañaNuevaActividad();
            //        int Indice = -1;
            //        for (int i = 0; i < VistaColeccionTrabajadores.Count; i++)
            //        {
            //            Indice++;
            //            EntidadTcp Item = VistaColeccionTrabajadores.GetItemAt(i) as EntidadTcp;
            //            if (Item.CodigoTcp == miTcp.CodigoTcp)
            //            {
            //                ComboBoxNombreTrabajador.SelectedIndex = Indice;
            //                break;
            //            }
            //        }
            //    }               
            //}
        }

        //private void PestanaNuevoTrabajador_Click(object sender, RoutedEventArgs e)
        //{
        //    SeleccionarPestañaNuevoTrabajador();
        //}

        //private void PestanaNuevaActividad_Click(object sender, RoutedEventArgs e)
        //{
        //    GridContenedorComponentesNuevaActividad.Visibility = Visibility.Visible;
        //    GridContenedorComponentesNuevoTrabajador.Visibility = Visibility.Collapsed;
        //    BordeFondoBotonBotonNuevaActividad.Visibility = Visibility.Visible;
        //    BordeFondoBotonNuevoTrabajador.Visibility = Visibility.Collapsed;
        //}

        //private void SeleccionarPestañaNuevoTrabajador()
        //{
        //    GridContenedorComponentesNuevoTrabajador.Visibility = Visibility.Visible;
        //    GridContenedorComponentesNuevaActividad.Visibility = Visibility.Collapsed;
        //    BordeFondoBotonBotonNuevaActividad.Visibility = Visibility.Collapsed;
        //    BordeFondoBotonNuevoTrabajador.Visibility = Visibility.Visible;
        //}
        //private void SeleccionarPestañaNuevaActividad()
        //{
        //    GridContenedorComponentesNuevaActividad.Visibility = Visibility.Visible;
        //    GridContenedorComponentesNuevoTrabajador.Visibility = Visibility.Collapsed;
        //    BordeFondoBotonBotonNuevaActividad.Visibility = Visibility.Visible;
        //    BordeFondoBotonNuevoTrabajador.Visibility = Visibility.Collapsed;
        //}
        //void BotonAdicionarNuevaActividad_Click(object sender, RoutedEventArgs e)
        //{
        //    if (ComboBoxNombreNuevaActividad.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Debe seleccionar una nueva actividad de la lista para poder continuar.", "Error en la entrada de datos", MessageBoxButton.OK);
        //        return;
        //    }
        //    if (TextBoxNumeroLicenciaNuevaActividad.Text == "")
        //    {
        //        MessageBox.Show("Debe escribir un número de licencia válido para poder continuar.", "Error en la entrada de datos", MessageBoxButton.OK);
        //        return;
        //    }
        //    int numAux = -1;
        //    if(!int.TryParse(TextBoxNumeroLicenciaNuevaActividad.Text,out numAux))
        //    {
        //        MessageBox.Show("Debe escribir un número de licencia válido para poder continuar.", "Error en la entrada de datos", MessageBoxButton.OK);
        //        return;
        //    }
        //    if (numAux <= 0)
        //    {
        //        MessageBox.Show("Debe escribir un número de licencia válido para poder continuar.", "Error en la entrada de datos", MessageBoxButton.OK);
        //        return;
        //    }
        //    EntidadActividad actividadSeleccionada = ComboBoxNombreNuevaActividad.SelectedItem as EntidadActividad;
        //    EntidadTcp trabajadorSeleccionado = ComboBoxNombreTrabajador.SelectedItem as EntidadTcp;
        //    EntidadLicencia nuevaLicencia = new EntidadLicencia() { CodigoLicencia = new DaoLicencia().ObtenerProximoCodigoLicencia(), CodigoActividad = actividadSeleccionada.CodigoActividad, Nombre = actividadSeleccionada.Nombre, CodigoTcp = trabajadorSeleccionado.CodigoTcp, NumeroLicencia = numAux };
        //    new DaoLicencia().AdicionarNuevoElemento(nuevaLicencia);            
        //    TrabajadorSeleccionado = trabajadorSeleccionado;
        //    LicenciaSeleccionada = nuevaLicencia;
        //    this.DialogResult = true;
        //}

        //void ComboBoxNombreLicencia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (ComboBoxNombreLicencia.SelectedIndex != -1)
        //    {
        //       TrabajadorSeleccionado = (EntidadTcp)this.ComboBoxNombreTrabajador.SelectedItem;
        //       LicenciaSeleccionada = (EntidadLicencia)this.ComboBoxNombreLicencia.SelectedItem;
        //       this.DialogResult = true;
        //    }
        //}

        //void BotonAdicionarNuevoTrabajador_Click(object sender, RoutedEventArgs e)
        //{          

        //    if (this.TextBoxNombreNuevoTrabajador.Text == "")
        //    {
        //        MessageBox.Show("Debe escribir un nombre de trabajador válido para poder continuar.", "Error en la entrada de datos", MessageBoxButton.OK);
        //        return;
        //    }
        //    if (this.TextBoxNitNuevoTrabajador.Text == "" || this.TextBoxNitNuevoTrabajador.Text.Length > 11)
        //    {
        //        MessageBox.Show("Debe escribir un Número de Identificación Tributaria (NIT) válido para poder continuar.", "Error en la entrada de datos", MessageBoxButton.OK);
        //        return;
        //    }

        //    EntidadTcp nuevoTcp = new EntidadTcp() { CodigoTcp = new DaoTcp().ObtenerProximoCodigoTcp(), Nit = this.TextBoxNitNuevoTrabajador.Text, NombreApellidos = this.TextBoxNombreNuevoTrabajador.Text };
        //    new DaoTcp().AdicionarNuevoElemento(nuevoTcp);
        //    this.TextBoxNitNuevoTrabajador.Text = "";
        //    this.TextBoxNombreNuevoTrabajador.Text = "";
        //    ModeloVista.ListaTrabajadores.RecargarElementos();
        //    int Indice = -1;
        //    for (int i = 0; i < VistaColeccionTrabajadores.Count; i++)
        //    {
        //        Indice++;
        //        EntidadTcp Item = VistaColeccionTrabajadores.GetItemAt(i) as EntidadTcp;
        //        if (Item.CodigoTcp == nuevoTcp.CodigoTcp)
        //        {
        //            this.ComboBoxNombreTrabajador.SelectedIndex = Indice;
        //            break;
        //        }
        //    }
        //    ModeloVista.ListaLicencias.RecargarElementos(nuevoTcp);
        //    if (ModeloVista.ListaLicencias.Count == 0)
        //    {
        //        this.SeleccionarPestañaNuevaActividad();
        //    }
        //}

        //void ComboBoxNombreTrabajador_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (ComboBoxNombreTrabajador.SelectedIndex != -1)
        //    {
        //        this.PestanaNuevaActividad.Visibility = Visibility.Visible;
        //    }
        //    else
        //    {
        //        this.PestanaNuevaActividad.Visibility = Visibility.Collapsed;
        //    }

        //    if (ComboBoxNombreTrabajador.SelectedIndex != -1)
        //    {
        //        ModeloVista.ListaLicencias.RecargarElementos(this.ComboBoxNombreTrabajador.SelectedItem as EntidadTcp);
        //        this.ComboBoxNombreLicencia.ItemsSource = ModeloVista.ListaLicencias;               
        //        if (ModeloVista.ListaLicencias.Count == 0)
        //        {
        //            this.SeleccionarPestañaNuevaActividad();
        //        }                
        //    }
        //    else
        //    {
        //        ModeloVista.ListaLicencias.Clear();
        //        this.ComboBoxNombreLicencia.SelectedIndex = -1;
        //    }
        //}

        //void ControlBarraTitulo_ClickMinimizar(object sender, RoutedEventArgs e)
        //{
        //    WindowState = WindowState.Minimized;
        //}

        //void ControlBarraTitulo_ClickCerrar(object sender, RoutedEventArgs e)
        //{
        //    DialogResult = false;            
        //}

        //void ControlBarraTitulo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    DragMove();
        //}
    }
}
