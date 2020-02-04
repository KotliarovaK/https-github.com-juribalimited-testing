using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime UkTime(this DateTime dTime)
        {
            var britishZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            var ukTime = TimeZoneInfo.ConvertTime(dTime, TimeZoneInfo.Local, britishZone);
            return ukTime;
        }
    }
}
