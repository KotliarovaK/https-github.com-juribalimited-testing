using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.ManagementConsole;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Pages.Projects
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
        }

        [When(@"User navigate to Dashworks User Site link")]
        public void WhenUserNavigateToDashworksUserSiteLink()
        {
            var page = _driver.NowAt<BaseElementsPage>();

            _driver.MouseHover(page.DashworksUserSiteLink);
            page.DashworksUserSiteLink.Click();
        }

        [When(@"User navigate to Projects link")]
        public void WhenUserNavigateToProjectsLink()
        {
            var page = _driver.NowAt<ProjectLogin>();

            _driver.MouseHover(page.ProjectsLink);
            page.ProjectsLink.Click();
        }

        [Then(@"""(.*)"" page is displayed to the user")]
        public void ThenPageIsDisplayedToTheUser(string pageName)
        {
            var page = _driver.NowAt<BaseElements>();

            _driver.WaitForTextToAppear(page.PageHeder, pageName);
            Logger.Write("Projects Home page is displayed");
        }
    }
}