using System.Collections.Generic;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class SelfService_WelcomePage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains(@class, 'AddLanguage')]")]
        public IWebElement AddLanguageButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@aria-label='Languages']")]
        public IWebElement Languages { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'SearchValue')]")]
        public IWebElement AllowToSearchForAnotherUser { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'allowUserToChangeLanguage')]")]
        public IWebElement AllowToChangeLanguage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'showProjectSelector')]")]
        public IWebElement ShowProjectSelector { get; set; }

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

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.AllowToSearchForAnotherUser),
                SelectorFor(this, p => p.AllowToChangeLanguage),
                SelectorFor(this, p => p.ShowProjectSelector),
                SelectorFor(this, p => p.ShowMoreDetailsLink),
                SelectorFor(this, p => p.Type),
                SelectorFor(this, p => p.Field),
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
    }
}