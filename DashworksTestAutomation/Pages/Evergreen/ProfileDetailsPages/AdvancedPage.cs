using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ProfileDetailsPages
{
    internal class AdvancedPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='List Page Size']")]
        public IWebElement ListPageSizeField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='List Pages to Cache']")]
        public IWebElement ListPagesToCache { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button/span[text()='UPDATE']")]
        public IWebElement UpdateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-success']")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//body")]
        public IWebElement BodyContainer { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.ListPageSizeField),
                SelectorFor(this, p => p.ListPagesToCache),
                SelectorFor(this, p => p.UpdateButton)
            };
        }

        public bool GetSelectedListPageSize(string selectedSize)
        {
            return Driver.IsElementDisplayed(By.XPath($".//span[@class='title'][contains(text(), '{selectedSize}')]"));
        }
    }
}