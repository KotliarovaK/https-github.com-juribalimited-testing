using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class SelfService_OtherOptions1Page : BaseDashboardPage
    {
        //TODO add a language?

        [FindsBy(How = How.XPath, Using = ".//input[@id='cb_otherOptions_ShowScreen']")]
        public IWebElement ShowScreen { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='cb_otherOptions_allowUsersToAddANoteFromThisPage']")]
        public IWebElement AllowUsersToAddANote { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='input_otherOptions_displayOnlyOwnedObjects']")]
        public IWebElement OnlyOwned { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='input_otherOptions_displayAllLinkedObjects']")]
        public IWebElement AllLinked { get; set; }

        //TODO User Task Name
        //TODO Computer Task Name

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