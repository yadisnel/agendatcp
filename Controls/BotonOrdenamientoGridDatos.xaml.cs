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
    public partial class BotonOrdenamientoGridDatos : UserControl
    {

        private bool _esSeleccionado;

        public bool EsSeleccionado
        {
            get { return _esSeleccionado; }
            set { 
                    _esSeleccionado = value;
                    if (_esSeleccionado)
                    {
                        if (EsAscendente)
                        {
                            CapaSimboloAscendente.Visibility = System.Windows.Visibility.Visible;
                            CapaSimboloDescendente.Visibility = System.Windows.Visibility.Hidden;
                        }
                        else
                        {
                            CapaSimboloAscendente.Visibility = System.Windows.Visibility.Hidden;
                            CapaSimboloDescendente.Visibility = System.Windows.Visibility.Visible;
                        }
                    }
                    else
                    {
                        CapaSimboloAscendente.Visibility = System.Windows.Visibility.Hidden;
                        CapaSimboloDescendente.Visibility = System.Windows.Visibility.Hidden;
                    }
                }
        }

        public event RoutedEventHandler Click;

        void onClick(object sender, RoutedEventArgs e)
        {
            EsSeleccionado = true;           
            if (this.Click != null)
            {               
                this.Click(this, e);
            }                
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
            "Titulo", typeof(string), typeof(BotonOrdenamientoGridDatos),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnTituloChanged)));

        private static void OnTituloChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            BotonOrdenamientoGridDatos control = (BotonOrdenamientoGridDatos)obj;
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
            typeof(RoutedPropertyChangedEventHandler<string>), typeof(BotonOrdenamientoGridDatos));

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

        private bool _esAscendente;

        public bool EsAscendente
        {
            get { return _esAscendente; }
            set 
            {
                _esAscendente = value;
                if ((bool)value)
                {
                    this.CapaSimboloAscendente.Visibility = System.Windows.Visibility.Visible;
                    this.CapaSimboloDescendente.Visibility = System.Windows.Visibility.Hidden;
                }
                else
                {
                    this.CapaSimboloAscendente.Visibility = System.Windows.Visibility.Hidden;
                    this.CapaSimboloDescendente.Visibility = System.Windows.Visibility.Visible;
                }
            }
        }
        public BotonOrdenamientoGridDatos()
        {  
            InitializeComponent();
            this.EsAscendente = true;
            this.CapaSimboloAscendente.Visibility = System.Windows.Visibility.Visible;
            this.CapaSimboloDescendente.Visibility = System.Windows.Visibility.Hidden;                    
        }
    }
}
