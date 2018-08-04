using System;
using System.Globalization;
using System.Windows.Controls;

namespace Agenda.ModeloDatos.Validaciones
{
    public class ReglaValidacionNit : ValidationRule
    {  
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            // Está vacío o es null?
            if (String.IsNullOrEmpty((string)value))
            {
                return new ValidationResult(false, "Debe proporcionar un Número de Identificación Tributaria Válido. No se permite dejar vacío.");
            }
            // Es un CI vacío (solo espacios)?
            var Aux1 = ((string)value).Trim();
            if (Aux1.Length == 0)
            {
                return new ValidationResult(false, "Debe proporcionar un Número de Identificación Tributaria Válido. No se permite dejar vacío.");
            }
            // Es un CI válido (11 dígitos, todos números)?
            var Aux2 = ((string)value);
            if (Aux2.Length == 11)
            {
                try
                {
                    var num = long.Parse(Aux2);
                }
                catch (Exception)
                {
                    return new ValidationResult(false, "Número de Identificación Tributaria debe contener solo números.");
                }
            }
            else
            {
                return new ValidationResult(false, "El Número de Identificación Tributaria debe contener 11 dígitos.");
            }
            // El nombre es válido
            return ValidationResult.ValidResult;
        }
    }
}


