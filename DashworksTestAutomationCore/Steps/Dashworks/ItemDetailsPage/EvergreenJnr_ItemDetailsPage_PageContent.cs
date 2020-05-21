using System;
using System.Collections.Generic;
using System.Linq;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage
{
    [Binding]
    internal class EvergreenJnr_ItemDetailsPage_PageContent : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ItemDetailsPage_PageContent(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Details page for '(.*)' item is displayed to the user")]
        public void ThenDetailsPageForItemIsDisplayedToTheUser(string pageName)
        {
            var page = _driver.NowAt<BaseHeaderElement>();
            page.CheckPageHeaderContainsText(pageName);

            var detailsPage = _driver.NowAt<DetailsPage>();
            Verify.IsTrue(detailsPage.GroupIcon.Displayed(),
                "Item details icon is not displayed on Item details page");
        }

        [Then(@"options are sorted in alphabetical order in the '(.*)' dropdown on item details page")]
        public void ThenOptionsAreSortedInAlphabeticalOrderInTheDropdownOnItemDetailsPage(string dropDownName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetDropdown(dropDownName).Click();
            List<string> actualOptions = page.GetDropdownValues(true);
             _driver.ClickByJavascript(page.BodyContainer);

            if (!actualOptions.Any())
            {
                throw new Exception($"There are no options in the '{dropDownName}' dropdown on items detail page");
            }

            //If Evergreen is not selected that it will be first in the list. Do not count it during sorting
            if (actualOptions.First().Equals("Evergreen"))
            {
                actualOptions.RemoveAt(0);
            }

            Verify.AreEqual(actualOptions.Where(x => !string.IsNullOrEmpty(x)).OrderBy(s => s),
                actualOptions.Where(x => !string.IsNullOrEmpty(x)),
                $"Options are displayed in not in alphabetical order in the '{dropDownName}' dropdown on items detail page");
        }
    }
}