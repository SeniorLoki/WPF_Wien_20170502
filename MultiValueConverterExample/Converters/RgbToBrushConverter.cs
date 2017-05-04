using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace MultiValueConverterExample.Converters
{
    public class RgbToBrushConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var a = (byte)(double)values[0];
            var red = (byte)(double)values[1];
            var green = (byte)(double)values[2];
            var blue = (byte)(double)values[3];

            return new SolidColorBrush(Color.FromArgb(a, red, green, blue));
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            var brush = value as SolidColorBrush;

            return new object[] 
            {
                (double)brush.Color.A,
                (double)brush.Color.R,
                (double)brush.Color.G,
                (double)brush.Color.B
            };
        }
    }
}
