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
    public partial class BotonOpcionAyuda : UserControl
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
            set { SetValue(IconoProperty, value); }
        }

        /// <summary>
        /// Identifies the Value dependency property.
        /// </summary>
        public static readonly DependencyProperty IconoProperty =
            DependencyProperty.Register(
            "Icono", typeof(Image), typeof(BotonOpcionAyuda),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnIconoChanged)));

        private static void OnIconoChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            BotonOpcionAyuda control = (BotonOpcionAyuda)obj;
            if (args.NewValue!=null) control.IconoBoton.Source = ((Image)args.NewValue).Source;           
            RoutedPropertyChangedEventArgs<Image> e = new RoutedPropertyChangedEventArgs<Image>(
                (Image)args.OldValue, (Image)args.NewValue, IconoChangedEvent);
            control.OnIconoChanged(e);
        }

        /// <summary>
        /// Identifies the IconoChanged routed event.
        /// </summary>
        public static readonly RoutedEvent IconoChangedEvent = EventManager.RegisterRoutedEvent(
            "IconoChanged", RoutingStrategy.Bubble,
            typeof(RoutedPropertyChangedEventHandler<Image>), typeof(BotonOpcionAyuda));

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
            "Titulo", typeof(string), typeof(BotonOpcionAyuda),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnTituloChanged)));

        private static void OnTituloChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            BotonOpcionAyuda control = (BotonOpcionAyuda)obj;
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
            typeof(RoutedPropertyChangedEventHandler<string>), typeof(BotonOpcionAyuda));

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

        //---------
        public string CornerRadius
        {
            get { return (string)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        /// <summary>
        /// Identifies the CornerRadius dependency property.
        /// </summary>
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(
            "CornerRadius", typeof(string), typeof(BotonOpcionAyuda),
            new FrameworkPropertyMetadata("0,0,0,0", new PropertyChangedCallback(OnCornerRadiusChanged)));

        private static void OnCornerRadiusChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            BotonOpcionAyuda control = (BotonOpcionAyuda)obj;
            //control.TituloBoton.Text = ((string)args.NewValue);
            RoutedPropertyChangedEventArgs<string> e = new RoutedPropertyChangedEventArgs<string>(
                (string)args.OldValue, (string)args.NewValue, CornerRadiusChangedEvent);
            control.OnCornerRadiusChanged(e);
        }

        /// <summary>
        /// Identifies the CornerRadiusChanged routed event.
        /// </summary>
        public static readonly RoutedEvent CornerRadiusChangedEvent = EventManager.RegisterRoutedEvent(
            "CornerRadiusChanged", RoutingStrategy.Bubble,
            typeof(RoutedPropertyChangedEventHandler<string>), typeof(BotonOpcionAyuda));

        /// <summary>
        /// Occurs when the CornerRadius property changes.
        /// </summary>
        public event RoutedPropertyChangedEventHandler<string> CornerRadiusChanged
        {
            add { AddHandler(CornerRadiusChangedEvent, value); }
            remove { RemoveHandler(CornerRadiusChangedEvent, value); }
        }

        /// <summary>
        /// Raises the CornerRadiusChanged event.
        /// </summary>
        /// <param name="args">Arguments associated with the ValueChanged event.</param>
        protected virtual void OnCornerRadiusChanged(RoutedPropertyChangedEventArgs<string> args)
        {
            RaiseEvent(args);
        }
        public BotonOpcionAyuda()
        {  
            InitializeComponent();
            this.Cursor = System.Windows.Input.Cursors.Hand;           
        }
    }
}
