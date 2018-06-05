using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class SelfService_OtherOptionsPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'ShowScreen')]")]
        public IWebElement ShowScreen { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'allowUsersToAddANoteFromThisPage')]")]
        public IWebElement AllowUsersToAddANote { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'OnlyOwnedObjects')]")]
        public IWebElement OnlyOwned { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'AllLinkedObjects')]")]
        public IWebElement AllLinked { get; set; }

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
                SelectorFor(this, p => p.ShowScreen),
                SelectorFor(this, p => p.AllowUsersToAddANote),
                SelectorFor(this, p => p.LongName),
                SelectorFor(this, p => p.ShortName),
                SelectorFor(this, p => p.PageDescription)
            };
        }
    }
}