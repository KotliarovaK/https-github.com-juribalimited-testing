using System;
using System.Net;

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