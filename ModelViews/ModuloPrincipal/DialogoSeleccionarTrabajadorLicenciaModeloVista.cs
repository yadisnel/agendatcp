using Agenda.ModeloDatos.Entidades;
using Agenda.ModeloDatos.Consultas;

namespace Agenda.ModeloVistas.ModuloPrincipal
{
    public class DialogoSeleccionarTrabajadorLicenciaModeloVista:  ModeloVistaAbs      
    {
        private EntidadTcp _tcpSeleccionado;
        private EntidadActividad _actividadSeleccionada;

        private ListadoLicencias _listaLicencias;
        private ListadoTrabajadores _listaTrabajadores;
        private ListadoActividades _listaActividades;

        private string _numeroLicencia;
        private string _nombreNuevoTrabajador;
        private string _nitNuevoTrabajador;       

        public EntidadTcp TcpSeleccionado
        {
            get
            {
                return _tcpSeleccionado;
            }

            set
            {
                _tcpSeleccionado = value;
                OnPropertyChanged("TcpSeleccionado");
            }
        }
        public EntidadActividad ActividadSeleccionada
        {
            get
            {
                return _actividadSeleccionada;
            }

            set
            {
                _actividadSeleccionada = value;
                OnPropertyChanged("ActividadSeleccionada");
            }
        }
      
        public string NumeroLicencia
        {
            get
            {
                return _numeroLicencia;
            }

            set
            {
                _numeroLicencia = value;
                OnPropertyChanged("NumeroLicencia");
            }
        }

        public string NombreNuevoTrabajador
        {
            get
            {
                return _nombreNuevoTrabajador;
            }

            set
            {
                _nombreNuevoTrabajador = value;
                OnPropertyChanged("NombreNuevoTrabajador");
            }
        }

        public string NitNuevoTrabajador
        {
            get
            {
                return _nitNuevoTrabajador;
            }

            set
            {
                _nitNuevoTrabajador = value;
                OnPropertyChanged("NitNuevoTrabajador");
            }
        }

        public ListadoLicencias ListaLicencias
        {
            get
            {
                return _listaLicencias;
            }

            set
            {
                _listaLicencias = value;
                OnPropertyChanged("ListaLicencias");
            }
        }

        public ListadoTrabajadores ListaTrabajadores
        {
            get
            {
                return _listaTrabajadores;
            }

            set
            {
                _listaTrabajadores = value;
                OnPropertyChanged("ListaTrabajadores");
            }
        }

        public ListadoActividades ListaActividades
        {
            get
            {
                return _listaActividades;
            }

            set
            {
                _listaActividades = value;
                OnPropertyChanged("ListaActividades");
            }
        }

        public DialogoSeleccionarTrabajadorLicenciaModeloVista()
        {
           ListaLicencias = new ListadoLicencias();
           ListaTrabajadores = new ListadoTrabajadores();
           ListaActividades = new ListadoActividades();     
        }        
    }
}
