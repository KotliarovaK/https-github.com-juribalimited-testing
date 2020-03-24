using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder.Components;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService.EndClient
{
    public class SelfServiceEndClientBasePage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//das-self-service-header/div")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.XPath, Using = ".//das-self-service-footer/div")]
        public IWebElement Footer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ssw-tools']")]
        public IWebElement SelfServiceToolsPanel { get; set; }

        public IWebElement GetComponentItemOnEndUserPage(string pageName, int order)
        {
            var selector = By.XPath($".//h2[text()='{pageName}']//..//div[@class='component-item ng-star-inserted'][{order}]");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public bool СheckThatComponentIsDisplayedOnEndUserPage(string pageName, int order)
        {
            return Driver.IsElementDisplayed(GetComponentItemOnEndUserPage(pageName, order));
        }

        public IWebElement GetButtonOnEndUserPage(string buttonName)
        {
            var selector = By.XPath($".//button[text()='{buttonName}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);

        }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p=> p.Header),
                //SelectorFor(this, p=> p.Footer)
            };
        }
    }
}
