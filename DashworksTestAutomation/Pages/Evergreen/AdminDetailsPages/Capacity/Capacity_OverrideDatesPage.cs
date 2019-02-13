using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Capacity
{
    internal class Capacity_OverrideDatesPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='title-container']/h1")]
        public IWebElement TitleContainer { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'action-container')]//h2[text()='Create Override Date']")]
        public IWebElement CreateOverrideDatePageTitle { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.TitleContainer)
            };
        }
    }
}