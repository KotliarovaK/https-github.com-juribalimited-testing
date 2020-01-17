using System;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO.ItemDetails;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage.CustomFields
{
    [Binding]
    class CreateCustomFieldViaApi : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private readonly DTO.RuntimeVariables.ItemDetails.CustomFields _customFields;

        public CreateCustomFieldViaApi(RestWebClient client, DTO.RuntimeVariables.ItemDetails.CustomFields customFields)
        {
            _client = client;
            _customFields = customFields;
        }

        //| ObjectType | ObjectId | FieldName | Value | FieldIndex |
        [When(@"User creates Custom Field via API")]
        public void WhenUserCreatesCustomFieldViaAPI(Table table)
        {
            var customFields = table.CreateSet<CustomFieldDto>().ToList();
            _customFields.Value.AddRange(customFields);

            foreach (CustomFieldDto customField in customFields)
            {
                var requestUri = $"{UrlProvider.RestClientBaseUrl}{customField.ObjectType}/{customField.ObjectId}/addCustomField";
                var request = requestUri.GenerateRequest();
                request.AddParameter("fieldName", customField.FieldName);
                request.AddParameter("value", customField.Value);
                request.AddParameter("fieldIndex", customField.FieldIndex);

                var response = _client.Evergreen.Post(request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception(
                        $"Unable to create '{customField.FieldName}' Custom Field via API: {response.StatusCode}, {response.ErrorMessage}");
                }
            }
        }
    }
}
