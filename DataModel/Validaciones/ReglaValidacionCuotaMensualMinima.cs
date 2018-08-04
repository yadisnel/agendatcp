using System;
using System.Globalization;
using System.Windows.Controls;

namespace Agenda.ModeloDatos.Validaciones
{
    public class ReglaValidacionCuotaMensualMinima : ValidationRule
    {  
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            // Está vacío o es null?
            if (String.IsNullOrEmpty((string)value))
            {
                return new ValidationResult(false, "Debe proporcionar un número mayor que 1. No se permite dejar vacío.");
            }
            // Es un # vacío (solo espacios)?
            var Aux1 = ((string)value).Trim();
            if (Aux1.Length == 0)
            {
                return new ValidationResult(false, "Debe proporcionar un número mayor que 1. No se permite dejar vacío.");
            }
          
            // Es un numero en rango válido (>1)?           
            try
            {
                var num = int.Parse(Aux1);
                if (num < 1)
                {
                    return new ValidationResult(false, "Debe proporcionar un número mayor que 1.");
                }
            }
            catch (Exception)
            {
                return new ValidationResult(false, "Debe proporcionar un número mayor que 1.");
            }
           
            // El nombre es válido
            return ValidationResult.ValidResult;
        }
    }
}


