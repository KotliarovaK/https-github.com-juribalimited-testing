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

        [Then(@"Permissions panel is displayed to the user")]
        public void ThenPermissionsPanelIsDisplayedToTheUser()
        {
            var listDetailsElement = _driver.NowAt<PermissionsElement>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(listDetailsElement.PermissionsPanel);
            Utils.Verify.IsTrue(listDetailsElement.PermissionsPanel.Displayed(), "Permissions panel is not displayed");
        }

        [When(@"User select ""(.*)"" sharing option")]
        public void WhenUserSelectSharingOption(string sharingOption)
        {
            var listDetailsElement = _driver.NowAt<PermissionsElement>();
            _driver.WaitForDataLoading();
            _driver.SelectCustomSelectbox(listDetailsElement.SharingDropdown, sharingOption);
            _driver.WaitForDataLoading();
        }

        [When(@"User select ""(.*)"" as a Owner of a list")]
        public void WhenUserSelectAsAOwnerOfAList(string ownerOption)
        {
            //Save user to remove its lists after test execution
            _usersWithSharedLists.Value.Add(DatabaseWorker.GetUserNameByFullName(ownerOption));
            var listDetailsElement = _driver.NowAt<PermissionsElement>();
            listDetailsElement.OwnerDropdown.ClearWithBackspaces();
            _driver.SelectCustomSelectbox(listDetailsElement.OwnerDropdown, ownerOption);
            _driver.WaitForDataLoading();
        }

        [When(@"User clears Owner field on List Details panel")]
        public void WhenUserClearsOwnerFieldOnListDetailsPanel()
        {
            var listDetailsElement = _driver.NowAt<PermissionsElement>();
            listDetailsElement.OwnerDropdown.Clear();
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

        [Then(@"""(.*)"" sharing option is selected")]
        public void ThenSharingOptionIsSelected(string sharingOption)
        {
            var listDetailsElement = _driver.NowAt<PermissionsElement>();
            _driver.WaitForDataLoading();
            Utils.Verify.AreEqual(sharingOption, listDetailsElement.GetSelectedValue(listDetailsElement.SharingDropdown),
                $"Selected option is not {sharingOption}");
        }

    }
}