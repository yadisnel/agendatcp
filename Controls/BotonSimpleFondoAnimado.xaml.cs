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
    public partial class BotonSimpleFondoAnimado : UserControl
    {
        #region Icono Property
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
            "Icono", typeof(Image), typeof(BotonSimpleFondoAnimado),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnIconoChanged)));

        private static void OnIconoChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            BotonSimpleFondoAnimado control = (BotonSimpleFondoAnimado)obj;

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
            typeof(RoutedPropertyChangedEventHandler<Image>), typeof(BotonSimpleFondoAnimado));
     
        public event RoutedPropertyChangedEventHandler<Image> IconoChanged
        {
            add { AddHandler(IconoChangedEvent, value); }
            remove { RemoveHandler(IconoChangedEvent, value); }
        }       
        protected virtual void OnIconoChanged(RoutedPropertyChangedEventArgs<Image> args)
        {
            RaiseEvent(args);          
        }
        public event RoutedEventHandler Click;  
        void onClick(object sender, RoutedEventArgs e)
        {
            if (Click != null)
            {
                Click(sender, e);
            }
        }
        #endregion 
        #region Foreground Property
        public new Brush Foreground
        {
            get { return (Brush)GetValue(ForegroundProperty); }
            set
            {
                SetValue(ForegroundProperty, value);
                TextoSeleccionado.Foreground = (Brush)value;              
            }
        }
        public new static readonly DependencyProperty ForegroundProperty =
            DependencyProperty.Register(
            "Foreground", typeof(Brush), typeof(BotonSimpleFondoAnimado),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnForegroundChanged)));

        private static void OnForegroundChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            BotonSimpleFondoAnimado control = (BotonSimpleFondoAnimado)obj;
            control.TextoSeleccionado.Foreground = (Brush)args.NewValue;
            RoutedPropertyChangedEventArgs<Brush> e = new RoutedPropertyChangedEventArgs<Brush>(
                (Brush)args.OldValue, (Brush)args.NewValue, ForegroundChangedEvent);
            control.OnForegroundChanged(e);
        }
        public static readonly RoutedEvent ForegroundChangedEvent = EventManager.RegisterRoutedEvent(
            "ForegroundChanged", RoutingStrategy.Bubble,
            typeof(RoutedPropertyChangedEventHandler<Brush>), typeof(BotonSimpleFondoAnimado));

        public event RoutedPropertyChangedEventHandler<Brush> ForegroundChanged
        {
            add { AddHandler(ForegroundChangedEvent, value); }
            remove { RemoveHandler(ForegroundChangedEvent, value); }
        }
        protected virtual void OnForegroundChanged(RoutedPropertyChangedEventArgs<Brush> args)
        {
            RaiseEvent(args);
        }
        #endregion
        #region Animated Background Property
        public Brush AnimatedForeground
        {
            get { return (Brush)GetValue(AnimatedForegroundProperty); }
            set
            {
                SetValue(AnimatedForegroundProperty, value);                
            }
        }
        public static readonly DependencyProperty AnimatedForegroundProperty =
            DependencyProperty.Register(
            "AnimatedForeground", typeof(Brush), typeof(BotonSimpleFondoAnimado),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnAnimatedForegroundChanged)));

        private static void OnAnimatedForegroundChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            BotonSimpleFondoAnimado control = (BotonSimpleFondoAnimado)obj;           
            RoutedPropertyChangedEventArgs<Brush> e = new RoutedPropertyChangedEventArgs<Brush>(
                (Brush)args.OldValue, (Brush)args.NewValue, AnimatedForegroundChangedEvent);
            control.OnAnimatedForegroundChanged(e);
        }
        public static readonly RoutedEvent AnimatedForegroundChangedEvent = EventManager.RegisterRoutedEvent(
            "AnimatedForegroundChanged", RoutingStrategy.Bubble,
            typeof(RoutedPropertyChangedEventHandler<Brush>), typeof(BotonSimpleFondoAnimado));

        public event RoutedPropertyChangedEventHandler<Brush> AnimatedForegroundChanged
        {
            add { AddHandler(AnimatedForegroundChangedEvent, value); }
            remove { RemoveHandler(AnimatedForegroundChangedEvent, value); }
        }
        protected virtual void OnAnimatedForegroundChanged(RoutedPropertyChangedEventArgs<Brush> args)
        {
            RaiseEvent(args);
        }
        #endregion
        #region Text Property
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set
            {
                SetValue(TextProperty, value);
                TextoSeleccionado.Text = (string)value;
            }
        }
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(
            "Text", typeof(string), typeof(BotonSimpleFondoAnimado),
            new FrameworkPropertyMetadata(null, new PropertyChangedCallback(OnTextChanged)));

        private static void OnTextChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            BotonSimpleFondoAnimado control = (BotonSimpleFondoAnimado)obj;
            control.TextoSeleccionado.Text = (string)args.NewValue;
            RoutedPropertyChangedEventArgs<string> e = new RoutedPropertyChangedEventArgs<string>(
                (string)args.OldValue, (string)args.NewValue, TextChangedEvent);
            control.OnTextChanged(e);
        }
        public static readonly RoutedEvent TextChangedEvent = EventManager.RegisterRoutedEvent(
            "TextChanged", RoutingStrategy.Bubble,
            typeof(RoutedPropertyChangedEventHandler<string>), typeof(BotonSimpleFondoAnimado));

        public event RoutedPropertyChangedEventHandler<string> TextChanged
        {
            add { AddHandler(AnimatedForegroundChangedEvent, value); }
            remove { RemoveHandler(AnimatedForegroundChangedEvent, value); }
        }
        protected virtual void OnTextChanged(RoutedPropertyChangedEventArgs<string> args)
        {
            RaiseEvent(args);
        }
        #endregion
        public BotonSimpleFondoAnimado()
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
            MiBotonSeleccion.MouseEnter +=MiBotonSeleccion_MouseEnter;
            MiBotonSeleccion.MouseLeave += MiBotonSeleccion_MouseLeave;
        }
        void MiBotonSeleccion_MouseLeave(object sender, MouseEventArgs e)
        {
            this.TextoSeleccionado.Foreground = this.Foreground;
            this.IconoTriangulo.Stroke = this.Foreground;
            this.IconoTriangulo.Fill = this.Foreground;
        }
        private void MiBotonSeleccion_MouseEnter(object sender, MouseEventArgs e)
        {
            this.TextoSeleccionado.Foreground = this.AnimatedForeground;
            this.IconoTriangulo.Stroke = this.AnimatedForeground;
            this.IconoTriangulo.Fill = this.AnimatedForeground;
        }  
    }
}
