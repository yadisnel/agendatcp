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
    public partial class BarraTitulo : UserControl
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

        /// <summary>
        /// Identifies the Value dependency property.
        /// </summary>
        public static readonly DependencyProperty IconoProperty =
            DependencyProperty.Register(
            "Icono", typeof(Image), typeof(BarraTitulo),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnIconoChanged)));

        private static void OnIconoChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            BarraTitulo control = (BarraTitulo)obj;
            
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
            typeof(RoutedPropertyChangedEventHandler<Image>), typeof(BarraTitulo));

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


        public string Titulo
        {
            get { return (string)GetValue(TituloProperty); }
            set { SetValue(TituloProperty, value); }
        }

        /// <summary>
        /// Identifies the Titulo dependency property.
        /// </summary>
        public static readonly DependencyProperty TituloProperty =
            DependencyProperty.Register(
            "Titulo", typeof(string), typeof(BarraTitulo),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnTituloChanged)));

        private static void OnTituloChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            BarraTitulo control = (BarraTitulo)obj;
            control.TituloControl.Text = ((string)args.NewValue);
            RoutedPropertyChangedEventArgs<string> e = new RoutedPropertyChangedEventArgs<string>(
                (string)args.OldValue, (string)args.NewValue, TituloChangedEvent);
            control.OnTituloChanged(e);
        }

        /// <summary>
        /// Identifies the TituloChanged routed event.
        /// </summary>
        public static readonly RoutedEvent TituloChangedEvent = EventManager.RegisterRoutedEvent(
            "TituloChanged", RoutingStrategy.Bubble,
            typeof(RoutedPropertyChangedEventHandler<string>), typeof(BarraTitulo));

        /// <summary>
        /// Occurs when the Titulo property changes.
        /// </summary>
        public event RoutedPropertyChangedEventHandler<string> TituloChanged
        {
            add { AddHandler(TituloChangedEvent, value); }
            remove { RemoveHandler(TituloChangedEvent, value); }
        }

        /// <summary>
        /// Raises the TituloChanged event.
        /// </summary>
        /// <param name="args">Arguments associated with the ValueChanged event.</param>
        protected virtual void OnTituloChanged(RoutedPropertyChangedEventArgs<string> args)
        {
            RaiseEvent(args);
        }

        public event RoutedEventHandler ClickCerrar;
        void onClickCerrar(object sender, RoutedEventArgs e)
        {
            if (this.ClickCerrar != null)
                this.ClickCerrar(this, e);
        }

        public event RoutedEventHandler ClickMinimizar;
        void onClickMinimizar(object sender, RoutedEventArgs e)
        {
            if (this.ClickMinimizar != null)
                this.ClickMinimizar(this, e);
        }

        public event RoutedEventHandler ClickMaximizar;

        void onClickMaximizar(object sender, RoutedEventArgs e)
        {
            if (this.ClickMaximizar != null)
                this.ClickMaximizar(this, e);
        }

        private bool _ocultarBotonCerrar;

        public bool OcultarBotonCerrar
        {
            get { return _ocultarBotonCerrar; }
            set 
            {
                _ocultarBotonCerrar = value;
                if (_ocultarBotonCerrar) BotonCerrar.Visibility = System.Windows.Visibility.Collapsed;
                else BotonCerrar.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private bool _ocultarBotonMaximizar;

        public bool OcultarBotonMaximizar
        {
            get { return _ocultarBotonMaximizar; }
            set
            {
                _ocultarBotonMaximizar = value;
                if (_ocultarBotonMaximizar) BotonMaximizar.Visibility = System.Windows.Visibility.Collapsed;
                else BotonMaximizar.Visibility = System.Windows.Visibility.Visible;
            }
        }
        private bool _ocultarBotonMinimizar;

        public bool OcultarBotonMinimizar
        {
            get { return _ocultarBotonMinimizar; }
            set
            {
                _ocultarBotonMinimizar = value;
                if (_ocultarBotonMinimizar) BotonMinimizar.Visibility = System.Windows.Visibility.Collapsed;
                else BotonMinimizar.Visibility = System.Windows.Visibility.Visible;
            }
        }
        public BarraTitulo()
        {            
           
            InitializeComponent();
            this.BotonCerrar.ClickCerrar += onClickCerrar;
            this.BotonMaximizar.ClickMaximizar += onClickMaximizar;
            this.BotonMinimizar.ClickMinimizar += onClickMinimizar;
            //this.BotonMaximizar.DataContext = this.BotonMaximizar;
            Button b;
            Icono = new Image();          
            if (IconoControl.Source == null)
            {
                IconoControl.Visibility = Visibility.Collapsed;
            }
            else
            {
                IconoControl.Visibility = Visibility.Visible;
            }
        }
    }
}
