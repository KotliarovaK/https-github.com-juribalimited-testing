using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using AutomationUtils.Extensions;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomationCore.Pages.Evergreen.Base.BaseDialog;

namespace DashworksTestAutomationCore.Pages.Evergreen.AdminDetailsPages.SelfService.EndClient
{
    class SelfServiceEndUserDialogPage : BaseDashboardPage
    {
        public IWebElement GetSSEndUserPageTextbox(string placeholder, WebDriverExtensions.WaitTime wait = WebDriverExtensions.WaitTime.Medium)
        {
            var by = By.XPath($"{BaseDialogPageSelectors.PopupSelector}{string.Format(BaseDashboardPage.NamedTextboxSelector, placeholder)}");
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
            
            throw new Exception($"Error message was not displayed for '{placeholder}' textbox");
        }
    }
}
