using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.ItemDetails;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage.Api
{
    [Binding]
    class CreateCustomFieldViaApi : SpecFlowContext
    {
        private readonly RestWebClient _client;

        public CreateCustomFieldViaApi(RestWebClient client)
        {
            _client = client;
        }

        //| List | ObjectId | FieldName | Value | FieldIndex |
        [When(@"User creates Custom Field via API")]
        public void WhenUserCreatesCustomFieldViaAPI(Table table)
        {
            var customFields = table.CreateSet<CustomFieldDto>();

            foreach (CustomFieldDto customField in customFields)
            {
                var requestUri = $"{UrlProvider.RestClientBaseUrl}{customField.List}/{customField.ObjectId}/addCustomField";
                var request = requestUri.GenerateRequest();
                request.AddParameter("fieldName", customField.FieldName);
                request.AddParameter("value", customField.Value);
                request.AddParameter("fieldIndex", customField.FieldIndex);

                var response = _client.Value.Post(request);

                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception(
                        $"Unable to create '{customField.FieldName}' Custom Field via API : {response.ErrorMessage}");
            }
        }
    }
}
