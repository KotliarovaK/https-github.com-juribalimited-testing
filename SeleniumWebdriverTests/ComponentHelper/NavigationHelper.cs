using SeleniumWebdriverTests.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriverTests.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NagigateToURL(string Url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(Url);
        }
    }
}
