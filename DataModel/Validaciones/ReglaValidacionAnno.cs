using System.Globalization;
using System.Windows.Controls;

namespace Agenda.ModeloDatos.Validaciones
{
    public class ReglaValidacionAnno : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int anno;       
            // Es un número?
            if (!int.TryParse((string)value, out anno))
            {
                return new ValidationResult(false, "El valor no es un importe válido.");
            }
            // Está en el rango válido?
            if ((anno < 1990) || (anno > 2100))
            {
                var msg = string.Format("El año debe estar entre {0} y {1}.", 0.01,9999999);
                return new ValidationResult(false, msg);
            }

            // El precio es válido.
            return ValidationResult.ValidResult;
        }
    }

}
