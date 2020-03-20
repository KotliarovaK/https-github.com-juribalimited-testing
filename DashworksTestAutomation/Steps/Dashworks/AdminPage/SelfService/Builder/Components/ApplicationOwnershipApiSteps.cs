using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder.Components;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.Builder.Components
{
    [Binding]
    class ApplicationOwnershipApiSteps : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private readonly SelfServicePages _selfServicePages;

        public ApplicationOwnershipApiSteps(RestWebClient client, SelfServicePages selfServicePages)
        {
            _client = client;
            _selfServicePages = selfServicePages;
        }

        [When(@"User creates new application ownership component for '(.*)' Self Service page via API")]
        public void WhenUserCreatesNewApplicationOwnershipComponentForSelfServicePageViaAPI(string ssPageName, Table table)
        {
            var component = table.CreateInstance<SelfServiceApplicationOwnershipComponent>();

            if (!_selfServicePages.Value.Any(x => x.Name.Equals(ssPageName)))
            {
                throw new Exception("Unable to find created Self Service in the context");
            }

            var ssPage = _selfServicePages.Value.First(x => x.Name.Equals(ssPageName));
            component.SelfServicePage = ssPage;

            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/selfservicecomponents";
            var request = requestUri.GenerateRequest();
            request.AddJsonBody(component);

            var response = _client.Evergreen.Post(request);

            if (!response.StatusCode.Equals(HttpStatusCode.OK))
            {
                throw new Exception($"Unable to create Self Service Application Ownership component: {response.StatusCode}, {response.ErrorMessage}");
            }

            //Assign created component back to the page
            _selfServicePages.Value.First(x => x.Name.Equals(ssPageName)).Components.Add(component);
        }
    }
}
