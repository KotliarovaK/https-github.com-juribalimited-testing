using System;
using OpenQA.Selenium;

namespace DashworksTestAutomation.Extensions
{
    public static class CookieExtensions
    {
        public static Cookie ToSeleniumCookies(this System.Net.Cookie cookie)
        {
            try
            {
                return new Cookie(cookie.Name, cookie.Value, cookie.Domain, cookie.Path, cookie.Expires);
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to convert cookie with '{cookie.Name}' name: {e}");
            }
        }
    }
}