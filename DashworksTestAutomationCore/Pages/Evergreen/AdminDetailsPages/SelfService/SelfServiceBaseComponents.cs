using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService
{
    public class SelfServiceBaseComponents : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//p[contains(text(),'Page: ')]")]
        public IWebElement PageNameLabel { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By> { };
        }

        public bool IsPageNameDisplayed(string pageName)
        {
            var by = $".//h2/following-sibling::p[text()='Page: {pageName}']";
            return Driver.IsElementDisplayed(By.XPath(by), WebDriverExtensions.WaitTime.Medium);
        }
    }
}
