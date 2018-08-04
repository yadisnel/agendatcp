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
    public partial class BotonMenuGridDatos : UserControl
    {
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
                IconoBoton.Source = ((Image)value).Source;
                if (IconoBoton.Source == null)
                {
                    IconoBoton.Visibility = System.Windows.Visibility.Collapsed;
                }
                else
                {
                    IconoBoton.Visibility = System.Windows.Visibility.Visible;
                }
            }
        }

        /// <summary>
        /// Identifies the Value dependency property.
        /// </summary>
        public static readonly DependencyProperty IconoProperty =
            DependencyProperty.Register(
            "Icono", typeof(Image), typeof(BotonMenuGridDatos),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnIconoChanged)));

        private static void OnIconoChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
           BotonMenuGridDatos control = (BotonMenuGridDatos)obj;
           if (args.NewValue != null)
           {
               control.IconoBoton.Visibility = Visibility.Visible;
               control.IconoBoton.Source = ((Image)args.NewValue).Source;
           }
           else
           {
               control.IconoBoton.Visibility = Visibility.Collapsed;
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
            typeof(RoutedPropertyChangedEventHandler<Image>), typeof(BotonMenuGridDatos));

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
            set { 
                    SetValue(TituloProperty, value);
                    TituloBoton.Text = ((string)value);
                }
        }

        /// <summary>
        /// Identifies the Titulo dependency property.
        /// </summary>
        public static readonly DependencyProperty TituloProperty =
            DependencyProperty.Register(
            "Titulo", typeof(string), typeof(BotonMenuGridDatos),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnTituloChanged)));

        private static void OnTituloChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
           BotonMenuGridDatos control = (BotonMenuGridDatos)obj;
            control.TituloBoton.Text = ((string)args.NewValue);
            RoutedPropertyChangedEventArgs<string> e = new RoutedPropertyChangedEventArgs<string>(
                (string)args.OldValue, (string)args.NewValue, TituloChangedEvent);
            control.OnTituloChanged(e);
        }

        /// <summary>
        /// Identifies the TituloChanged routed event.
        /// </summary>
        public static readonly RoutedEvent TituloChangedEvent = EventManager.RegisterRoutedEvent(
            "TituloChanged", RoutingStrategy.Bubble,
            typeof(RoutedPropertyChangedEventHandler<string>), typeof(BotonMenuGridDatos));

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
       
        public BotonMenuGridDatos()
        {  
            InitializeComponent();            
            if (IconoBoton.Source == null)
            {
                IconoBoton.Visibility = Visibility.Collapsed;
            }
            else
            {
                IconoBoton.Visibility = Visibility.Visible;
            }
        }
    }
}
