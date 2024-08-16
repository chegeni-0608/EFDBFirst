using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDBFirst.Utility
{
     public static class DateUtility
    {
      public static string GetCurrentShamsiDateWithDash()
        {
         var date = DateTime.Now;
            var pc = new PersianCalendar();
            return $"{pc.GetYear(date)}-{pc.GetMonth(date)}-{pc.GetDayOfMonth(date)}";
        }
    }
}
