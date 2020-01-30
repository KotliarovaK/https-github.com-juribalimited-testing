using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class AdminLeftHandMenu : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='title-container']")]
        public IWebElement AdminTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[text()='Projects']/ancestor::mat-tree-node")]
        public IWebElement Projects { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[text()='Teams']")]
        public IWebElement Teams { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div/a[text()='Automations']")]
        public IWebElement Automations { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Capacity Units']")]
        public IWebElement CapacityUnits { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Rings']")]
        public IWebElement Rings { get; set; }

        //TODO should be moved to generic page
        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'buttonToggleSubmenu')]")]
        public IWebElement ExpandSidePanelIcon { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By> { };
        }
    }
}