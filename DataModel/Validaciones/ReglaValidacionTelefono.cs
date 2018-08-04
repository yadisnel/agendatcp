using System;
using System.Globalization;
using System.Windows.Controls;

namespace Agenda.ModeloDatos.Validaciones
{
    public class ReglaValidacionTelefono : ValidationRule
    {  
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            // Está vacío o es null?
            if (String.IsNullOrEmpty((string)value))
            {
                return new ValidationResult(false, "Debe proporcionar un número de teléfono. No se permite dejar vacío.");
            }
            // Es un CI vacío (solo espacios)?
            var Aux1 = ((string)value).Trim();
            if (Aux1.Length == 0)
            {
                return new ValidationResult(false, "Debe proporcionar un número de teléfono. No se permite dejar vacío.");
            }
            // Es un numero válido (5 dígitos, todos números)?
            var Aux2 = ((string)value);
            if (Aux2.Length >= 5)
            {
                try
                {
                    var num = long.Parse(Aux2);
                }
                catch (Exception)
                {
                    return new ValidationResult(false, "El número de teléfono debe contener solo números.");
                }
            }
            else
            {
                return new ValidationResult(false, "El número de teléfono debe contener más de 5 dígitos.");
            }
            // El nombre es válido
            return ValidationResult.ValidResult;
        }
    }
}


