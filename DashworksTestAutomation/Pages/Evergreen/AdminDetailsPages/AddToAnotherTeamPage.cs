using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    public class AddToAnotherTeamPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//h1")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='teams']")]
        public IWebElement TeamSelectBox { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.PageTitle),
                SelectorFor(this, p => p.TeamSelectBox)
            };
        }

        public void AddUsersToAnotherTeam(string teamName)
        {
            TeamSelectBox.Click();
            var teamSelector = $"//mat-option/span[text()='{teamName}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(teamSelector));
            Driver.FindElement(By.XPath(teamSelector)).Click();
        }
    }
}