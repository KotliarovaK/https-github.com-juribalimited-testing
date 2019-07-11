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

namespace DashworksTestAutomation.Steps.API.Columns
{
    [Binding]
    class EvergreenJnr_API_CheckAllColumns : SpecFlowContext
    {
        private readonly RestWebClient _client;

        public EvergreenJnr_API_CheckAllColumns(RestWebClient client)
        {
            _client = client;
        }

        [Then(@"All columns with correct data are returned from the API for '(.*)' list")]
        public void ThenAllColumnsWithCorrectDataAreReturnedFromTheAPIForList(string list)
        {
            var url = $"{UrlProvider.RestClientBaseUrl}{list.ToLower()}/filters?$lang=en-US";
            var response = _client.Value.Get(url.GenerateRequest());

            if (!response.StatusCode.Equals(HttpStatusCode.OK))
                throw new Exception($"Unable to get filters for '{list}' list: {response.ErrorMessage}");

            CheckFiltersCount(list, response);

            var currentColumns = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ColumnDto>>(response.Content);

            var expectedList = FileSystemHelper.ReadJsonListFromSystem<ColumnDto>($"Columns\\{list}.json");

            foreach (ColumnDto columnDto in expectedList)
            {
                Assert.True(currentColumns.Contains(columnDto), $"Incorrect data for column with '{columnDto.Label}' name");
            }
        }

        private void CheckFiltersCount(string list, IRestResponse response)
        {
            var currentColumns = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ColumnDto>>(response.Content);

            var expectedList = FileSystemHelper.ReadJsonListFromSystem<ColumnDto>($"Columns\\{list}.json");

            Assert.AreEqual(expectedList.Count, currentColumns.Count, "Columns count are different");
        }
    }
}
