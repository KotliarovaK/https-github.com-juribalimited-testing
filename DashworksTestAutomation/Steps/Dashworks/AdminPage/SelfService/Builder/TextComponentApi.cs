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
using Newtonsoft.Json;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.Builder
{
    [Binding]
    class TextComponentApi : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private readonly SelfServicePages _selfServicePages;
        private readonly SelfServiceTextComponents _selfServiceTextComponents;

        public TextComponentApi(RestWebClient client, SelfServicePages selfServicePages, SelfServiceTextComponents selfServiceTextComponents)
        {
            _client = client;
            _selfServicePages = selfServicePages;
            _selfServiceTextComponents = selfServiceTextComponents;
        }

        [When(@"User creates new text component for '(.*)' Self Service page via API")]
        public void WhenUserCreatesNewTextComponentForSelfServicePage(string ssPageName, Table table)
        {
            if (!_selfServicePages.Value.Any(x => x.Name.Equals(ssPageName)))
            {
                throw new Exception("Unable to find created Self Service in the context");
            }

            var ssPage = _selfServicePages.Value.First(x => x.Name.Equals(ssPageName));

            var textComponents = table.CreateSet<SelfServiceTextComponent>();

            foreach (SelfServiceTextComponent component in textComponents)
            {
                component.PageId = ssPage.PageId;

                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/selfservicecomponents";
                var request = requestUri.GenerateRequest();
                request.AddJsonBody(component);

                var response = _client.Evergreen.Post(request);

                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    throw new Exception($"Unable to create Self Service Text Component: {response.StatusCode}, {response.ErrorMessage}");
                }

                var content = response.Content;
                var createdTextComponent = JsonConvert.DeserializeObject<SelfServiceTextComponent>(content);
                component.ComponentId = createdTextComponent.ComponentId;
                component.Order = createdTextComponent.Order;
                component.ComponentTypeId = createdTextComponent.ComponentTypeId;

                //Assign created component back to the page
                _selfServicePages.Value.First(x => x.Name.Equals(ssPageName)).Components.Add(component);
            }
        }
    }
}
