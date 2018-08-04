using System;
using System.Globalization;
using System.Windows.Controls;

namespace Agenda.ModeloDatos.Validaciones
{
    public class ReglaValidacionFecha : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                var data = ((DateTime?)value).Value.Date;
            }
            catch(Exception)
            {
                return new ValidationResult(false, "La fecha seleccionada es incorrecta.");
            }           
            return ValidationResult.ValidResult;
        }
    }

}
