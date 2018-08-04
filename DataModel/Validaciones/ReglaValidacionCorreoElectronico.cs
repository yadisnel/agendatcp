using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace Agenda.ModeloDatos.Validaciones
{
    public class ReglaValidacionCorreoElectronico : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            // Está vacío o es null?
            if (String.IsNullOrEmpty((string)value))
            {
                return new ValidationResult(false, "Debe proporcionar una dirección de correo. No se permite dejar vacío.");
            }
            // Es vacío?
            var Aux = ((string)value).Trim();
            if (Aux.Length == 0)
            {
                return new ValidationResult(false, "Debe proporcionar una dirección de correo. No se permite dejar vacío.");
            }
            // Es una dirección de correo válida?
            var patron = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*([,;]\s*\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)*";
            if (!Regex.IsMatch((string)value, patron))
            {
                return new ValidationResult(false, "La dirección proporcionada no es una dirección de correo válida.");
            }
            // La dirección es válida!
            return new ValidationResult(true, null);
        }

    }
}
