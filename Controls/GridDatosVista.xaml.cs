using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Agenda.ModuloExc.Excepciones;
using System.ComponentModel;
using System.Windows.Media.Animation;

namespace Agenda.Controles
{
    class GridViewColumConBindingPath : GridViewColumn
    {
        public string BindingPath { get; set;}
    }
    public partial class GridDatosVista : UserControl
    {
        public event RoutedEventHandler TextSearchChanged;
        private GridView _gridViewControl = new GridView();

        public GridView GridViewControl
        {
            get { return _gridViewControl; }
            set { _gridViewControl = value; }           
        }

        GridViewColumnHeader _lastHeaderClicked = null;
        ListSortDirection _lastDirection = ListSortDirection.Ascending;

        void GridViewColumnHeaderClickedHandler(object sender, RoutedEventArgs e)
        {          
            GridViewColumnHeader headerClicked = e.OriginalSource as GridViewColumnHeader;
            ListSortDirection direction;
            if (headerClicked != null)
            {
                if (headerClicked.Role != GridViewColumnHeaderRole.Padding)
                {
                    if (headerClicked != _lastHeaderClicked)
                    {
                        direction = ListSortDirection.Ascending;
                    }
                    else
                    {
                        if (_lastDirection == ListSortDirection.Ascending)
                        {
                            direction = ListSortDirection.Descending;
                        }
                        else
                        {
                            direction = ListSortDirection.Ascending;
                        }
                    }

                    string BindingPath = (headerClicked.Column as GridViewColumConBindingPath).BindingPath;
                    Sort(BindingPath, direction);

                    if (direction == ListSortDirection.Ascending)
                    {
                        headerClicked.Column.HeaderTemplate = Resources["PlantillaHeaderFlechaArriba"] as DataTemplate;
                    }
                    else
                    {
                        headerClicked.Column.HeaderTemplate = Resources["PlantillaHeaderFlechaAbajo"] as DataTemplate;
                    }

                    // Remove arrow from previously sorted header
                    if (_lastHeaderClicked != null && _lastHeaderClicked != headerClicked)
                    {
                        _lastHeaderClicked.Column.HeaderTemplate = null;
                    }

                    _lastHeaderClicked = headerClicked;
                    _lastDirection = direction;
                }
            }
        }
       
        private void Sort(string sortBy, ListSortDirection direction)
        {
            ICollectionView dataView =    CollectionViewSource.GetDefaultView(ListViewDatos.ItemsSource);
            dataView.SortDescriptions.Clear();
            SortDescription sd = new SortDescription(sortBy, direction);
            dataView.SortDescriptions.Add(sd);
            dataView.Refresh();
        }

        void onTextSearchChanged(object sender, RoutedEventArgs e)
        {
            if (this.TextSearchChanged != null)
            {
                this.TextSearchChanged(this, e);
            }
        }

        public string TextSearch
        {
            get { return ControlBotonBusqueda.TextSearch; }
            set 
            {
                ControlBotonBusqueda.TextSearch = value;
            }
        } 

        public string Titulo
        {
            get { return (string)GetValue(TituloProperty); }
            set { SetValue(TituloProperty, value); }
        }

        
        public static readonly DependencyProperty TituloProperty =
            DependencyProperty.Register(
            "Titulo", typeof(string), typeof(GridDatosVista),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnTituloChanged)));

        private static void OnTituloChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            GridDatosVista  control = (GridDatosVista)obj;
            control.TituloControl.Text = ((string)args.NewValue);
            RoutedPropertyChangedEventArgs<string> e = new RoutedPropertyChangedEventArgs<string>(
                (string)args.OldValue, (string)args.NewValue, TituloChangedEvent);
            control.OnTituloChanged(e);
        }

        
        public static readonly RoutedEvent TituloChangedEvent = EventManager.RegisterRoutedEvent(
            "TituloChanged", RoutingStrategy.Bubble,
            typeof(RoutedPropertyChangedEventHandler<string>), typeof(GridDatosVista));

       
        public event RoutedPropertyChangedEventHandler<string> TituloChanged
        {
            add { AddHandler(TituloChangedEvent, value); }
            remove { RemoveHandler(TituloChangedEvent, value); }
        }

        
        protected virtual void OnTituloChanged(RoutedPropertyChangedEventArgs<string> args)
        {
            RaiseEvent(args);
        }


        private Object _selectedItem;

        public Object SelectedItem
        {
            get { return _selectedItem; }
            set 
            { 
                _selectedItem = value;
                ListViewDatos.SelectedItem = _selectedItem;
            }
        }       


        private int _selectedIndex;

        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set 
            {
                _selectedIndex = value;
                ListViewDatos.SelectedIndex = _selectedIndex;
            }
        }

        private string _detalles;

        public string Detalles
        {
            get { return _detalles; }
            set 
            { 
                _detalles = value;
                this.TextBockDetalles.Text = _detalles;
               
            }
        }
        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value);}
        }
       
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register(
            "ItemsSource", typeof(IEnumerable), typeof(GridDatosVista),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnItemsSourceChanged)));

        private static void OnItemsSourceChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            GridDatosVista  control = (GridDatosVista)obj;

            if (args.NewValue != null)
            {
                control.ListViewDatos.ItemsSource = ((IEnumerable)args.NewValue);
            }

            RoutedPropertyChangedEventArgs<IEnumerable> e = new RoutedPropertyChangedEventArgs<IEnumerable>(
                (IEnumerable)args.OldValue, (IEnumerable)args.NewValue, ItemsSourceChangedEvent);
            control.OnItemsSourceChanged(e);
        }
       
        public static readonly RoutedEvent ItemsSourceChangedEvent = EventManager.RegisterRoutedEvent(
            "ItemsSourceChanged", RoutingStrategy.Bubble,
            typeof(RoutedPropertyChangedEventHandler<IEnumerable>), typeof(GridDatosVista));

        
        public event RoutedPropertyChangedEventHandler<IEnumerable> ItemsSourceChanged
        {
            add { AddHandler(ItemsSourceChangedEvent, value); }
            remove { RemoveHandler(ItemsSourceChangedEvent, value); }
        }
        protected virtual void OnItemsSourceChanged(RoutedPropertyChangedEventArgs<IEnumerable> args)
        {
            RaiseEvent(args);
        }


        public DataTemplate ItemTemplate
        {
            get { return (DataTemplate)GetValue(ItemTemplateProperty); }
            set
            {
                SetValue(ItemTemplateProperty, value); 
            }
        }

        public static readonly DependencyProperty ItemTemplateProperty =
            DependencyProperty.Register(
            "ItemTemplate", typeof(DataTemplate), typeof(GridDatosVista),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnItemTemplateChanged)));

        private static void OnItemTemplateChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            GridDatosVista control = (GridDatosVista)obj;
            
            if (args.NewValue != null)
            {
                control.ListViewDatos.ItemTemplate = ((DataTemplate)args.NewValue);                    
            }              
            
            RoutedPropertyChangedEventArgs<DataTemplate> e = new RoutedPropertyChangedEventArgs<DataTemplate>(
                (DataTemplate)args.OldValue, (DataTemplate)args.NewValue, ItemTemplateChangedEvent);
            control.OnItemTemplateChanged(e);
        }

        
        public static readonly RoutedEvent ItemTemplateChangedEvent = EventManager.RegisterRoutedEvent(
            "ItemTemplateChanged", RoutingStrategy.Bubble,
            typeof(RoutedPropertyChangedEventHandler<DataTemplate>), typeof(GridDatosVista));

       
        public event RoutedPropertyChangedEventHandler<DataTemplate> ItemTemplateChanged
        {
            add { AddHandler(ItemTemplateChangedEvent, value); }
            remove { RemoveHandler(ItemTemplateChangedEvent, value); }
        }

       
        protected virtual void OnItemTemplateChanged(RoutedPropertyChangedEventArgs<DataTemplate> args)
        {
            RaiseEvent(args);
        }

        public Image Icono
        {
            get { return (Image)GetValue(IconoProperty); }
            set
            {
                SetValue(IconoProperty, value);
                if (IconoControl != null)
                {                    
                    IconoControl.Source = ((Image)value).Source;
                    if (IconoControl.Source == null)
                    {
                        IconoControl.Visibility = System.Windows.Visibility.Collapsed;
                    }
                    else
                    {
                        IconoControl.Visibility = System.Windows.Visibility.Visible;
                    }
                }
            }
        }

        
        public static readonly DependencyProperty IconoProperty =
            DependencyProperty.Register(
            "Icono", typeof(Image), typeof(GridDatosVista),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnIconoChanged)));

        private static void OnIconoChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            GridDatosVista control = (GridDatosVista)obj;
            if (control.IconoControl != null)
            {
                if (args.NewValue != null)
                {
                    control.IconoControl.Source = ((Image)args.NewValue).Source;
                    control.IconoControl.Visibility = Visibility.Visible;
                }
                else
                {
                    control.IconoControl.Visibility = Visibility.Collapsed;                    
                }
            }
            RoutedPropertyChangedEventArgs<Image> e = new RoutedPropertyChangedEventArgs<Image>(
                (Image)args.OldValue, (Image)args.NewValue, IconoChangedEvent);
            control.OnIconoChanged(e);
        }

        
        public static readonly RoutedEvent IconoChangedEvent = EventManager.RegisterRoutedEvent(
            "IconoChanged", RoutingStrategy.Bubble,
            typeof(RoutedPropertyChangedEventHandler<Image>), typeof(GridDatosVista));

        
        public event RoutedPropertyChangedEventHandler<Image> IconoChanged
        {
            add { AddHandler(IconoChangedEvent, value); }
            remove { RemoveHandler(IconoChangedEvent, value); }
        }

        
        protected virtual void OnIconoChanged(RoutedPropertyChangedEventArgs<Image> args)
        {
            RaiseEvent(args);
        }

        private ArrayList ItemsMenu = new ArrayList();
        private Storyboard _storyboardAnimarItemsMenu;
        private void AnimarItemsMenu()
        {
            _storyboardAnimarItemsMenu = new Storyboard();
            NameScope.SetNameScope(this, new NameScope());
            foreach (FrameworkElement uie in ItemsMenu)
            {
                RegisterName(uie.Name, uie);               
            }
            ArrayList Animaciones = new ArrayList();
            float i = 0;
            foreach (FrameworkElement uie in ItemsMenu)
            {
                var miDoubleAnimation = new DoubleAnimation();
                miDoubleAnimation.From = 0.0;
                miDoubleAnimation.To = 1.0;
                miDoubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(1));
                miDoubleAnimation.BeginTime = TimeSpan.FromSeconds(i);                
                i += 0.5f;
                Animaciones.Add(miDoubleAnimation);
            }
           
            foreach (DoubleAnimation da in Animaciones)
            {
                _storyboardAnimarItemsMenu.Children.Add(da);
            }

            int j = 0;
            foreach (FrameworkElement uie in ItemsMenu)
            {
                Storyboard.SetTargetName((DependencyObject)Animaciones[j], uie.Name);
                Storyboard.SetTargetProperty((DependencyObject)Animaciones[j++], new PropertyPath(OpacityProperty));
            }
            _storyboardAnimarItemsMenu.Begin(this);

        }
        public GridDatosVista()
        {  
            InitializeComponent();
            ListViewDatos.View = _gridViewControl;           
            
            if (IconoControl != null)
            {                
                if (IconoControl.Source == null)
                {
                    IconoControl.Visibility = System.Windows.Visibility.Collapsed;
                }
                else
                {
                    IconoControl.Visibility = System.Windows.Visibility.Visible;
                }
            }   
              
            ListViewDatos.SelectionChanged += ListViewDatos_SelectionChanged;
            ControlBotonBusqueda.TextSearchChanged += ControlBotonBusqueda_TextSearchChanged;
            this.ControlBotonBusqueda.TextSearchKeyUp += new KeyEventHandler(ControlBotonBusqueda_TextSearchKeyUp);           
            this.Loaded += GridDatosVista_Loaded;
            
        }

        private void GridDatosVista_Loaded(object sender, RoutedEventArgs e)
        {
            AnimarItemsMenu();
        }

        public event KeyEventHandler TextSearchKeyUp;
        
        void ControlBotonBusqueda_TextSearchKeyUp(object sender, KeyEventArgs e)
        {
            if (this.TextSearchKeyUp != null)
            {
                this.TextSearchKeyUp(this, e);
            }
        }

        void ControlBotonBusqueda_TextSearchChanged(object sender, RoutedEventArgs e)
        {
            onTextSearchChanged(sender,e);
        }

        public event RoutedEventHandler SelectionChanged;

        void onSelectionChanged(object sender, RoutedEventArgs e)
        {
            if (this.SelectionChanged != null)
                this.SelectionChanged(this, e);
        }

        void ListViewDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {                                 
            _selectedIndex = ListViewDatos.SelectedIndex;
            _selectedItem = ListViewDatos.SelectedItem;
            onSelectionChanged(sender, e);
        }        
        public void AdicionarColumna(string bindingPath, string titulo,DataTemplate cellTemplate)
        {
            GridViewColumConBindingPath gvc = new GridViewColumConBindingPath();           
            gvc.Header = titulo;
            gvc.CellTemplate = cellTemplate;
            gvc.BindingPath = bindingPath;
            _gridViewControl.Columns.Add(gvc);
        }

        public void AdicionarMenu(string nombre, string titulo, string icono)
        {                       
            BotonMenuGridDatos  bm = new BotonMenuGridDatos();
            bm.Name = nombre;
            bm.Titulo = titulo;
            bm.Icono = (Image)this.FindResource(icono);
            bm.Opacity = 0;
            StackPanelAreaMenu.Children.Add(bm);
            ItemsMenu.Add(bm);
            StackPanelAreaMenu.Visibility = Visibility.Visible;
            CapaBaseAreaMenu.BorderThickness = new Thickness(1, 1, 1, 1);
        }
        public void AdicionarMenu(string nombre, string titulo)
        {           
            BotonMenuGridDatos bm = new BotonMenuGridDatos();
            bm.Name = nombre;
            bm.Titulo = titulo;
            bm.Opacity = 0;
            StackPanelAreaMenu.Children.Add(bm);
            ItemsMenu.Add(bm);
            StackPanelAreaMenu.Visibility = Visibility.Visible;
            CapaBaseAreaMenu.BorderThickness = new Thickness(1, 1, 1, 1);
        }

        public void RenombrarSeleccion(string nombreSeleccion, string nuevoTitulo)
        {
            UIElementCollection Coleccion = StackPanelAreaMenu.Children;
            foreach (UIElement uie in Coleccion)
            {
                if (uie is BotonSeleccionGridDatos)
                {
                    if (((BotonSeleccionGridDatos)uie).Name == nombreSeleccion)
                    {
                        ((BotonSeleccionGridDatos)uie).Titulo = nuevoTitulo;
                        return;
                    }
                }
            }
            throw new EObjetoNoEncontrado(nombreSeleccion);
        }
       

        public void AdicionarSeleccion(string nombre, string titulo)
        {   
            BotonSeleccionGridDatos  bm = new BotonSeleccionGridDatos();
            bm.Name = nombre;
            bm.Titulo = titulo;
            bm.Opacity = 0;
            StackPanelAreaMenu.Children.Add(bm);
            ItemsMenu.Add(bm);
            StackPanelAreaMenu.Visibility = Visibility.Visible;
            CapaBaseAreaMenu.BorderThickness = new Thickness(1, 1, 1, 1);
        }
        public BotonMenuGridDatos  ObtenerMenu(string nombre)
        {
            UIElementCollection Coleccion = StackPanelAreaMenu.Children;
            foreach (UIElement uie in Coleccion)
            {
                if (uie is BotonMenuGridDatos)
                {
                    if (((BotonMenuGridDatos)uie).Name == nombre)
                    {
                        return (BotonMenuGridDatos)uie;
                    }
                }
            }
            throw new EObjetoNoEncontrado(nombre);
        }
        public BotonSeleccionGridDatos ObtenerSeleccion(string nombre)
        {
            UIElementCollection Coleccion = StackPanelAreaMenu.Children;
            foreach (UIElement uie in Coleccion)
            {
                if (uie is BotonSeleccionGridDatos)
                {
                    if (((BotonSeleccionGridDatos)uie).Name == nombre)
                    {
                        return (BotonSeleccionGridDatos)uie;
                    }
                }
            }
            throw new EObjetoNoEncontrado(nombre);
        }
       
        public void FocusTextSearch()
        {
            ControlBotonBusqueda.FocusTextSearch();
        }      
    }
}
