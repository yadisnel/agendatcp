using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MaterialDesignThemes.Wpf.Converters
{
    public class RangePositionConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if(values == null || values.Length != 3 || values.Any(v => v == null))
                return Binding.DoNothing;
            double positionAsScaleFactor, lower, upper;
            if (!double.TryParse(values[0].ToString(), out  positionAsScaleFactor)
                || !double.TryParse(values[1].ToString(), out  lower)
                || !double.TryParse(values[2].ToString(), out  upper))

                return Binding.DoNothing;

            var result = upper + (lower - upper)*positionAsScaleFactor;            

            return result;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
