using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AutomationUtils.Extensions;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using TechTalk.SpecFlow;
using DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.AfterScenarios;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.Settings
{
    [Binding]
    class SettingsApi : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private SelfServiceApiMethods _SelfServiceApiMethods;

        public SettingsApi(RestWebClient client, SelfServiceApiMethods ssApiMethods)
        {
            _client = client;
            _SelfServiceApiMethods = ssApiMethods;
        }

        [Then(@"self service base url is equals to '(.*)'")]
        public void ThenSelfServiceBaseUrlIsEqualsTo(string url)
        {
            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/selfservicesettings/baseurl";
            var request = requestUri.GenerateRequest();

            var response = _client.Evergreen.Get(request);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception(
                    $"Unable to get Self Service Base URL. Error details: {JsonConvert.DeserializeObject<JObject>(response.Content)["message"]}");
            }

            string ssBaseUrl = response.Content.ReadJsonProperty("settingValue");

            Verify.AreEqual(url, ssBaseUrl, "Self Service Base URL is incorrect");
        }

        [When(@"User sets self service base url as '(.*)'")]
        public void WhenUserSetsSelfServiceBaseUrlAs(string url)
        {
            _SelfServiceApiMethods.SetBaseUrl(url);
        }
    }
}
