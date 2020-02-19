using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Remote;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService
{
    public class SelfServiceDetailsPage : SeleniumBasePage
    {
        public IWebElement SelfServiceUrlPreview(string baseSelfServiceUrl, string selfServiceIdentifier)
        {
            string validUrl = $"{baseSelfServiceUrl}/{selfServiceIdentifier}";
            var selector = By.XPath($".//span[@class='ng-star-inserted']//self::*[contains(text(),'{validUrl}')]");
            return Driver.FindElement(selector);
        }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By> { };
        }
    }
}