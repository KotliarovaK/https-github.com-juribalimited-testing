using System;
using System.Linq;
using System.Net;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using DashworksTestAutomation.DTO.RuntimeVariables.SelfService;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService;
using DashworksTestAutomation.DTO.RuntimeVariables;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder;
using DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.AfterScenarios;
using Logger = DashworksTestAutomation.Utils.Logger;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService
{
    [Binding]
    class CreateSelfServiceViaApi : SpecFlowContext
    {
        private readonly SelfServices _selfServices;
        private readonly RestWebClient _client;
        private readonly SelfServiceApiMethods _selfServiceApiMethods;
        private SelfServicePages _selfServicePages;

        public CreateSelfServiceViaApi(SelfServices selfServices, RestWebClient client, SelfServicePages selfServicePages)
        {
            _selfServices = selfServices;
            _client = client;
            _selfServiceApiMethods = new SelfServiceApiMethods(selfServices, client);
            _selfServicePages = selfServicePages;
        }

        //| ServiceId | Name | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate | EndDate | SelfServiceURL | AllowAnonymousUsers | ScopeId |
        [When(@"User creates Self Service via API")]
        public void WhenUserCreatesSelfServiceViaApi(Table table)
        {
            _selfServices.Value.AddRange(_selfServiceApiMethods.CreateSelfService(table, out var exception, ref _selfServicePages).Value);
            if (!string.IsNullOrEmpty(exception))
            {
                throw new Exception(exception);
            }
        }

        [Then(@"User checks the Self Service via API")]
        public void WhenUserChecksTheSelfServiceViaApi()
        {
            foreach (SelfServiceDto SelfService in _selfServices.Value)
            {
                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/selfservices/{SelfService.ServiceId}";
                var response = _client.Evergreen.Get(requestUri.GenerateRequest());

                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    throw new Exception($"Unable to get the Self Service: {response.StatusCode}, {response.ErrorMessage}");
                }

                var selfServiceObjResponse = JsonConvert.DeserializeObject<SelfServiceDto>(response.Content);
                Verify.IsTrue(SelfService.CompareTo(selfServiceObjResponse), "Self Service ");
            }
        }

        //| OldName | Name | ServiceIdentifier | Enabled | ScopeId |
        [When(@"User updates Self Service via API")]
        public void WhenUserUpdatesSelfServiceViaApi(Table table)
        {
            var oldNames = table.GetDataByKey("OldName");
            var updatedSelfServices = table.CreateSet<SelfServiceDto>().ToArray();

            for (int i = 0; i < oldNames.Count; i++)
            {
                var selfService = _selfServices.Value.First(x => x.Name.Equals(oldNames[i]));
                var newSelfService = updatedSelfServices[i];

                selfService.Name = string.IsNullOrEmpty(newSelfService.Name) ? selfService.Name : newSelfService.Name;
                selfService.ScopeId = newSelfService.ScopeId.Equals(selfService.ScopeId) ? selfService.ScopeId : newSelfService.ScopeId;
                selfService.Enabled = newSelfService.Enabled.Equals(selfService.Enabled) ? selfService.Enabled : newSelfService.Enabled;
                selfService.ServiceIdentifier = newSelfService.ServiceIdentifier.Equals(selfService.ServiceIdentifier) ? selfService.ServiceIdentifier : newSelfService.ServiceIdentifier;
            }

            foreach (SelfServiceDto SelfService in _selfServices.Value)
            {
                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/selfservices/{SelfService.ServiceId}";
                var request = requestUri.GenerateRequest();
                request.AddObject(SelfService);
                var response = _client.Evergreen.Put(request);

                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    throw new Exception($"Unable to create Self Service: {response.StatusCode}, {response.ErrorMessage}");
                }
            }
        }

        [Then(@"User checks the Self Services Grid via API")]
        public void WhenUserChecksTheSelfServicesGridViaApi()
        {
            if (_selfServices.Value.Equals(null))
            {
                throw new Exception("The List of Self Services is empty");
            }

            foreach (SelfServiceDto SelfService in _selfServices.Value)
            {
                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/selfservices";
                var response = _client.Evergreen.Get(requestUri.GenerateRequest());

                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    throw new Exception($"Unable to get the Self Services Grid: {response.StatusCode}, {response.ErrorMessage}");
                }

                var selfServicesGrid = JsonConvert.DeserializeObject<JObject>(response.Content);
                var listOfReturnedSelfServices = selfServicesGrid["results"].ToObject<SelfServiceDto[]>().ToList();
                Verify.IsTrue(listOfReturnedSelfServices.Any(ss => ss.Equals(SelfService)), "The created Self Service doesn't match to the existing Self Service in the Grid");
            }
        }

        [Then(@"User deletes the Self Services via API")]
        public void ThenUserDeletesSelfServicesViaApi()
        {
            _selfServiceApiMethods.DeleteSelfService();
        }

        [Then(@"User enables Self Service with '(.*)' identifier via API")]
        public void ThenUserEnablesSelfServiceWithIdentifierViaApi(string identifier)
        {
            ThenUserEnablesDisablesSelfServiceViaApi(identifier, true);
        }

        [Then(@"User disables Self Service with '(.*)' identifier via API")]
        public void ThenUserDisablesSelfServiceWithIdentifierViaApi(string identifier)
        {
            ThenUserEnablesDisablesSelfServiceViaApi(identifier, false);
        }

        public void ThenUserEnablesDisablesSelfServiceViaApi(string selfServiceIdentifier, bool state)
        {
            var selfService = _selfServices.Value.First(x => x.ServiceIdentifier.Equals(selfServiceIdentifier));
            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/selfservices/action";
            var request = requestUri.GenerateRequest();
            request.AddObject(new { ServiceIds = new List<int>() { selfService.ServiceId }.ToArray(), ActionRequestType = state ? "enable" : "disable" });
            var response = _client.Evergreen.Put(request);

            if (!response.StatusCode.Equals(HttpStatusCode.OK))
            {
                Logger.Write($"Self Service enabled state was not set to '{state}': {response.StatusCode}, {response.ErrorMessage}");
            }

            //Update state in the original SelfServiceDTO
            selfService.Enabled = state;
        }
    }
}