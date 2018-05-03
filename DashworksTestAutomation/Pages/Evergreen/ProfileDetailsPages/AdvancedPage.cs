using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ProfileDetailsPages
{
    internal class AdvancedPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//label[text()='List Page Size']/ancestor::div[@class='form-item']//input")]
        public IWebElement ListPageSizeField { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//label[text()='List Pages to Cache']/ancestor::div[@class='form-item']//input")]
        public IWebElement ListPagesToCache { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@title='UPDATE']")]
        public IWebElement UpdateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-success']")]
        public IWebElement SuccessMessage { get; set; }

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
    }
}