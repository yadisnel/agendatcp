using Agenda.ModeloDatos.Dao;
using Agenda.ModeloDatos.Entidades;
using Agenda.ModeloDatos.Consultas;
using Agenda.Controles;
using Agenda.ModuloExc.Excepciones;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace Agenda.ModuloDialogos.Dialogos
{
    public partial class DialogoSeleccionarLicencia
    {
        //private readonly ListadoLicencias _actividadsActivas = new ListadoLicencias();
        //private readonly ListadoTrabajadores _trabajadoresConfigurados = new ListadoTrabajadores();
        //public EntidadTcp TcpActivo { get; set; }
        //public EntidadLicencia Licencia { get; set; }
        
        //private ListCollectionView VistaColeccionactividads { get; set; }
        //private ListCollectionView VistaColeccionTrabajadores { get; set; } 
       
        public DialogoSeleccionarLicencia()
        {
            InitializeComponent();

            //ControlBarraTitulo.MouseLeftButtonDown += ControlBarraTitulo_MouseLeftButtonDown;
            //ControlBarraTitulo.ClickCerrar += ControlBarraTitulo_ClickCerrar;
            //ControlBarraTitulo.OcultarBotonMaximizar = true;
            //ControlBarraTitulo.ClickMinimizar += ControlBarraTitulo_ClickMinimizar;

            //GridTrabajadores.AdicionarMenu("AdicionarTrabajador", "Adicionar trabajador", "IconoAdicionar");
            //GridTrabajadores.AdicionarMenu("ModificarTrabajador", "Modificar trabajador", "IconoModificar");
            //GridTrabajadores.AdicionarMenu("EliminarTrabajador", "Eliminar trabajador", "IconoEliminar");

            //GridTrabajadores.AdicionarColumna("IconoItem", "", (DataTemplate)this.FindResource("plantillaDatosCeldaIconoItemListadoTrabajadores"));
            //GridTrabajadores.AdicionarColumna("Nit", "NIT", (DataTemplate)this.FindResource("plantillaDatosCeldaNitTrabajador"));
            //GridTrabajadores.AdicionarColumna("NombreApellidos", "Nombre y apellidos", (DataTemplate)this.FindResource("plantillaDatosCeldaNombreTrabajador"));
            //GridLicencias.AdicionarColumna("IconoItem", "", (DataTemplate)this.FindResource("plantillaDatosCeldaIconoItemListadoActividades"));
            //GridLicencias.AdicionarColumna("NumeroLicencia", "Número de licencia", (DataTemplate)this.FindResource("plantillaDatosCeldaNumeroLicencia"));
            //GridLicencias.AdicionarColumna("Nombre", "Nombre", (DataTemplate)this.FindResource("plantillaDatosCeldaNombreActividad"));
            //GridTrabajadores.ObtenerMenu("AdicionarTrabajador").Click += AdicionarNuevoTrabajador_Click;
            //GridTrabajadores.ObtenerMenu("ModificarTrabajador").Click += ModificarTrabajador_Click;
            //GridTrabajadores.ObtenerMenu("EliminarTrabajador").Click += EliminarTrabajador_Click;
            //GridTrabajadores.TextSearchChanged += GridTrabajadores_TextSearchChanged;
            //_trabajadoresConfigurados.RecargarElementos();
            //GridTrabajadores.ItemsSource = _trabajadoresConfigurados;
            //VistaColeccionTrabajadores = (ListCollectionView)CollectionViewSource.GetDefaultView(_trabajadoresConfigurados);

            //GridLicencias.AdicionarMenu("GestionarActividadesTrabajador", "Gestionar actividades", "IconoAdicionar");

            //GridLicencias.TextSearchChanged += GridLicencias_TextSearchChanged;
            //GridLicencias.ItemsSource = _actividadsActivas;
            //VistaColeccionactividads= (ListCollectionView)CollectionViewSource.GetDefaultView(_actividadsActivas);            
            //GridTrabajadores.SelectionChanged += GridTrabajadores_SelectionChanged;
            //VistaColeccionTrabajadores.SortDescriptions.Clear();            
            //VistaColeccionTrabajadores.SortDescriptions.Add(new SortDescription("NombreApellidos", ListSortDirection.Ascending));
            //GridLicencias.SelectionChanged += GridLicencias_SelectionChanged;           
            //GridLicencias.ObtenerMenu("GestionarActividadesTrabajador").Click += GestionarActividadesTrabajador_Click; 
            //VistaColeccionactividads.SortDescriptions.Clear();
            
            //botonAceptar.Click += botonAceptar_Click;
            //botonCancelar.Click += botonCancelar_Click;

            //GridTrabajadores.SelectedIndex = -1;
            //GridLicencias.SelectedIndex = -1;
        }

        //void GestionarActividadesTrabajador_Click(object sender, RoutedEventArgs e)
        //{
        //    if (GridTrabajadores.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Para gestionar las actividades, primeramente debe seleccionar un trabajador de la lista.");
        //        return;
        //    }
        //    DialogoAdicionarModificarLicencias dlg = new DialogoAdicionarModificarLicencias();
        //    dlg.TcpActivo = GridTrabajadores.SelectedItem as EntidadTcp;
        //    dlg.ConfigurarActividades(false);
        //    this.Opacity = 0;
        //    dlg.ShowDialog();            
        //    _actividadsActivas.RecargarElementos(dlg.TcpActivo);
        //    this.Opacity = 1;        
        //}

        //void botonCancelar_Click(object sender, RoutedEventArgs e)
        //{
        //    Licencia = null;
        //    DialogResult = false;
        //}

        //void botonAceptar_Click(object sender, RoutedEventArgs e)
        //{
        //    if(GridTrabajadores.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Para seleccionar una actividad, primeramente debe seleccionar un trabajador de la lista.");
        //        return;
        //    }
        //    if (GridLicencias.SelectedIndex == -1)
        //    {
        //        if (_actividadsActivas.Count == 0)
        //        {
        //            MessageBox.Show("Debe adicionar una actividad y a continuación seleccionarla.");
        //            return;
        //        }
        //        else if (_actividadsActivas.Count == 1)
        //        {
        //            GridLicencias.SelectedIndex = 0;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Para continuar, primeramente debe seleccionar una actividad de la lista.");
        //            return;
        //        }
        //    }
        //    Licencia = (EntidadLicencia)new DaoLicencia().ObtenerElemento(  (GridLicencias.SelectedItem as EntidadLicencia).CodigoLicencia  );
        //    DialogResult = true;
        //}

        //void GridLicencias_TextSearchChanged(object sender, RoutedEventArgs e)
        //{
        //    var textoBusqueda = GridLicencias.TextSearch;
        //    if (textoBusqueda != "")
        //    {
        //        VistaColeccionactividads.Filter = FiltrarBusquedaRapidaactividads;
        //    }
        //    else
        //    {
        //        VistaColeccionactividads.Filter = null;
        //    }
        //}

        //void GridTrabajadores_TextSearchChanged(object sender, RoutedEventArgs e)
        //{
        //    var textoBusqueda = GridTrabajadores.TextSearch;
        //    if (textoBusqueda != "")
        //    {
        //        VistaColeccionTrabajadores.Filter = FiltrarBusquedaRapidaTrabajadores;
        //    }
        //    else
        //    {
        //        VistaColeccionTrabajadores.Filter = null;
        //    }
        //}

        //void OrdenPorcientoUso_Click(object sender, RoutedEventArgs e)
        //{
        //    VistaColeccionactividads.SortDescriptions.Clear();
        //    if ((sender as BotonOrdenamientoGridDatos).EsAscendente)
        //    {
        //        VistaColeccionactividads.SortDescriptions.Add(new SortDescription("PorcientoUso", ListSortDirection.Descending));
        //        (sender as BotonOrdenamientoGridDatos).EsAscendente = false;
        //    }
        //    else
        //    {
        //        VistaColeccionactividads.SortDescriptions.Add(new SortDescription("PorcientoUso", ListSortDirection.Ascending));
        //        (sender as BotonOrdenamientoGridDatos).EsAscendente = true;
        //    }
        //}

        //void OrdenNombre_Click(object sender, RoutedEventArgs e)
        //{
        //    VistaColeccionactividads.SortDescriptions.Clear();
        //    if ((sender as BotonOrdenamientoGridDatos).EsAscendente)
        //    {
        //        VistaColeccionactividads.SortDescriptions.Add(new SortDescription("Nombre", ListSortDirection.Descending));
        //        (sender as BotonOrdenamientoGridDatos).EsAscendente = false;
        //    }
        //    else
        //    {
        //        VistaColeccionactividads.SortDescriptions.Add(new SortDescription("Nombre", ListSortDirection.Ascending));
        //        (sender as BotonOrdenamientoGridDatos).EsAscendente = true;
        //    }
        //}

        //void OrdenamientoNombreTrabajador_Click(object sender, RoutedEventArgs e)
        //{           
        //    VistaColeccionTrabajadores.SortDescriptions.Clear();
        //    if ((sender as BotonOrdenamientoGridDatos).EsAscendente)
        //    {
        //        VistaColeccionTrabajadores.SortDescriptions.Add(new SortDescription("Nit", ListSortDirection.Descending));
        //        (sender as BotonOrdenamientoGridDatos).EsAscendente = false;
        //    }
        //    else
        //    {
        //        VistaColeccionTrabajadores.SortDescriptions.Add(new SortDescription("Nit", ListSortDirection.Ascending));
        //        (sender as BotonOrdenamientoGridDatos).EsAscendente = true;
        //    }
        //}

        //void OrdenamientoNitTrabajador_Click(object sender, RoutedEventArgs e)
        //{   
        //   VistaColeccionTrabajadores.SortDescriptions.Clear();
        //   if (  (sender as BotonOrdenamientoGridDatos).EsAscendente  )
        //   {
        //       VistaColeccionTrabajadores.SortDescriptions.Add(new SortDescription("Nit", ListSortDirection.Descending));
        //       (sender as BotonOrdenamientoGridDatos).EsAscendente = false;
        //   }
        //   else
        //   {
        //       VistaColeccionTrabajadores.SortDescriptions.Add(new SortDescription("Nit", ListSortDirection.Ascending));
        //       (sender as BotonOrdenamientoGridDatos).EsAscendente = true;
        //   }
        //}

        //void ModificarTrabajador_Click(object sender, RoutedEventArgs e)
        //{
        //    if (GridTrabajadores.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Primeramente debe seleccionar un trabajador para luego modificarlo.");
        //        return;
        //    }
        //    EntidadTcp miTcp = GridTrabajadores.SelectedItem as EntidadTcp;            
        //    DialogoAdicionarModificarTrabajador dlg = new DialogoAdicionarModificarTrabajador();
        //    dlg.ConfigurarDialogo(true);
        //    dlg.DataContext = miTcp;                
        //    if (dlg.ShowDialog() == true)
        //    {
        //        new DaoTcp().ActualizarElemento(miTcp.CodigoTcp, (EntidadAbs)dlg.DataContext);
        //        _trabajadoresConfigurados.RecargarElementos();
        //        MessageBox.Show("Los datos del trabajador fueron actualizados correctamente.");
        //    }    
        //}

        //void GridLicencias_SelectionChanged(object sender, RoutedEventArgs e)
        //{
        //    if (GridLicencias.SelectedIndex != -1)
        //    {
        //        VistaColeccionactividads.SortDescriptions.Clear();             

        //        EntidadLicencia epa = GridLicencias.SelectedItem as EntidadLicencia;              
        //        Licencia = (EntidadLicencia) new DaoLicencia().ObtenerElemento(epa.CodigoLicencia);               
        //        GridLicencias.Detalles = ((EntidadActividad)new DaoActividad().ObtenerElemento(epa.CodigoActividad)).Descripcion;
        //    }
        //}

        //void GridTrabajadores_SelectionChanged(object sender, RoutedEventArgs e)
        //{
        //    if (GridTrabajadores.SelectedIndex != -1)
        //    {
        //        EntidadTcp miTcp = GridTrabajadores.SelectedItem as EntidadTcp;
        //        TcpActivo = miTcp;
        //        _actividadsActivas.RecargarElementos(miTcp);
        //        GridTrabajadores.Detalles = miTcp.NombreApellidos + " con NIT: " + miTcp.Nit;
        //        GridLicencias.SelectedIndex = -1;
        //        GridLicencias.Detalles = "";                
        //    }
        //    else
        //    {
        //        GridTrabajadores.Detalles = "";
        //    }
        //}

        //void EliminarTrabajador_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        if (GridTrabajadores.SelectedIndex == -1)
        //        {
        //            MessageBox.Show("Primeramente debe seleccionar un trabajador para luego eliminarlo.");
        //            return;
        //        }
               

        //        var Trabajador = GridTrabajadores.SelectedItem as EntidadTcp;
               

        //        var Result = MessageBox.Show("Al eliminar un trabajador se elmiminarán automáticamente todos los datos asociados a este. ¿Desea continuar y que el sistema haga esto para usted?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
        //        if (Result == MessageBoxResult.Yes)
        //        {
        //            new DaoTcp().EliminarElemento(Trabajador.CodigoTcp);
        //            _trabajadoresConfigurados.RecargarElementos();
        //        }

        //    }
        //    catch (EAccesoDatosNoSePudoConectarConLaBd ex)
        //    {
        //        MessageBox.Show("No se pudo completar la operación debido a un error al acceder a los datos. Por favor revise la configuración de acceso a datos. Detalles del error:" + ex.Message);
        //    }
        //}

        //void AdicionarNuevoTrabajador_Click(object sender, RoutedEventArgs e)
        //{
        //    DialogoAdicionarModificarTrabajador dlg = new DialogoAdicionarModificarTrabajador();
        //    dlg.ConfigurarDialogo(false);
        //    if (dlg.ShowDialog() == true)
        //    {
        //        dlg.DatosTcp.CodigoTcp = new DaoTcp().ObtenerProximoCodigoTcp();
        //        new DaoTcp().AdicionarNuevoElemento(dlg.DatosTcp);
        //        _trabajadoresConfigurados.RecargarElementos();
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

        //private bool FiltrarBusquedaRapidaactividads(object de)
        //{
        //    var textoBusquedaMayuscula = GridLicencias.TextSearch.ToUpper();
        //    var textoNombre = "";
        //    if (de != null)
        //    {
        //        if (de is EntidadLicencia)
        //        {
        //            textoNombre = (de as EntidadLicencia).Nombre;
        //        }                
        //    }
        //    else throw new ArgumentNullException("El parámetro 'de' no puede ser null.");
        //    textoNombre = textoNombre.ToUpper();
        //    if (textoNombre.Contains(textoBusquedaMayuscula)) return true;
        //    return false;
        //}
        //private bool FiltrarBusquedaRapidaTrabajadores(object de)
        //{
        //    if (de == null) throw new ArgumentNullException("El parámetro 'de' no puede ser null.");
            
        //    var TextoBusqueda = GridTrabajadores.TextSearch;
        //    var miTCP = de as EntidadTcp;
        //    if (miTCP != null)
        //    {
        //        var NombreMay = miTCP.NombreApellidos.ToUpper();
        //        var NitMay = miTCP.Nit.ToUpper();
        //        var TextoBusquedaMayuscula = TextoBusqueda.ToUpper();
        //        if (NombreMay.Contains(TextoBusquedaMayuscula) || NitMay.Contains(TextoBusquedaMayuscula))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //} 
    }
}
