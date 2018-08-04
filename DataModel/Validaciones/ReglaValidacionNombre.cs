using System;
using System.Globalization;
using System.Windows.Controls;

namespace Agenda.ModeloDatos.Validaciones
{
    public class ReglaValidacionNombre : ValidationRule
    {  
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            // Está vacío o es null?
            if (String.IsNullOrEmpty((string)value))
            {
                return new ValidationResult(false, "Debe proporcionar un nombre. No se permite dejar vacío.");
            }
            // Es un nombre válido?
            var Aux = ((string)value).Trim();
            if (Aux.Length == 0)
            {
                return new ValidationResult(false, "Debe proporcionar un nombre. No se permite dejar vacío.");
            }
            // El nombre es válido
            return ValidationResult.ValidResult;
        }
    }
}


