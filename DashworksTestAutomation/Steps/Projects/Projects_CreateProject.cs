using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Projects;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Projects
{
    [Binding]
    internal class Projects_CreateProject : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public Projects_CreateProject(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User creates Project")]
        public void WhenUserCreatesProject()
        {
            var menu = _driver.NowAt<BaseProjectsElements>();
            _driver.MouseHover(menu.Administration);
            menu.CreateProject.Click();
        }
    }
}