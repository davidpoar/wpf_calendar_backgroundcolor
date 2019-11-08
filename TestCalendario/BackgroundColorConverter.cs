using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestCalendario
{
    public class CalendarDayBackgroundColorConverter : IMultiValueConverter
    {
        public CalendarDayBackgroundColorConverter()
        {

        }

        #region IMultiValueConverter Members
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var dia = values[0] as DateTime?;
            var control = values[1] as CustomCalendar;
            var col = control.Days[dia.Value.Day - 1];

            if (control.DisplayDate.Month == dia.Value.Month)
            {
                return col;
            }

            return new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            return new object[0];
        }

        #endregion
    }
}
