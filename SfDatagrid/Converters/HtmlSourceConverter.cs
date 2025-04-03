using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace Douglas.Fumiguide.Vikane.Converters
{
    public class HtmlSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var html = new HtmlWebViewSource();

            if (value != null)
            {
                html.Html = value.ToString();
            }
            else
            {
                html.Html = "<html><body><h1>Nothing Loaded</h1></body></html>";
            }

            return html;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
