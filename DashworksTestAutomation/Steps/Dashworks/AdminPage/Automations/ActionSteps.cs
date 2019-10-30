using System;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Automations;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Automations
{
    [Binding]
    internal class ActionSteps : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public ActionSteps(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User selects ""(.*)"" Value for Actions")]
        public void WhenUserSelectsValueForActions(string dropdownName)
        {
           throw new Exception("DELETE THIS METHOD AND REUSE GENERIC");
        }

        [Then(@"following items are displayed in the ""(.*)"" dropdown for Actions:")]
        public void ThenFollowingItemsAreDisplayedInTheDropdownForActions(string dropDownName, Table table)
        {
            throw new Exception("DELETE THIS METHOD AND REUSE GENERIC");
            //var page = _driver.NowAt<ActionsPage>();
            //page.GetDropdownByName(dropDownName).Click();
            //var element = _driver.NowAt<BaseDashboardPage>();
            //var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            //var actualList = element.OptionListOnActionsPanel.Select(value => value.Text).ToList();
            //Verify.AreEqual(expectedList, actualList, $"Value for {dropDownName} are different");
        }
    }
}