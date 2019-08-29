using System;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_MenuNavigation : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_MenuNavigation(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks ""(.*)"" on the left-hand menu")]
        public void WhenUserClicksOnTheLeft_HandMenu(string listPage)
        {
            var menu = _driver.NowAt<LeftHandMenuElement>();

            switch (listPage)
            {
                case "Dashboards":
                    menu.Dashboards.Click();
                    break;

                case "Devices":
                    menu.Devices.Click();
                    break;

                case "Users":
                    menu.Users.Click();
                    break;

                case "Applications":
                    menu.Applications.Click();
                    break;

                case "Mailboxes":
                    menu.Mailboxes.Click();
                    break;

                case "Projects":
                    menu.Projects.Click();
                    break;

                case "Admin":
                    menu.Admin.Click();
                    break;

                default:
                    throw new Exception($"'{listPage}' menu name is not valid menu item and can not be opened");
            }

            Logger.Write($"{listPage} left-hand menu was clicked");
        }

        [When(@"User quickly navigate to ""(.*)"" on the left-hand menu")]
        public void WhenUserQuicklyNavigateToOnTheLeft_HandMenu(string listPage)
        {
            var menu = _driver.NowAtWithoutWait<LeftHandMenuElement>();

            switch (listPage)
            {
                case "Devices":
                    menu.Devices.Click();
                    break;

                case "Users":
                    menu.Users.Click();
                    break;

                case "Applications":
                    menu.Applications.Click();
                    break;

                case "Mailboxes":
                    menu.Mailboxes.Click();
                    break;

                case "Admin":
                    menu.Admin.Click();
                    break;

                default:
                    throw new Exception($"'{listPage}' menu name is not valid menu item and can not be opened");
            }

            Logger.Write($"{listPage} left-hand menu was clicked");
        }

        [Then(@"""(.*)"" list should be displayed to the user")]
        public void ThenListShouldBeDisplayedToTheUser(string listPage)
        {
            switch (listPage)
            {
                case "Devices":
                    //Check Devices heading is visible
                    var devicesPage = _driver.NowAt<DevicesPage>();
                    Verify.AreEqual(listPage.ToLower(), devicesPage.Heading.Text.ToLower(),
                        "Incorrect list is displayed to user");
                    break;

                case "Users":
                    //Check Users heading is visible
                    var usersPage = _driver.NowAt<UsersPage>();
                    Verify.AreEqual(listPage.ToLower(), usersPage.Heading.Text.ToLower(),
                        "Incorrect list is displayed to user");
                    break;

                case "Applications":
                    //Check Applications heading is visible
                    var applicationsPage = _driver.NowAt<ApplicationsPage>();
                    Verify.AreEqual(listPage.ToLower(), applicationsPage.Heading.Text.ToLower(),
                        "Incorrect list is displayed to user");
                    break;

                case "Mailboxes":
                    //Check Mailboxes heading is visible
                    var mailboxesPage = _driver.NowAt<MailboxesPage>();
                    Verify.AreEqual(listPage.ToLower(), mailboxesPage.Heading.Text.ToLower(),
                        "Incorrect list is displayed to user");
                    break;

                case "Admin":
                    //Check Admin heading is visible
                    var adminPage = _driver.NowAt<Pages.Evergreen.AdminPage>();
                    Verify.AreEqual(listPage.ToLower(), adminPage.Heading.Text.ToLower(),
                        "Incorrect list is displayed to user");
                    break;

                default:
                    throw new Exception($"'{listPage}' menu item is not valid ");
            }

            Logger.Write($"'{listPage}' list is visible");
        }

        [When(@"User clicks Admin on the left-hand menu")]
        public void WhenUserClicksAdminOnTheLeft_HandMenu()
        {
            var menu = _driver.NowAt<LeftHandMenuElement>();
            menu.Admin.Click();
        }

        [Then(@"Admin page should be displayed to the user")]
        public void ThenAdminPageShouldBeDisplayedToTheUser()
        {
            var page = _driver.NowAt<AdminLeftHandMenu>();
            Verify.IsTrue(_driver.IsElementExists(page.AdminSubMenu), "Admin page was not displayed");
            if (!page.AdminSubMenu.Displayed())
                page.ExpandSidePanelIcon.Click();
        }

        [Then(@"Update Readiness is displayed to the User")]
        public void ThenUpdateReadinessIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<UpdateReadinessPage>();
            Verify.IsTrue(page.UpdateReadinessTitle.Displayed(), "Update Readiness page was not displayed");
            Logger.Write("Update Readiness page is visible");
        }

        [Then(@"Admin menu item is hidden")]
        public void ThenAdminMenuItemIsHidden()
        {
            var menu = _driver.NowAtWithoutWait<LeftHandMenuElement>();
            Verify.IsFalse(menu.Admin.Displayed(), "Admin menu item is displayed");
        }

        [When(@"User navigates to ""(.*)"" Object on PMObject page")]
        public void WhenUserNavigatesToObjectOnPMObjectPage(int objectId)
        {
            _driver.NavigateToUrl($"{UrlProvider.Url}PMObject.aspx?ObjectId={objectId}");
            Logger.Write("PMObject page was loaded");
        }

        [When(@"User closes Toggle Menu")]
        [When(@"User closes left-hand menu")]
        [When(@"User opens Toggle Menu")]
        [When(@"User opens left-hand menu")]
        public void WhenUserClosesLeft_HandMenu()
        {
            var menu = _driver.NowAtWithoutWait<BaseDashboardPage>();
            menu.ToggleMenu.Click();
            Logger.Write("Toggle Menu button was clicked");
        }

        [When(@"User clicks ""(.*)"" hidden left-hand menu")]
        public void WhenUserClicksHiddenLeft_HandMenu(string menuName)
        {
            var menu = _driver.NowAtWithoutWait<BaseDashboardPage>();
            menu.SelectHiddenLeftHandMenu(menuName).Click();
        }

        [Then(@"""(.*)"" left-hand menu is highlighted")]
        public void ThenLeft_HandMenuIsHighlighted(string menuName)
        {
            var menu = _driver.NowAtWithoutWait<BaseDashboardPage>();
            Utils.Verify.AreEqual(menu.GetHighlightedLeftMenuByName(menuName).GetCssValue("color"),
                "rgba(242, 88, 49, 1)", "PLEASE ADD EXCEPTION MESSAGE");
            Utils.Verify.IsTrue(menu.GetHighlightedLeftMenuByName(menuName).Displayed(), $"");
        }
    }
}