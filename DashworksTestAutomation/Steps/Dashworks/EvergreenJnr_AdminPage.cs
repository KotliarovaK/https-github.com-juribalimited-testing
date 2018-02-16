using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Pages.Evergreen.AdminPages;
using DashworksTestAutomation.Utils;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_AdminPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_AdminPage(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User click ""(.*)"" link on the Admin page")]
        public void WhenUserClickLinkOnTheAdminPage(string adminLinks)
        {
            var menu = _driver.NowAt<AdminPage>();

            switch (adminLinks)
            {
                case "Projects":
                    menu.Projects.Click();
                    break;

                case "Teams":
                    menu.Teams.Click();
                    break;

                case "Buckets":
                    menu.Buckets.Click();
                    break;

                default:
                    throw new Exception($"'{adminLinks}' link is not valid menu item and can not be opened");
            }
            Logger.Write($"{adminLinks} left-hand menu was clicked");
        }

        [Then(@"""(.*)"" page should be displayed to the user")]
        public void ThenPageShouldBeDisplayedToTheUser(string adminLinks)
        {
            switch (adminLinks)
            {
                case "Projects":
                    var projectsPage = _driver.NowAt<AdminPage>();
                    StringAssert.Contains(projectsPage.ProjectsPage.Text.ToLower(), adminLinks.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Teams":
                    var teamsPage = _driver.NowAt<AdminPage>();
                    StringAssert.Contains(teamsPage.TeamsPage.Text.ToLower(), adminLinks.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                case "Buckets":
                    var bucketsPage = _driver.NowAt<AdminPage>();
                    StringAssert.Contains(bucketsPage.BucketsPage.Text.ToLower(), adminLinks.ToLower(),
                        "Incorrect page is displayed to user");
                    break;

                default:
                    throw new Exception($"'{adminLinks}' menu item is not valid ");
            }
            Logger.Write($"'{adminLinks}' page is visible");
        }

        [When(@"User clicks Create Team button")]
        public void WhenUserClicksCreateTeamButton()
        {
            var page = _driver.NowAt<AdminPage>();
            _driver.WaitWhileControlIsNotDisplayed<AdminPage>(() => page.CreateTeamButton);
            page.CreateTeamButton.Click();
            Logger.Write("Create Team button was clicked");
        }

        [Then(@"Create Team page should be displayed to the user")]
        public void ThenCreateTeamPageShouldBeDisplayedToTheUser()
        {
            var page = _driver.NowAt<AdminPage>();
            Assert.IsTrue(filterElement.FiltersPanel.Displayed(), "Actions panel was not displayed");
            Logger.Write("Actions Panel panel is visible");
        }


    }

}