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

        [FindsBy(How = How.XPath, Using = ".//h2[text()='Reassign Objects']")]
        public IWebElement ReassignObjectsSummary { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class,'mat-primary mat-raised-button')]")]
        public IWebElement UpdateTeamButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='ADD MEMBERS']")]
        public IWebElement AddMembersButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Default Team']")]
        public IWebElement DefaultTeamCheckbox { get; set; }

        //TODO this is button in grid action header. Should be moved to generic place
        [FindsBy(How = How.XPath, Using = "//button/span[text()='REMOVE']")]
        public IWebElement RemoveButtonOnPage { get; set; }

        [FindsBy(How = How.XPath,
            Using = "//button[contains(@class, 'messageAction')]/span[contains(text(), 'REMOVE')]")]
        public IWebElement RemoveButtonInWarningMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='width100']")]
        public IWebElement TeamMembersPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ng-star-inserted']")]
        public IWebElement ResultsOnPageCount { get; set; }

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

        public bool AppropriateTeamName(string teamName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//h1[text()='{teamName}']"));
        }
    }
}