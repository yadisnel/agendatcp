using System;
namespace Agenda.ModeloDatos.Entidades
{
    
    public class EntidadEscala: EntidadAbs
    {
        private short _codigoEscala;
        private short _codigoLineaTiempoAño;
        private short _año;
        private double _desde;
        private double _hasta;
        private double _porciento;

        public EntidadEscala()
        {
            _codigoEscala = -1;
            _desde = 0;
            _hasta = 0;
            _porciento = 0;
        }

        public short CodigoEscala
        {
            get { return _codigoEscala; }
            set { _codigoEscala = value; OnPropertyChanged("CodigoEscala"); }
        }
        public short CodigoLineaTiempoAño
        {
            get { return _codigoLineaTiempoAño; }
            set { _codigoLineaTiempoAño = value; OnPropertyChanged("CodigoLineaTiempoAño"); }
        }
        public short Año
        {
            get { return _año; }
            set { _año = value; OnPropertyChanged("Año"); }
        }
        public double Desde 
        {
            get { return _desde; }
            set { _desde = value; OnPropertyChanged("Desde"); }
        }

        public double Hasta 
        {
            get { return _hasta; }
            set { _hasta = value; OnPropertyChanged("Hasta"); } 
        }
        public double Porciento 
        {
            get { return _porciento; }
            set { _porciento = value; OnPropertyChanged("Porciento"); } 
        }
        private string ConvertirStringDecimales(double numero)
        {
            double numeroRed = Math.Round(numero, 2);
            string[] partes = numeroRed.ToString().Split(",".ToCharArray());
            string res = partes[0];
            res += ".";
            if (partes.Length == 1)
            {
                res += "00";
                return res;
            }
            res += partes[1];
            if (partes[1].Length == 1)
            {
                res += "0";
            }
            return res;
        }
        public string PorcientoString
        {
            get { return ConvertirStringDecimales(Porciento); }
        }
        public string DesdeString
        {
            get { return ConvertirStringDecimales(Desde); }
        }
        public string HastaString
        {
            get { return ConvertirStringDecimales(Hasta); }
        }
    }   
}
