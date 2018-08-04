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

namespace Agenda.Controles
{
    public partial class ComboBoxSimple : UserControl
    {
        public Image Icono
        {
            get { return (Image)GetValue(IconoProperty); }
            set
            {
                SetValue(IconoProperty, value);
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
        public static readonly DependencyProperty IconoProperty =
            DependencyProperty.Register(
            "Icono", typeof(Image), typeof(ComboBoxSimple),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnIconoChanged)));

        private static void OnIconoChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            ComboBoxSimple control = (ComboBoxSimple)obj;

            if (args.NewValue != null)
            {
                control.IconoControl.Visibility = Visibility.Visible;
                control.IconoControl.Source = ((Image)args.NewValue).Source;                
            }
            else
            {
                control.IconoControl.Visibility = Visibility.Collapsed;
            }
            RoutedPropertyChangedEventArgs<Image> e = new RoutedPropertyChangedEventArgs<Image>(
                (Image)args.OldValue, (Image)args.NewValue, IconoChangedEvent);
            control.OnIconoChanged(e);
        }      
        public static readonly RoutedEvent IconoChangedEvent = EventManager.RegisterRoutedEvent(
            "IconoChanged", RoutingStrategy.Bubble,
            typeof(RoutedPropertyChangedEventHandler<Image>), typeof(ComboBoxSimple));
     
        public event RoutedPropertyChangedEventHandler<Image> IconoChanged
        {
            add { AddHandler(IconoChangedEvent, value); }
            remove { RemoveHandler(IconoChangedEvent, value); }
        }       
        protected virtual void OnIconoChanged(RoutedPropertyChangedEventArgs<Image> args)
        {
            RaiseEvent(args);          
        }

        public DataTemplate ItemTemplate
        {
            get { return (DataTemplate)GetValue(ItemTemplateProperty); }
            set
            {
                SetValue(ItemTemplateProperty, value);
                ListadoElementos.ItemTemplate = ((DataTemplate)value);                
            }
        }
        public static readonly DependencyProperty ItemTemplateProperty =
            DependencyProperty.Register(
            "ItemTemplate", typeof(DataTemplate), typeof(ComboBoxSimple),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnItemTemplateChanged)));

        private static void OnItemTemplateChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            ComboBoxSimple control = (ComboBoxSimple)obj;
            control.ListadoElementos.ItemTemplate = (DataTemplate)args.NewValue; 
            RoutedPropertyChangedEventArgs<DataTemplate> e = new RoutedPropertyChangedEventArgs<DataTemplate>(
                (DataTemplate)args.OldValue, (DataTemplate)args.NewValue, ItemTemplateChangedEvent);            
            control.OnItemTemplateChanged(e);
        }
        public static readonly RoutedEvent ItemTemplateChangedEvent = EventManager.RegisterRoutedEvent(
            "ItemTemplateChanged", RoutingStrategy.Bubble,
            typeof(RoutedPropertyChangedEventHandler<DataTemplate>), typeof(ComboBoxSimple));

        public event RoutedPropertyChangedEventHandler<DataTemplate> ItemTemplateChanged
        {
            add { AddHandler(ItemTemplateChangedEvent, value); }
            remove { RemoveHandler(ItemTemplateChangedEvent, value); }
        }
        protected virtual void OnItemTemplateChanged(RoutedPropertyChangedEventArgs<DataTemplate> args)
        {
            RaiseEvent(args);           
        }

        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set
            {
                SetValue(ItemsSourceProperty, value);
                ListadoElementos.ItemsSource = ((IEnumerable)value);
            }
        }
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register(
            "ItemsSource", typeof(IEnumerable), typeof(ComboBoxSimple),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnItemsSourceChanged)));

        private static void OnItemsSourceChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            ComboBoxSimple control = (ComboBoxSimple)obj;
            control.ListadoElementos.ItemsSource = (IEnumerable)args.NewValue;
            RoutedPropertyChangedEventArgs<IEnumerable> e = new RoutedPropertyChangedEventArgs<IEnumerable>(
                (IEnumerable)args.OldValue, (IEnumerable)args.NewValue, ItemsSourceChangedEvent);
            control.OnItemsSourceChanged(e);
        }
        public static readonly RoutedEvent ItemsSourceChangedEvent = EventManager.RegisterRoutedEvent(
            "ItemsSourceChanged", RoutingStrategy.Bubble,
            typeof(RoutedPropertyChangedEventHandler<IEnumerable>), typeof(ComboBoxSimple));

        public event RoutedPropertyChangedEventHandler<IEnumerable> ItemsSourceChanged
        {
            add { AddHandler(ItemsSourceChangedEvent, value); }
            remove { RemoveHandler(ItemsSourceChangedEvent, value); }
        }
        protected virtual void OnItemsSourceChanged(RoutedPropertyChangedEventArgs<IEnumerable> args)
        {
            RaiseEvent(args);
        }


        public event SelectionChangedEventHandler SelectionChanged;

        public Object SelectedItem
        {
            get { return (Object)GetValue(SelectedItemProperty); }
            set
            {
                SetValue(SelectedItemProperty, value);
                ListadoElementos.SelectedItem = ((Object)value);
            }
        }
        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register(
            "SelectedItem", typeof(Object), typeof(ComboBoxSimple),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnSelectedItemChanged)));

        private static void OnSelectedItemChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            ComboBoxSimple control = (ComboBoxSimple)obj;
            control.ListadoElementos.SelectedItem= (Object)args.NewValue;
            RoutedPropertyChangedEventArgs<Object> e = new RoutedPropertyChangedEventArgs<Object>(
                (Object)args.OldValue, (Object)args.NewValue, SelectedItemChangedEvent);
            control.OnSelectedItemChanged(e);
        }
        public static readonly RoutedEvent SelectedItemChangedEvent = EventManager.RegisterRoutedEvent(
            "SelectedItemChanged", RoutingStrategy.Bubble,
            typeof(RoutedPropertyChangedEventHandler<Object>), typeof(ComboBoxSimple));

        public event RoutedPropertyChangedEventHandler<Object> SelectedItemChanged
        {
            add { AddHandler(SelectedItemChangedEvent, value); }
            remove { RemoveHandler(SelectedItemChangedEvent, value); }
        }
        protected virtual void OnSelectedItemChanged(RoutedPropertyChangedEventArgs<Object> args)
        {
            RaiseEvent(args);
        }

        public int SelectedIndex
        {
            get { return ListadoElementos.SelectedIndex; }
            set
            {
                ListadoElementos.SelectedIndex = value;
            }
        }
        
        private string _textoNoSeleccionado;
        public string TextoNoSeleccionado
        {
            get { return _textoNoSeleccionado; }
            set {
                    this._textoNoSeleccionado = value;
                    if (SelectedIndex == -1)
                    {
                        TextoSeleccionado.Text = _textoNoSeleccionado;                        
                    }
                }
        }
        public ItemCollection Items
        {
            get {return ListadoElementos.Items;}           
        }
        
        void onClick(object sender, RoutedEventArgs e)
        {
            if (ListadoElementos.Items.Count == 1)
            {
                if (ListadoElementos.SelectedIndex == -1)
                {
                    ControlPopup.IsOpen = true;
                }
            }
            else if (ListadoElementos.Items.Count > 1)
            {
                ControlPopup.IsOpen = true;
            }            
        }

        public ComboBoxSimple()
        {  
            InitializeComponent();
            Icono = new Image();
            if (IconoControl.Source == null)
            {
                IconoControl.Visibility = Visibility.Collapsed;
            }
            else
            {
                IconoControl.Visibility = Visibility.Visible;
            }
            ControlPopup.StaysOpen = true;
            ListadoElementos.SelectionChanged += ListadoElementos_SelectionChanged;
            ListadoElementos.MouseLeftButtonUp += ListadoElementos_MouseLeftButtonUp;
            ListadoElementos_SelectionChanged(null, null);
            MiBotonSeleccion.MouseEnter += MiBotonSeleccion_MouseEnter;
            MiBotonSeleccion.MouseLeave += MiBotonSeleccion_MouseLeave;
            this.DataContextChanged += ComboBoxSimple_DataContextChanged;
        }

        void ComboBoxSimple_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            ListadoElementos.DataContext = this.DataContext;
        }

        void MiBotonSeleccion_MouseLeave(object sender, MouseEventArgs e)
        {
            if (ListadoElementos.SelectedIndex == -1)
            {
                TextoSeleccionado.Foreground = (Brush)this.FindResource("ColorTextoCuandoNoHaySeleccion");
                IconoTriangulo.Stroke = (Brush)this.FindResource("ColorTextoCuandoNoHaySeleccion");
                IconoTriangulo.Fill = (Brush)this.FindResource("ColorTextoCuandoNoHaySeleccion");
            }
            else
            {
                TextoSeleccionado.Foreground = (Brush)this.FindResource("ColorTextoSeleccionado");
                IconoTriangulo.Stroke = (Brush)this.FindResource("ColorTextoSeleccionado");
                IconoTriangulo.Fill = (Brush)this.FindResource("ColorTextoSeleccionado");
            }
        }

        void MiBotonSeleccion_MouseEnter(object sender, MouseEventArgs e)
        {
            if (ListadoElementos.SelectedIndex == -1)
            {
                TextoSeleccionado.Foreground = (Brush)this.FindResource("ColorTextoCuandoNoHaySeleccionMouseEnter");
                IconoTriangulo.Stroke = (Brush)this.FindResource("ColorTextoCuandoNoHaySeleccionMouseEnter");
                IconoTriangulo.Fill = (Brush)this.FindResource("ColorTextoCuandoNoHaySeleccionMouseEnter");
            }
            else
            {
                TextoSeleccionado.Foreground = (Brush)this.FindResource("ColorTextoSeleccionadoMouseEnter");
                IconoTriangulo.Stroke = (Brush)this.FindResource("ColorTextoSeleccionadoMouseEnter");
                IconoTriangulo.Fill = (Brush)this.FindResource("ColorTextoSeleccionadoMouseEnter");
            }
        }

        void ListadoElementos_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.ControlPopup.IsOpen = false;
        }

        void ListadoElementos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListadoElementos.SelectedIndex == -1)
            {
                TextoSeleccionado.Text = _textoNoSeleccionado;
            }
            else
            {
                TextoSeleccionado.Text = ListadoElementos.SelectedItem.ToString();
                SelectedItem = ListadoElementos.SelectedItem;               
            }
            MiBotonSeleccion_MouseLeave(null, null);
            if (SelectionChanged != null)
            {
                SelectionChanged(sender, e);
            }
            this.ControlPopup.IsOpen = false;           
        }
    }
}
