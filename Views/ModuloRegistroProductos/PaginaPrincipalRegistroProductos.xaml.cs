using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Agenda.ModuloExc.Excepciones;
using Agenda.ModeloDatos.Dao;
using Agenda.ModeloDatos.Entidades;
using Agenda.ModeloDatos.Consultas;
using Agenda.ModuloDialogos.Dialogos;

namespace Agenda.Vistas.ModuloReportes
{
    public partial class PaginaPrincipalRegistroProductos
    {        
        //public ListCollectionView VistaColeccion;       
        //private ListadoProductos ProductosExistentes = new ListadoProductos();
        public PaginaPrincipalRegistroProductos()
        {
            InitializeComponent();
            //ProductosExistentes.RecargarTodosLosProductos();
            //GridProductos.ItemsSource = ProductosExistentes;         

            //GridProductos.SelectionChanged += new RoutedEventHandler(GridProductos_SelectionChanged);
            //GridProductos.AdicionarMenu("MenuAdicionarProducto", "Adicionar", "IconoBotonAdicionarProducto");
            //GridProductos.AdicionarMenu("MenuModificarProducto", "Modificar", "IconoBotonModificarProducto");
            //GridProductos.AdicionarMenu("MenuEliminarProducto", "Eliminar", "IconoBotonEliminarProducto");

            //GridProductos.AdicionarColumna("IconoItem", "", (DataTemplate)this.FindResource("plantillaDatosCeldaIconoItemListadoProductos"));
            //GridProductos.AdicionarColumna("CodigoProducto", "Código", (DataTemplate)this.FindResource("plantillaDatosCeldaCodigoProducto"));
            //GridProductos.AdicionarColumna("Nombre", "Nombre", (DataTemplate)this.FindResource("plantillaDatosCeldaNombreProducto"));            
            //GridProductos.AdicionarColumna("Precio", "Precio", (DataTemplate)this.FindResource("plantillaDatosCeldaPrecioProducto"));

            //GridProductos.ObtenerMenu("MenuAdicionarProducto").Click += new RoutedEventHandler(MenuAdicionarProducto_Click);
            //GridProductos.ObtenerMenu("MenuModificarProducto").Click += new RoutedEventHandler(MenuModificarProducto_Click);
            //GridProductos.ObtenerMenu("MenuEliminarProducto").Click += new RoutedEventHandler(MenuEliminarProducto_Click);
            
            //GridProductos.TextSearchChanged += new RoutedEventHandler(GridProductos_TextSearchChanged);

            //VistaColeccion = (ListCollectionView)CollectionViewSource.GetDefaultView(ProductosExistentes);
            //VistaColeccion.SortDescriptions.Clear();
            //VistaColeccion.SortDescriptions.Add(new SortDescription("Nombre", ListSortDirection.Ascending));
            
            //GridProductos.SelectedIndex = -1;           
        }
        //private bool FiltrarBusquedaRapida(object de)
        //{
        //    var textoBusquedaMayuscula = GridProductos.TextSearch.ToUpper();
        //    textoBusquedaMayuscula = textoBusquedaMayuscula.Replace(",", ".");
        //    var producto = de as EntidadProducto;
        //    if (producto == null) return false;
        //    var nombreProducto = producto.Nombre.ToUpper();
        //    var descripcionProducto = producto.Descripcion.ToUpper();
        //    var precioProducto = producto.Precio.ToString(CultureInfo.InvariantCulture).ToUpper();
        //    precioProducto = precioProducto.Replace(",", ".");
        //    var codigoProducto = producto.CodigoProducto.ToString(CultureInfo.InvariantCulture).ToUpper();

        //    if (nombreProducto.Contains(textoBusquedaMayuscula)
        //        || nombreProducto.Contains(textoBusquedaMayuscula)
        //        || descripcionProducto.Contains(textoBusquedaMayuscula)
        //        || precioProducto.Contains(textoBusquedaMayuscula)
        //        || codigoProducto.Contains(textoBusquedaMayuscula))
        //    {
        //        return true;
        //    }
        //    return false;
        //}      
        //void GridProductos_TextSearchChanged(object sender, RoutedEventArgs e)
        //{
        //    var textoBusqueda = GridProductos.TextSearch;
        //    if (textoBusqueda != "")
        //    {
        //        VistaColeccion.Filter = FiltrarBusquedaRapida;
        //    }
        //    else
        //    {
        //        VistaColeccion.Filter = null;
        //    }
        //}        

        //void MenuEliminarProducto_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        if (GridProductos.SelectedIndex == -1)
        //        {
        //            MessageBox.Show("Primeramente debe seleccionar un producto para luego eliminarlo.");
        //        }
        //        else
        //        {
        //            var result = MessageBox.Show("Al eliminar un producto se elmiminarán automáticamente todas las ventas asociadas a este. ¿Desea continuar y que el sistema haga esto para usted?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                var prod = GridProductos.SelectedItem as EntidadProducto;
        //                new DaoProducto().EliminarElemento(prod.CodigoProducto);
        //                ProductosExistentes.RemoveAt(GridProductos.SelectedIndex);
        //                ProductosExistentes.RecargarTodosLosProductos();
        //            }
        //        }
        //    }
        //    catch (EAccesoDatosNoSePudoConectarConLaBd ex)
        //    {
        //        MessageBox.Show("No se pudo completar la operación debido a un error al acceder a los datos. Por favor revise la configuración de acceso a datos. Detalles del error:" + ex.Message);
        //    }
        //}

        //void MenuModificarProducto_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        if (GridProductos.SelectedIndex == -1)
        //        {
        //            MessageBox.Show("Primeramente debe seleccionar un producto para luego modificarlo.");
        //            return;
        //        }
        //        var prod = GridProductos.SelectedItem as EntidadProducto;
        //        if (prod == null) return;
        //        var dlg = new DialogoAdicionarModificarProducto
        //        {
        //            DataContext = prod
        //        };
        //        dlg.ConfigurarDialogo(true);
        //        if (dlg.ShowDialog() == true)
        //        {
        //            new DaoProducto().ActualizarElemento(prod.CodigoProducto, prod);
        //            ProductosExistentes.RecargarTodosLosProductos();
        //        }
        //    }
        //    catch (EAccesoDatosNoSePudoConectarConLaBd ex)
        //    {
        //        MessageBox.Show("No se pudo completar la operación debido a un error al acceder a los datos. Por favor revise la configuración de acceso a datos. Detalles del error:" + ex.Message);
        //    }
        //}

        //void MenuAdicionarProducto_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        var dlg = new DialogoAdicionarModificarProducto();
        //        dlg.Title = "Adicionar producto";
        //        dlg.DataContext = new EntidadProducto();
        //        dlg.ShowDialog();
        //        if (dlg.DialogResult == true)
        //        {
        //            EntidadProducto miProducto = (EntidadProducto)dlg.DataContext;
        //            miProducto.CodigoProducto = new DaoProducto().ObtenerProximoCodigoProducto();                   
        //            new DaoProducto().AdicionarNuevoElemento(miProducto);                    
        //        }
        //        ProductosExistentes.RecargarTodosLosProductos();
        //    }
        //    catch (EAccesoDatosNoSePudoConectarConLaBd ex)
        //    {
        //        MessageBox.Show("No se pudo completar la operación debido a un error al acceder a los datos. Por favor revise la configuración de acceso a datos. Detalles del error:" + ex.Message);
        //    }
        //}

        //void GridProductos_SelectionChanged(object sender, RoutedEventArgs e)
        //{
        //    if (GridProductos.SelectedIndex != -1)
        //    {
        //        var prod = GridProductos.SelectedItem as EntidadProducto;                              
        //        GridProductos.Detalles = prod.Descripcion;               
        //    }
        //} 
    }
}
