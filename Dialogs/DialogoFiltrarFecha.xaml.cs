using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System;

using Agenda.ModuloExc.Excepciones;
using Agenda.ModeloDatos.Seguridad;
using Agenda.ModeloDatos.Configuracion;
using Agenda.ModeloDatos.Dao;
using Agenda.ModeloDatos.Entidades;
using Agenda.ModeloDatos.Validaciones;

namespace Agenda.ModuloDialogos.Dialogos
{
    public partial class DialogoFiltrarFecha
    {       
        //public bool EsSemana { get; private set; }
        //public bool EsDia { get; private set; }
        //public bool EsMes { get; private set; }
        //public bool EsPeriodo { get; private set; }
        //public DateTime FechaPeriodoDesde
        //{
        //    get
        //    {
        //        return PeriodoDesde.Fecha.Value;
        //    }
        //}
        //public DateTime FechaPeriodoHasta
        //{
        //    get
        //    {
        //        return PeriodoHasta.Fecha.Value;
        //    }
        //}

        public DialogoFiltrarFecha()
        {
            InitializeComponent();

            //EsSemana = false;
            //EsDia = false;
            //EsMes = false;
            //EsPeriodo = false;

            //ControlBarraTitulo.ClickCerrar += BotonCerrar_Click;
            //ControlBarraTitulo.ClickMinimizar += BotonMinimizarVentana_Click;
            //ControlBarraTitulo.OcultarBotonMaximizar = true;
            //ControlBarraTitulo.MouseLeftButtonDown += ControlBarraTitulo_MouseLeftButtonDown;
            //BotonAceptar.Click += BotonAceptar_Click;    
        
            //CheckBoxVentasEnDiaFechaContable.Checked +=new RoutedEventHandler(CheckBoxVentasEnDiaFechaContable_Checked);
            //CheckBoxVentasEnSemanaContable.Checked +=new RoutedEventHandler(CheckBoxVentasEnSemanaContable_Checked);
            //CheckBoxVentasEnMesContable.Checked += new RoutedEventHandler(CheckBoxVentasEnMesContable_Checked);
            //CheckBoxVentasEnPeriodo.Checked += new RoutedEventHandler(CheckBoxVentasEnPeriodo_Checked);

            //PeriodoDesde.IsEnabled = false;
            //PeriodoHasta.IsEnabled = false;
        }

        //void CheckBoxVentasEnPeriodo_Checked(object sender, RoutedEventArgs e)
        //{
        //    CheckBoxVentasEnDiaFechaContable.IsChecked = false;
        //    CheckBoxVentasEnSemanaContable.IsChecked = false;
        //    CheckBoxVentasEnMesContable.IsChecked = false;
        //    EsSemana = false;
        //    EsDia = false;
        //    EsMes = false;
        //    EsPeriodo = true;
        //    PeriodoDesde.IsEnabled = true;
        //    PeriodoHasta.IsEnabled = true;
        //}

        //void CheckBoxVentasEnMesContable_Checked(object sender, RoutedEventArgs e)
        //{
        //    CheckBoxVentasEnDiaFechaContable.IsChecked = false;
        //    CheckBoxVentasEnSemanaContable.IsChecked = false;
        //    CheckBoxVentasEnPeriodo.IsChecked = false;
        //    EsSemana = false;
        //    EsDia = false;
        //    EsMes = true;
        //    EsPeriodo = false;
        //    PeriodoDesde.IsEnabled = false;
        //    PeriodoHasta.IsEnabled = false;
        //}

        //void  CheckBoxVentasEnSemanaContable_Checked(object sender, RoutedEventArgs e)
        //{
        //    CheckBoxVentasEnDiaFechaContable.IsChecked = false;
        //    CheckBoxVentasEnMesContable.IsChecked = false;
        //    CheckBoxVentasEnPeriodo.IsChecked = false;
        //    EsSemana = true;
        //    EsDia = false;
        //    EsMes = false;
        //    EsPeriodo = false;
        //    PeriodoDesde.IsEnabled = false;
        //    PeriodoHasta.IsEnabled = false;
        //}

        //void  CheckBoxVentasEnDiaFechaContable_Checked(object sender, RoutedEventArgs e)
        //{
        //    EsSemana = false;
        //    EsDia = true;
        //    EsMes = false;
        //    EsPeriodo = false;
        //    CheckBoxVentasEnSemanaContable.IsChecked = false;
        //    CheckBoxVentasEnMesContable.IsChecked = false;
        //    CheckBoxVentasEnPeriodo.IsChecked = false;
        //    PeriodoDesde.IsEnabled = false;
        //    PeriodoHasta.IsEnabled = false;
        //}
        //void BotonAceptar_Click(object sender, RoutedEventArgs e)
        //{
        //    if (!EsSemana && !EsDia && !EsMes && !EsPeriodo)
        //    {
        //        MessageBox.Show("Usted no ha seleccionado un criterio de filtrado. Para filtrar las ventas, debe primeramente seleccionar un criterio.");
        //        return;
        //    }
        //    if (EsPeriodo)
        //    {
        //        DateTime FechaDesde = PeriodoDesde.Fecha.Value;
        //        DateTime FechaHasta = PeriodoHasta.Fecha.Value;
        //        if (FechaDesde > FechaHasta)
        //        {
        //            MessageBox.Show("Usted ha seleccionado un período como rango de filtrado, sin embargo la fecha inicial del período es mayor a la fecha final. Por favor seleccione un período correctamente para poder continuar.");
        //            return;
        //        }
        //    }
        //    DialogResult = true;
        //}

        //void ControlBarraTitulo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    DragMove();
        //}

        //void BotonCerrar_Click(object sender, RoutedEventArgs e)
        //{
        //    DialogResult = false;
        //}

        //void BotonMinimizarVentana_Click(object sender, RoutedEventArgs e)
        //{
        //    WindowState = WindowState.Minimized;
        //}

        //private void Titulo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    DragMove();
        //}
        //private static bool DialogoEsValido(DependencyObject node)
        //{
        //    // Check if dependency object was passed
        //    if (node != null)
        //    {
        //        // Check if dependency object is valid.
        //        // NOTE: Validation.GetHasError works for controls that have validation rules attached 

        //        var isValid = !Validation.GetHasError(node);
        //        if (!isValid)
        //        {
        //            // If the dependency object is invalid, and it can receive the focus,
        //            // set the focus
        //            var inputElement = node as IInputElement;
        //            if (inputElement != null) Keyboard.Focus(inputElement);
        //            return false;
        //        }
        //    }
        //    // If this dependency object is valid, check all child dependency objects
        //    return node == null || LogicalTreeHelper.GetChildren(node).OfType<DependencyObject>().All(DialogoEsValido);
        //    // All dependency objects are valid
        //}
    }
}
