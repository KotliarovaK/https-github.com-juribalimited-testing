using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage.Resynk.BeforeScenario
{
    [Binding]
    class ResyncObject : SpecFlowContext
    {
        private readonly RestWebClient _client;

        public ResyncObject(RestWebClient client)
        {
            _client = client;
        }

        [Given(@"User resync '(.*)' objects for '(.*)' project")]
        public void GivenUserResyncObjectsForProject(string listName, string projectName, Table table)
        {
            var projId = DatabaseHelper.GetProjectId(projectName);

            foreach (string itemName in table.Rows.Select(x => x.Values.First()))
            {
                var id = DatabaseHelper.GetItemId(listName, itemName);
                var requestUri = $"{UrlProvider.RestClientBaseUrl}/{listName.ToLower()}/{id}/relinkObjects";
                var request = requestUri.GenerateRequest();
                request.AddParameter("projectId", projId);
                request.AddParameter("IsOwnerResync", true);
                request.AddParameter("IsAppsResync", true);
                request.AddParameter("IsNameResync", true);
                request.AddParameter("IsSkipRelink", true);
                request.AddParameter("objectId", id);

                var response = _client.Evergreen.Post(request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception(
                        $"Unable to resynk '{itemName}' {listName} object for '{projectName}' project: {response.StatusCode}, {response.ErrorMessage}");
                }
            }
        }
    }
}
