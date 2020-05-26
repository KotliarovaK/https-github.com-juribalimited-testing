using System;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Providers;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage
{
    [Binding]
    internal class EvergreenJnr_ItemDetailsPage_Navigation : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ItemDetailsPage_Navigation(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User navigates to the '(.*)' details page for '(.*)' item")]
        public void WhenUserNavigatesToTheDetailsPageForItem(string listName, string itemName)
        {
            var id = DatabaseHelper.GetItemId(listName, itemName);

            OpenItemDetailsById(listName.ToLower(), id);
        }

        [When(@"User navigates to the '(.*)' details page for the item with '(.*)' ID")]
        public void WhenUserNavigatesToTheDetailsPageForItemWithId(string listName, string id)
        {
            listName = listName.ToLower();

            OpenItemDetailsById(listName, id);
        }

        private void OpenItemDetailsById(string listName, string id)
        {
            //Navigate back to evergreeen from self service end user page
            if (_driver.Url.Contains("selfservice") && _driver.Url.Contains("ObjectId"))
            {
                _driver.NavigateToUrl(UrlProvider.EvergreenUrl);
            }

            var url = $"{UrlProvider.EvergreenUrl}#/{listName}/{id}/details/{listName}";

            _driver.NavigateToUrl(url);
            _driver.WaitForDataLoading();
            _driver.NowAt<BaseHeaderElement>();
        }
    }
}