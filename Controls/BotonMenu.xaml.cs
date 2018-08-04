using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Agenda.Controles
{
    /// <summary>
    /// Interaction logic for BarraTitulo.xaml
    /// </summary>
    public partial class BotonMenu : UserControl
    {
        public event RoutedEventHandler Click;

        void onClick(object sender, RoutedEventArgs e)
        {           
            if (this.Click != null && !EstaSeleccionado)
            {
                this.Click(this, e);
            }                
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
            "Titulo", typeof(string), typeof(BotonMenu),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnTituloChanged)));

        private static void OnTituloChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            BotonMenu control = (BotonMenu)obj;
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
            typeof(RoutedPropertyChangedEventHandler<string>), typeof(BotonMenu));

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

        private bool _estaSeleccionado;
        private string _idElemento;

        public bool EstaSeleccionado
        {
            get { return _estaSeleccionado; }
            set 
            {
                _estaSeleccionado = value;
                if (_estaSeleccionado)
                {                   
                    this.Cursor = System.Windows.Input.Cursors.Arrow;
                    System.Windows.Media.Brush color = (System.Windows.Media.Brush)this.FindResource("PrimaryHueMidBrush");
                    TituloBoton.Foreground = color;

                }
                else
                {                  
                    this.Cursor = System.Windows.Input.Cursors.Hand;
                    TituloBoton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#555"));
                }
            }
        }

        public string IdElemento
        {
            get
            {
                return _idElemento;
            }

            set
            {
                _idElemento = value;
            }
        }

        public BotonMenu()
        {  
            InitializeComponent();
            this.EstaSeleccionado = false;
            this.MouseLeave += BotonMenu_MouseLeave;
            this.MouseEnter += BotonMenu_MouseEnter;         
        }

        private void BotonMenu_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //new SolidColorBrush( (Color)ColorConverter.ConvertFromString("#FFDFD991"));
            System.Windows.Media.Brush color = (System.Windows.Media.Brush)this.FindResource("PrimaryHueMidBrush");
            TituloBoton.Foreground = color;
        }

        private void BotonMenu_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (!this.EstaSeleccionado)
            {
                TituloBoton.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#555"));
            }
            else
            {
                System.Windows.Media.Brush color = (System.Windows.Media.Brush)this.FindResource("PrimaryHueMidBrush");
                TituloBoton.Foreground = color;
            }
        }
    }
}
