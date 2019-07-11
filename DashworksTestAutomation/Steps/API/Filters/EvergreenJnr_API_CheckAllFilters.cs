using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.Evergreen;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.API.Filters
{
    [Binding]
    class EvergreenJnr_API_CheckAllFilters : SpecFlowContext
    {
        private readonly RestWebClient _client;

        public EvergreenJnr_API_CheckAllFilters(RestWebClient client)
        {
            _client = client;
        }

        [Then(@"All filters with correct data are returned from the API for '(.*)' list")]
        public void ThenAllFiltersWithCorrectDataAreReturnedFromTheAPIForList(string list)
        {
            var url = $"{UrlProvider.RestClientBaseUrl}{list.ToLower()}/fields?$lang=en-US";
            var response = _client.Value.Get(url.GenerateRequest());

            if (!response.StatusCode.Equals(HttpStatusCode.OK))
                throw new Exception($"Unable to get filters for '{list}' list: {response.ErrorMessage}");

            CheckFiltersCount(list, response);

            var currentFilters = Newtonsoft.Json.JsonConvert.DeserializeObject<List<FilterDto>>(response.Content);

            var expectedList = FileSystemHelper.ReadJsonListFromSystem<FilterDto>($"Filters\\{list}.json");

            Assert.True(expectedList.All(x => currentFilters.Contains(x)));
        }

        private void CheckFiltersCount(string list, IRestResponse response)
        {
            var currentFilters = Newtonsoft.Json.JsonConvert.DeserializeObject<List<FilterDto>>(response.Content);

            var expectedList = FileSystemHelper.ReadJsonListFromSystem<FilterDto>($"Filters\\{list}.json");

            Assert.AreEqual(expectedList.Count, currentFilters.Count, "Filters count are different");
        }
    }
}
