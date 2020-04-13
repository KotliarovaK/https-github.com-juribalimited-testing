using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.Evergreen.Admin.Rings;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Rings
{
    [Binding]

    public class CreateRingViaApi : SpecFlowContext
    {
        private readonly DTO.RuntimeVariables.Rings.Rings _rings;
        private readonly RestWebClient _client;

        private CreateRingViaApi(DTO.RuntimeVariables.Rings.Rings rings, RestWebClient client)
        {
            _rings = rings;
            _client = client;
        }

        //| Name | Description | IsDefault | Project |
        [When(@"User creates new Ring via api")]
        public void WhenUserCreatesNewRingViaApi(Table table)
        {
            var rings = table.CreateSet<RingDto>();

            if (rings == null || !rings.Any())
                throw new Exception("Rings table is not set");

            if (rings.Count(x => x.IsDefault) > 1)
                throw new Exception("More that one Ring was set to default");

            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/ring/createRing";

            foreach (var ring in rings)
            {
                if (string.IsNullOrEmpty(ring.Name))
                    throw new Exception("Unable to create Ring with empty name");

                var request = requestUri.GenerateRequest();
                request.AddParameter("name", ring.Name);
                request.AddParameter("description", ring.Description);
                request.AddParameter("isDefault", ring.IsDefault);
                if (!string.IsNullOrEmpty(ring.Project))
                {
                    request.AddParameter("mapsToEvergreenUnit", "-1");
                    request.AddParameter("projectId", DatabaseHelper.GetProjectId(ring.Project));
                }

                var response = _client.Evergreen.Post(request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception(
                        $"Ring with '{ring.Name}' name was not created via api: {response.ErrorMessage}");
                }

                _rings.Value.Add(ring);
            }
        }
    }
}