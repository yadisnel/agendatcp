using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Agenda.ModeloDatos.Configuracion;
using Agenda.ModeloDatos.Dao;
using Agenda.ModuloDialogos.Dialogos;
using Agenda.ModeloDatos.Entidades;
using Agenda.ModuloExc.Excepciones;
using Agenda.ModeloDatos.Consultas;

namespace Agenda.Vistas.ModuloRegistroIngresos
{
    /// <summary>
    /// Interaction logic for PaginaReproductor.xaml
    /// </summary>
    public partial class PaginaPrincipalRegistroIngresos
    {  
        //public Page PaginaInicio { get; set; }     
        //private readonly ListadoConceptosIngresos _conceptos = new ListadoConceptosIngresos();
        public PaginaPrincipalRegistroIngresos()
        {
            InitializeComponent();
            //ComboBoxConceptosIngresos.SelectionChanged += ComboBoxConceptosIngresos_SelectionChanged; 
            //_conceptos.RecargarElementos();
            //ComboBoxConceptosIngresos.DataContext = _conceptos;
            //ComboBoxConceptosIngresos.ItemsSource = _conceptos;
            //if (ComboBoxConceptosIngresos.Items.Count > 0) ComboBoxConceptosIngresos.SelectedIndex = 0;
        }

        //void ComboBoxConceptosIngresos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (ComboBoxConceptosIngresos.SelectedIndex == -1)
        //    {
        //        return;
        //    }
        //    var miEntidadCi = ComboBoxConceptosIngresos.SelectedItem as EntidadConceptoIngreso;
        //    if (miEntidadCi.Nombre.Equals("Ventas de productos o servicios"))
        //    {
        //        PaginaRegistroVentas prv = new PaginaRegistroVentas((EntidadConceptoIngreso)ComboBoxConceptosIngresos.SelectedItem);                
        //        CapaTrabajo.Navigate(prv);
        //    }
        //}
    }
}
