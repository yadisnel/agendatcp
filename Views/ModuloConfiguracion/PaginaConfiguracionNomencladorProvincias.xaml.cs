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
    /// <summary>
    /// Interaction logic for PaginaConfiguracionNomencladorProvincias.xaml
    /// </summary>
    public partial class PaginaConfiguracionNomencladorProvincias
    {
        //readonly ListadoProvincias _listadoProvincias = new ListadoProvincias();
        //public ListCollectionView VistaColeccion;

        public PaginaConfiguracionNomencladorProvincias()
        {
            InitializeComponent();
            //_listadoProvincias.RecargarElementos();
            //GridProvincias.ItemsSource = _listadoProvincias;

            //GridProvincias.SelectionChanged += new RoutedEventHandler(GridProvincias_SelectionChanged);
            //GridProvincias.AdicionarMenu("MenuAdicionarProvincia", "Adicionar", "IconoAdicionar");
            //GridProvincias.AdicionarMenu("MenuModificarProvincia", "Modificar", "IconoModificar");
            //GridProvincias.AdicionarMenu("MenuEliminarProvincia", "Eliminar", "IconoEliminar");

            //GridProvincias.AdicionarColumna("IconoItem", "", (DataTemplate)this.FindResource("plantillaDatosCeldaIconoItemListadoProvincias"));
            //GridProvincias.AdicionarColumna("Nombre", "Nombre", (DataTemplate)this.FindResource("plantillaDatosCeldaNombreProvincia"));

            //GridProvincias.ObtenerMenu("MenuAdicionarProvincia").Click += new RoutedEventHandler(MenuAdicionarProvincia_Click);
            //GridProvincias.ObtenerMenu("MenuModificarProvincia").Click += new RoutedEventHandler(MenuModificarProvincia_Click);
            //GridProvincias.ObtenerMenu("MenuEliminarProvincia").Click += new RoutedEventHandler(MenuEliminarProvincia_Click);
            

            //VistaColeccion = (ListCollectionView)CollectionViewSource.GetDefaultView(_listadoProvincias);
            //VistaColeccion.SortDescriptions.Clear();
            //VistaColeccion.SortDescriptions.Add(new SortDescription("Nombre", ListSortDirection.Ascending));
            

            //GridProvincias.TextSearchChanged += new RoutedEventHandler(GridProvincias_TextSearchChanged);
        }

        //private bool FiltrarBusquedaRapida(object de)
        //{           
        //    var textoBusquedaMayuscula = GridProvincias.TextSearch.ToUpper();
        //    var textoNombre = "";            
          
        //    if (de is EntidadProvincia)
        //    {
        //        textoNombre = (de as EntidadProvincia).Nombre;
        //    }
        //    textoNombre = textoNombre.ToUpper();
        //    if (textoNombre.Contains(textoBusquedaMayuscula)) return true;
        //    return false;
        //}

        //void GridProvincias_TextSearchChanged(object sender, RoutedEventArgs e)
        //{
        //    var textoBusqueda = GridProvincias.TextSearch;
        //    if (textoBusqueda != "")
        //    {
        //        VistaColeccion.Filter = FiltrarBusquedaRapida;
        //    }
        //    else
        //    {
        //        VistaColeccion.Filter = null;
        //    }
        //}

      
        //void MenuEliminarProvincia_Click(object sender, RoutedEventArgs e)
        //{
        //    if (GridProvincias.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Debe seleccionar una provincia para luego eliminarla.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        //        return;
        //    }
        //    var result = MessageBox.Show("Al eliminar la provincia se elmiminarán automáticamente todos los datos a esta. ¿Desea continuar y que el sistema haga esto para usted?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
        //    if (result != MessageBoxResult.Yes) return;
        //    var ep = GridProvincias.SelectedItem as EntidadProvincia;            
        //    new DaoProvincia().EliminarElemento(ep.CodigoProvincia);
        //    _listadoProvincias.Remove(ep);
        //    _listadoProvincias.RecargarElementos();
        //    MessageBox.Show("La provincia fue eliminada correctamente.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);

          
        //}

        //void MenuModificarProvincia_Click(object sender, RoutedEventArgs e)
        //{
        //    if (GridProvincias.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Debe seleccionar una provincia para luego modificarla.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        //        return;
        //    }
        //    EntidadProvincia ep = GridProvincias.SelectedItem as EntidadProvincia;
        //    var dlg = new DialogoAdicionarModificarProvincias();
        //    dlg.ConfigurarDialogo(true);
        //    dlg.DataContext = ep;
        //    if (dlg.ShowDialog() == true)
        //    {
        //        var epmodificada = (EntidadProvincia)dlg.DataContext;
        //        new DaoProvincia().ActualizarElemento(epmodificada.CodigoProvincia, epmodificada);                
        //        GridProvincias.SelectedIndex = _listadoProvincias.IndexOf(epmodificada);
        //        MessageBox.Show("La provincia fue modificada correctamente.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        //    }
        //    _listadoProvincias.RecargarElementos();           
        //}

        //void MenuAdicionarProvincia_Click(object sender, RoutedEventArgs e)
        //{
        //    var dlg = new DialogoAdicionarModificarProvincias();
        //    dlg.ConfigurarDialogo(false);
        //    if (dlg.ShowDialog() != true) return;
        //    var ep = (EntidadProvincia)dlg.DataContext;
        //    ep.CodigoProvincia = new DaoProvincia().ObtenerProximoCodigoProvincia();
        //    new DaoProvincia().AdicionarNuevoElemento(ep);
        //    _listadoProvincias.Add(ep);
        //    _listadoProvincias.RecargarElementos();
        //    GridProvincias.SelectedIndex = _listadoProvincias.IndexOf(ep);                
        //    MessageBox.Show("La provincia fue adicionada correctamente.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
           
        //}

        //void GridProvincias_SelectionChanged(object sender, RoutedEventArgs e)
        //{
        //    if (GridProvincias.SelectedIndex == -1)
        //    {
        //        GridProvincias.Detalles = "";
        //        return;
        //    }
        //    var ep = GridProvincias.SelectedItem as EntidadProvincia;
        //    if (ep != null) GridProvincias.Detalles = ep.Nombre;           
        //}       
    }
}
