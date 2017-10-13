using OpenQA.Selenium;
using SeleniumWebdriverTests.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebdriverTests.ComponentHelper
{
    public class GenericHelper
    {
        public static bool IsElementPresent(By Locator)
        { 
            try
            {
                return ObjectRepository.Driver.FindElements(Locator).Count == 1;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public static IWebElement GetElement(By Locator)
        {
            if (IsElementPresent(Locator))
                return ObjectRepository.Driver.FindElement(Locator);
            else
                throw new NoSuchElementException("Element Not Found : " + Locator.ToString());
        }

        public static void TakeScreenShot(string fileName = "Screen_")
        {
            Screenshot screen = ObjectRepository.Driver.TakeScreenshot();
            if (fileName.Equals("Screen_"))
            {
                string filename = fileName + DateTime.UtcNow.ToString("dd-MM-yyyy-hh-mm-ss") + ".jpeg";
                screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
                return;
            }
            screen.SaveAsFile(fileName, ScreenshotImageFormat.Jpeg);
        }

        public static WebDriverWait GetWebdriverWait(TimeSpan timeout)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, timeout)
            {
                PollingInterval = TimeSpan.FromMilliseconds(500),
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            return wait;

        }


    }
}
