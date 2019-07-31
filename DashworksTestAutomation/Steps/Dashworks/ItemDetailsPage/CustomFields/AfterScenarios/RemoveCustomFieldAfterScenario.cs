using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.Evergreen.Admin.Rings;
using DashworksTestAutomation.DTO.ItemDetails;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage.CustomFields.AfterScenarios
{
    [Binding]
    class RemoveCustomFieldAfterScenario : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private readonly DTO.RuntimeVariables.CustomFields _customFields;

        private RemoveCustomFieldAfterScenario(DTO.RuntimeVariables.CustomFields customFields, RestWebClient client)
        {
            _customFields = customFields;
            _client = client;
        }

        [AfterScenario("Cleanup")]
        public void DeleteNewlyCreatedCustomField()
        {
            if (!_customFields.Value.Any())
                return;

            foreach (CustomFieldDto customField in _customFields.Value)
            {
                try
                {
                    var requestUri = $"{UrlProvider.RestClientBaseUrl}{customField.ObjectType}/{customField.ObjectId}/deleteCustomField";

                    var request = requestUri.GenerateRequest();
                    request.AddParameter("fieldName", customField.FieldName);
                    request.AddParameter("fieldIndex", customField.FieldIndex);

                    var response = _client.Value.Delete(request);
                }
                catch (Exception e)
                {
                    Logger.Write($"Unable to delete Custom Field via API: {e}");
                }
            }
        }
    }
}
