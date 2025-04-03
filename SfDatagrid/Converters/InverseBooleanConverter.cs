using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace SfDatagrid.Converters
{
    /// <summary>
    /// This value converter takes a boolean and returns its inverse.
    /// So true becomes false, and false becomes true.
    /// </summary>
    public class InverseBooleanConverter : IValueConverter
    {
        // This method is called when data flows from ViewModel to View (UI).
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Make sure the value is a bool before trying to invert it
            if (value is bool boolValue)
                return !boolValue;

            // If we can't convert it, just return the original value (fail gracefully)
            return value;
        }

        // This method is called when data flows from View (UI) back to ViewModel.
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Same logic here: invert the boolean if it's valid
            if (value is bool boolValue)
                return !boolValue;

            return value;
        }
    }
}