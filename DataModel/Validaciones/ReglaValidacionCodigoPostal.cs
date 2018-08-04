using System;
using System.Globalization;
using System.Windows.Controls;

namespace Agenda.ModeloDatos.Validaciones
{
    public class ReglaValidacionCodigoPostal : ValidationRule
    {  
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            // Está vacío o es null?
            if (String.IsNullOrEmpty((string)value))
            {
                return new ValidationResult(false, "Debe proporcionar un código postal. No se permite dejar vacío.");
            }
            // Es un CI vacío (solo espacios)?
            var Aux1 = ((string)value).Trim();
            if (Aux1.Length == 0)
            {
                return new ValidationResult(false, "Debe proporcionar un código postal. No se permite dejar vacío.");
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
                    //TODO Verificar que los códigos postales de cuba tengan solo números.
                    return new ValidationResult(false, "El código postal debe contener solo números.");
                }
            }
            else
            {
                //TODO Verificar que los códigos postales de cuba tengan esta cantidad de dígitos.
                return new ValidationResult(false, "El código postal debe contener más de 5 dígitos.");
            }
            // El nombre es válido
            return ValidationResult.ValidResult;
        }
    }
}


