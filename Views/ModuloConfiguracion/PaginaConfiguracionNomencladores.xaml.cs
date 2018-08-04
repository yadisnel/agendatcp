using Agenda.ModeloDatos.Entidades;
using Agenda.ModeloDatos.Consultas;
namespace Agenda.Vistas.ModuloConfiguracion
{
    /// <summary>
    /// Interaction logic for PaginaConfiguracionEscalaProgresiva.xaml
    /// </summary>
    public partial class PaginaConfiguracionNomencladores
    {       
        public PaginaConfiguracionNomencladores()
        {
            InitializeComponent();
            //ControlPestanasNomencladores.AdicionarPestana("PestanaNomencladorActividades", "Actividades", "IconoPestanaNomencladorActividades");
            //ControlPestanasNomencladores.AdicionarPestana("PestanaNomencladorProvincias", "Provincias", "IconoPestanaNomencladorProvincias");
            //ControlPestanasNomencladores.AdicionarPestana("PestanaNomencladorMunicipios", "Municipios", "IconoPestanaNomencladorMunicipios");
            //ControlPestanasNomencladores.AdicionarPestana("PestanaNomencladorEscalaProgresiva", "Escala Progresiva", "IconoPestanaNomencladorEscalaProgresiva");           

            //ControlPestanasNomencladores.ObtenerPestana("PestanaNomencladorActividades").Click += new System.Windows.RoutedEventHandler(PestanaNomencladorActividades_Click);
            //ControlPestanasNomencladores.ObtenerPestana("PestanaNomencladorProvincias").Click += new System.Windows.RoutedEventHandler(PestanaNomencladorProvincias_Click);
            //ControlPestanasNomencladores.ObtenerPestana("PestanaNomencladorMunicipios").Click += new System.Windows.RoutedEventHandler(PestanaNomencladorMunicipios_Click);
            //ControlPestanasNomencladores.ObtenerPestana("PestanaNomencladorEscalaProgresiva").Click += new System.Windows.RoutedEventHandler(PestanaNomencladorEscalaProgresiva_Click);           

            //PestanaNomencladorActividades_Click(null, null);
            //ControlPestanasNomencladores.ObtenerPestana("PestanaNomencladorActividades").EstaSeleccionado = true;
        }

        //void PestanaNomencladorEscalaProgresiva_Click(object sender, System.Windows.RoutedEventArgs e)
        //{
        //    var pcnep = new PaginaConfiguracionNomencladorEscalaProgresiva();
        //    CapaTrabajoNomencladores.Navigate(pcnep);
        //}

        //void PestanaNomencladorMunicipios_Click(object sender, System.Windows.RoutedEventArgs e)
        //{
        //    var pcnm = new PaginaConfiguracionNomencladorMunicipios();
        //    CapaTrabajoNomencladores.Navigate(pcnm);
        //}

        //void PestanaNomencladorProvincias_Click(object sender, System.Windows.RoutedEventArgs e)
        //{
        //    var pcnp = new PaginaConfiguracionNomencladorProvincias();
        //    CapaTrabajoNomencladores.Navigate(pcnp);
        //}

        //void PestanaNomencladorActividades_Click(object sender, System.Windows.RoutedEventArgs e)
        //{
        //    var pcna = new PaginaConfiguracionNomencladorActividades();
        //    CapaTrabajoNomencladores.Navigate(pcna);
        //}
    }
}
