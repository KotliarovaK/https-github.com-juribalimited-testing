using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService.Components
{
    public class AppOwnershipComponentPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//ul[contains(@class,'fields-list')]//li")]
        public IList<IWebElement> FieldsToDisplay { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By> { };
        }
    }
}