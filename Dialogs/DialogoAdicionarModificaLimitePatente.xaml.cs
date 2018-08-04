using Agenda.ModeloDatos.Entidades;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Linq;
using Agenda.ModeloDatos.Consultas;

namespace Agenda.ModuloDialogos.Dialogos
{
    public partial class DialogoAdicionarModificaLimitePatente
    {
        //public EntidadActividad Actividad { get; set; }
        //public EntidadProvincia ProvinciaSeleccionada { get; set;}
        //public EntidadMunicipio MunicipioSeleccionado { get; set; }       
        //public double GastoMaximo { get; private set; }
        //public double CuotaMensualMinima { get; private set; }       
        //public EntidadLineaTiempo LineaTiempoSeleccionada {get;private set;}
        //private ListadoProvincias _provincias = new ListadoProvincias();
        //private ListadoMunicipios _municipios = new ListadoMunicipios();
        //private ListadoLineaTiempo _tiempos = new ListadoLineaTiempo();

        public DialogoAdicionarModificaLimitePatente()
        {
            InitializeComponent();
            //ControlBarraTitulo.ClickCerrar += ControlBarraTituloBotonCerrar_Click;
            //ControlBarraTitulo.ClickMinimizar += ControlBarraTituloBotonMinimizarVentana_Click;
            //ControlBarraTitulo.MouseLeftButtonDown += ControlBarraTitulo_MouseLeftButtonDown;
            //ControlBarraTitulo.OcultarBotonMaximizar = true;
            //BotonAceptar.Click += BotonAceptar_Click;            
            //this.Title = ControlBarraTitulo.Titulo;
            //_provincias.RecargarElementosConTodas();
            //this.ComboBoxProvincias.ItemsSource = _provincias;
            //_tiempos.RecargarTodosLosTiempos();         
            //this.ComboBoxEnInstanteLineaTiempo.ItemsSource = _tiempos;
            //if (_provincias.Count > 0) this.ComboBoxProvincias.SelectedIndex = 0;
            //if (_tiempos.Count > 0)
            //{              
            //    this.ComboBoxEnInstanteLineaTiempo.SelectedIndex = 0;
            //} 
            //this.ComboBoxProvincias.SelectionChanged += ComboBoxProvincias_SelectionChanged;
            //ComboBoxProvincias_SelectionChanged(null,null);           
        }

        //void ComboBoxProvincias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    _municipios.Clear();
        //    if (ComboBoxProvincias.SelectedIndex != -1)
        //    {
        //        EntidadProvincia prov = ComboBoxProvincias.SelectedItem as EntidadProvincia;
        //        if (prov.Nombre == "Todas")
        //        {
        //            _municipios.RecargarElementosUnicamenteConTodos();
        //            ComboBoxMunicipios.ItemsSource = _municipios;
        //            ComboBoxMunicipios.IsEnabled = false;
        //            ComboBoxMunicipios.SelectedIndex = 0;
        //        }
        //        else
        //        {
        //            _municipios.RecargarElementosConTodos(prov.CodigoProvincia);
        //            ComboBoxMunicipios.ItemsSource = _municipios;
        //            ComboBoxMunicipios.IsEnabled = true;
        //            ComboBoxMunicipios.SelectedIndex = 0;
        //        } 
        //    }
        //}
        //public void ConfigurarDialogo(string nombreActividad)
        //{
        //    this.Title = "Establecer límites de actividad";
        //    this.ControlBarraTitulo.Titulo = this.Title;
        //    this.TextBoxNombrePatente.Text = nombreActividad;            
        //}
        
        //void BotonAceptar_Click(object sender, RoutedEventArgs e)
        //{
        //    if (ComboBoxProvincias.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Debe seleccionar una provincia para proceder a actualizar los límites.", "Error en la entrada de datos", MessageBoxButton.OK);
        //        return;
        //    }
        //    if (ComboBoxMunicipios.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Debe seleccionar una municipio para proceder a actualizar los límites.", "Error en la entrada de datos", MessageBoxButton.OK);
        //        return;
        //    }
        //    if (ComboBoxEnInstanteLineaTiempo.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Debe seleccionar un mes y año en la línea de tiempo para proceder a actualizar los límites.", "Error en la entrada de datos", MessageBoxButton.OK);
        //        return;
        //    }
        //    ProvinciaSeleccionada = ComboBoxProvincias.SelectedItem as EntidadProvincia;
        //    MunicipioSeleccionado = ComboBoxMunicipios.SelectedItem as EntidadMunicipio;
        //    LineaTiempoSeleccionada = ComboBoxEnInstanteLineaTiempo.SelectedItem as EntidadLineaTiempo;
          
        //    double valueCuotaMensualMinima;
        //    if (!double.TryParse(TextBoxCuotaMensualMinima.Text, out valueCuotaMensualMinima))
        //    {
        //        MessageBox.Show("Debe entrar un valor de cuota mensual mínima válido para proceder a actualizar los límites.", "Error en la entrada de datos", MessageBoxButton.OK);
        //        return;
        //    }
        //    this.CuotaMensualMinima = valueCuotaMensualMinima;
        //    double valueGastoMaximo;
        //    if (!double.TryParse(TextBoxGastoMaximo.Text, out valueGastoMaximo))
        //    {
        //        MessageBox.Show("Debe entrar un valor de gasto máximo válido para proceder a actualizar los límites.", "Error en la entrada de datos", MessageBoxButton.OK);
        //        return;
        //    }
        //    this.GastoMaximo = valueGastoMaximo;

        //    if (this.CuotaMensualMinima <= 0)
        //    {
        //        MessageBox.Show("Debe entrar un valor de cuota mensual mínima válido para proceder a actualizar los límites.", "Error en la entrada de datos", MessageBoxButton.OK);
        //        return;
        //    }
        //    if (this.GastoMaximo <= 0)
        //    {
        //        MessageBox.Show("Debe entrar un valor de  de gasto máximo válido para proceder a actualizar los límites.", "Error en la entrada de datos", MessageBoxButton.OK);
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
