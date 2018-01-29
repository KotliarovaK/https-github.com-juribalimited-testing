using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System;
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
                    StringAssert.Contains(devicesPage.Heading.Text.ToLower(), listPage.ToLower(),
                        "Incorrect list is displayed to user");
                    break;

                case "Users":
                    //Check Users heading is visible
                    var usersPage = _driver.NowAt<UsersPage>();
                    StringAssert.Contains(usersPage.Heading.Text.ToLower(), listPage.ToLower(),
                        "Incorrect list is displayed to user");
                    break;

                case "Applications":
                    //Check Applications heading is visible
                    var applicationsPage = _driver.NowAt<ApplicationsPage>();
                    StringAssert.Contains(applicationsPage.Heading.Text.ToLower(), listPage.ToLower(),
                        "Incorrect list is displayed to user");
                    break;

                case "Mailboxes":
                    //Check Mailboxes heading is visible
                    var mailboxesPage = _driver.NowAt<MailboxesPage>();
                    StringAssert.Contains(mailboxesPage.Heading.Text.ToLower(), listPage.ToLower(),
                        "Incorrect list is displayed to user");
                    break;

                default:
                    throw new Exception($"'{listPage}' menu item is not valid ");
            }

            Logger.Write($"'{listPage}' list is visible");
        }
    }
}