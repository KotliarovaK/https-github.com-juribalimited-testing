using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
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