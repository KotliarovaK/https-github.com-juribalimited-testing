﻿using System;
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
            listName = listName.ToLower();
            var id = string.Empty;

            switch (listName)
            {
                case "device":
                    id = DatabaseHelper.GetDeviceDetailsIdByName(itemName);
                    break;
                case "user":
                    id = DatabaseHelper.GetUserDetailsIdByName(itemName);
                    break;
                case "application":
                    id = DatabaseHelper.GetApplicationDetailsIdByName(itemName);
                    break;
                case "mailbox":
                    id = DatabaseHelper.GetMailboxDetailsIdByName(itemName);
                    break;
                default:
                    throw new Exception($"Unknown list type: {listName}");
            }

            OpenItemDetailsById(listName, id);
        }

        [When(@"User navigates to the '(.*)' details page for the item with '(.*)' ID")]
        public void WhenUserNavigatesToTheDetailsPageForItemWithId(string listName, string id)
        {
            listName = listName.ToLower();

            OpenItemDetailsById(listName, id);
        }

        private void OpenItemDetailsById(string listName, string id)
        {
            _driver.NowAt<BaseHeaderElement>();
            var url = $"{UrlProvider.EvergreenUrl}#/{listName}/{id}/details/{listName}";

            _driver.NavigateToUrl(url);
            _driver.WaitForDataLoading();
        }
    }
}