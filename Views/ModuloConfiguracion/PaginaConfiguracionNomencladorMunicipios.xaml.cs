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
    /// Interaction logic for PaginaConfiguracionNomencladoractividads.xaml
    /// </summary>
    public partial class PaginaConfiguracionNomencladorMunicipios
    {
        //readonly ListadoMunicipios _listadoMunicipios = new ListadoMunicipios();
        //readonly ListadoProvincias _listadoProvincias = new ListadoProvincias();
        //public ListCollectionView VistaColeccion;
        
        public PaginaConfiguracionNomencladorMunicipios()
        {
            InitializeComponent();
            //_listadoProvincias.RecargarElementos();
            //ComboBoxProvincias.DataContext = _listadoProvincias;
            //ComboBoxProvincias.ItemsSource = _listadoProvincias;
            //GridMunicipios.ItemsSource = _listadoMunicipios;    
       
            //GridMunicipios.AdicionarMenu("MenuAdicionarMunicipio", "Adicionar", "IconoAdicionar");
            //GridMunicipios.AdicionarMenu("MenuModificarMunicipio", "Modificar", "IconoModificar");
            //GridMunicipios.AdicionarMenu("MenuEliminarMunicipio", "Eliminar", "IconoEliminar");

            //GridMunicipios.AdicionarColumna("IconoItem", "", (DataTemplate)this.FindResource("plantillaDatosCeldaIconoItemListadoMunicipios"));
            //GridMunicipios.AdicionarColumna("Nombre", "Nombre", (DataTemplate)this.FindResource("plantillaDatosCeldaNombreMunicipio"));

            //GridMunicipios.ObtenerMenu("MenuAdicionarMunicipio").Click += new RoutedEventHandler(MenuAdicionarMunicipio_Click);
            //GridMunicipios.ObtenerMenu("MenuModificarMunicipio").Click += new RoutedEventHandler(MenuModificarMunicipio_Click);
            //GridMunicipios.ObtenerMenu("MenuEliminarMunicipio").Click += new RoutedEventHandler(MenuEliminarMunicipio_Click);
           

            
            //GridMunicipios.TextSearchChanged += new RoutedEventHandler(GridMunicipios_TextSearchChanged);
            //GridMunicipios.SelectionChanged += new RoutedEventHandler(GridMunicipios_SelectionChanged);

            //ComboBoxProvincias.SelectionChanged += ComboBoxProvincias_SelectionChanged;
            //if (_listadoProvincias.Count > 0) ComboBoxProvincias.SelectedIndex = 0;
    
        }

        //void GridMunicipios_SelectionChanged(object sender, RoutedEventArgs e)
        //{

        //    if (GridMunicipios.SelectedIndex == -1)
        //    {
        //        GridMunicipios.Detalles = "";
        //        return;
        //    }
        //    var em = GridMunicipios.SelectedItem as EntidadMunicipio;
        //    if (em != null) GridMunicipios.Detalles = em.Nombre;  
        //}

        //void GridMunicipios_TextSearchChanged(object sender, RoutedEventArgs e)
        //{
        //    var textoBusqueda = GridMunicipios.TextSearch;
        //    if (textoBusqueda != "")
        //    {
        //        VistaColeccion.Filter = FiltrarBusquedaRapida;
        //    }
        //    else
        //    {
        //        VistaColeccion.Filter = null;
        //    }
        //}

        //private bool FiltrarBusquedaRapida(object de)
        //{
        //    var textoBusquedaMayuscula = GridMunicipios.TextSearch.ToUpper();
        //    var textoNombre = "";

        //    if (de is EntidadMunicipio)
        //    {
        //        textoNombre = (de as EntidadMunicipio).Nombre;
        //    }
        //    textoNombre = textoNombre.ToUpper();
        //    if (textoNombre.Contains(textoBusquedaMayuscula)) return true;
        //    return false;
        //}

        //void OrdenamientoNombre_Click(object sender, RoutedEventArgs e)
        //{
        //    VistaColeccion.SortDescriptions.Clear();
        //    BotonOrdenamientoGridDatos bo = sender as BotonOrdenamientoGridDatos;
        //    if (bo.EsAscendente)
        //    {
        //        VistaColeccion.SortDescriptions.Add(new SortDescription("Nombre", ListSortDirection.Descending));
        //        bo.EsAscendente = false;
        //        bo.EsSeleccionado = true;
        //    }
        //    else
        //    {
        //        VistaColeccion.SortDescriptions.Add(new SortDescription("Nombre", ListSortDirection.Ascending));
        //        bo.EsAscendente = true;
        //        bo.EsSeleccionado = true;
        //    }
        //}

        //void MenuEliminarMunicipio_Click(object sender, RoutedEventArgs e)
        //{
        //    if (ComboBoxProvincias.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Debe seleccionar una provincia para poder modificar sus municipios.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        //        return;
        //    }
        //    if (GridMunicipios.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Debe seleccionar un municipio para luego modificarlo.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        //        return;
        //    }
        //    var result = MessageBox.Show("Al eliminar un municipio se elmiminarán automáticamente todos los datos asociados a este. ¿Desea continuar y que el sistema haga esto para usted?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
        //    if (result != MessageBoxResult.Yes) return;
        //    var em = GridMunicipios.SelectedItem as EntidadMunicipio;            
        //    new DaoMunicipio().EliminarElemento(em.CodigoMunicipio);
        //    _listadoMunicipios.Remove(em);
        //    _listadoMunicipios.RecargarElementos((ComboBoxProvincias.SelectedItem as EntidadProvincia).CodigoProvincia);
        //    MessageBox.Show("El municipio fue eliminado correctamente.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        //}

        //void MenuModificarMunicipio_Click(object sender, RoutedEventArgs e)
        //{
        //    if (ComboBoxProvincias.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Debe seleccionar una provincia para poder modificar sus municipios.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        //        return;
        //    }
        //    if (GridMunicipios.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Debe seleccionar un municipio para luego modificarlo.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        //        return;
        //    }
        //    var em = GridMunicipios.SelectedItem as EntidadMunicipio;
        //    var dlg = new DialogoAdicionarModificarMunicipios { DataContext = em };
        //    dlg.ConfigurarDialogo(true);
        //    if (dlg.ShowDialog() == true)
        //    {
        //        var emmodificado = (EntidadMunicipio)dlg.DataContext;
        //        new DaoMunicipio().ActualizarElemento(emmodificado.CodigoMunicipio, emmodificado);
        //        _listadoMunicipios.RemoveAt(GridMunicipios.SelectedIndex);
        //        _listadoMunicipios.Add(emmodificado);
        //        _listadoMunicipios.RecargarElementos(emmodificado.CodigoProvincia);           
        //        MessageBox.Show("El municipio fue modificado correctamente.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        //    }
        //    var entidadProvincia = ComboBoxProvincias.SelectedItem as EntidadProvincia; 
        //    _listadoMunicipios.RecargarElementos(entidadProvincia.CodigoProvincia);
        //}

        //void MenuAdicionarMunicipio_Click(object sender, RoutedEventArgs e)
        //{
        //    if (ComboBoxProvincias.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Debe seleccionar una provincia para poder agragar luego un municipio.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        //        return;
        //    }
        //    var dlg = new DialogoAdicionarModificarMunicipios();
        //    dlg.ConfigurarDialogo(false);
        //    if (dlg.ShowDialog() != true) return;
        //    var em = (EntidadMunicipio)dlg.DataContext;
        //    em.CodigoProvincia = (ComboBoxProvincias.SelectedItem as EntidadProvincia).CodigoProvincia;           
        //    em.CodigoMunicipio = new DaoMunicipio().ObtenerProximoCodigoMunicipio();
        //    new DaoMunicipio().AdicionarNuevoElemento(em);
        //    _listadoMunicipios.Add(em);
        //    _listadoMunicipios.RecargarElementos((ComboBoxProvincias.SelectedItem as EntidadProvincia).CodigoProvincia);           
        //    MessageBox.Show("El municipio fue adionado correctamente.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);           
        //}

        //void ComboBoxProvincias_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        //{
        //    if (ComboBoxProvincias.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Debe seleccionar una provincia para poder modificar sus municipios.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        //        return;
        //    }
        //    _listadoMunicipios.RecargarElementos((ComboBoxProvincias.SelectedItem as EntidadProvincia).CodigoProvincia);
        //    VistaColeccion = (ListCollectionView)CollectionViewSource.GetDefaultView(_listadoMunicipios);            
        //}
    }
}
