using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService;
using DashworksTestAutomation.DTO.RuntimeVariables.SelfService;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using RestSharp;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.AfterScenarios
{
    public class RemoveSelfServiceMethods
    {
        private readonly RestWebClient _client;
        private readonly SelfServices _selfServices;

        public RemoveSelfServiceMethods(SelfServices selfServices, RestWebClient client)
        {
            _selfServices = selfServices;
            _client = client;
        }

        public void DeleteSelfService()
        {
            if (!_selfServices.Value.Any())
                return;

            try
            {
                List<int> ids = new List<int>();
                foreach (SelfServiceDto dto in _selfServices.Value)
                {
                    try
                    {
                        ids.Add(dto.ServiceId);
                    }
                    catch { }
                }

                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/selfservices";

                var request = requestUri.GenerateRequest();

                request.AddObject(new { ServiceIds = ids.ToArray() });

                var response = _client.Value.Delete(request);

                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    Logger.Write($"Self Service was not deleted: {response.StatusCode}, {response.ErrorMessage}");
                }
            }
            catch (Exception e)
            {
                Logger.Write($"Unable to delete Self Service via API: {e}");
            }
        }
    }
}