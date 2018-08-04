using Agenda.ModeloDatos.Configuracion;
using Agenda.ModeloDatos.Dao;
using Agenda.ModeloDatos.Entidades;
using Agenda.ModeloDatos.Consultas;
using Agenda.Controles;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace Agenda.ModuloDialogos.Dialogos
{
    public partial class DialogoAdicionarModificarLicencias
    {
        //private readonly ListadoActividades _actividadesDisponibles = new ListadoActividades();
        //private readonly ListadoLicencias _licencias = new ListadoLicencias();
        //private bool _esPrimeraConfiguracion = false;
        //public EntidadTcp TcpActivo {get;set;}
        //private ListCollectionView VistaColeccionPatentesActivas { get; set; }
        //private ListCollectionView VistaColeccionPatentesDisponibles { get; set; }
       
        //private Storyboard _storyboardAnimacionFlecha;
       
        public void ConfigurarActividades(bool esPrimeraConfiguracion)
        {
            //_esPrimeraConfiguracion = esPrimeraConfiguracion;
            //if (TcpActivo != null)
            //{
            //    _licencias.RecargarElementos(TcpActivo);
            //    _actividadesDisponibles.RecargarElementos();
            //    /*foreach (EntidadLicencia pa in _licencias)
            //    {
            //        foreach (EntidadActividad pt in _actividadesDisponibles)
            //        {
            //            if (pa.CodigoActividad == pt.CodigoActividad)
            //            {
            //                _actividadesDisponibles.Remove(pt);
            //                break;
            //            }
            //        }
            //    }*/
            //}
            //else
            //{
            //    throw new ArgumentNullException("TcpActivo no puede ser null.");
            //}
        }
        //public DialogoAdicionarModificarLicencias()
        //{
        //    InitializeComponent();
        //    ControlBarraTitulo.OcultarBotonMaximizar = true;
        //    ControlBarraTitulo.MouseLeftButtonDown += ControlBarraTitulo_MouseLeftButtonDown;
        //    ControlBarraTitulo.ClickCerrar += ControlBarraTitulo_ClickCerrar;
        //    ControlBarraTitulo.ClickMinimizar += ControlBarraTitulo_ClickMinimizar;
        //    BotonAceptar.Click += BotonAceptar_Click; 
            
        //    GridActividades.ItemsSource = _actividadesDisponibles;            
        //    GridLicencias.ItemsSource = _licencias;
            
        //    GridActividades.AdicionarMenu("MenuSeleccionarActividad","Seleccionar actividad","IconoAdicionar");            
        //    GridActividades.ObtenerMenu("MenuSeleccionarActividad").Click += MenuSeleccionarActividad_Click;           
        //    GridLicencias.AdicionarMenu("MenuEliminarActividad", "Eliminar actividad", "IconoEliminar");

        //    GridActividades.AdicionarColumna("IconoItem", "", (DataTemplate)this.FindResource("plantillaDatosCeldaIconoItemListadoActividades"));
        //    GridActividades.AdicionarColumna("Nombre", "Nombre", (DataTemplate)this.FindResource("plantillaDatosCeldaNombreActividad"));

        //    GridLicencias.AdicionarColumna("IconoItem", "", (DataTemplate)this.FindResource("plantillaDatosCeldaIconoItemListadoActividades"));
        //    GridLicencias.AdicionarColumna("NumeroLicencia", "Número de licencia", (DataTemplate)this.FindResource("plantillaDatosCeldaNumeroLicencia"));
        //    GridLicencias.AdicionarColumna("Nombre", "Nombre", (DataTemplate)this.FindResource("plantillaDatosCeldaNombreActividad"));

        //    GridLicencias.ObtenerMenu("MenuEliminarActividad").Click += MenuEliminarActividad_Click;

        //    GridActividades.SelectionChanged += GridActividades_SelectionChanged;
        //    GridLicencias.SelectionChanged += GridLicencias_SelectionChanged;

        //    BotonSeleccionarActividad.Click +=BotonSeleccionarActividad_Click;
        //    BotonDeseleccionarActividad.Click +=BotonDeseleccionarActividad_Click;

        //    GridActividades.SelectedIndex = -1;
        //    GridLicencias.SelectedIndex = -1;

        //    GridLicencias.TextSearchChanged += GridLicencias_TextSearchChanged;
        //    GridActividades.TextSearchChanged += GridActividades_TextSearchChanged;

        //    VistaColeccionPatentesDisponibles = (ListCollectionView)CollectionViewSource.GetDefaultView(_actividadesDisponibles);
        //    VistaColeccionPatentesActivas = (ListCollectionView)CollectionViewSource.GetDefaultView(_licencias);
        //    VistaColeccionPatentesDisponibles.SortDescriptions.Add(new SortDescription("Nombre", ListSortDirection.Ascending));
        //    VistaColeccionPatentesActivas.SortDescriptions.Add(new SortDescription("Nombre", ListSortDirection.Ascending));
        //}

        //void MenuEliminarActividad_Click(object sender, RoutedEventArgs e)
        //{
        //    BotonDeseleccionarActividad_Click(sender, e);
        //}

        //void MenuSeleccionarActividad_Click(object sender, RoutedEventArgs e)
        //{
        //    BotonSeleccionarActividad_Click(sender, e);
        //}

        //void GridActividades_TextSearchChanged(object sender, RoutedEventArgs e)
        //{
        //    var textoBusqueda = GridActividades.TextSearch;
        //    if (textoBusqueda != "")
        //    {
        //        VistaColeccionPatentesDisponibles.Filter = FiltrarBusquedaRapidaPatentesDisponibles;
        //    }
        //    else
        //    {
        //        VistaColeccionPatentesDisponibles.Filter = null;
        //    }
        //}

        //void GridLicencias_TextSearchChanged(object sender, RoutedEventArgs e)
        //{
        //    var textoBusqueda = GridLicencias.TextSearch;
        //    if (textoBusqueda != "")
        //    {
        //        VistaColeccionPatentesActivas.Filter = FiltrarBusquedaRapidaPatentesActivas;
        //    }
        //    else
        //    {
        //        VistaColeccionPatentesActivas.Filter = null;
        //    }
        //}

        //void GridLicencias_SelectionChanged(object sender, RoutedEventArgs e)
        //{
        //    if (GridLicencias.SelectedIndex != -1)
        //    {
        //        var EntidadLicencia = GridLicencias.SelectedItem as EntidadLicencia;
        //        EntidadActividad ptte = new DaoActividad().ObtenerElemento(EntidadLicencia.CodigoLicencia) as EntidadActividad;
        //        if (EntidadLicencia != null)
        //        {
        //            GridLicencias.Detalles = ptte.Descripcion;                    
        //        }
        //        if (_storyboardAnimacionFlecha != null)
        //        {
        //            _storyboardAnimacionFlecha.Stop(this);
        //            _storyboardAnimacionFlecha.SkipToFill(this);
        //        }            
        //        ConfigurarAnimacionFlecha(BotonDeseleccionarActividad);
        //    }
        //}

        //void GridActividades_SelectionChanged(object sender, RoutedEventArgs e)
        //{
        //    if (GridActividades.SelectedIndex != -1)
        //    {
        //        var entidadNpatente = GridActividades.SelectedItem as EntidadActividad;
        //        if (entidadNpatente != null)
        //        {
        //            GridActividades.Detalles = entidadNpatente.Descripcion;                    
        //        }
        //        if (_storyboardAnimacionFlecha != null)
        //        {
        //            _storyboardAnimacionFlecha.Stop(this);
        //            _storyboardAnimacionFlecha.SkipToFill(this);
        //        }                
        //        ConfigurarAnimacionFlecha(BotonSeleccionarActividad);
        //    }
        //} 
                

        //void ControlBarraTitulo_ClickMinimizar(object sender, RoutedEventArgs e)
        //{
        //    WindowState = WindowState.Minimized;
        //}

        //void ControlBarraTitulo_ClickCerrar(object sender, RoutedEventArgs e)
        //{
        //    Close();
        //}

        //void ControlBarraTitulo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    DragMove();
        //}

        //void BotonAceptar_Click(object sender, RoutedEventArgs e)
        //{
        //   this.DialogResult = true;                  
        //}
        
        //private bool FiltrarBusquedaRapidaPatentesDisponibles(object de)
        //{
        //    var textoBusquedaMayuscula = GridActividades.TextSearch.ToUpper();
        //    var textoNombre = "";
        //    if (de != null)
        //    {
        //        if (de is EntidadActividad)
        //        {
        //            textoNombre = (de as EntidadActividad).Nombre;
        //        }                
        //    }
        //    else throw new ArgumentNullException("El parámetro 'de' no puede ser null.");
        //    textoNombre = textoNombre.ToUpper();
        //    if (textoNombre.Contains(textoBusquedaMayuscula)) return true;          
        //    return false;
        //}
        //private bool FiltrarBusquedaRapidaPatentesActivas(object de)
        //{
        //    var textoBusquedaMayuscula = GridLicencias.TextSearch.ToUpper();
        //    var textoNombre = "";
        //    if (de != null)
        //    {
        //        if (de is EntidadActividad)
        //        {
        //            textoNombre = (de as EntidadActividad).Nombre;
        //        }
        //    }
        //    else throw new ArgumentNullException("El parámetro 'de' no puede ser null.");
        //    textoNombre = textoNombre.ToUpper();
        //    if (textoNombre.Contains(textoBusquedaMayuscula)) return true;
        //    return false;
        //} 
        
        //void BotonDeseleccionarActividad_Click(object sender, RoutedEventArgs e)
        //{
        //    if (TcpActivo != null)
        //    {
        //        if (_licencias.Count == 0)
        //        {
        //            MessageBox.Show("No hay actividades disponibles para ser eliminadas.");
        //            return;
        //        }

        //        if (GridLicencias.SelectedIndex == -1)
        //        {
        //            MessageBox.Show("Para eliminar una actividad, primeramente debe seleccionarla de la lista.");
        //            return;
        //        }
        //        if (!_esPrimeraConfiguracion)
        //        {
        //            var Result = MessageBox.Show("Al eliminar una actividad, se elmiminarán automáticamente todos los datos asociados a esta. ¿Desea continuar y que el sistema haga esto para usted?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
        //            if (Result == MessageBoxResult.Yes)
        //            {
        //                EntidadLicencia epa = GridLicencias.SelectedItem as EntidadLicencia;
        //                int  codigoep = (GridLicencias.SelectedItem as EntidadLicencia).CodigoActividad;
        //                EntidadActividad ep = new DaoActividad().ObtenerElemento(codigoep) as EntidadActividad;
        //                new DaoLicencia().EliminarElemento(epa.CodigoLicencia);
        //                _licencias.RecargarElementos(TcpActivo);
        //                _actividadesDisponibles.Add(ep);
        //                MessageBox.Show("La actividad fue eliminada correctamente.");
        //            }
        //            else
        //            {
        //                return;
        //            }
        //        }
        //        else
        //        {
        //            if (_licencias.Count == 1)
        //            {
        //                MessageBox.Show("No puede eliminar la actividad y dejar al trabajador sin actividades configuradas. Si desea eliminar la actividad actual, adicione una nueva antes de hacerlo.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        //                return;
        //            }
        //            EntidadLicencia epa = GridLicencias.SelectedItem as EntidadLicencia;
        //            int codigoep = (GridLicencias.SelectedItem as EntidadLicencia).CodigoActividad;
        //            EntidadActividad ep = new DaoActividad().ObtenerElemento(codigoep) as EntidadActividad;
        //            new DaoLicencia().EliminarElemento(epa.CodigoLicencia);
        //            _licencias.RecargarElementos(TcpActivo);
        //            _actividadesDisponibles.Add(ep);
        //            MessageBox.Show("La actividad fue eliminada correctamente.");
        //        }

        //        GridLicencias.Detalles = "";
        //        GridLicencias.TextSearch = "";
        //    }
        //    else
        //    {
        //        throw new ArgumentNullException("TcpActivo no puede ser null.");
        //    }
        //}
        //void BotonSeleccionarActividad_Click(object sender, RoutedEventArgs e)
        //{
        //    if (TcpActivo != null)
        //    {
        //        if (GridActividades.SelectedIndex != -1)
        //        {
        //            int numeroLicencia = 0;
        //            if (int.TryParse(TextBoxNumeroLicencia.Text, out numeroLicencia) == false)
        //            {
        //                MessageBox.Show("Por favor introduzca un número de licencia válido para poder continuar.", "Error en la entrada de datos", MessageBoxButton.OK);
        //                return;
        //            }
        //            if (numeroLicencia < 0)
        //            {
        //                MessageBox.Show("Por favor introduzca un número de licencia válido para poder continuar.", "Error en la entrada de datos", MessageBoxButton.OK);
        //                return;
        //            }

        //            if (new DaoLicencia().ExisteLicenciaConNumero(numeroLicencia))
        //            {
        //                MessageBox.Show("El número de licencia proporcionado ya se encuentra registrado en el sistema.Por favor introduzca un número de licencia válido para poder continuar.", "Error en la entrada de datos", MessageBoxButton.OK);
        //                return;
        //            }

        //            var tcp = TcpActivo;
        //            var patente = GridActividades.SelectedItem as EntidadActividad;
        //            var patenteActiva = new EntidadLicencia
        //            {
        //                CodigoLicencia = new DaoLicencia().ObtenerProximoCodigoLicencia(),
        //                CodigoActividad = patente.CodigoActividad,
        //                CodigoTcp = tcp.CodigoTcp,  
        //                NumeroLicencia  = numeroLicencia,
        //                Nombre = patente.Nombre
        //            };
        //            new DaoLicencia().AdicionarNuevoElemento(patenteActiva);
        //            _licencias.Add(patenteActiva);                   
        //            GridActividades.SelectedIndex = -1;
        //            GridActividades.TextSearch = "";
        //            GridActividades.Detalles = "";
        //            TextBoxNumeroLicencia.Text = "";
        //            if (_storyboardAnimacionFlecha != null)
        //            {
        //                _storyboardAnimacionFlecha.Stop(this);
        //                _storyboardAnimacionFlecha.SkipToFill(this);
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Debe seleccionar una actividad para luego poder agregarla.");
        //        }
        //    }
        //    else
        //    {
        //        throw new ArgumentNullException("TcpActivo no puede ser null.");
        //    }
        //}
       
        //void ConfigurarAnimacionFlecha( IFrameworkInputElement flecha)
        //{
        //    RegisterName(flecha.Name, flecha);

        //    var miDoubleAnimation1 = new DoubleAnimation
        //    {
        //        From = 1.0,
        //        To = 0.0,
        //        Duration = new Duration(TimeSpan.FromSeconds(1.5)),
        //        AutoReverse = true,
        //        BeginTime = TimeSpan.FromSeconds(0),
        //    };

        //    var miDoubleAnimation2 = new DoubleAnimation
        //    {
        //        From = 1.0,
        //        To = 0.0,
        //        Duration = new Duration(TimeSpan.FromSeconds(1.5)),
        //        BeginTime = TimeSpan.FromSeconds(3),
        //        AutoReverse = true
        //    };

        //    var miDoubleAnimation3 = new DoubleAnimation
        //    {
        //        From = 1.0,
        //        To = 0.0,
        //        Duration = new Duration(TimeSpan.FromSeconds(1.5)),
        //        BeginTime = TimeSpan.FromSeconds(6),
        //        AutoReverse = true               
        //    };

        //    _storyboardAnimacionFlecha = new Storyboard();
        //    _storyboardAnimacionFlecha.Children.Add(miDoubleAnimation1);
        //    _storyboardAnimacionFlecha.Children.Add(miDoubleAnimation2);
        //    _storyboardAnimacionFlecha.Children.Add(miDoubleAnimation3);

        //    Storyboard.SetTargetName(miDoubleAnimation1, flecha.Name);
        //    Storyboard.SetTargetName(miDoubleAnimation2, flecha.Name);
        //    Storyboard.SetTargetName(miDoubleAnimation3, flecha.Name);

        //    Storyboard.SetTargetProperty(miDoubleAnimation1, new PropertyPath(OpacityProperty));
        //    Storyboard.SetTargetProperty(miDoubleAnimation2, new PropertyPath(OpacityProperty));
        //    Storyboard.SetTargetProperty(miDoubleAnimation3, new PropertyPath(OpacityProperty));

        //    _storyboardAnimacionFlecha.Begin(this,true);
        //}

        //private void Titulo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    DragMove();
        //}
    }
}
