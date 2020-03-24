using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_PermissionsPanel : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly UsersWithSharedLists _usersWithSharedLists;

        public EvergreenJnr_PermissionsPanel(RemoteWebDriver driver, UsersWithSharedLists usersWithSharedLists)
        {
            _driver = driver;
            _usersWithSharedLists = usersWithSharedLists;
        }

        [Then(@"current user is selected in '(.*)' autocomplete")]
        public void ThenCurrentUserIsSelectedInAutocomplete(string dropdown)
        {
            var header = _driver.NowAt<HeaderElement>();
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.AreEqual(header.UserNameDropdown.Text, page.GetTextbox(dropdown).GetAttribute("value"),
                "Invalid user selected as owner");
        }

        [Then(@"form container is displayed to the user")]
        public void ThenFormContainerIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<PermissionsElement>();
            Verify.IsTrue(page.SharingFormContainer.Displayed(), "Form container is not loaded");
        }

        [Then(@"form container is not displayed to the user")]
        public void ThenFormContainerIsNotDisplayedToTheUser()
        {
            var page = _driver.NowAt<PermissionsElement>();
            Verify.IsFalse(page.SharingFormContainer.Displayed(), "Form container is loaded");
        }

        [Then(@"""(.*)"" Sharing user is displayed correctly")]
        public void ThenSharingUserIsDisplayedCorrectly(string userName)
        {
            var page = _driver.NowAt<PermissionsElement>();
            Verify.IsTrue(page.GetSharingUserOnDetailsPanelByName(userName).Displayed(),
                "Selected Sharing user is not displayed on Details panel");
        }

        [Then(@"User list for sharing is not displayed")]
        public void ThenUserListForSharingIsNotDisplayed()
        {
            var page = _driver.NowAt<PermissionsElement>();
            Verify.IsFalse(page.SharingUserList.Displayed(), "User list for sharing is displayed");
        }
    }
}