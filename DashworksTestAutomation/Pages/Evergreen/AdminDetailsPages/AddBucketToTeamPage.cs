using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    //TODO delete this page
    internal class AddBucketToTeamPage : SeleniumBasePage
    {
        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
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