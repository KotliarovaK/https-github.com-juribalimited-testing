using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using Newtonsoft.Json;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.Builder
{
    [Binding]
    class SsBuilderPageApi : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private readonly SelfServicePages _selfServicePages;

        public SsBuilderPageApi(RestWebClient client, SelfServicePages selfServicePages)
        {
            _client = client;
            _selfServicePages = selfServicePages;
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

            var content = response.Content;
            var createdSsPage = JsonConvert.DeserializeObject<SelfServicePageDto>(content);
            createdSsPage.ServiceIdentifier = ssPage.ServiceIdentifier;

            _selfServicePages.Value.Add(createdSsPage);
        }

        [When(@"User updates '(.*)' Self Service Page via API")]
        public void WhenUserUpdatesSelfServicePageViaAPI(string name, Table table)
        {
            var ssPage = table.CreateInstance<SelfServicePageDto>();

            var prevSsPage = _selfServicePages.Value
                .First(x => x.Name.Equals(name) && x.ServiceIdentifier.Equals(ssPage.ServiceIdentifier));
            ssPage.PageId = prevSsPage.PageId;

            var requestUri =
                $"{UrlProvider.RestClientBaseUrl}admin/selfservicepages/{ssPage.PageId}";

            var request = requestUri.GenerateRequest();

            request.AddObject(ssPage);

            var response = _client.Evergreen.Put(request);

            if (!response.StatusCode.Equals(HttpStatusCode.OK))
            {
                throw new Exception($"ADD EXCEPTION HERE: {response.StatusCode}, {response.ErrorMessage}");
            }

            var content = response.Content;
            var updatedPage = JsonConvert.DeserializeObject<SelfServicePageDto>(content);

            _selfServicePages.Value.Remove(_selfServicePages.Value.First(x =>
                x.Name.Equals(prevSsPage.Name) && x.ServiceIdentifier.Equals(ssPage.ServiceIdentifier)));
            updatedPage.ServiceIdentifier = prevSsPage.ServiceIdentifier;

            _selfServicePages.Value.Add(updatedPage);
        }

        [When(@"User deletes '(.*)' Self Service Page with '(.*)' dentifier via API")]
        public void WhenUserDeletesSelfServicePageWithDentifierViaAPI(string name, string serviceIdentifier)
        {
            var ssPage = _selfServicePages.Value
                .First(x => x.Name.Equals(name) && x.ServiceIdentifier.Equals(serviceIdentifier));

            var requestUri =
                $"{UrlProvider.RestClientBaseUrl}admin/selfservicepages/{ssPage.PageId}";

            var request = requestUri.GenerateRequest();

            var response = _client.Evergreen.Delete(request);

            if (!response.StatusCode.Equals(HttpStatusCode.Accepted))
            {
                throw new Exception($"ADD EXCEPTION HERE: {response.StatusCode}, {response.ErrorMessage}");
            }
        }
    }
}
