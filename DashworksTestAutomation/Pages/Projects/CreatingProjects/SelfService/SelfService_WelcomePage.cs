using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.CreatingProjects.SelfService
{
    internal class SelfService_WelcomePage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains(@class, 'AddLanguage')]")]
        public IWebElement AddLanguageButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@aria-label='Languages']")]
        public IWebElement Languages { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'SearchValue')]")]
        public IWebElement AllowUsersToSearch { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'allowUserToChangeLanguage')]")]
        public IWebElement AllowToChangeLanguage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'showProjectSelector')]")]
        public IWebElement ShowProjectSelector { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'showSelectedObjectDetails')]")]
        public IWebElement ShowObjectDetails { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'displayFurtherDetailsLink')]")]
        public IWebElement ShowMoreDetailsLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@aria-label, 'Type')]")]
        public IWebElement Type { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@aria-label, 'Field')]")]
        public IWebElement Field { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Long Name']")]
        public IWebElement LongName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Short Name']")]
        public IWebElement ShortName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[@aria-label='Page Description']")]
        public IWebElement PageDescription { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Project Name']")]
        public IWebElement ProjectName { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[@colspan]//input[@value='Add']")]
        public IWebElement AddObjectDetailsButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.AllowUsersToSearch),
                SelectorFor(this, p => p.AllowToChangeLanguage),
                SelectorFor(this, p => p.ShowProjectSelector),
                SelectorFor(this, p => p.ShowMoreDetailsLink),
                SelectorFor(this, p => p.LongName),
                SelectorFor(this, p => p.ShortName),
                SelectorFor(this, p => p.PageDescription),
                SelectorFor(this, p => p.ProjectName)
            };
        }

        public IWebElement GetLanguagesByName(string languages)
        {
            var selector = By.XPath($".//td[contains(text(), '{languages}')]");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetDeleteButtonByLanguages(string languages)
        {
            var selector = By.XPath($".//td[contains(text(), '{languages}')]/..//img[@title='Delete']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public void GetTypeByName(string typeName)
        {
            var selector = By.XPath($"//select[@aria-label='Type']/option[text()='{typeName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            Driver.FindElement(selector).Click();
        }

        public void GetFieldByName(string fieldName)
        {
            var selector = By.XPath($"//select[@aria-label='Field']/option[text()='{fieldName}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            Driver.FindElement(selector).Click();
        }
    }
}