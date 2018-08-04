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
    public partial class BotonSeleccionarTrabajadorActividad : UserControl
    {
        public event RoutedEventHandler Click;

        private string _texto;
        public string Texto
        {
            get { return _texto; }
            set 
            { 
                _texto = value;
                MiBotonSeleccion.Content = _texto;
            }
        }

        void onClick(object sender, RoutedEventArgs e)
        {
            if (Click != null)
            {
                Click(sender, e);
            }
        }
        public BotonSeleccionarTrabajadorActividad()
        {
            InitializeComponent();           
        }
    }
}
