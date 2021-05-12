using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace view.Converter
{
    public class ColorConverter : IValueConverter
    {
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture) =>
            (int)value < 10 ? new SolidColorBrush(Colors.Red) : new SolidColorBrush(Colors.Green);
        

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
