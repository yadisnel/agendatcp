using Agenda.ModeloDatos.Dao;
using Agenda.ModeloDatos.Entidades;
using Agenda.ModeloDatos.Consultas;
using Agenda.ModuloDialogos.Dialogos;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using Agenda.Controles;
namespace Agenda.Vistas.ModuloConfiguracion
{
    public partial class PaginaConfiguracionNomencladorActividades
    {
        //readonly ListadoActividades _listadoActividades = new ListadoActividades();
        //public ListCollectionView VistaColeccion;

        public PaginaConfiguracionNomencladorActividades()
        {
            InitializeComponent();
            //_listadoActividades.RecargarElementos();
            //GridActividades.ItemsSource = _listadoActividades;

            //GridActividades.SelectionChanged += new RoutedEventHandler(GridActividades_SelectionChanged);
            //GridActividades.AdicionarMenu("MenuAdicionarActividad", "Adicionar", "IconoAdicionar");
            //GridActividades.AdicionarMenu("MenuModificarActividad", "Modificar", "IconoModificar");
            //GridActividades.AdicionarMenu("MenuEstablecerLimitesActividad", "Establecer límites", "IconoEstablecerLimites");
            //GridActividades.AdicionarMenu("MenuEliminarActividad", "Eliminar", "IconoEliminar");

           

            //GridActividades.AdicionarColumna("IconoItem", "", (DataTemplate)this.FindResource("plantillaDatosCeldaIconoItemListadoActividades"));
            //GridActividades.AdicionarColumna("Nombre", "Nombre", (DataTemplate)this.FindResource("plantillaDatosCeldaNombreActividad"));

            //GridActividades.ObtenerMenu("MenuAdicionarActividad").Click += new RoutedEventHandler(MenuAdicionarActividad_Click);
            //GridActividades.ObtenerMenu("MenuModificarActividad").Click += new RoutedEventHandler(MenuModificarActividad_Click);
            //GridActividades.ObtenerMenu("MenuEliminarActividad").Click += new RoutedEventHandler(MenuEliminarActividad_Click);
            //GridActividades.ObtenerMenu("MenuEstablecerLimitesActividad").Click += MenuEstablecerLimitesActividad_Click;

            //VistaColeccion = (ListCollectionView)CollectionViewSource.GetDefaultView(_listadoActividades);
            //VistaColeccion.SortDescriptions.Clear();
            //VistaColeccion.SortDescriptions.Add(new SortDescription("Nombre", ListSortDirection.Ascending));          

            //GridActividades.TextSearchChanged += new RoutedEventHandler(GridActividades_TextSearchChanged);
        }
        //void MenuEstablecerLimitesActividad_Click(object sender, RoutedEventArgs e)
        //{
        //    if (GridActividades.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Debe seleccionar una actividad para luego establecer sus  límites.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        //        return;
        //    }
        //    DialogoAdicionarModificaLimitePatente dlg = new DialogoAdicionarModificaLimitePatente();
        //    dlg.Actividad = GridActividades.SelectedItem as EntidadActividad;
        //    dlg.ConfigurarDialogo( (GridActividades.SelectedItem as EntidadActividad).Nombre );
        //    if (dlg.ShowDialog() == true)
        //    {
        //        EntidadLimiteActividad lp = new EntidadLimiteActividad()
        //        {
        //            CodigoActividad = dlg.Actividad.CodigoActividad,
        //            CuotaMensualMinima = dlg.CuotaMensualMinima,
        //            GastoMaximo = dlg.GastoMaximo                    
        //        };
        //        //Todas las provincias
        //        if (dlg.ProvinciaSeleccionada.Nombre == "Todas")
        //        {
        //            new DaoLimiteActividad().AdicionarActualizarLimiteActividadTodasLasProvinciasEnInstanteLineaTiempo(lp, dlg.LineaTiempoSeleccionada);
        //        }
        //        else
        //        {
        //            //Todos los municipios de una provincia
        //            if (dlg.MunicipioSeleccionado.Nombre == "Todos")
        //            {
        //                new DaoLimiteActividad().AdicionarActualizarLimiteActividadTodosLosMunicipiosDeUnaProvinciaEnInstanteLineaTiempo(lp, dlg.ProvinciaSeleccionada, dlg.LineaTiempoSeleccionada);
        //            }//Un municipio de una provincia
        //            else
        //            {
        //                new DaoLimiteActividad().AdicionarActualizarLimiteActividadUnMunicipioEnInstanteLineaTiempo(lp, dlg.MunicipioSeleccionado, dlg.LineaTiempoSeleccionada);
        //            }
        //        }
        //        MessageBox.Show("Los límites de la actividad fueron actualizados correctamente.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        //    }
        //}
        //private bool FiltrarBusquedaRapida(object de)
        //{
        //    if (de == null)
        //    {
        //        throw new ArgumentNullException("El parámetro 'de' no puede ser null.");
        //    }

        //    var textoBusquedaMayuscula = GridActividades.TextSearch.ToUpper();
        //    var textoNombre = "";            
          
        //    if (de is EntidadActividad)
        //    {
        //        textoNombre = (de as EntidadActividad).Nombre;
        //    }
        //    textoNombre = textoNombre.ToUpper();
        //    if (textoNombre.Contains(textoBusquedaMayuscula)) return true;
        //    return false;
        //}

        //void GridActividades_TextSearchChanged(object sender, RoutedEventArgs e)
        //{
        //    var textoBusqueda = GridActividades.TextSearch;
        //    if (textoBusqueda != "")
        //    {
        //        VistaColeccion.Filter = FiltrarBusquedaRapida;
        //    }
        //    else
        //    {
        //        VistaColeccion.Filter = null;
        //    }
        //}

        //void MenuEliminarActividad_Click(object sender, RoutedEventArgs e)
        //{
        //    if (GridActividades.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Debe seleccionar una actividad para luego eliminarla.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        //        return;
        //    }
        //    var result = MessageBox.Show("Al eliminar la actividad se elmiminarán automáticamente todos los productos y ventas asociadas a esta. ¿Desea continuar y que el sistema haga esto para usted?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
        //    if (result != MessageBoxResult.Yes) return;
        //    var ep = GridActividades.SelectedItem as EntidadActividad;            
        //    new DaoActividad().EliminarElemento(ep.CodigoActividad);
        //    _listadoActividades.Remove(ep);
        //    _listadoActividades.RecargarElementos();
        //    MessageBox.Show("La actividad fue eliminada correctamente.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);          
        //}

        //void MenuModificarActividad_Click(object sender, RoutedEventArgs e)
        //{
        //    if (GridActividades.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Debe seleccionar una actividad para luego modificarla.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        //        return;
        //    }
        //    EntidadActividad ep = GridActividades.SelectedItem as EntidadActividad;
        //    var dlg = new DialogoAdicionarModificarActividades();
        //    dlg.ConfigurarDialogo(true);
        //    dlg.DataContext = ep;
        //    if (dlg.ShowDialog() == true)
        //    {
        //        var epmodificada = (EntidadActividad)dlg.DataContext;
        //        new DaoActividad().ActualizarElemento(epmodificada.CodigoActividad, epmodificada);

        //        GridActividades.SelectedIndex = _listadoActividades.IndexOf(epmodificada);
        //        MessageBox.Show("La actividad fue modificada correctamente.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        //    }
        //    _listadoActividades.RecargarElementos();           
        //}

        //void MenuAdicionarActividad_Click(object sender, RoutedEventArgs e)
        //{
        //    var dlg = new DialogoAdicionarModificarActividades();
        //    dlg.ConfigurarDialogo(false);
        //    if (dlg.ShowDialog() != true) return;
        //    var ep = (EntidadActividad)dlg.DataContext;           
        //    ep.CodigoActividad = new DaoActividad().ObtenerProximoCodigoActividad();
        //    new DaoActividad().AdicionarNuevoElemento(ep);
        //    _listadoActividades.Add(ep);
        //    _listadoActividades.RecargarElementos();
        //    GridActividades.SelectedIndex = _listadoActividades.IndexOf(ep);                
        //    MessageBox.Show("La actividad fue adicionada correctamente.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
           
        //}

        //void GridActividades_SelectionChanged(object sender, RoutedEventArgs e)
        //{
        //    if (GridActividades.SelectedIndex == -1)
        //    {
        //        GridActividades.Detalles = "";
        //        return;
        //    }
        //    var ep = GridActividades.SelectedItem as EntidadActividad;
        //    if (ep != null) GridActividades.Detalles = ep.Descripcion;           
        //}
    }
}
