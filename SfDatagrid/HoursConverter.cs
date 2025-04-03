using System.Globalization;

namespace SfDatagrid;

public class HoursConverter : IValueConverter
{
    // This method is called when the grid displays the value
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is double hours)
        {
            // Return formatted string with " h" at the end
            return $"{hours:0.##} h";
        }

        return value;
    }

    // This method is used if user edits and sends value back to the source
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var input = value?.ToString()?.Replace("h", "").Trim();
        return double.TryParse(input, out var result) ? result : 0;
    }
}