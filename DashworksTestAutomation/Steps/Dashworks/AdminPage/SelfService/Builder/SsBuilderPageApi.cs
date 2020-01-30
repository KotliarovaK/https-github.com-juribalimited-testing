using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.Builder
{
    [Binding]
    class SsBuilderPageApi : SpecFlowContext
    {
        private readonly RestWebClient _client;

        public SsBuilderPageApi(RestWebClient client)
        {
            _client = client;
        }

        [When(@"User creates new Self Service Page cia API")]
        public void WhenUserCreatesNewSelfServicePageCiaAPI(Table table)
        {
            var ssPage = table.CreateInstance<SelfServicePageDto>();

            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/selfservicepages";
            var request = requestUri.GenerateRequest();

            request.AddObject(ssPage);

            var response = _client.Evergreen.Post(request);

            if (!response.StatusCode.Equals(HttpStatusCode.OK))
            {
                throw new Exception($"ADD EXCEPTION HERE: {response.StatusCode}, {response.ErrorMessage}");
            }
        }
    }
}
