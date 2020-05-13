using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService
{
    public class SelfServiceDetailsPage : SeleniumBasePage
    {
        public IWebElement SelfServiceUrlPreview(string baseSelfServiceUrl, string selfServiceIdentifier)
        {
            string validUrl = $"{baseSelfServiceUrl}/evergreen/#/selfservice/{selfServiceIdentifier}";
            var selector = By.XPath($".//div[@class='ng-star-inserted']/div[@class='action-container']/self::*[contains(text(),'{validUrl}')]");
            return Driver.FindElement(selector);
        }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By> { };
        }
    }
}