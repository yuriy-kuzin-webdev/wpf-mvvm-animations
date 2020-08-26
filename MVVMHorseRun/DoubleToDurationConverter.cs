using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace MVVMHorseRun
{
    [ValueConversion(typeof(double),typeof(Duration))]
    public class DoubleToDurationConverter : IValueConverter
    {
        public static DoubleToDurationConverter Instance = new DoubleToDurationConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new Duration(TimeSpan.FromMilliseconds((double)value));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
