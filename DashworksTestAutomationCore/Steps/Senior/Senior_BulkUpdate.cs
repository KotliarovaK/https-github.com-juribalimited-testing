using System.Linq;
using AutomationUtils.Extensions;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.BulkUpdatePage;
using DashworksTestAutomation.Pages.Projects;
using DashworksTestAutomation.Pages.Senior;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation
{
    [Binding]
    internal class Projects_BulkUpdate : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public Projects_BulkUpdate(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User navigates to ""(.*)"" page on Senior")]
        public void WhenUserNavigateToBulkUpdate(string subMenu)
        {
            var menu = _driver.NowAt<SeniorProjectsBaseElements>();
            _driver.MouseHover(menu.ActionsTab);
            _driver.MouseHover(menu.GetSubTabByName(subMenu));
            menu.GetSubTabByName(subMenu).Click();
        }

        [When(@"User selects ""(.*)"" project for Bulk Update")]
        public void WhenSelectProjectForBulkUpdate (string project)
        {
            var page = _driver.NowAt<BulkUpdatePage>();
            _driver.WaitForDataLoadingOnProjects();
            page.Project.SelectboxSelect(project);
        }

        [When(@"User selects ""(.*)"" object type for Bulk Update")]
        public void WhenSelectObjectTypeForBulkUpdate(string objectType)
        {
            var page = _driver.NowAt<BulkUpdatePage>();
            _driver.WaitForDataLoadingOnProjects();
            page.ObjectType.SelectboxSelect(objectType);
        }

        [Then(@"Bulk Update Type dropdown has ""(.*)"" option")]
        public void WhenUserChecksThatOptionExistsInBulkUpdateTypeDropdown(string option)
        {
            var page = _driver.NowAt<BulkUpdatePage>();
            _driver.WaitForDataLoadingOnProjects();
            Verify.That(page.BulkUpdateTypeOptions.Any(x => x.Text.Equals(option)), Is.True, "Option was not found in list");
        }
    }
}