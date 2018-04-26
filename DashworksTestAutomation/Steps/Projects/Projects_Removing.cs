using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Projects;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Projects
{
    [Binding]
    internal class Projects_Removing : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public Projects_Removing(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"User remove ""(.*)"" Request Type")]
        public void ThenUserRemoveRequestType(string requestType)
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteRequestTypeButtonElementByName(requestType).Click();
        }

        [Then(@"User remove ""(.*)"" Category")]
        public void ThenUserRemoveCategory(string categoryName)
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteCategoryButtonElementByName(categoryName).Click();
        }

        [Then(@"User remove ""(.*)"" Stage")]
        public void ThenUserRemoveStage(string stageName)
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteStageButtonElementByName(stageName).Click();
            _driver.AcceptAlert();
        }

        [Then(@"User remove ""(.*)"" Task")]
        public void ThenUserRemoveTask(string taskName)
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteTaskButtonElementByName(taskName).Click();
            _driver.AcceptAlert();
        }

        [Then(@"User remove ""(.*)"" Team")]
        public void ThenUserRemoveTeam(string teamName)
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteTeamButtonElementByName(teamName).Click();
            page.DeleteGroupButton.Click();
            _driver.AcceptAlert();
        }

        [Then(@"User remove ""(.*)"" Group")]
        public void ThenUserRemoveGroup(string groupName)
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteGroupButtonElementByName(groupName).Click();
            page.DeleteGroupButton.Click();
            _driver.AcceptAlert();
        }

        [Then(@"User remove ""(.*)"" Mail Templates")]
        public void ThenUserRemoveMailTemplates(string templateName)
        {
            var page = _driver.NowAt<BaseElements>();

            page.GetDeleteTemplateButtonElementByName(templateName).Click();
            _driver.AcceptAlert();
        }

        [Then(@"User remove Project")]
        public void ThenUserRemoveProject()
        {
            var page = _driver.NowAt<BaseElements>();

            page.DeleteProjectButton.Click();
            _driver.AcceptAlert();
            page.ConfirmDeletedTheProjectButton.Click();
            _driver.AcceptAlert();
        }
    }
}