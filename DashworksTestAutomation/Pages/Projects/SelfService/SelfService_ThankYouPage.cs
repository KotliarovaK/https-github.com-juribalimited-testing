using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class SelfService_ThankYouPage : BaseDashboardPage
    {
        //TODO add a language?

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'reviewChoiceshowScreen')]")]
        public IWebElement ShowInTheSelfServicePortal { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'showInNavChoiceshowScreen')]")]
        public IWebElement ShowInTheNavigationMenu { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'cb_showChoicesSummary')]")]
        public IWebElement ShowChoicesSummary { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'reviewChoicesIncludeDashworksHomepageButtonValuee')]")]
        public IWebElement IncludeLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Long Name']")]
        public IWebElement LongName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Short Name']")]
        public IWebElement ShortName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[@aria-label='Page Description']")]
        public IWebElement PageDescription { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.ShowInTheSelfServicePortal),
                SelectorFor(this, p => p.ShowInTheNavigationMenu),
                SelectorFor(this, p => p.ShowChoicesSummary),
                SelectorFor(this, p => p.IncludeLink),
                SelectorFor(this, p => p.LongName),
                SelectorFor(this, p => p.ShortName),
                SelectorFor(this, p => p.PageDescription)
            };
        }
    }
}