using System.Collections.Generic;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class TeamsPage : BaseGridPage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='title-container']")]
        public IWebElement TeamsPageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-tab']//span[@class='ag-icon ag-icon-filter']")]
        public IWebElement FilterButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Default Team']")]
        public IWebElement DefaultTeamCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='width100']")]
        public IWebElement TeamMembersPanel { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.TeamsPageTitle)
            };
        }

        public void NavigateToTeamTabByName(string tabName)
        {
            var tab = Driver.FindElement(By.XPath($".//div[contains(@class, 'menuItems')]/a/span[text()='{tabName}']"));
            tab.Click();
        }
    }
}