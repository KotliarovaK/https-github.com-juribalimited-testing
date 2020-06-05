using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace DashworksTestAutomationCore.Steps.Dashworks.ActionsPanel.FavouriteBulkUpdate
{
    public class RemoveFbuMethods
    {
        private readonly RestWebClient _client;

        public RemoveFbuMethods(RestWebClient client)
        {
            _client = client;
        }

        public FavouritesList GetFavourites()
        {
            var requestUri = $"{UrlProvider.RestClientBaseUrl}bulk-update/favourites";
            var request = requestUri.GenerateRequest();

            var response = _client.Evergreen.Get(request);
            if (!response.StatusCode.Equals(HttpStatusCode.OK))
            {
                throw new Exception($"Unable to get Favourite Bulk Update: {response.StatusCode}, {response.ErrorMessage}");
            }
            var content = response.Content;
            return JsonConvert.DeserializeObject<FavouritesList>(content);
        }

        public List<int> GetFbuId(string favouriteBulkUpdateObjects)
        {
            return GetFavourites().Favourites.Where(x => x.Name.Equals(favouriteBulkUpdateObjects)).Select(p => int.Parse(p.Id)).ToList();
        }

        public void DeleteFavouritesBulkUpdate(List<Favourit> favouriteBulkUpdateObjects)
        {
            foreach (Favourit row in favouriteBulkUpdateObjects)
            {
                var allFavouritesWithName = GetFbuId(row.Name).ToArray();

                var requestUri = $"{UrlProvider.RestClientBaseUrl}bulk-update/favourites";
                var request = requestUri.GenerateRequest();
                request.AddJsonBody(new { favouriteBulkUpdateIds = allFavouritesWithName });

                var response = _client.Evergreen.Delete(request);
                if (!response.StatusCode.Equals(HttpStatusCode.NoContent))
                {
                    Logger.Write($"Unable to delete Favourite Bulk Update: {response.StatusCode}, {response.ErrorMessage}");
                }
            }
        }

        public partial class RemovingFavouriteBulkUpdate
        {
            [JsonProperty("favouriteBulkUpdateIds")]
            public List<int> FavouriteBulkUpdateIds { get; set; }
        }

        public partial class FavouritesList
        {
            [JsonProperty("results")]
            public List<Favourit> Favourites { get; set; }
        }

        public partial class Favourit
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }
    }
}
