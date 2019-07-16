using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
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

        [Then(@"Actions page is displayed to the User")]
        public void ThenActionsPageIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<ActionsPage>();
            Assert.IsTrue(page.CreateActionButton.Displayed(), "Actions page is not displayed");
        }
    }
}