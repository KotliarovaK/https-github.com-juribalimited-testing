using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace DashworksTestAutomation.Pages.Evergreen.Base
{
    public class BaseWidgetPage : SeleniumBasePage
    { 

        [FindsBy(How = How.XPath, Using = ".//div[@class='chartContainer ng-star-inserted']//*[@style='font-weight:bold']")]
        public IWebElement DataLabels { get; set; }

    }
}
