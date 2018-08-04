using Agenda.ModeloDatos.Entidades;
using Agenda.ModeloDatos.Consultas;
using System.Windows.Controls;

namespace Agenda.Vistas.ModuloConfiguracion
{
    /// <summary>
    /// Interaction logic for PaginaPrincipalConfiguracion.xaml
    /// </summary>
    public partial class PaginaPrincipalConfiguracion : Page
    {
        //public Page PaginaInicio { get; set; }
        //private ListadoSecciones Secciones = new ListadoSecciones();
        public PaginaPrincipalConfiguracion()
        {
            InitializeComponent();
            //Secciones.RecargarElementos();
            //ControlPestanasConfiguracion.AdicionarPestana("PestanaDatosCuotas", "Cuotas", "IconoPestanaCuotas");
            //ControlPestanasConfiguracion.AdicionarPestana("PestanaDatosSeguridad", "Seguridad", "IconoPestanaSeguridad");
            //ControlPestanasConfiguracion.AdicionarPestana("PestanaDatosNomencladores", "Nomencladores", "IconoPestanaNomencladores");
            //ControlPestanasConfiguracion.ObtenerPestana("PestanaDatosNomencladores").Click += new System.Windows.RoutedEventHandler(PestanaDatosNomencladores_Click);
            //ControlPestanasConfiguracion.ObtenerPestana("PestanaDatosSeguridad").Click += new System.Windows.RoutedEventHandler(PestanaDatosSeguridad_Click);
            //ControlPestanasConfiguracion.ObtenerPestana("PestanaDatosCuotas").Click += PestanaDatosCuotas_Click;
            //PestanaDatosCuotas_Click(null, null);
            //ControlPestanasConfiguracion.ObtenerPestana("PestanaDatosCuotas").EstaSeleccionado = true;
        }

        //void PestanaDatosCuotas_Click(object sender, System.Windows.RoutedEventArgs e)
        //{
        //    var Pc = new PaginaConfiguracionCuotasMensuales();
        //    CapaTrabajoConfiguracion.Navigate(Pc);
        //}

        //void PestanaDatosSeguridad_Click(object sender, System.Windows.RoutedEventArgs e)
        //{
        //    var Pcs = new PaginaConfiguracionSeguridadSistema();
        //    CapaTrabajoConfiguracion.Navigate(Pcs);
        //}

        //void PestanaDatosNomencladores_Click(object sender, System.Windows.RoutedEventArgs e)
        //{            
        //     var Pcn = new PaginaConfiguracionNomencladores();            
        //     CapaTrabajoConfiguracion.Navigate(Pcn);
        //}
    }
}
