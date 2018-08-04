using System;
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
    /// <summary>
    /// Interaction logic for BarraTitulo.xaml
    /// </summary>
    public partial class BotonBusqueda : UserControl
    {
        public string TextSearch
        {
            get { return TextBoxBusqueda.Text; }
            set 
            {
                TextBoxBusqueda.Text = value; 
            }
        }

        public void FocusTextSearch()
        {
            TextBoxBusqueda.Focus();
        }
        public event RoutedEventHandler Click;

        void onClick(object sender, RoutedEventArgs e)
        {
            if (this.Click != null)
            {
                this.Click(this, e);
            }
        }

       

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

        /// <summary>
        /// Identifies the Value dependency property.
        /// </summary>
        public static readonly DependencyProperty IconoProperty =
            DependencyProperty.Register(
            "Icono", typeof(Image), typeof(BotonBusqueda),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnIconoChanged)));

        private static void OnIconoChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            BotonBusqueda control = (BotonBusqueda)obj;
            
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

        /// <summary>
        /// Identifies the IconoChanged routed event.
        /// </summary>
        public static readonly RoutedEvent IconoChangedEvent = EventManager.RegisterRoutedEvent(
            "IconoChanged", RoutingStrategy.Bubble,
            typeof(RoutedPropertyChangedEventHandler<Image>), typeof(BotonBusqueda));

        /// <summary>
        /// Occurs when the Icono property changes.
        /// </summary>
        public event RoutedPropertyChangedEventHandler<Image> IconoChanged
        {
            add { AddHandler(IconoChangedEvent, value); }
            remove { RemoveHandler(IconoChangedEvent, value); }
        }

        /// <summary>
        /// Raises the IconoChanged event.
        /// </summary>
        /// <param name="args">Arguments associated with the ValueChanged event.</param>
        protected virtual void OnIconoChanged(RoutedPropertyChangedEventArgs<Image> args)
        {
            RaiseEvent(args);
        }
        public event RoutedEventHandler TextSearchChanged;

        void onTextSearchChanged(object sender, RoutedEventArgs e)
        {
            if (this.TextSearchChanged != null)
            {
                this.TextSearchChanged(this, e);
            }
        }
        public BotonBusqueda()
        {  
            InitializeComponent();
            TextBoxBusqueda.TextChanged += TextBoxBusqueda_TextChanged;
            TextBoxBusqueda.KeyUp += new KeyEventHandler(TextBoxBusqueda_KeyUp);
        }
        public event KeyEventHandler TextSearchKeyUp;
        void onTextSearchKeyUp(object sender, KeyEventArgs e)
        {
            if (this.TextSearchKeyUp != null)
            {
                this.TextSearchKeyUp(this, e);
            }
        }

        void TextBoxBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            onTextSearchKeyUp(sender, e);
        }

        void TextBoxBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextBoxBusqueda.Text.Equals(""))
            {
                TextBoxBusqueda.Tag = "NoTieneTexto";
            }
            else
            {
                TextBoxBusqueda.Tag = "TieneTexto";
            }
            onTextSearchChanged(sender, e);
        }
    }
}
