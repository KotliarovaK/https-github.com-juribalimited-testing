using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using Newtonsoft.Json;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder.Components;

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

        [When(@"User creates new Self Service Page via API")]
        public void WhenUserCreatesNewSelfServicePageCiaAPI(Table table)
        {
            var ssPages = table.CreateSet<SelfServicePageDto>();

            foreach (SelfServicePageDto ssPage in ssPages)
            {
                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/selfservicepages";
                var request = requestUri.GenerateRequest();

                request.AddObject(ssPage);

                var response = _client.Evergreen.Post(request);

                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    throw new Exception($"Unable to create Self Service: {response.StatusCode}, {response.ErrorMessage}");
                }

                var content = response.Content;
                var createdSsPage = JsonConvert.DeserializeObject<SelfServicePageDto>(content);
                createdSsPage.ServiceIdentifier = ssPage.ServiceIdentifier;

                _selfServicePages.Value.Add(createdSsPage);
            }
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
                throw new Exception($"Unable to update {name} Self Service: {response.StatusCode}, {response.ErrorMessage}");
            }

            var content = response.Content;
            var updatedPage = JsonConvert.DeserializeObject<SelfServicePageDto>(content);

            _selfServicePages.Value.Remove(_selfServicePages.Value.First(x =>
                x.Name.Equals(prevSsPage.Name) && x.ServiceIdentifier.Equals(ssPage.ServiceIdentifier)));
            updatedPage.ServiceIdentifier = prevSsPage.ServiceIdentifier;

            _selfServicePages.Value.Add(updatedPage);
        }

        [When(@"User deletes '(.*)' Self Service Page with '(.*)' identifier via API")]
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
                throw new Exception($"Unable to delete {name} Self Service with {serviceIdentifier} identifier: {response.StatusCode}, {response.ErrorMessage}");
            }
        }

        [Then(@"Self Service Page with below data is created")]
        public void ThenSelfServicePageWithBelowDataIsCreated(Table table)
        {
            var ssPage = table.CreateInstance<SelfServicePageDto>();

            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/selfservices/{ssPage.ServiceId}/pages";
            var request = requestUri.GenerateRequest();

            var response = _client.Evergreen.Get(request);

            if (!response.StatusCode.Equals(HttpStatusCode.OK))
            {
                throw new Exception($"Unable to get Self Service: {response.StatusCode}, {response.ErrorMessage}");
            }

            var content = response.Content;

            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new SelfServiceComponentConverter());

            var createdSsPage = JsonConvert.DeserializeObject<List<SelfServicePageDto>>(content, settings).Last();

            Verify.AreEqual(ssPage.Name, createdSsPage.Name, $"Self Service name should be {ssPage.Name} but it is {createdSsPage.Name}");
            Verify.AreEqual(ssPage.DisplayName, createdSsPage.DisplayName, $"Self Service display name should be {ssPage.DisplayName} but it is {createdSsPage.DisplayName}");
            Verify.AreEqual(ssPage.ShowInSelfService, createdSsPage.ShowInSelfService, $"Self Service checkbox's state should be {ssPage.ShowInSelfService} but it is {createdSsPage.ShowInSelfService}");
        }

        [Then(@"'(.*)' Self Service does not contains any pages")]
        public void ThenSelfServiceDoesNotContainsAnyPages(string serviceIdentifier)
        {
            var ss = new SelfServiceDto() { ServiceIdentifier = serviceIdentifier };

            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/selfservices/{ss.ServiceId}/pages";
            var request = requestUri.GenerateRequest();

            var response = _client.Evergreen.Get(request);

            if (!response.StatusCode.Equals(HttpStatusCode.OK))
            {
                throw new Exception($"Unable to get the Self Service pages: {response.StatusCode}, {response.ErrorMessage}");
            }

            var content = response.Content;

            Verify.AreEqual("[]", content, $"Self Service shouldn't contain any pages, but it contains the following: {content}");
        }

        [Then(@"'(.*)' Self Service does not contain '(.*)' page")]
        public void ThenSelfServiceDoesNotContainsPage(string serviceIdentifier, string pageName)
        {
            var ss = new SelfServiceDto() { ServiceIdentifier = serviceIdentifier };

            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/selfservices/{ss.ServiceId}/pages";
            var request = requestUri.GenerateRequest();

            var response = _client.Evergreen.Get(request);

            if (!response.StatusCode.Equals(HttpStatusCode.OK))
            {
                throw new Exception($"Unable to get the Self Service pages: {response.StatusCode}, {response.ErrorMessage}");
            }

            var content = response.Content;

            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new SelfServiceComponentConverter());

            bool isThePageExist = JsonConvert.DeserializeObject<List<SelfServicePageDto>>(content, settings).Any(x => x.Name.Equals(pageName));

            Verify.IsFalse(isThePageExist, $"Self Service '{serviceIdentifier}' shouldn't contain '{pageName}' page");
        }
    }
}
