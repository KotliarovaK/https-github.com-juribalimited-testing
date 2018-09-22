using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class Projects_PMObjectPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div/h1")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='pmform']")]
        public IWebElement TabContent { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[contains(@id, 'ViewState')]")]
        public IWebElement ViewState { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[contains(@id, 'ViewType')]")]
        public IWebElement ViewType { get; set; }

        [FindsBy(How = How.XPath, Using = "//img[contains(@id, 'OverallReadinessIcon')]")]
        public IWebElement ColorItem { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.PageTitle)
            };
        }

        public void GetViewStateByName(string stateName)
        {
            var selector = By.XPath($"//select[contains(@id, 'ViewState')]//option[text()='{stateName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            Driver.FindElement(selector).Click();
        }

        public void GetViewTypeByName(string typeName)
        {
            var selector = By.XPath($"//select[contains(@id, 'ViewType')]//option[text()='{typeName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            Driver.FindElement(selector).Click();
        }
    }
}
