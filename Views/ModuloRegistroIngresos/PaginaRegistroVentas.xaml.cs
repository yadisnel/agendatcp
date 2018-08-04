using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Agenda.ModeloDatos.Configuracion;
using Agenda.ModeloDatos.Dao;
using Agenda.ModuloDialogos.Dialogos;
using Agenda.ModeloDatos.Entidades;
using Agenda.ModuloExc.Excepciones;
using Agenda.ModeloDatos.Consultas;

namespace Agenda.Vistas.ModuloRegistroIngresos
{
    public partial class PaginaRegistroVentas
    {        
        //public ListCollectionView VistaColeccion;        
        //public Page PaginaInicio { get; set; }
        //private DateTime PeriodoDesde;
        //private DateTime PeriodoHasta;

        //private bool EsDia = false;
        //private bool EsSemana = false;
        //private bool EsMes = false;
        //private bool EsPeriodo = false;
       
        //private readonly ListadoVentasConImporte _ventasExistentes = new ListadoVentasConImporte();
        //private readonly ListadoConceptosIngresos _conceptos = new ListadoConceptosIngresos();
        public PaginaRegistroVentas(EntidadConceptoIngreso pEntidadConceptoVenta)
        {
            InitializeComponent();          
            //GridVentas.SelectionChanged += new RoutedEventHandler(GridVentas_SelectionChanged);
            //_ventasExistentes.RecargarVentasDeLicencia(ConfiguracionSistema.GetConfig().LicenciaEnUso);
            //GridVentas.ItemsSource = _ventasExistentes;
            //VistaColeccion = (ListCollectionView)CollectionViewSource.GetDefaultView(_ventasExistentes);
            //_conceptos.RecargarElementos();

            //GridVentas.AdicionarMenu("AdicionarNuevaVenta", "Adicionar", "IconoAdicionar");
            //GridVentas.AdicionarMenu("ModificarVenta", "Modificar", "IconoModificar");
            //GridVentas.AdicionarMenu("EliminarVenta", "Eliminar", "IconoEliminar");
            //GridVentas.AdicionarSeleccion("FiltrarPorFecha","Filtrar por fecha");

            //GridVentas.ObtenerMenu("AdicionarNuevaVenta").Click += new RoutedEventHandler(AdicionarNuevaVenta_Click);
            //GridVentas.ObtenerMenu("ModificarVenta").Click += new RoutedEventHandler(ModificarVenta_Click);
            //GridVentas.ObtenerMenu("EliminarVenta").Click += new RoutedEventHandler(EliminarVenta_Click);
            //GridVentas.TextSearchChanged += GridVentas_TextSearchChanged;

            //GridVentas.ObtenerSeleccion("FiltrarPorFecha").OnSelectedChanged += new RoutedEventHandler(FiltrarPorFechaOnSelectedChanged);
                             
            //VistaColeccion.SortDescriptions.Clear();
            //VistaColeccion.SortDescriptions.Add(new SortDescription("FechaRegistro", ListSortDirection.Ascending));

            //_ventasExistentes.RecargarVentasUltimos30dias(ConfiguracionSistema.GetConfig().LicenciaEnUso, ConfiguracionSistema.GetConfig().FechaContableEnUso.Value);
            //EsMes = true;
            //GridVentas.RenombrarSeleccion("FiltrarPorFecha", "Filtrar por fecha(últimos 30 días)");
            //GridVentas.ObtenerSeleccion("FiltrarPorFecha").Selected = true;
            //ConfiguracionSistema.GetConfig().FechaContableEnUsoHaCambiado += PaginaRegistroVentas_FechaContableEnUsoHaCambiado;

            //GridVentas.AdicionarColumna("IconoItem", "", (DataTemplate)this.FindResource("plantillaDatosCeldaIconoItemListadoVentas"));
            //GridVentas.AdicionarColumna("FechaRegistro", "Fecha de venta", (DataTemplate)this.FindResource("plantillaDatosCeldaFechaRegistro"));
            //GridVentas.AdicionarColumna("NombreProducto", "Producto vendido", (DataTemplate)this.FindResource("plantillaDatosCeldaNombreProductoVentaConImporte"));
            //GridVentas.AdicionarColumna("CantidadUnidades", "Unidades", (DataTemplate)this.FindResource("plantillaDatosCeldaCantidadUnidades"));
            //GridVentas.AdicionarColumna("Importe", "Importe", (DataTemplate)this.FindResource("plantillaDatosCeldaImporte"));
            //GridVentas.AdicionarColumna("Subtotal", "Ingresos", (DataTemplate)this.FindResource("plantillaDatosCeldaSubtotal"));            
        }
        //private bool FiltrarBusquedaRapida(object de)
        //{
        //    var VentaConImporte = de as EntidadVentaConImporte;           
        //    if (GridVentas.TextSearch != "")
        //    {
        //        var textoBusquedaMayuscula = GridVentas.TextSearch.ToUpper();
        //        textoBusquedaMayuscula = textoBusquedaMayuscula.Replace(",", ".");
        //        var descripcionIngreso = VentaConImporte.Descripcion.ToUpper();
        //        var nombreProducto = VentaConImporte.NombreProducto.ToUpper();
        //        var ingreso = VentaConImporte.Subtotal.ToString().Replace(",", ".");
        //        var importe = VentaConImporte.Importe.ToString(CultureInfo.InvariantCulture).ToUpper();
        //        var unidades = VentaConImporte.CantidadUnidades.ToString();
        //        var fechaRegistro = VentaConImporte.FechaRegistro.ToShortDateString();
        //        importe = importe.Replace(",", ".");
        //        if (descripcionIngreso.Contains(textoBusquedaMayuscula) || nombreProducto.Contains(textoBusquedaMayuscula) || importe.Contains(textoBusquedaMayuscula)
        //        || ingreso.Contains(textoBusquedaMayuscula) || unidades.Contains(textoBusquedaMayuscula) || fechaRegistro.Contains(textoBusquedaMayuscula))
        //        {
        //            return true;
        //        }
        //    }   
        //    return false;
        //}
          
        //void GridVentas_TextSearchChanged(object sender, RoutedEventArgs e)
        //{
        //    var textoBusqueda = GridVentas.TextSearch;
        //    if (textoBusqueda != "")
        //    {
        //        VistaColeccion.Filter = FiltrarBusquedaRapida;
        //    }
        //    else
        //    {
        //        VistaColeccion.Filter = null;
        //    }
        //}

        //void PaginaRegistroVentas_FechaContableEnUsoHaCambiado(object sender, EventArgs e)
        //{
        //    if (EsDia)
        //    {
        //        _ventasExistentes.RecargarVentas1Dia(ConfiguracionSistema.GetConfig().LicenciaEnUso, ConfiguracionSistema.GetConfig().FechaContableEnUso.Value);                             
        //    }
        //    else if (EsSemana)
        //    {
        //        _ventasExistentes.RecargarVentasUltimos7dias(ConfiguracionSistema.GetConfig().LicenciaEnUso, ConfiguracionSistema.GetConfig().FechaContableEnUso.Value);                                          
        //    }
        //    else if (EsMes)
        //    {
        //        _ventasExistentes.RecargarVentasUltimos30dias(ConfiguracionSistema.GetConfig().LicenciaEnUso, ConfiguracionSistema.GetConfig().FechaContableEnUso.Value);                                        
        //    }
        //    else if (EsPeriodo)
        //    {                
        //        _ventasExistentes.RecargarVentasPeriodo(ConfiguracionSistema.GetConfig().LicenciaEnUso, PeriodoDesde, PeriodoHasta);               
        //    }
        //}
        
        //private void FiltrarPorFechaOnSelectedChanged(object sender, RoutedEventArgs e)
        //{            
        //    DialogoFiltrarFecha dlg = new DialogoFiltrarFecha();
        //    if (dlg.ShowDialog() == true)
        //    {                
        //        if (dlg.EsDia)
        //        {                   
        //           _ventasExistentes.RecargarVentas1Dia(ConfiguracionSistema.GetConfig().LicenciaEnUso, ConfiguracionSistema.GetConfig().FechaContableEnUso.Value);
        //           GridVentas.RenombrarSeleccion("FiltrarPorFecha", "Filtrar por fecha(día contable)");
        //           GridVentas.ObtenerSeleccion("FiltrarPorFecha").Selected = true;
        //           EsDia = true;
        //           EsSemana = false;
        //           EsMes = false;
        //           EsPeriodo = false;
        //        }
        //        else if (dlg.EsSemana)
        //        {
        //            _ventasExistentes.RecargarVentasUltimos7dias(ConfiguracionSistema.GetConfig().LicenciaEnUso, ConfiguracionSistema.GetConfig().FechaContableEnUso.Value);
        //            GridVentas.RenombrarSeleccion("FiltrarPorFecha", "Filtrar por fecha(últimos 7 días)");
        //            GridVentas.ObtenerSeleccion("FiltrarPorFecha").Selected = true;
        //            EsDia = false;
        //            EsSemana = true;
        //            EsMes = false;
        //            EsPeriodo = false;
        //        }
        //        else if (dlg.EsMes)
        //        {
        //            _ventasExistentes.RecargarVentasUltimos30dias(ConfiguracionSistema.GetConfig().LicenciaEnUso, ConfiguracionSistema.GetConfig().FechaContableEnUso.Value);
        //            GridVentas.RenombrarSeleccion("FiltrarPorFecha", "Filtrar por fecha(últimos 30 días)");
        //            GridVentas.ObtenerSeleccion("FiltrarPorFecha").Selected = true;
        //            EsDia = false;
        //            EsSemana = false;
        //            EsMes = true;
        //            EsPeriodo = false;
        //        }
        //        else if (dlg.EsPeriodo)
        //        {
        //            EsDia = false;
        //            EsSemana = false;
        //            EsMes = false;
        //            EsPeriodo = true;

        //            PeriodoDesde = dlg.FechaPeriodoDesde;
        //            PeriodoHasta = dlg.FechaPeriodoHasta;
                  
        //            string str = "Filtrar por fecha(desde ";
                    
        //            if (PeriodoDesde.Day < 10) str += "0";
        //            str += PeriodoDesde.Day.ToString();
        //            str += "/";
        //            if (PeriodoDesde.Month < 10) str += "0";
        //            str += PeriodoDesde.Month.ToString();
        //            str += "/";
        //            str += PeriodoDesde.Year.ToString();
        //            str += " hasta ";

        //            if (PeriodoHasta.Day < 10) str += "0";
        //            str += PeriodoHasta.Day.ToString();
        //            str += "/";
        //            if (PeriodoHasta.Month < 10) str += "0";
        //            str += PeriodoHasta.Month.ToString();
        //            str += "/";
        //            str += PeriodoHasta.Year.ToString();
        //            str += ")";
        //            _ventasExistentes.RecargarVentasPeriodo(ConfiguracionSistema.GetConfig().LicenciaEnUso, PeriodoDesde, PeriodoHasta);
        //            GridVentas.RenombrarSeleccion("FiltrarPorFecha", str);
        //            GridVentas.ObtenerSeleccion("FiltrarPorFecha").Selected = true;
        //        }
        //    }
        //    else
        //    {
        //        _ventasExistentes.RecargarVentasUltimos30dias(ConfiguracionSistema.GetConfig().LicenciaEnUso, ConfiguracionSistema.GetConfig().FechaContableEnUso.Value);
        //        GridVentas.ObtenerSeleccion("FiltrarPorFecha").Selected = true;                
        //        GridVentas.RenombrarSeleccion("FiltrarPorFecha", "Filtrar por fecha(últimos 30 días)");               
        //    }
        //}
        //void EliminarVenta_Click(object sender, RoutedEventArgs e)
        //{
        //   try
        //   {
        //       if (GridVentas.SelectedIndex == -1)
        //       {
        //           MessageBox.Show("Primeramente debe seleccionar una venta de la lista para luego eliminarla.");
        //       }
        //       else
        //       {
        //           var result = MessageBox.Show("Al eliminar una venta se elmiminarán automáticamente todos los datos asociados a esta. ¿Desea continuar y que el sistema haga esto para usted?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
        //           if (result != MessageBoxResult.Yes) return;
        //           var venta = GridVentas.SelectedItem as EntidadVentaConImporte;
        //           new DaoVenta().EliminarElemento(venta.CodigoVenta);
        //           _ventasExistentes.RemoveAt(GridVentas.SelectedIndex);
        //           PaginaRegistroVentas_FechaContableEnUsoHaCambiado(null, null);
        //           MessageBox.Show("La venta fue eliminada correctamente.");
        //       }
        //   }
        //   catch (EAccesoDatosNoSePudoConectarConLaBd ex)
        //   {
        //       MessageBox.Show("No se pudo completar la operación debido a un error al acceder a los datos. Por favor revise la configuración de acceso a datos. Detalles del error:" + ex.Message);
        //   }
        //}

        //void ModificarVenta_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        if (GridVentas.SelectedIndex == -1)
        //        {
        //            MessageBox.Show("Primeramente debe seleccionar una venta para luego modificarla.");
        //            return;
        //        }

        //        var Venta = GridVentas.SelectedItem as EntidadVentaConImporte;                               
        //        var dlg = new DialogoAdicionarModificarVenta();
        //        dlg.DataContext = Venta;
        //        dlg.ConfigurarDialogo(true);                
        //        if (dlg.ShowDialog() == true)
        //        {
        //            EntidadVentaConImporte venta_modificada = (EntidadVentaConImporte)dlg.DataContext;
        //            new DaoVenta().ActualizarElemento(venta_modificada.CodigoVenta, venta_modificada);
        //            PaginaRegistroVentas_FechaContableEnUsoHaCambiado(null, null);
        //            MessageBox.Show("La venta fue modificada correctamente.");                   
        //        }                
        //    }
        //    catch (EAccesoDatosNoSePudoConectarConLaBd ex)
        //    {
        //        MessageBox.Show("No se pudo completar la operación debido a un error al acceder a los datos. Por favor revise la configuración de acceso a datos. Detalles del error:" + ex.Message);
        //    }
        //}

        //void AdicionarNuevaVenta_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //       var dlg = new DialogoAdicionarModificarVenta();
        //       dlg.ConfigurarDialogo(false);               
        //       dlg.ShowDialog();             
        //       if (dlg.DialogResult == true)
        //       {
        //           var miVenta = (EntidadVentaConImporte)dlg.DataContext;
        //           miVenta.CodigoVenta = new DaoVenta().ObtenerProximoCodigoVenta();                 
        //           miVenta.FechaRegistro = ConfiguracionSistema.GetConfig().FechaContableEnUso.Value;
        //           short codigoLicencia = ConfiguracionSistema.GetConfig().LicenciaEnUso.CodigoLicencia;
        //           miVenta.CodigoLicencia = codigoLicencia;
        //           new DaoVenta().AdicionarNuevoElemento(miVenta);
        //           PaginaRegistroVentas_FechaContableEnUsoHaCambiado(null, null);
        //           MessageBox.Show("La venta fue registrada correctamente.");
        //       }
        //   }
        //   catch (EAccesoDatosNoSePudoConectarConLaBd ex)
        //   {
        //       MessageBox.Show("No se pudo completar la operación debido a un error al acceder a los datos. Por favor revise la configuración de acceso a datos. Detalles del error:" + ex.Message);
        //   }
        //}

        //void GridVentas_SelectionChanged(object sender, RoutedEventArgs e)
        //{
        //    if (GridVentas.SelectedIndex != -1)
        //   {
        //       var Venta = GridVentas.SelectedItem as EntidadVentaConImporte;
        //       GridVentas.Detalles = "Venta de ";
        //       GridVentas.Detalles += Venta.CantidadUnidades;
        //       if (Venta.CantidadUnidades > 1) GridVentas.Detalles += " unidades de ";
        //       else GridVentas.Detalles += " unidad de ";
        //       GridVentas.Detalles += Venta.NombreProducto;
        //       GridVentas.Detalles += " para un ingreso de $";
        //       GridVentas.Detalles += Venta.SubtotalString;
        //   }
        //   else
        //   {
        //       GridVentas.Detalles = "";               
        //   }
        //}
    }
}
