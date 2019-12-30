using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO.RuntimeVariables.SelfService;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using RestSharp;
using TechTalk.SpecFlow;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.AfterScenarios
{
    [Binding]
    class RemoveSelfServiceAfterScenario : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private readonly SelfServices _selfServices;

        private RemoveSelfServiceAfterScenario(SelfServices selfServices, RestWebClient client)
        {
            _selfServices = selfServices;
            _client = client;
        }

        [AfterScenario("Cleanup", Order = 10)]
        public void DeleteNewlyCreatedSelfService()
        {
            if (!_selfServices.Value.Any())
                return;

            try
            {
                List<int> Ids = _selfServices.Value.Select(x => x.ServiceId).ToList();

                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/selfservices";

                var request = requestUri.GenerateRequest();

                request.AddObject(new { ServiceIds = Ids.ToArray() });

                var response = _client.Value.Delete(request);

                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    Logger.Write($"Self Service was not deleted: {response.StatusCode}, {response.ErrorMessage}");
                    //try
                    //{
                    //    var cfId = DatabaseHelper.GetCustomFieldId(SelfService.FieldName);
                    //    Logger.Write($"Custom filed with '{SelfService.FieldName}' name and '{cfId}' id is still present in the database");
                    //}
                    //catch
                    //{
                    //    Logger.Write($"Custom filed with '{SelfService.FieldName}' was removed from database");
                    //}
                }
            }
            catch (Exception e)
            {
                Logger.Write($"Unable to delete Self Service via API: {e}");
            }
        }
    }
}
