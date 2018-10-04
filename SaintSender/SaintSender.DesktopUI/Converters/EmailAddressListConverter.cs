using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Data;

namespace SaintSender.DesktopUI.Converters
{
    public class EmailAddressListConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.Join(", ", (List<string>)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new List<string>(Regex.Split((string)value, ", "));
        }
    }
}