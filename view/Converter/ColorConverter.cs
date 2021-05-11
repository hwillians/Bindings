using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace view.Converter
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int number = (int)value;

            if (number < 10)
            {
                return new SolidColorBrush(Colors.Red);
            }
            else return new SolidColorBrush(Colors.Green);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
