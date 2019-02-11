using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPF_MasterDetailApp.PresentationLayer
{
    //
    // reference: https://social.msdn.microsoft.com/Forums/vstudio/en-US/347f4b46-af46-42a3-a09f-d064777bbce3/datepicker-in-datagrid-how-to-show-current-date?forum=wpf
    //
    public class NullToDateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            DateTime dateValue = (DateTime)value;
            if (dateValue.ToShortDateString() == "1/1/0001")
            {
                return DateTime.Now;
            }
            else
            {
                return value;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
