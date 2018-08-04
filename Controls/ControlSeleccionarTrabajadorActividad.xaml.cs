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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Agenda.Controles
{
    /// <summary>
    /// Interaction logic for BotonCerrarAplicacion.xaml
    /// </summary>
    public partial class ControlSeleccionarTrabajadorActividad : UserControl
    {
        public ControlSeleccionarTrabajadorActividad()
        {
            InitializeComponent();
            this.ComboBoxNombreTrabajador.TextoNoSeleccionado = "Primero seleccione el trabajador por cuenta propia.";
            this.ComboBoxNombreActividad.TextoNoSeleccionado = "Luego seleccione una actividad con la cual trabajar.";
            this.ComboBoxNombreNuevaActividad.TextoNoSeleccionado = "Click aquí para seleccionar una nueva actividad.";
            this.ComboBoxNombreTrabajador.SelectedIndex = -1;
            this.ComboBoxNombreActividad.SelectedIndex = -1;           
            this.PestanaNuevaActividad.Click += BotonNuevaActividad_Click;
            this.PestanaNuevoTrabajador.Click += BotonNuevoTrabajador_Click;
            this.PestanaNuevaActividad.Visibility = System.Windows.Visibility.Collapsed;
            this.ComboBoxNombreTrabajador.SelectionChanged += ComboBoxNombreTrabajador_SelectionChanged;
        }

        void ComboBoxNombreTrabajador_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxNombreTrabajador.SelectedIndex != -1)
            {
                this.PestanaNuevaActividad.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                this.PestanaNuevaActividad.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        void BotonNuevoTrabajador_Click(object sender, RoutedEventArgs e)
        {
            if (GridContenedorComponentesNuevoTrabajador.Visibility == System.Windows.Visibility.Visible)
            {
                GridContenedorComponentesNuevoTrabajador.Visibility = System.Windows.Visibility.Collapsed;
                BordeFondoBotonNuevoTrabajador.Visibility = System.Windows.Visibility.Collapsed;
                BordeFondoBotonBotonNuevaActividad.Visibility = System.Windows.Visibility.Collapsed;
            }
            else
            {
                GridContenedorComponentesNuevoTrabajador.Visibility = System.Windows.Visibility.Visible;
                GridContenedorComponentesNuevaActividad.Visibility = System.Windows.Visibility.Collapsed;
                BordeFondoBotonBotonNuevaActividad.Visibility = System.Windows.Visibility.Collapsed;
                BordeFondoBotonNuevoTrabajador.Visibility = System.Windows.Visibility.Visible;
            }
        }

        void BotonNuevaActividad_Click(object sender, RoutedEventArgs e)
        {
            if (GridContenedorComponentesNuevaActividad.Visibility == System.Windows.Visibility.Visible)
            {
                GridContenedorComponentesNuevaActividad.Visibility = System.Windows.Visibility.Collapsed;
                BordeFondoBotonNuevoTrabajador.Visibility = System.Windows.Visibility.Collapsed;
                BordeFondoBotonBotonNuevaActividad.Visibility = System.Windows.Visibility.Collapsed;
            }
            else
            {
                GridContenedorComponentesNuevaActividad.Visibility = System.Windows.Visibility.Visible;
                GridContenedorComponentesNuevoTrabajador.Visibility = System.Windows.Visibility.Collapsed;
                BordeFondoBotonBotonNuevaActividad.Visibility = System.Windows.Visibility.Visible;
                BordeFondoBotonNuevoTrabajador.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        public ComboBoxSimple ControlComboBoxNombreTrabajador
        {
            get { return this.ComboBoxNombreTrabajador; }
        }

        public ComboBoxSimple ControlComboBoxNombreActividad
        {
            get { return this.ComboBoxNombreActividad; }
        }
        public ComboBoxSimple ControlComboBoxNombreNuevaActividad
        {
            get { return this.ComboBoxNombreNuevaActividad; }
        }
        public BotonSimpleFondoAnimado ControlPestañaNuevoTrabajador
        {
            get { return this.PestanaNuevoTrabajador; }
        }
        public BotonSimpleFondoAnimado ControlPestañaNuevaActividad
        {
            get { return this.PestanaNuevaActividad; }
        }

        public Button ControlAdicionarNuevoTrabajador
        {
            get { return this.BotonAdicionarNuevoTrabajador; }
        }
        public Button ControlAdicionarNuevaActividad
        {
            get { return this.BotonAdicionarNuevaActividad; }
        }

        public TextBox ControlTextBoxNombreNuevoTrabajador
        {
            get { return this.TextBoxNombreNuevoTrabajador;}
        }
        public TextBox ControlTextBoxNumeroLicenciaNuevaActividad
        {
            get { return this.TextBoxNumeroLicenciaNuevaActividad; }
        }
        public TextBox ControlTextBoxNitNuevoTrabajador
        {
            get { return this.TextBoxNitNuevoTrabajador; }
        }

        public void SeleccionarPestañaNuevoTrabajador()
        {
            GridContenedorComponentesNuevoTrabajador.Visibility = System.Windows.Visibility.Visible;
            GridContenedorComponentesNuevaActividad.Visibility = System.Windows.Visibility.Collapsed;
            BordeFondoBotonBotonNuevaActividad.Visibility = System.Windows.Visibility.Collapsed;
            BordeFondoBotonNuevoTrabajador.Visibility = System.Windows.Visibility.Visible;
        }
        public void SeleccionarPestañaNuevaActividad()
        {
            GridContenedorComponentesNuevaActividad.Visibility = System.Windows.Visibility.Visible;
            GridContenedorComponentesNuevoTrabajador.Visibility = System.Windows.Visibility.Collapsed;
            BordeFondoBotonBotonNuevaActividad.Visibility = System.Windows.Visibility.Visible;
            BordeFondoBotonNuevoTrabajador.Visibility = System.Windows.Visibility.Collapsed;
        }
    }
}
