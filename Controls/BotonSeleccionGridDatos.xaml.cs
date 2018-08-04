using System.Windows;
using System.Windows.Controls;

namespace Agenda.Controles
{
    /// <summary>
    /// Interaction logic for BarraTitulo.xaml
    /// </summary>
    public partial class BotonSeleccionGridDatos : UserControl
    {

        private bool _selected;

        public bool Selected
        {
            get { return _selected; }
            set 
            { 
                _selected = value;
                if (_selected)
                {
                    CapaSimbolo.Visibility = System.Windows.Visibility.Visible;
                }
                else
                {
                    CapaSimbolo.Visibility = System.Windows.Visibility.Hidden;
                }               
            }
        }
        void onClick(object sender, RoutedEventArgs e)
        {
            Selected = !Selected;
            if (this.OnSelectedChanged != null)
            {
                this.OnSelectedChanged(this, e);
            }
        }
        public event RoutedEventHandler OnSelectedChanged;
        public string Titulo
        {
            get { return (string)GetValue(TituloProperty); }
            set 
            { 
                    SetValue(TituloProperty, value);
                    TituloBoton.Text = ((string)value);
            }
        }

        /// <summary>
        /// Identifies the Titulo dependency property.
        /// </summary>
        public static readonly DependencyProperty TituloProperty =
            DependencyProperty.Register(
            "Titulo", typeof(string), typeof(BotonSeleccionGridDatos),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnTituloChanged)));

        private static void OnTituloChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            BotonSeleccionGridDatos control = (BotonSeleccionGridDatos)obj;
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
            typeof(RoutedPropertyChangedEventHandler<string>), typeof(BotonSeleccionGridDatos));

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

        public BotonSeleccionGridDatos()
        {  
            InitializeComponent();           
            this.Selected = false;
        }
      
    }
}
