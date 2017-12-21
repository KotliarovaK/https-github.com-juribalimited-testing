using System.Collections.Generic;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    class EvergreenJnr_DetailsPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_DetailsPage(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User navigates to the ""(.*)"" tab")]
        public void WhenUserNavigatesToTheTab(string tabName)
        {
            var tabs = _driver.NowAt<BaseDetailsTabsMenu>();

            tabs.NavigateToTabByName(tabName);
        }

        [Then(@"Fields with empty information are displayed")]
        public void ThenFieldsWithEmptyInformationAreDisplayed()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            detailsPage.ExpandAllSections();
            detailsPage.CheckThatAllContentIsNotEmpty();
        }

        [Then(@"Unknown text is displayed for empty fields for ""(.*)"" section")]
        public void ThenUnknownTextIsDisplayedForEmptyFieldsForSection(string sectionName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            detailsPage.ExpandAllSections();
            var table = detailsPage.GetFieldsWithContent(sectionName);
            foreach (KeyValuePair<string, string> pair in table)
            {
                if (pair.Key.Equals("Address 2") || pair.Key.Equals("Address 3") || pair.Key.Equals("Address 4"))
                    continue;

                Assert.IsTrue(!string.IsNullOrEmpty(pair.Value),
                    $"'Unknown' text is not displayed for {pair.Key} field ");
            }
        }

        [Then(@"""(.*)"" text is displayed for ""(.*)"" section")]
        public void ThenTextIsDisplayedForSection(string sectionName, string textMessage)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            detailsPage.GetFieldsWithContent(sectionName);
            detailsPage.MaximizeOrMinimizeSectionButton(sectionName).Click();
            Assert.AreEqual(textMessage, detailsPage.NoMailboxOwnerFoundMessage.Text);
        }
    }
}