using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Providers;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.CapacityUnits.AfterScenario
{
    [Binding]
    public class SetDefaultCapacityUnitAfterScenario : SpecFlowContext
    {
        private readonly RestWebClient _client;

        private SetDefaultCapacityUnitAfterScenario(RestWebClient client)
        {
            _client = client;
        }

        [AfterScenario("Set_Default_Capacity_Unit")]
        public void SetDefaultCapacityUnit()
        {
            try
            {
                var capacityUnit = new CapacityUnitDto() { Name = "Unassigned", Description = "Unassigned", IsDefault = true };

                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/capacityUnits/{capacityUnit.GetId()}/updateCapacityUnit";

                var request = new RestRequest(requestUri);

                request.AddParameter("Host", UrlProvider.RestClientBaseUrl);
                request.AddParameter("Origin", UrlProvider.Url.TrimEnd('/'));
                request.AddParameter("Referer", UrlProvider.EvergreenUrl);
                request.AddParameter("objectId", null);
                request.AddParameter("name", capacityUnit.Name);
                request.AddParameter("description", capacityUnit.Description);
                request.AddParameter("isDefault", capacityUnit.IsDefault);
                request.AddParameter("projectId", string.Empty);

                _client.Value.Put(request);
            }
            catch { }
        }
    }
}