using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Automations;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
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

        [When(@"User moves ""(.*)"" action to ""(.*)"" action")]
        public void WhenUserMovesActionToAction(string actionFrom, string actionTo)
        {
            var page = _driver.NowAt<ActionsPage>();
            _driver.WaitForElementToBeNotDisplayed(page.ActionsTableContent);
            var action1 = page.GetMoveButtonByActionName(actionFrom);
            var action2 = page.GetMoveButtonByActionName(actionTo);
            _driver.DragAndDrop(action1, action2);
        }

        [When(@"User selects ""(.*)"" in the ""(.*)"" dropdown for Actions")]
        public void WhenUserSelectsInTheDropdownForActions(string item, string dropdownName)
        {
            var page = _driver.NowAt<ActionsPage>();
            page.GetDropdownByName(dropdownName).Click();
            var dropdown = _driver.NowAt<BaseGridPage>();
            dropdown.GetDropdownValueByName(item).Click();
        }

        [When(@"User selects ""(.*)"" Value for Actions")]
        public void WhenUserSelectsValueForActions(string dropdownName)
        {
            var page = _driver.NowAt<ActionsPage>();
            page.GetSelectValueForActions(dropdownName);
        }

        [Then(@"following items are displayed in the ""(.*)"" dropdown for Actions:")]
        public void ThenFollowingItemsAreDisplayedInTheDropdownForActions(string dropDownName, Table table)
        {
            var page = _driver.NowAt<ActionsPage>();
            page.GetDropdownByName(dropDownName).Click();
            var element = _driver.NowAt<BaseDashboardPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = element.OptionListOnActionsPanel.Select(value => value.Text).ToList();
            Utils.Verify.AreEqual(expectedList, actualList, $"Value for {dropDownName} are different");
        }

        [Then(@"Actions page is displayed to the User")]
        public void ThenActionsPageIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<ActionsPage>();
            _driver.WaitForElementToBeDisplayed(page.CreateActionButton);
            Utils.Verify.IsTrue(page.CreateActionButton.Displayed(), "Actions page is not displayed");
        }
    }
}