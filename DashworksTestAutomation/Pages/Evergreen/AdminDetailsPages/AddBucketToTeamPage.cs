using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class AddBucketToTeamPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//h2[text()='Add Buckets']")]
        public IWebElement PageTitle { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.PageTitle)
            };
        }

        public IWebElement ExpandProjectByName(string projectName)
        {
            var editFilterSelector =
                $"//span[contains(text(), '{projectName}')]//ancestor::div[@class='panel-expand-inner btn-group-sm ng-star-inserted']//button";
            return Driver.FindElement(By.XPath(editFilterSelector));
        }
    }
}