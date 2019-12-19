using System;
using System.Linq;
using System.Net;
using System.Threading;
using DashworksTestAutomation.DTO.ItemDetails;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails.CustomFields;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using DashworksTestAutomation.DTO.RuntimeVariables.SelfService;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService;
using DashworksTestAutomation.DTO.RuntimeVariables;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService
{
    [Binding]
    class CreateSelfServiceViaApi : SpecFlowContext
    {
        private readonly SelfServices _selfServices;
        private readonly RestWebClient _client;

        public CreateSelfServiceViaApi(SelfServices selfServices, RestWebClient client)
        {
            _selfServices = selfServices;
            _client = client;
        }

        //| ServiceId | Name | ServiceIdentifier | Enabled | ObjectType | ObjectTypeId | StartDate | EndDate | SelfServiceURL | AllowAnonymousUsers | ScopeId |
        [When(@"User creates Self Service via API")]
        public void WhenUserCreatesSelfServiceViaApi(Table table)
        {
            var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/selfservices";
            var createSelfService = table.CreateSet<SelfServiceDto>();

            foreach (SelfServiceDto SelfService in createSelfService)
            {
                var request = requestUri.GenerateRequest();
                request.AddObject(SelfService);
                var response = _client.Value.Post(request);

                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    throw new Exception($"Unable to create Self Service: {response.StatusCode}, {response.ErrorMessage}");
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

                _selfServices.Value.Add(SelfService);
            }
        }

        [Then(@"User checks the Self Service via API")]
        public void WhenUserChecksTheSelfServiceViaApi()
        {
            foreach (SelfServiceDto SelfService in _selfServices.Value)
            {
                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/selfservices/{SelfService.ServiceId}";
                var response = _client.Value.Get(requestUri.GenerateRequest());

                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    throw new Exception($"Unable to get the Self Service: {response.StatusCode}, {response.ErrorMessage}");
                }

                var selfServiceObjResponse = JsonConvert.DeserializeObject<SelfServiceDto>(response.Content);
                if (!SelfService.Equals(selfServiceObjResponse))
                {
                    throw new Exception("The created Self Service doesn't match to the received Self Service");
                }
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
                var response = _client.Value.Put(request);

                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    throw new Exception($"Unable to create Self Service: {response.StatusCode}, {response.ErrorMessage}");
                }
            }
        }

        [Then(@"User checks the Self Services Grid via API")]
        public void WhenUserChecksTheSelfServicesGridViaApi()
        {
            foreach (SelfServiceDto SelfService in _selfServices.Value)
            {
                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/selfservices";
                var response = _client.Value.Get(requestUri.GenerateRequest());

                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    throw new Exception($"Unable to get the Self Services Grid: {response.StatusCode}, {response.ErrorMessage}");
                }

                var selfServicesGrid = JsonConvert.DeserializeObject<JObject>(response.Content);
                Verify.IsTrue(selfServicesGrid["results"].ToObject<SelfServiceDto[]>().ToList().Any(ss => ss.Equals(SelfService)), "The created Self Service doesn't match to the existing Self Service in the Grid");
            }
        }
    }
}