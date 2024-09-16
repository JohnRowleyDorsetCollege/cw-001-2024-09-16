using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_001.Models
{
    public static class Utilities
    {
        public static string GetDayOfWeek(int day)
        {
            string dayOfWeek = string.Empty;
            switch (day)
            {
                case 1:
                    dayOfWeek= "Monday";
                    break;
                case 2:
                    dayOfWeek = "Tuesday";
                    break;
                case 3:
                    dayOfWeek = "Wednesday";
                    break;
                case 4:
                    dayOfWeek = "Thursday";
                    break;
                case 5:
                    dayOfWeek = "Friday";
                    break;
                case 6:
                    dayOfWeek = "Saturday";
                    break;
                case 7:
                    dayOfWeek = "Sunday";
                    break;
            }

            return dayOfWeek;
        }
    }
}
