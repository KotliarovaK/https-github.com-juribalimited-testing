using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Capacity
{
    public class Capacity_CapacityUnitsPage : SeleniumBasePage
    {
        public const string ApplicationsRow = "//div[@col-id='application']//a";

        [FindsBy(How = How.XPath, Using = "//h1")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ApplicationsRow)]
        public IList<IWebElement> ApplicationsRowsList { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.PageTitle)
            };
        }

        public IWebElement GetMovingElementByName(string name)
        {
            var selector = By.XPath($"//div[contains(@class, 'action-container')]//h2[text()='{name}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}
