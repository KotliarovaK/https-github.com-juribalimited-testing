using OpenQA.Selenium;
using SeleniumWebdriverTests.Settings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebdriverTests.ComponentHelper
{
    public class BrowserHelper
    {
        public static void BrowserMaximise()
        {
            ObjectRepository.Driver.Manage().Window.Maximize();
        }

        public static void BrowserGoBack()
        {
            ObjectRepository.Driver.Navigate().Back();
        }

        public static void BrowserGoForward()
        {
            ObjectRepository.Driver.Navigate().Forward();
        }

        public static void BrowserRefresh()
        {
            ObjectRepository.Driver.Navigate().Refresh();
        }

        public static void SwitchToWindow(int index)
        {
            ReadOnlyCollection<string> windows = ObjectRepository.Driver.WindowHandles;
            if (windows.Count < index)
            {
                throw new NoSuchWindowException("Invalid Browser Window Index" + index);
            }
            ObjectRepository.Driver.SwitchTo().Window(windows[index]);
            Thread.Sleep(1000);
            BrowserMaximise();
        }

        public static void SwitchToParent()
        {
            var windowIds = ObjectRepository.Driver.WindowHandles;
            var windowIdsCount = windowIds.Count - 1; //reduce count by 1, as count value is always 1 more than window id number

            for (int i = windowIdsCount; i > 0; --i)
            {
                 ObjectRepository.Driver.Close();
                 i = i - 1;
                 ObjectRepository.Driver.SwitchTo().Window(windowIds[i]);
                 if (i == 1) //if only 2 browser windows remain, break out of for loop
                 {
                    ObjectRepository.Driver.Close();
                    break;
                 }   

            }
            ObjectRepository.Driver.SwitchTo().Window(windowIds[0]);
        }
    }
}
