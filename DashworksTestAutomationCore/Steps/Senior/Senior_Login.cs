using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.ManagementConsole;
using DashworksTestAutomation.Pages.Projects;
using DashworksTestAutomation.Pages.Projects.CreatingProjects;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Projects
{
    [Binding]
    internal class ProjectsLogin : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public ProjectsLogin(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User navigate to Manage link")]
        public void WhenUserNavigateToManageLink()
        {
            var page = _driver.NowAt<ManagementConsolePage>();

            _driver.MouseHover(page.ManageLink);
            page.ManageLink.Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User navigate to Dashworks User Site link")]
        public void WhenUserNavigateToDashworksUserSiteLink()
        {
            var page = _driver.NowAt<BaseElementsPage>();

            _driver.MouseHover(page.DashworksUserSiteLink);
            page.DashworksUserSiteLink.Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User navigate to Projects link")]
        public void WhenUserNavigateToProjectsLink()
        {
            var page = _driver.NowAt<ProjectLogin>();

            _driver.WaitForDataLoadingOnProjects();
            _driver.MouseHover(page.ProjectsLink);
            page.ProjectsLink.Click();
            _driver.WaitForDataLoadingOnProjects();
        }

        [When(@"User navigate to Evergreen link")]
        public void WhenUserNavigateToEvergreenLink()
        {
            var page = _driver.NowAt<ProjectLogin>();

            _driver.MouseHover(page.EvergreenLink);
            page.EvergreenLink.Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User navigate to Evergreen URL")]
        public void WhenUserNavigateToEvergreenUrl()
        {
            _driver.NavigateToUrl(UrlProvider.EvergreenUrl);
            _driver.WaitForDataLoading();
        }

        [When(@"User cliks Logout link")]
        public void WhenUserCliksLogoutLink()
        {
            var page = _driver.NowAt<BaseElementsPage>();

            _driver.MouseHover(page.LogoutLink);
            page.LogoutLink.Click();
            //TODO: Yurii T. 8 Aug 2019: commented below method closes alert and AcceptAlert() fails; remove this todo and commented wait if everything is ok
            //_driver.WaitForDataLoading();
            _driver.AcceptAlert();
        }

        [Then(@"""(.*)"" page is displayed to the user")]
        public void ThenPageIsDisplayedToTheUser(string pageName)
        {
            var page = _driver.NowAt<MainElementsOfProjectCreation>();

            _driver.WaitForElementToHaveText(page.PageHeader, pageName);
            Logger.Write("Projects Home page is displayed");
        }
    }
}