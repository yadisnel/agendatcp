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
    public partial class PaginaConfiguracionNomencladorEscalaProgresiva
    {
        //readonly ListadoEscalas _listadoEscalas = new ListadoEscalas();
        //private ListadoLineaTiempoAño _listadoAños = new ListadoLineaTiempoAño();
        //public ListCollectionView VistaColeccion;
        //public ListCollectionView VistaColeccionAnnos;

        public PaginaConfiguracionNomencladorEscalaProgresiva()
        {
            InitializeComponent();

            //_listadoAños.RecargarTodosLosAños();
            //ComboBoxAnnos.ItemsSource = _listadoAños;
            //GridEscalas.ItemsSource = _listadoEscalas;
            //GridEscalas.SelectionChanged += new RoutedEventHandler(GridEscalas_SelectionChanged);
            //VistaColeccion = (ListCollectionView)CollectionViewSource.GetDefaultView(_listadoEscalas);
            //VistaColeccionAnnos = (ListCollectionView)CollectionViewSource.GetDefaultView(_listadoAños);

            //GridEscalas.AdicionarMenu("MenuAdicionarEscala", "Adicionar", "IconoAdicionar");
            //GridEscalas.AdicionarMenu("MenuModificarEscala", "Modificar", "IconoModificar");
            //GridEscalas.AdicionarMenu("MenuEliminarEscala", "Eliminar", "IconoEliminar");

            //GridEscalas.AdicionarColumna("IconoItem", "", (DataTemplate)this.FindResource("plantillaDatosCeldaIconoItemListadoEscalas"));
            //GridEscalas.AdicionarColumna("Desde", "Desde", (DataTemplate)this.FindResource("plantillaDatosCeldaEscalaProgresivaDesde"));
            //GridEscalas.AdicionarColumna("Hasta", "Hasta", (DataTemplate)this.FindResource("plantillaDatosCeldaEscalaProgresivaHasta"));
            //GridEscalas.AdicionarColumna("Porciento", "Porciento", (DataTemplate)this.FindResource("plantillaDatosCeldaEscalaProgresivaPorciento"));
            
            //GridEscalas.ObtenerMenu("MenuAdicionarEscala").Click += new RoutedEventHandler(MenuAdicionarEscala_Click);
            //GridEscalas.ObtenerMenu("MenuModificarEscala").Click += new RoutedEventHandler(MenuModificarEscala_Click);
            //GridEscalas.ObtenerMenu("MenuEliminarEscala").Click += new RoutedEventHandler(MenuEliminarEscala_Click);
            //GridEscalas.TextSearchChanged += new RoutedEventHandler(GridEscalas_TextSearchChanged);
            //ComboBoxAnnos.SelectionChanged += ComboBoxAnnos_SelectionChanged;
            //if (_listadoAños.Count > 0)
            //{
            //    ComboBoxAnnos.SelectedIndex = 0;
            //}
        }

        //void ComboBoxAnnos_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        //{
        //    if (ComboBoxAnnos.SelectedIndex != -1)
        //    {
        //        _listadoEscalas.RecargarElementosDeCodigoLineaTiempoAño( (ComboBoxAnnos.SelectedItem as EntidadLineaTiempoAño).CodigoLineaTiempoAño );
        //    }
        //}

        //private bool FiltrarBusquedaRapida(object de)
        //{
        //    var textoBusquedaMayuscula = GridEscalas.TextSearch.ToUpper();
        //    var textoDesde = "";
        //    var textoHasta = "";
        //    var textoPorciento = "";

        //    textoDesde = (de as EntidadEscala).Desde.ToString();
        //    textoHasta = (de as EntidadEscala).Hasta.ToString();
        //    textoPorciento = (de as EntidadEscala).Porciento.ToString();

        //    textoDesde = textoDesde.ToUpper();
        //    textoHasta = textoHasta.ToUpper();
        //    textoPorciento = textoPorciento.ToUpper();

        //    if (textoDesde.Contains(textoBusquedaMayuscula)) return true;
        //    if (textoHasta.Contains(textoBusquedaMayuscula)) return true;
        //    if (textoPorciento.Contains(textoBusquedaMayuscula)) return true;

        //    return false;
        //}

        //void GridEscalas_TextSearchChanged(object sender, RoutedEventArgs e)
        //{
        //    var textoBusqueda = GridEscalas.TextSearch;
        //    if (textoBusqueda != "")
        //    {
        //        VistaColeccion.Filter = FiltrarBusquedaRapida;
        //    }
        //    else
        //    {
        //        VistaColeccion.Filter = null;
        //    }
        //}

        //void MenuEliminarEscala_Click(object sender, RoutedEventArgs e)
        //{
        //    if (GridEscalas.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Debe seleccionar una actividad para luego eliminarla.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        //        return;
        //    }
        //    var result = MessageBox.Show("Al eliminar la actividad se elmiminarán automáticamente todos los productos y ventas asociadas a esta. ¿Desea continuar y que el sistema haga esto para usted?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
        //    if (result != MessageBoxResult.Yes) return;
        //    var ep = GridEscalas.SelectedItem as EntidadEscala;
        //    if (ep != null)
        //    {
        //        new DaoEscalaProgresiva().EliminarElemento(ep.CodigoEscala);
        //        _listadoEscalas.Remove(ep);
        //        _listadoEscalas.RecargarElementos();
        //        MessageBox.Show("La escala fue eliminada correctamente.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);

        //    }
        //    else throw new ArgumentException("Objeto ep no puede ser null.");
        //}

        //void MenuModificarEscala_Click(object sender, RoutedEventArgs e)
        //{
        //    if (GridEscalas.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Debe seleccionar una escala para luego modificarla.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        //        return;
        //    }
        //    var dlg = new DialogoAdicionarModificarEscalas();
        //    dlg.ConfigurarDialogo(true);
        //    dlg.DataContext = GridEscalas.SelectedItem as EntidadEscala;

        //    while (dlg.ShowDialog() == true)
        //    {
        //        var eenueva = (EntidadEscala)dlg.DataContext;
        //        bool repetir = false;
        //        bool esPosible = true;

        //        MessageBoxResult result;
        //        if (eenueva.Desde > eenueva.Hasta)
        //        {
        //            result = MessageBox.Show("No se ha podido modificar la escala porque el rango 'Desde' es mayor que el rago 'Hasta' en la nueva escala. ¿Desea cambiar los rangos y añadirla nuevamente?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                repetir = true;
        //            }
        //            esPosible = false;
        //        }
        //        else if (eenueva.Desde == eenueva.Hasta)
        //        {
        //            result = MessageBox.Show("No se ha podido modificar la escala porque el rango 'Desde' es igual al rago 'Hasta' en la nueva escala. ¿Desea cambiar los rangos y añadirla nuevamente?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                repetir = true;
        //            }
        //            esPosible = false;
        //        }
        //        else if (eenueva.Desde < 0.0d)
        //        {
        //            result = MessageBox.Show("No se ha podido modificar la escala porque el rango 'Desde' es menor que 0 en la nueva escala. ¿Desea cambiar los rangos y añadirla nuevamente?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                repetir = true;
        //            }
        //            esPosible = false;
        //        }
        //        else if (new DaoEscalaProgresiva().ExisteRangoDesdeEscalaNuevaIgualRangoDesdeEscalaExistente(eenueva))
        //        {
        //            result = MessageBox.Show("No se ha podido modificar la escala porque el rango 'Desde' coincide con el rago 'Desde' de una escala existente. ¿Desea cambiar los rangos y añadirla nuevamente?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                repetir = true;
        //            }
        //            esPosible = false;
        //        }
        //        else if (new DaoEscalaProgresiva().ExisteRangoHastaEscalaNuevaIgualRangoHastaEscalaExistente(eenueva))
        //        {
        //            result = MessageBox.Show("No se ha podido modificar la escala porque el rango 'Hasta' coincide con el rago 'Hasta' de una escala existente. ¿Desea cambiar los rangos y añadirla nuevamente?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                repetir = true;
        //            }
        //            esPosible = false;
        //            break;
        //        }
        //        else if (new DaoEscalaProgresiva().ExisteRangoDesdeEscalaNuevaIgualRangoHastaEscalaExistente(eenueva))
        //        {
        //            result = MessageBox.Show("No se ha podido modificar la escala porque el rango 'Desde' coincide con el rago 'Hasta' de una escala existente. ¿Desea cambiar los rangos y añadirla nuevamente?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                repetir = true;
        //            }
        //            esPosible = false;
        //            break;
        //        }
        //        else if (new DaoEscalaProgresiva().ExisteRangoHastaEscalaNuevaIgualRangoDesdeEscalaExistente(eenueva))
        //        {
        //            result = MessageBox.Show("No se ha podido modificar la escala porque el rango 'Hasta' coincide con el rago 'Desde' de una escala existente. ¿Desea cambiar los rangos y añadirla nuevamente?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                repetir = true;
        //            }
        //            esPosible = false;
        //        }
        //        else if (new DaoEscalaProgresiva().ExisteRangoHastaEscalaNuevaDentroRangoEscalaExistente(eenueva))
        //        {
        //            result = MessageBox.Show("No se ha podido modificar la escala porque el rango 'Hasta' se encuentra en el rango de una escala existente. ¿Desea cambiar los rangos y añadirla nuevamente?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                repetir = true;
        //            }
        //            esPosible = false;
        //        }
        //        else if (new DaoEscalaProgresiva().ExisteRangoDesdeEscalaNuevaDentroRangoEscalaExistente(eenueva))
        //        {
        //            result = MessageBox.Show("No se ha podido modificar la escala porque el rango 'Desde' se encuentra en el rango de una escala existente. ¿Desea cambiar los rangos y añadirla nuevamente?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                repetir = true;
        //            }
        //            esPosible = false;
        //        }
        //        else if (new DaoEscalaProgresiva().ExisteRangoEscalaNuevaDentroRangoEscalaExistente(eenueva))
        //        {
        //            result = MessageBox.Show("No se ha podido modificar la escala porque los rangos se encuentran en el rango de una escala existente. ¿Desea cambiar los rangos y añadirla nuevamente?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                repetir = true;
        //            }
        //            esPosible = false;
        //        }

        //        if (!esPosible)
        //        {
        //            if (repetir)
        //            {
        //                _listadoEscalas.RecargarElementos();
        //                dlg = new DialogoAdicionarModificarEscalas { Escala = eenueva, DataContext = eenueva };
        //                continue;
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }
        //        new DaoEscalaProgresiva().ActualizarElemento(eenueva.CodigoEscala, eenueva);
        //        _listadoEscalas.RemoveAt(GridEscalas.SelectedIndex);
        //        _listadoEscalas.Add(eenueva);

        //        VistaColeccionAnnos = (ListCollectionView)CollectionViewSource.GetDefaultView(_listadoAños);
        //        int Indice = -1;
        //        for (int i = 0; i < VistaColeccionAnnos.Count; i++)
        //        {
        //            Indice++;
        //            EntidadLineaTiempoAño Item = VistaColeccionAnnos.GetItemAt(i) as EntidadLineaTiempoAño;
        //            if (Item.Año == eenueva.Año)
        //            {
        //                ComboBoxAnnos.SelectedIndex = Indice;
        //            }
        //        }
        //        MessageBox.Show("La escala fue modificada correctamente.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        //        break;
        //    }
        //    _listadoEscalas.RecargarElementos();
        //}

        //void MenuAdicionarEscala_Click(object sender, RoutedEventArgs e)
        //{
        //    if(ComboBoxAnnos.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Debe seleccionar un año para luego agregar una escala.");
        //    }
        //    var dlg = new DialogoAdicionarModificarEscalas();
        //    dlg.ConfigurarDialogo(false);
        //    while (dlg.ShowDialog() == true)
        //    {
        //        var eenueva = (EntidadEscala)dlg.DataContext;
        //        bool repetir = false;
        //        bool esPosible = true;
        //        eenueva.CodigoEscala = new DaoEscalaProgresiva().ObtenerProximoCodigoEscala();
        //        eenueva.CodigoLineaTiempoAño = (ComboBoxAnnos.SelectedItem as EntidadLineaTiempoAño).CodigoLineaTiempoAño;
        //        eenueva.Año = (ComboBoxAnnos.SelectedItem as EntidadLineaTiempoAño).Año;

        //        MessageBoxResult result;
        //        if (eenueva.Desde > eenueva.Hasta)
        //        {
        //            result = MessageBox.Show("No se ha podido adicionar la escala porque el rango 'Desde' es mayor que el rago 'Hasta' en la nueva escala. ¿Desea cambiar los rangos y añadirla nuevamente?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                repetir = true;
        //            }
        //            esPosible = false;
        //        }
        //        else if (eenueva.Desde == eenueva.Hasta)
        //        {
        //            result = MessageBox.Show("No se ha podido adicionar la escala porque el rango 'Desde' es igual al rago 'Hasta' en la nueva escala. ¿Desea cambiar los rangos y añadirla nuevamente?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                repetir = true;
        //            }
        //            esPosible = false;
        //        }
        //        else if (eenueva.Desde < 0.0d)
        //        {
        //            result = MessageBox.Show("No se ha podido adicionar la escala porque el rango 'Desde' es menor que 0 en la nueva escala. ¿Desea cambiar los rangos y añadirla nuevamente?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                repetir = true;
        //            }
        //            esPosible = false;
        //        }
        //        else if (new DaoEscalaProgresiva().ExisteRangoDesdeEscalaNuevaIgualRangoDesdeEscalaExistente(eenueva))
        //        {
        //            result = MessageBox.Show("No se ha podido adicionar la escala porque el rango 'Desde' coincide con el rago 'Desde' de una escala existente. ¿Desea cambiar los rangos y añadirla nuevamente?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                repetir = true;
        //            }
        //            esPosible = false;
        //        }
        //        else if (new DaoEscalaProgresiva().ExisteRangoHastaEscalaNuevaIgualRangoHastaEscalaExistente(eenueva))
        //        {
        //            result = MessageBox.Show("No se ha podido adicionar la escala porque el rango 'Hasta' coincide con el rago 'Hasta' de una escala existente. ¿Desea cambiar los rangos y añadirla nuevamente?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                repetir = true;
        //            }
        //            esPosible = false;                  
        //        }
        //        else if (new DaoEscalaProgresiva().ExisteRangoDesdeEscalaNuevaIgualRangoHastaEscalaExistente(eenueva))
        //        {
        //            result = MessageBox.Show("No se ha podido adicionar la escala porque el rango 'Desde' coincide con el rago 'Hasta' de una escala existente. ¿Desea cambiar los rangos y añadirla nuevamente?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                repetir = true;
        //            }
        //            esPosible = false;                    
        //        }
        //        else if (new DaoEscalaProgresiva().ExisteRangoHastaEscalaNuevaIgualRangoDesdeEscalaExistente(eenueva))
        //        {
        //            result = MessageBox.Show("No se ha podido adicionar la escala porque el rango 'Hasta' coincide con el rago 'Desde' de una escala existente. ¿Desea cambiar los rangos y añadirla nuevamente?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                repetir = true;
        //            }
        //            esPosible = false;
        //        }
        //        else if (new DaoEscalaProgresiva().ExisteRangoHastaEscalaNuevaDentroRangoEscalaExistente(eenueva))
        //        {
        //            result = MessageBox.Show("No se ha podido adicionar la escala porque el rango 'Hasta' se encuentra en el rango de una escala existente. ¿Desea cambiar los rangos y añadirla nuevamente?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                repetir = true;
        //            }
        //            esPosible = false;
        //        }
        //        else if (new DaoEscalaProgresiva().ExisteRangoDesdeEscalaNuevaDentroRangoEscalaExistente(eenueva))
        //        {
        //            result = MessageBox.Show("No se ha podido adicionar la escala porque el rango 'Desde' se encuentra en el rango de una escala existente. ¿Desea cambiar los rangos y añadirla nuevamente?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                repetir = true;
        //            }
        //            esPosible = false;
        //        }
        //        else if (new DaoEscalaProgresiva().ExisteRangoEscalaNuevaDentroRangoEscalaExistente(eenueva))
        //        {
        //            result = MessageBox.Show("No se ha podido adicionar la escala porque los rangos se encuentran en el rango de una escala existente. ¿Desea cambiar los rangos y añadirla nuevamente?", "", MessageBoxButton.YesNo, MessageBoxImage.Information);
        //            if (result == MessageBoxResult.Yes)
        //            {
        //                repetir = true;
        //            }
        //            esPosible = false;
        //        }

        //        if (!esPosible)
        //        {
        //            if (repetir)
        //            {
        //                dlg = new DialogoAdicionarModificarEscalas { Escala = eenueva, DataContext = eenueva };
        //                continue;
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }
                
        //        new DaoEscalaProgresiva().AdicionarNuevoElemento(eenueva);
        //        _listadoEscalas.Add(eenueva);
        //        _listadoEscalas.RecargarElementos();
        //        VistaColeccionAnnos = (ListCollectionView)CollectionViewSource.GetDefaultView(_listadoAños);
        //        int Indice = -1;
        //        for (int i = 0; i < VistaColeccionAnnos.Count; i++)
        //        {
        //            Indice++;
        //            EntidadLineaTiempoAño Item = VistaColeccionAnnos.GetItemAt(i) as EntidadLineaTiempoAño;
        //            if (Item.Año == eenueva.Año)
        //            {
        //                ComboBoxAnnos.SelectedIndex = Indice;
        //            }
        //        }
        //        MessageBox.Show("La escala fue adicionada correctamente.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        //        break;
        //    }
        //}

        //void GridEscalas_SelectionChanged(object sender, RoutedEventArgs e)
        //{
        //    if (GridEscalas.SelectedIndex == -1)
        //    {
        //        GridEscalas.Detalles = "";               
        //        return;
        //    }
        //    var ee = GridEscalas.SelectedItem as EntidadEscala;
        //    if (ee != null) GridEscalas.Detalles = "Cuando el importe se encuentre en el rango de $" + ee.Desde.ToString() + " a $" + ee.Hasta + ". Aplicar un tipo impositivo del " + ee.Porciento.ToString() + "%.";           
        //}        
    }
}
