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
    public partial class BotonSeleccionarFechaContable : UserControl
    {
        public event EventHandler<SelectionChangedEventArgs> SelectedDateChanged;
        public DateTime? Fecha;
        private string[] Dias = {"Domingo", "Lunes", "Martes","Miércoles","Jueves","Viernes","Sábado"};
        private string[] Meses = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        public BotonSeleccionarFechaContable()
        {  
            InitializeComponent();            
            Calendario.DisplayDateEnd = System.DateTime.Now;
            DateTime? FechaInicio = new DateTime(1990,1,1);
            Calendario.DisplayDateStart = FechaInicio;
            Calendario.SelectedDateChanged += Calendario_SelectedDateChanged;
            Calendario.SelectedDate = System.DateTime.Now;
        }

        private void Calendario_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Fecha = Calendario.SelectedDate;
            BotonSeleccion.Content = Dias[(int)Fecha.Value.DayOfWeek];
            BotonSeleccion.Content += " ";
            if (Fecha.Value.Day == 1)
            {
                BotonSeleccion.Content += "1ro de ";
            }
            else
            {
                BotonSeleccion.Content += Fecha.Value.Day.ToString();
                BotonSeleccion.Content += " de ";
            }

            BotonSeleccion.Content += Meses[Fecha.Value.Month - 1];
            BotonSeleccion.Content += " de ";
            BotonSeleccion.Content += Fecha.Value.Year.ToString();
            
            if (this.SelectedDateChanged != null)
            {
                this.SelectedDateChanged(this, e);
            }    
        }

        private void BotonSeleccion_Click(object sender, RoutedEventArgs e)
        {
            Calendario.IsDropDownOpen = true;
        }

        private void TextBlockFechaVisible_MouseEnter(object sender, MouseEventArgs e)
        {
           
        }
    }
}
