﻿using System;
using System.Globalization;
using System.Windows.Controls;

namespace Agenda.ModeloDatos.Validaciones
{
    public class ReglaValidacionProvincia : ValidationRule
    {  
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            // Está vacío o es null?
            if (String.IsNullOrEmpty((string)value))
            {
                return new ValidationResult(false, "Debe proporcionar un nombre de provincia. No se permite dejar vacío.");
            }
            // Es un valor válido?
            var Aux = ((string)value).Trim();
            if (Aux.Length == 0)
            {
                return new ValidationResult(false, "Debe proporcionar un nombre de provincia. No se permite dejar vacío.");
            }
            // El valor es válido
            return ValidationResult.ValidResult;
        }
    }
}


