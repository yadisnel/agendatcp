using System;

namespace Agenda.ModeloDatos.Entidades
{
    public class EntidadProducto: EntidadAbs
    {
        private short _codigoProducto;      
        private string _nombre;
        private double _precio;        
        private string _descripcion;
        public EntidadProducto()
        {            
            Nombre = "";
            Precio = 0.01d;
            Descripcion = "";
        }

        public short CodigoProducto
        {
            get { return _codigoProducto; }
            set { _codigoProducto = value; OnPropertyChanged("CodigoProducto"); }
        }       

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; OnPropertyChanged("Nombre"); }
        }
        public double Precio
        {
            get { return _precio; }
            set 
            {                
                _precio = Math.Round(value, 2); 
                OnPropertyChanged("Precio"); 
            }
        }        

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; OnPropertyChanged("Descripcion"); }
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
        public string PrecioString
        {
            get 
            {
                return ConvertirStringDecimales(Precio);
            }          
        }

    }
}
