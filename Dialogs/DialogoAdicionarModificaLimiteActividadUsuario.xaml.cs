using Agenda.ModeloDatos.Entidades;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Linq;
using Agenda.ModeloDatos.Consultas;
using Agenda.ModeloDatos.Dao;
using Agenda.ModeloDatos.Configuracion;
using System.Windows.Data;
using System;

namespace Agenda.ModuloDialogos.Dialogos
{
    public partial class DialogoAdicionarModificaLimiteActividadUsuario
    {        
        //public double GastoMaximo { get; private set; }
        //public double CuotaMensualMinima { get; private set; }      
        //public EntidadLineaTiempo LineaTiempoSeleccionada {get;private set;}       
        //private ListadoLineaTiempo _tiempos = new ListadoLineaTiempo();
        //public ListCollectionView VistaColeccionLineaTiempo;
        //ListadoProvincias Provincias = new ListadoProvincias();
        //ListadoMunicipios Municipios = new ListadoMunicipios();
        //private bool EsOperacionModificar = false;

        public DialogoAdicionarModificaLimiteActividadUsuario()
        {
            InitializeComponent();
            //ControlBarraTitulo.ClickCerrar += ControlBarraTituloBotonCerrar_Click;
            //ControlBarraTitulo.ClickMinimizar += ControlBarraTituloBotonMinimizarVentana_Click;
            //ControlBarraTitulo.MouseLeftButtonDown += ControlBarraTitulo_MouseLeftButtonDown;
            //ControlBarraTitulo.OcultarBotonMaximizar = true;
            //BotonAceptar.Click += BotonAceptar_Click;            
            //this.Title = ControlBarraTitulo.Titulo;
            //DateTime? FechaAhora =  System.DateTime.Now; 
            //_tiempos.RecargarTodosLosTiemposHastaMesAño(FechaAhora.Value.Month,FechaAhora.Value.Year);
            //ComboBoxEnInstanteLineaTiempo.SelectedIndex = _tiempos.Count-1;
            //this.ComboBoxEnInstanteLineaTiempo.ItemsSource = _tiempos;
            //VistaColeccionLineaTiempo = (ListCollectionView)CollectionViewSource.GetDefaultView(_tiempos);
            //Provincias.RecargarElementos();            
            //ComboBoxProvincias.SelectionChanged += ComboBoxProvincias_SelectionChanged;
            //ComboBoxProvincias.ItemsSource = Provincias;
            //if (Provincias.Count > 0) ComboBoxProvincias.SelectedIndex = 0;
        }

        //void ComboBoxProvincias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if(ComboBoxProvincias.SelectedIndex != -1)
        //    {
        //        Municipios.RecargarElementos( (ComboBoxProvincias.SelectedItem as EntidadProvincia).CodigoProvincia);
        //        ComboBoxMunicipios.ItemsSource = Municipios;
        //    }            
        //}

        //public void ConfigurarDialogo(bool esOperacionModificar,double cuotaMensual,double gastoMaximo,int codigoLineaTiempo)
        //{
        //    this.EsOperacionModificar = esOperacionModificar;
        //    if (esOperacionModificar)
        //    {
        //        this.Title = "Modificar las cuotas mensuales de la actividad";                
        //        this.BotonAceptar.Content = "Modificar";
        //        int Indice = -1;
        //        for (int i = 0; i < VistaColeccionLineaTiempo.Count; i++)
        //        {
        //            Indice++;
        //            EntidadLineaTiempo Item = VistaColeccionLineaTiempo.GetItemAt(i) as EntidadLineaTiempo;
        //            if (Item.CodigoLineaTiempo == codigoLineaTiempo)
        //            {
        //                ComboBoxEnInstanteLineaTiempo.SelectedIndex = Indice;
        //            }
        //        }
        //        this.TextBoxGastoMaximo.Text = cuotaMensual.ToString();
        //        this.TextBoxCuotaMensualMinima.Text = cuotaMensual.ToString();
        //    }
        //    else
        //    {
        //        this.Title = "Establecer las cuotas mensuales de la actividad";
        //        this.BotonAceptar.Content = "Establecer";                
        //    }            
        //    this.ControlBarraTitulo.Titulo = this.Title;
        //    this.TextBoxNombrePatente.Text = ConfiguracionSistema.GetConfig().LicenciaEnUso.Nombre;       
        //}
        
        //void BotonAceptar_Click(object sender, RoutedEventArgs e)
        //{
        //    if (ComboBoxEnInstanteLineaTiempo.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Debe seleccionar un mes y año para poder continuar.", "Error en la entrada de datos", MessageBoxButton.OK);
        //        return;
        //    }          
        //    LineaTiempoSeleccionada = ComboBoxEnInstanteLineaTiempo.SelectedItem as EntidadLineaTiempo;

        //    if (!EsOperacionModificar)
        //    {
        //        if (new DaoLimiteActividad().ExisteLimiteActividadMesLineaTiempo(ConfiguracionSistema.GetConfig().LicenciaEnUso, LineaTiempoSeleccionada))
        //        {
        //            MessageBox.Show("En el sistema ya existe una cuota mensual registrada para la actividad. Si desea cambiar los datos registrados para dicha cuota, utilice la opción Modidificar.", "Error en la entrada de datos", MessageBoxButton.OK);
        //            return;
        //        }
        //    }
          
        //    double valueCuotaMensualMinima;
        //    if (!double.TryParse(TextBoxCuotaMensualMinima.Text, out valueCuotaMensualMinima))
        //    {
        //        MessageBox.Show("Debe proporcionar un valor de cuota mensual mínima válido para poder continuar.", "Error en la entrada de datos", MessageBoxButton.OK);
        //        return;
        //    }
        //    this.CuotaMensualMinima = valueCuotaMensualMinima;
        //    double valueGastoMaximo;
        //    if (!double.TryParse(TextBoxGastoMaximo.Text, out valueGastoMaximo))
        //    {
        //        MessageBox.Show("Debe proporcionar un valor de gasto máximo válido para poder continuar.", "Error en la entrada de datos", MessageBoxButton.OK);
        //        return;
        //    }
        //    this.GastoMaximo = valueGastoMaximo;

        //    if (this.CuotaMensualMinima <= 0)
        //    {
        //        MessageBox.Show("Debe proporcionar un valor de cuota mensual mínima válido para poder continuar.", "Error en la entrada de datos", MessageBoxButton.OK);
        //        return;
        //    }
        //    if (this.GastoMaximo <= 0)
        //    {
        //        MessageBox.Show("Debe proporcionar un valor de  de gasto máximo válido para poder continuar.", "Error en la entrada de datos", MessageBoxButton.OK);
        //        return;
        //    }          
        //    DialogResult = true;           
        //}

        //void ControlBarraTitulo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    DragMove();
        //}

        //void ControlBarraTituloBotonCerrar_Click(object sender, RoutedEventArgs e)
        //{
        //    DialogResult = false;
        //}

        //void ControlBarraTituloBotonMinimizarVentana_Click(object sender, RoutedEventArgs e)
        //{
        //    WindowState = WindowState.Minimized;
        //}

        //private void Titulo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    DragMove();
        //}       
    }
}
