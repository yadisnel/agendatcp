using System;
using System.Globalization;
using System.Windows.Controls;

namespace Agenda.ModeloDatos.Validaciones
{
    public class ReglaValidacionSexo : ValidationRule
    {  
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {           
            // Está vacío o es null?
            if (String.IsNullOrEmpty((string)value))
            {               
                return new ValidationResult(false, "El sexo debe ser 'M' o 'F'. No se permite dejar vacío.");
            }
            // Es un sexo válido?
            var Aux = ((string)value).Trim();
            if (Aux.Length == 0)
            {
                return new ValidationResult(false, "El sexo debe ser 'M' o 'F'. No se permite dejar vacío.");
            }
            var Aux2 = ((string)value).Trim();
            if ( (Aux2 != "M") && (Aux2 != "F") )
            {
                return new ValidationResult(false, "El sexo debe ser 'M' o 'F'.");
            }
            // El sexo es válido
            return ValidationResult.ValidResult;
        }
    }
}


