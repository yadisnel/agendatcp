using Agenda.ModeloDatos.Entidades;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Linq;
using Agenda.ModeloDatos.Consultas;
using Agenda.ModeloDatos.Configuracion;
using System.Windows.Data;
using System.ComponentModel;
using System.Globalization;
using System;

namespace Agenda.ModuloDialogos.Dialogos
{
    public partial class DialogoAdicionarModificarVenta
    {
        //public EntidadVentaConImporte Venta { get; set;}
        //private bool _esOperacionModificar = false;
        //public ListCollectionView VistaColeccion;  
        //private ListadoProductos ProductosExistentes = new ListadoProductos();

        public DialogoAdicionarModificarVenta()
        {
            InitializeComponent();
            //ProductosExistentes.RecargarTodosLosProductos();
            //GridProductos.ItemsSource = ProductosExistentes;
            //GridProductos.SelectionChanged += new RoutedEventHandler(GridProductos_SelectionChanged);

            //ControlBarraTitulo.ClickCerrar += ControlBarraTituloBotonCerrar_Click;
            //ControlBarraTitulo.ClickMinimizar += ControlBarraTituloBotonMinimizarVentana_Click;
            //ControlBarraTitulo.MouseLeftButtonDown += ControlBarraTitulo_MouseLeftButtonDown;
            //ControlBarraTitulo.OcultarBotonMaximizar = true;
            //BotonAceptar.Click += BotonAceptar_Click;
            //Venta = new EntidadVentaConImporte();
            //DataContext = Venta;

            //GridProductos.AdicionarColumna("IconoItem", "", (DataTemplate)this.FindResource("plantillaDatosCeldaIconoItemListadoProductos"));
            //GridProductos.AdicionarColumna("CodigoProducto", "Código", (DataTemplate)this.FindResource("plantillaDatosCeldaCodigoProducto"));
            //GridProductos.AdicionarColumna("Nombre", "Nombre", (DataTemplate)this.FindResource("plantillaDatosCeldaNombreProducto"));
            //GridProductos.AdicionarColumna("Precio", "Precio", (DataTemplate)this.FindResource("plantillaDatosCeldaPrecioProducto"));

           
            //GridProductos.TextSearchChanged += new RoutedEventHandler(GridProductos_TextSearchChanged);

            //VistaColeccion = (ListCollectionView)CollectionViewSource.GetDefaultView(ProductosExistentes);
            //VistaColeccion.SortDescriptions.Clear();
            //VistaColeccion.SortDescriptions.Add(new SortDescription("CodigoProducto", ListSortDirection.Descending));          
            //GridProductos.SelectedIndex = -1;
            //GridProductos.TextSearchKeyUp += new KeyEventHandler(GridProductos_TextSearchKeyUp);
            
            //TextBoxCantidadUnidades.KeyUp += new KeyEventHandler(TextBoxCantidadUnidades_KeyUp);
            //TextBoxDescripcion.KeyUp += new KeyEventHandler(TextBoxDescripcion_KeyUp);
        }
        
        //void TextBoxDescripcion_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if ((int)e.Key == 6)
        //    {
        //        BotonAceptar_Click(null, null);
        //    }
        //}

        //void TextBoxCantidadUnidades_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if ((int)e.Key == 6)
        //    {
        //        bool PuedeSeguir = false;
        //        try
        //        {
        //            int num = int.Parse(TextBoxCantidadUnidades.Text);
        //            PuedeSeguir = true;
        //        }
        //        catch (Exception)
        //        { 
                
        //        }
        //        if (PuedeSeguir)
        //        {
        //            TextBoxDescripcion.Focus();
        //        }
        //    }
        //}

        //void GridProductos_TextSearchKeyUp(object sender, KeyEventArgs e)
        //{
        //    if (VistaColeccion.Count == 1)
        //    {                              
        //        GridProductos.SelectedIndex = 0;
        //    }
        //    else
        //    {
        //        GridProductos.SelectedIndex = -1;
        //        GridProductos.Detalles = "";
        //    }

        //    if ((int)e.Key == 6)
        //    {   
        //        if (GridProductos.SelectedIndex != -1)
        //        {
        //            TextBoxCantidadUnidades.Focus();
        //            TextBoxCantidadUnidades.SelectAll();
        //        }
        //    }
        //}
        
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


        //public void ConfigurarDialogo(bool esOperacionModificar)
        //{
        //    _esOperacionModificar = esOperacionModificar;           
        //    if (esOperacionModificar)
        //    {
        //        ControlBarraTitulo.Titulo = "Modificar venta";
        //        this.Title = ControlBarraTitulo.Titulo;
        //        BotonAceptar.Content = "Modificar";
        //        int Indice = -1;
        //        for (int i = 0; i < VistaColeccion.Count; i++)
        //        {
        //            Indice++;
        //            EntidadProducto Item = VistaColeccion.GetItemAt(i) as EntidadProducto;
        //            if (Item.CodigoProducto == ((EntidadVentaConImporte)this.DataContext).CodigoProducto)
        //            {
        //                GridProductos.SelectedIndex = Indice;
        //            }
        //        }
        //        TextBoxCantidadUnidades.Text = ((EntidadVentaConImporte)this.DataContext).CantidadUnidades.ToString();
        //        TextBoxCantidadUnidades.Focus();
        //        TextBoxCantidadUnidades.SelectAll();
        //        TextBoxDescripcion.Text = ((EntidadVentaConImporte)this.DataContext).Descripcion;
        //    }
        //    else
        //    {
        //        ControlBarraTitulo.Titulo = "Adicionar nueva venta";
        //        this.Title = ControlBarraTitulo.Titulo;
        //        BotonAceptar.Content = "Adicionar";
        //        GridProductos.FocusTextSearch();
        //    }            
        //}
        //private void ValidarComponentes()
        //{
        //    string aux = TextBoxDescripcion.Text;
        //    TextBoxDescripcion.Text = "";
        //    TextBoxDescripcion.Text = aux;

        //    aux = TextBoxCantidadUnidades.Text;
        //    TextBoxCantidadUnidades.Text = "";
        //    TextBoxCantidadUnidades.Text = aux;
        //}
        //void BotonAceptar_Click(object sender, RoutedEventArgs e)
        //{
        //    ValidarComponentes();
        //    if (DialogoEsValido(this) == false)
        //    {
        //        MessageBox.Show("Por favor corrija los datos marcados como no válidos.", "Error en la entrada de datos", MessageBoxButton.OK);
        //        return;
        //    }
        //    if (GridProductos.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Para adicionar una nueva venta primeramente debe seleccionar un producto.");
        //        return;
        //    }
        //    if (_esOperacionModificar)
        //    {
        //        ((EntidadVentaConImporte)DataContext).CodigoProducto = (GridProductos.SelectedItem as EntidadProducto).CodigoProducto;
        //        ((EntidadVentaConImporte)DataContext).Descripcion = TextBoxDescripcion.Text;
        //        ((EntidadVentaConImporte)DataContext).CantidadUnidades = short.Parse(TextBoxCantidadUnidades.Text);
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

        //void GridProductos_SelectionChanged(object sender, RoutedEventArgs e)
        //{
        //    if (GridProductos.SelectedIndex != -1)
        //    {
        //        var prod = GridProductos.SelectedItem as EntidadProducto;                
        //        Venta.CodigoProducto = prod.CodigoProducto;                
        //        GridProductos.Detalles = prod.Descripcion;
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
