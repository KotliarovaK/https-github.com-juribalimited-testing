using System;
using System.Linq;
using System.Net;
using System.Threading;
using DashworksTestAutomation.DTO.Evergreen.Admin.Automations;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Automations;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using DashworksTestAutomation.Providers;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Automations
{
    [Binding]
    internal class CreateAutomation : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly Automation _automation;
        private readonly RestWebClient _client;

        public CreateAutomation(RemoteWebDriver driver, RestWebClient client, Automation automation)
        {
            _driver = driver;
            _client = client;
            _automation = automation;
        }

        [Then(@"Create Automation page is displayed to the User")]
        public void ThenCreateAutomationPageIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<CreateAutomationsPage>();
            Assert.IsTrue(page.CreateAutomationsTitle.Displayed());
            Assert.IsTrue(page.AutomationNameField.Displayed(), "Create Automation page is not displayed");
        }

        [When(@"User creates new Automation Unit via API")]
        public void WhenUserCreatesNewAutomationUnitViaAPI(Table table)
        {
            var automations = table.CreateSet<AutomationsDto>();

            if (automations == null || !automations.Any())
                throw new Exception("Automation table is not set");

            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/automation";

            foreach (var automation in automations)
            {
                if (string.IsNullOrEmpty(automation.AutomationName))
                    throw new Exception("Unable to create Automation with empty name");

                var request = new RestRequest(requestUri);

                request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
                request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
                request.AddParameter("Referer", UrlProvider.EvergreenUrl);
                request.AddParameter("objectId", null);

                request.AddParameter("active", automation.Active);
                request.AddParameter("automationId", automation.AutomationId);
                request.AddParameter("automationName", automation.AutomationName);
                request.AddParameter("automationScheduleTypeId", GetScheduleTypeId(automation.Run));
                request.AddParameter("automationSqlAgentJobId", automation.AutomationSqlAgentJobId);
                request.AddParameter("description", automation.Description);
                request.AddParameter("listId", GetListId(automation.Scope));
                request.AddParameter("objectTypeId", GetObjectTypeId(automation.Scope));
                request.AddParameter("stopOnFailedAction", automation.StopOnFailedAction);

                var response = _client.Value.Post(request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception($"Automation with {automation.AutomationName} name was not created via api: {response.ErrorMessage}");
                }

                _automation.Value.Add(automation);
            }
        }

        private string GetScheduleTypeId(string runType)
        {
            if (runType.Equals("Manual"))
                return "1";
            if (runType.Equals("After Transform"))
                return "2";
            if (runType.Equals("Dashworks Daily"))
                return "3";
            return "NOT FOUND";
        }

        private string GetListId(string listName)
        {
            if (listName.Equals("All Devices") || listName.Equals("All Users") || listName.Equals("All Mailboxes") || listName.Equals("All Mailboxes"))
                return "-1";
            else
            {
                GetProjectListIdScope(listName);
            }
            return "NOT FOUND";
        }

        private string GetObjectTypeId(string scope)
        {
            if (scope.Equals("All Devices"))
                return "2";
            if (scope.Equals("All Users"))
                return "1";
            if (scope.Equals("All Mailboxes"))
                return "4";
            if (scope.Equals("All Applications"))
                return "3";
            return "NOT FOUND";
        }

        private string GetProjectListIdScope(string listName)
        {
            return DatabaseHelper.ExecuteReader(
                $"select [ListId] from [DesktopBI].[dbo].[EvergreenList] where [ListName]='{listName}'", 0).LastOrDefault();
        }
    }
}