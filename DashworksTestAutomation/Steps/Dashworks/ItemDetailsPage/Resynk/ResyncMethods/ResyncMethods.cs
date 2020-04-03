using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.ItemDetails;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using RestSharp;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage.Resynk.ResyncMethods
{
    public class ResyncMethods
    {
        private RestWebClient _client;

        public ResyncMethods(RestWebClient client)
        {
            _client = client;
        }

        public void Resync(ResyncItemst item)
        {
            foreach (string itemName in item.Objects)
            {
                var id = DatabaseHelper.GetItemId(item.List, itemName);
                var requestUri = $"{UrlProvider.RestClientBaseUrl}/{item.List.ToLower()}/{id}/relinkObjects";
                var request = requestUri.GenerateRequest();
                request.AddParameter("projectId", DatabaseHelper.GetProjectId(item.ProjectName));
                request.AddParameter("IsOwnerResync", true);
                request.AddParameter("IsAppsResync", true);
                request.AddParameter("IsNameResync", true);
                request.AddParameter("IsSkipRelink", true);
                request.AddParameter("objectId", id);

                var response = _client.Evergreen.Post(request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception(
                        $"Unable to resynk '{itemName}' {item.List} object for '{item.ProjectName}' project: {response.StatusCode}, {response.ErrorMessage}");
                }
            }
        }
    }
}
