using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage
{
    [Binding]

    class EvergreenJnr_ItemDetailsPage_ActionsPanel : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ItemDetailsPage_ActionsPanel (RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Actions drop-down is displayed on the Item Details page")]
        public void ThenActionsDrop_DownIsDisplayedOnTheItemDetailsPage()
        {
            var actionPanel = _driver.NowAt<ActionPanelPage>();
            Utils.Verify.IsTrue(actionPanel.ActionsDropDown.Displayed, "Actions drop-down is not displayed!");
        }

        //TODO move to ActionPanel
        [When(@"User clicks Actions button on the Item Details page")]
        public void WhenUserClicksActionsButtonOnTheItemDetailsPage()
        {
            var actionPanel = _driver.NowAt<ActionPanelPage>();
            actionPanel.ActionsDropDown.Click();
        }

        [When(@"User clicks ""(.*)"" button in Actions drop-down on the Item Details page")]
        public void WhenUserClicksButtonInActionsDrop_DownOnTheItemDetailsPage(string actinonButton)
        {
            var actionPanel = _driver.NowAt<ActionPanelPage>();
            actionPanel.GetActionButtonByName(actinonButton).Click();
        }
    }
}