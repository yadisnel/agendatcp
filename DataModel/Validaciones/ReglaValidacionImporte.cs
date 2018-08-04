using System.Globalization;
using System.Windows.Controls;

namespace Agenda.ModeloDatos.Validaciones
{
    public class ReglaValidacionImporte : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double precio;
            System.Globalization.NumberFormatInfo Formato = new NumberFormatInfo();
                            Formato.CurrencyDecimalSeparator = ".";
                            Formato.NumberDecimalSeparator = ".";
                            Formato.PerMilleSymbol = "";
                            
            // Es un número?
            if (!double.TryParse((string)value,System.Globalization.NumberStyles.Float, Formato, out precio))
            {
                return new ValidationResult(false, "El valor no es un importe válido.");
            }

            // Está en el rango válido?
            if ((precio < 0.01) || (precio > 999999999))
            {
                var msg = string.Format("El precio debe estar entre {0} y {1}.", 0.01,9999999);
                return new ValidationResult(false, msg);
            }

            // El precio es válido.
            return ValidationResult.ValidResult;
        }
    }

}
