using System;
using System.Globalization;
using System.Windows.Controls;

namespace Agenda.ModeloDatos.Validaciones
{
    public class ReglaValidacionPorciento : ValidationRule
    {  
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            // Está vacío o es null?
            if (String.IsNullOrEmpty((string)value))
            {
                return new ValidationResult(false, "Debe proporcionar un número en el rango de 0.01 a 100. No se permite dejar vacío.");
            }
            // Es un # vacío (solo espacios)?
            var Aux1 = ((string)value).Trim();
            if (Aux1.Length == 0)
            {
                return new ValidationResult(false, "Debe proporcionar un número en el rango de 0.01 a 100. No se permite dejar vacío.");
            }

            double porciento;
            System.Globalization.NumberFormatInfo Formato = new NumberFormatInfo();
            Formato.CurrencyDecimalSeparator = ".";
            Formato.NumberDecimalSeparator = ".";
            Formato.PerMilleSymbol = "";

            // Es un número?
            if (!double.TryParse((string)value, System.Globalization.NumberStyles.Float, Formato, out porciento))
            {
                return new ValidationResult(false, "El valor no es un porciento válido.");
            }

            // Es un numero en rango válido (0.01 a 100)? 
            if (porciento < 0.01d || porciento > 100)
            {
                return new ValidationResult(false, "El porciento debe ser un número comprendido en el rango de 0.01 a 100.");
            }            
           
            // El nombre es válido
            return ValidationResult.ValidResult;
        }
    }
}


