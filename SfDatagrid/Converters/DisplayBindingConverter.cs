using System.Globalization;

namespace SfDatagrid.Converters;

public class DisplayBindingConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value != null)
        {
            if (value is DateTime dateTime && dateTime == new DateTime(2022, 03, 22))
            {
                return "";
            }
            else
            {
                return ((DateTime)value).ToString("dd.MM.yyyy");
            }
        }
        else
        {
            return "";
        }
    }
 
    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
