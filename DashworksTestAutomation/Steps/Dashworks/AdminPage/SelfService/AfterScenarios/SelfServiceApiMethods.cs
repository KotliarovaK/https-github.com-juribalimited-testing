using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder.Components;
using DashworksTestAutomation.DTO.RuntimeVariables.SelfService;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using Newtonsoft.Json;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.AfterScenarios
{
    public class SelfServiceApiMethods
    {
        private readonly RestWebClient _client;
        private readonly SelfServices _selfServices;

        public SelfServiceApiMethods(SelfServices selfServices, RestWebClient client)
        {
            _selfServices = selfServices;
            _client = client;
        }

        public SelfServices CreateSelfService(Table table, out string exception, ref SelfServicePages selfServicePages)
        {
            exception = string.Empty;

            try
            {
                SelfServices createdSs = new SelfServices();

                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/selfservices/default";
                var createSelfService = table.CreateSet<SelfServiceDto>();

                foreach (SelfServiceDto SelfService in createSelfService)
                {
                    var request = requestUri.GenerateRequest();
                    request.AddJsonBody(SelfService);
                    var response = _client.Evergreen.Post(request);

                    if (!response.StatusCode.Equals(HttpStatusCode.OK))
                    {
                        createdSs.Value.Add(new SelfServiceDto() { ServiceIdentifier = SelfService.ServiceIdentifier });
                        exception = $"Unable to create Self Service: {response.StatusCode}, {response.ErrorMessage}";
                        return createdSs;
                    }

                    var content = response.Content;
                    var selfServiceObjResponse = JsonConvert.DeserializeObject<SelfServiceDto>(content);

                    SelfService.ServiceId = selfServiceObjResponse.ServiceId;
                    SelfService.CreatedByUser = selfServiceObjResponse.CreatedByUser;
                    SelfService.ScopeId = selfServiceObjResponse.ScopeId;
                    SelfService.ScopeName = selfServiceObjResponse.ScopeName;
                    SelfService.StartDate = selfServiceObjResponse.StartDate;
                    SelfService.EndDate = selfServiceObjResponse.EndDate;
                    SelfService.ObjectType = selfServiceObjResponse.ObjectType;
                    SelfService.ObjectTypeId = selfServiceObjResponse.ObjectTypeId;
                    SelfService.SelfServiceURL = selfServiceObjResponse.SelfServiceURL;

                    createdSs.Value.Add(SelfService);

                    #region Get Pages/Components created by default

                    var drUri = $"{UrlProvider.RestClientBaseUrl}admin/selfservices/{SelfService.ServiceId}/pages";

                    var dRequest = drUri.GenerateRequest();
                    var dResponse = _client.Evergreen.Get(dRequest);

                    if (!dResponse.StatusCode.Equals(HttpStatusCode.OK))
                    {
                        exception = $"Unable to get default Pages/Components for '{SelfService.Name}' Self Service";
                    }

                    var dContent = dResponse.Content;

                    var settings = new JsonSerializerSettings();
                    settings.Converters.Add(new SelfServiceComponentConverter());

                    var defaultPagesAndComponents = JsonConvert.DeserializeObject<List<SelfServicePageDto>>(dContent, settings);

                    selfServicePages.Value.AddRange(defaultPagesAndComponents);

                    #endregion
                }

                return createdSs;
            }
            catch (Exception e)
            {
                exception = e.Message;
                return null;
            }
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

                var response = _client.Evergreen.Delete(request);

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