using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Agenda.Controles
{
     public partial class BotonMaximizarAplicacion : UserControl, INotifyPropertyChanged
    {
        public event RoutedEventHandler ClickMaximizar;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

         public bool EsMaximimizar
        {
            get { return (bool)GetValue(EsMaximimizarProperty); }
            set
            {
                SetValue(EsMaximimizarProperty, value);
                OnPropertyChanged("EsMaximimizar");
            }
        }

        /// <summary>
        /// Identifies the Titulo dependency property.
        /// </summary>
        public static readonly DependencyProperty EsMaximimizarProperty =
            DependencyProperty.Register(
            "EsMaximimizar", typeof(bool), typeof(BotonMaximizarAplicacion),
            new FrameworkPropertyMetadata(true, new PropertyChangedCallback(OnEsMaximimizarChanged)));

        private static void OnEsMaximimizarChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            BotonMaximizarAplicacion control = (BotonMaximizarAplicacion)obj;
            if (control.EsMaximimizar)
            {
                control.MiBotonMaximizarAplicacion.Tag = "Maximizado";
            }
            else
            {
                control.MiBotonMaximizarAplicacion.Tag = "Minimizado";
            }
            
            RoutedPropertyChangedEventArgs<bool> e = new RoutedPropertyChangedEventArgs<bool>(
                (bool)args.OldValue, (bool)args.NewValue, EsMaximimizarChangedEvent);
            control.OnEsMaximimizarChanged(e);
        }

        /// <summary>
        /// Identifies the TituloChanged routed event.
        /// </summary>
        public static readonly RoutedEvent EsMaximimizarChangedEvent = EventManager.RegisterRoutedEvent(
            "EsMaximimizarChanged", RoutingStrategy.Bubble,
            typeof(RoutedPropertyChangedEventHandler<bool>), typeof(BotonMaximizarAplicacion));

        /// <summary>
        /// Occurs when the EsMaximimizar property changes.
        /// </summary>
        public event RoutedPropertyChangedEventHandler<bool> EsMaximimizarChanged
        {
            add { AddHandler(EsMaximimizarChangedEvent, value); }
            remove { RemoveHandler(EsMaximimizarChangedEvent, value); }
        }

        protected virtual void OnEsMaximimizarChanged(RoutedPropertyChangedEventArgs<bool> args)
        {
            RaiseEvent(args);
        }

        void onClickMaximizar(object sender, RoutedEventArgs e)
        {
            EsMaximimizar = !EsMaximimizar;            
            if (this.ClickMaximizar != null)
            {
                this.ClickMaximizar(this, e);
            }                
        }
        public BotonMaximizarAplicacion()
        {
            InitializeComponent();
            EsMaximimizar = true;
        }
    }
}
