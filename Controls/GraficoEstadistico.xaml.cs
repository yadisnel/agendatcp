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
    public partial class GraficoEstadistico : UserControl
    {
        private string _ambito;

        public string Ambito
        {
            get { return _ambito; }
            private set { _ambito = value; }
        }
        public event RoutedEventHandler ClickAdelante;
        void onClickAdelante(object sender, RoutedEventArgs e)
        {
            if ((string)labelModoGrafico.Content == "100% Histórico")
            {
                labelModoGrafico.Content = "Último año";
            }
            else if ((string)labelModoGrafico.Content == "Último año")
            {
                labelModoGrafico.Content = "Últimos 6 meses";
            }
            else if ((string)labelModoGrafico.Content == "Últimos 6 meses")
            {
                labelModoGrafico.Content = "Últimos 3 meses";
            }
            else if ((string)labelModoGrafico.Content == "Últimos 3 meses")
            {
                labelModoGrafico.Content = "Último mes";
            }
            else if ((string)labelModoGrafico.Content == "Último mes")
            {
                labelModoGrafico.Content = "Últimos 7 días";
            }
            else if ((string)labelModoGrafico.Content == "Últimos 7 días")
            {
                labelModoGrafico.Content = "Hoy";
            }
            else if ((string)labelModoGrafico.Content == "Hoy")
            {
                labelModoGrafico.Content = "100% Histórico";
            }
            Ambito = (string)labelModoGrafico.Content;
            if (this.ClickAdelante != null)
            {                
                this.ClickAdelante(this, e);
            }

        }

        public event RoutedEventHandler ClickAtras;
        void onClickAtras(object sender, RoutedEventArgs e)
        {
            if ((string)labelModoGrafico.Content == "100% Histórico")
            {
                labelModoGrafico.Content = "Hoy";
            }
            else if ((string)labelModoGrafico.Content == "Hoy")
            {
                labelModoGrafico.Content = "Últimos 7 días";
            }
            else if ((string)labelModoGrafico.Content == "Últimos 7 días")
            {
                labelModoGrafico.Content = "Último mes";
            }
            else if ((string)labelModoGrafico.Content == "Último mes")
            {
                labelModoGrafico.Content = "Últimos 3 meses";
            }
            else if ((string)labelModoGrafico.Content == "Últimos 3 meses")
            {
                labelModoGrafico.Content = "Últimos 6 meses";
            }
            else if ((string)labelModoGrafico.Content == "Últimos 6 meses")
            {
                labelModoGrafico.Content = "Último año";
            }
            else if ((string)labelModoGrafico.Content == "Último año")
            {
                labelModoGrafico.Content = "100% Histórico";
            }
            Ambito = (string)labelModoGrafico.Content;
            if (this.ClickAtras != null)
            {
                this.ClickAtras(this, e);
            }
        }

        public GraficoEstadistico()
        {  
            InitializeComponent();
            ControlBarraTitulo.OcultarBotonCerrar = true;
            ControlBarraTitulo.OcultarBotonMaximizar = true;
            ControlBarraTitulo.OcultarBotonMinimizar = true;
            BotonGraficoEstadisticoAdelante.Click += onClickAdelante;
            BotonGraficoEstadisticoAtras.Click += onClickAtras;
        }

    }
}
