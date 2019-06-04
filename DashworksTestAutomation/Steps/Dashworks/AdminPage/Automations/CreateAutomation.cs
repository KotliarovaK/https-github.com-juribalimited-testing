using System;
using System.Linq;
using System.Net;
using System.Threading;
using DashworksTestAutomation.DTO.Evergreen.Admin.Automations;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
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

        //[When(@"User creates new Automation Unit via API")]
        //public void WhenUserCreatesNewAutomationUnitViaAPI(Table table)
        //{
        //    var automations = table.CreateSet<AutomationsDto>();

        //    if (automations == null || !automations.Any())
        //        throw new Exception("Automation table is not set");

        //    var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/capacityUnits/createCapacityUnit";

        //    foreach (var automation in automations)
        //    {
        //        if (string.IsNullOrEmpty(automation.Name))
        //            throw new Exception("Unable to create Automation with empty name");

        //        var request = new RestRequest(requestUri);

        //        request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
        //        request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
        //        request.AddParameter("Referer", UrlProvider.EvergreenUrl);
        //        request.AddParameter("objectId", null);
        //        request.AddParameter("automationName", automation.Name);
        //        request.AddParameter("description", automation.Description);
        //        request.AddParameter("stopOnFailedAction", automation.StopOnFailedAction);
        //        request.AddParameter("active", automation.Active);
        //        request.AddParameter("automationScheduleTypeId", GetRunType(automation.Run));
        //        request.AddParameter("listId", );

        //        var response = _client.Value.Post(request);

        //        if (response.StatusCode != HttpStatusCode.OK)
        //        {
        //            throw new Exception($"Automation with {automation.Name} name was not created via api: {response.ErrorMessage}");
        //        }

        //        _automation.Value.Add(automation);
        //    }
        //}

        //private string GetRunType(string runType)
        //{
        //    string[] subMenus = { "Manual", "After Transform", "Dashworks Daily" };
        //}

        //private string GetScheduleTypeId(string runType)
        //{
        //    if (runType.Equals("Manual"))
        //        return "1";
        //    if (runType.Equals("After Transform"))
        //        return "2";
        //    if (runType.Equals("Dashworks Daily"))
        //        return "3";
        //    return "NOT FOUND";
        //}
    }
}