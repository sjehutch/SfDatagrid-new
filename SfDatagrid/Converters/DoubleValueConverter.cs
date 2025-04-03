using System;
using System.Globalization;



namespace Douglas.Fumiguide.Vikane.Converters
{
    public class DoubleValueConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case null:
                    return "0";
                case double _:
                    return value.ToString();
                case string str when string.IsNullOrWhiteSpace(str):
                    return "0";
                case string str when double.TryParse(str, NumberStyles.Float, culture.NumberFormat, out var doubleValue):
                    return doubleValue.ToString(culture);
                case string str:
                    return "0";
                case int _:
                case decimal _:
                    return value.ToString();
                default:
                    return "0";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case null:
                    return 0.0d;
                case double _:
                    return value;
                case string str when string.IsNullOrWhiteSpace(str):
                    return 0.0d;
                case string str when double.TryParse(str, NumberStyles.Float, culture.NumberFormat, out var doubleValue):
                    return doubleValue;
                case string str:
                    return 0.0d;
                case int _:
                case decimal _:
                    return value;
                default:
                    return 0.0d;
            }
        }
    }
}