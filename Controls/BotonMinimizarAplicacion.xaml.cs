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
    /// Interaction logic for BotonCerrarAplicacion.xaml
    /// </summary>
    public partial class BotonMinimizarAplicacion : UserControl
    {
        public event RoutedEventHandler ClickMinimizar;

        void onClickMinimizar(object sender, RoutedEventArgs e)
        {
            if (this.ClickMinimizar != null)
                this.ClickMinimizar(this, e);
        }
        public BotonMinimizarAplicacion()
        {
            InitializeComponent();         
        }
    }
}
