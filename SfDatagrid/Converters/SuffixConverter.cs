using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace SfDatagrid.Converters
{
    /// <summary>
    /// Adds a suffix (like "h" or "°C") to a numeric value for display only.
    /// Converts back to raw double for editing or logic.
    /// </summary>
    public class SuffixConverter : IValueConverter
    {
        public string Suffix { get; set; } = "";

        // Converts number -> "24.00 h"
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return "";

            return value switch
            {
                double d => $"{d:0.00} {Suffix}",
                float f => $"{f:0.00} {Suffix}",
                decimal m => $"{m:0.00} {Suffix}",
                _ => $"{value} {Suffix}"
            };
        }

        // Converts "24.00 h" -> 24.0 (editing time only)
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var input = value?.ToString()?.Replace(Suffix, "").Trim();

            // Try parsing the cleaned string as a double
            return double.TryParse(input, NumberStyles.Any, culture, out double result)
                ? result
                : 0;
        }
    }
}