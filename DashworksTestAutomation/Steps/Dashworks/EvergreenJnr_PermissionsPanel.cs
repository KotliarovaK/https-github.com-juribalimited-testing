using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
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

        [Then(@"current user is selected as a owner of a list")]
        public void ThenCurrentUserIsSelectedAsAOwnerOfAList()
        {
            var listDetailsElement = _driver.NowAt<PermissionsElement>();
            var header = _driver.NowAt<HeaderElement>();
            Utils.Verify.AreEqual(header.UserNameDropdown.Text,
                listDetailsElement.OwnerDropdown.GetAttribute("value"),
                "Another User is selected as a owner");
        }

        [Then(@"form container is displayed to the user")]
        public void ThenFormContainerIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<PermissionsElement>();
            Utils.Verify.IsTrue(page.SharingFormContainer.Displayed(), "Form container is not loaded");
        }

        [Then(@"form container is not displayed to the user")]
        public void ThenFormContainerIsNotDisplayedToTheUser()
        {
            var page = _driver.NowAt<PermissionsElement>();
            Utils.Verify.IsFalse(page.SharingFormContainer.Displayed(), "Form container is loaded");
        }
    }
}