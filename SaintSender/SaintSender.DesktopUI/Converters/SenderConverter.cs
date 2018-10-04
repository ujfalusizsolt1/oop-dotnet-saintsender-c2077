using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Data;

namespace SaintSender.DesktopUI.Converters
{
    public class SenderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var fullSender = (string)value;

            try
            {
                var senderAddressList = Regex.Matches(fullSender, "<.*>");
                var senderAddress = senderAddressList[0].Value;
                return senderAddress.Substring(1, senderAddress.Length - 2);
            }
            catch (ArgumentOutOfRangeException)
            {
                return fullSender;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}