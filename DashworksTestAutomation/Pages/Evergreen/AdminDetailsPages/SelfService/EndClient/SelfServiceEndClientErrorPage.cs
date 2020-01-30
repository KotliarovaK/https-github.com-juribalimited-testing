using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService.EndClient
{
    public class SelfServiceEndClientErrorPage : SelfServiceEndClientBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='ssw-errors-message']/i")]
        public IWebElement ErrorIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ssw-errors-message']/p")]
        public IWebElement ErrorText { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By> { };
        }

        public bool ErrorPageIsDisplayed(string text)
        {
            if (!(Driver.IsElementDisplayed(ErrorIcon, WebDriverExtensions.WaitTime.Long) &
                  Driver.IsElementDisplayed(ErrorText, WebDriverExtensions.WaitTime.Long)))
            {
                return false;
            }

            return ErrorText.Text.Equals(text);
        }
    }
}
