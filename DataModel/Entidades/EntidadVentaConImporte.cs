using System;

namespace Agenda.ModeloDatos.Entidades
{
    public class EntidadVentaConImporte: EntidadAbs
    {
        private int _codigoVenta;
        private short _codigoProducto;
        private short _codigoLicencia;
        private short _cantidadUnidades;       
        private DateTime _fechaRegistro;
        private string _descripcion;
        private double _importe;
        private string _nombreProducto;
        public EntidadVentaConImporte()
        {
            CodigoVenta = -1;
            CodigoProducto = -1;
            CantidadUnidades = 1; 
            FechaRegistro = DateTime.Now;          
            Descripcion = "";
        }

        public int CodigoVenta
        {
            get { return _codigoVenta; }
            set { _codigoVenta = value; OnPropertyChanged("CodigoVenta"); }
        }
        public short CodigoProducto
        {
            get { return _codigoProducto; }
            set { _codigoProducto = value; OnPropertyChanged("CodigoProducto"); }
        }
        public short CodigoLicencia
        {
            get { return _codigoLicencia; }
            set { _codigoLicencia = value; OnPropertyChanged("CodigoLicencia"); }
        }
        public short CantidadUnidades
        {
            get { return _cantidadUnidades; }
            set { _cantidadUnidades = value; OnPropertyChanged("CantidadUnidades"); }
        }

        public double Importe
        {
            get { return _importe; }
            set { _importe = value; OnPropertyChanged("Importe"); }
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
        public string ImporteString
        {
            get 
            { 
                return ConvertirStringDecimales(Importe); 
            }           
        }

        public DateTime FechaRegistro
        {
            get { return _fechaRegistro; }
            set { _fechaRegistro = value; OnPropertyChanged("FechaRegistro"); }
        }       

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; OnPropertyChanged("Descripcion"); }
        }
        public string NombreProducto
        {
            get { return _nombreProducto; }
            set { _nombreProducto = value; OnPropertyChanged("NombreProducto"); }
        }

        public string FechaRegistroString
        {
            get
            {
                string res = "";
                if (FechaRegistro.Day < 10) res += "0";
                res += FechaRegistro.Day;
                res += "/";
                if (FechaRegistro.Month < 10) res += "0";
                res += FechaRegistro.Month;
                res += "/";
                res += FechaRegistro.Year;
                return res;
            }
        }
        public string SubtotalString
        {
            get
            {
                return ConvertirStringDecimales(Subtotal);
            }
        }
        public double Subtotal
        {
            get 
            {
                return _importe * _cantidadUnidades; 
            }            
        }        
    }
}
