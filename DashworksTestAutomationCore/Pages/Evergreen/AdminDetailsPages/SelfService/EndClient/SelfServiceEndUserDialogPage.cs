using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using AutomationUtils.Extensions;

namespace DashworksTestAutomationCore.Pages.Evergreen.AdminDetailsPages.SelfService.EndClient
{
    class SelfServiceEndUserDialogPage : SeleniumBasePage
    {
        private static string NamedTextboxSelector = "(.//textarea[@placeholder='{0}'] | .//input[@placeholder='{0}'] | .//input[@automation='{0}'])";

        public IWebElement GetSSEndUserPageTextbox(string placeholder, WebDriverExtensions.WaitTime wait = WebDriverExtensions.WaitTime.Medium)
        {
            var by = By.XPath(string.Format(NamedTextboxSelector, placeholder));
            if (!Driver.IsElementDisplayed(by, wait))
            {
                throw new Exception($"Textbox with '{placeholder}' placeholder was not displayed");
            }
            return Driver.FindElement(by);
        }

        public IWebElement GetSSTextboxInlineMessageElement(string placeholder)
        {
            var namedTextbox = GetSSEndUserPageTextbox(placeholder);

            //Self Service EndUser page
            var sSErrorSelector = By.XPath($".//ancestor::das-selfservice-autocomplete/following-sibling::div");

            if (Driver.IsElementDisplayed(namedTextbox, WebDriverExtensions.WaitTime.Short))
            {
                return namedTextbox.FindElement(sSErrorSelector);
            }
            else
            {
                throw new Exception($"Error message was not displayed for '{placeholder}' textbox");
            }
        }
    }
}
