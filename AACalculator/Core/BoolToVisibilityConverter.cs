using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace AACalculator.Core
{
    class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Visibility visible = Visibility.Visible;
            if (value != null)
            {
                if (!(bool)value)
                {
                    visible = Visibility.Collapsed;
                }
            }

            if (parameter != null && parameter.ToString().ToLower() == "reverse")
            {
                if (visible == Visibility.Visible)
                {
                    visible = Visibility.Collapsed;
                }
                else
                {
                    visible = Visibility.Visible;
                }
            }
            return visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool visible = true;
            if (value != null)
            {
                if ((Visibility)value != Visibility.Visible)
                {
                    visible = false;
                }
            }
            return visible;
        }
    }
}
