using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.Extensions
{
    public static class CookieExtensions
    {
        public static OpenQA.Selenium.Cookie ToSeleniumCookies(this Cookie cookie)
        {
            try
            {
                return new OpenQA.Selenium.Cookie(cookie.Name, cookie.Value, cookie.Domain, cookie.Path, cookie.Expires);
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to convert cookie with '{cookie.Name}' name: {e}");
            }
        }
    }
}
