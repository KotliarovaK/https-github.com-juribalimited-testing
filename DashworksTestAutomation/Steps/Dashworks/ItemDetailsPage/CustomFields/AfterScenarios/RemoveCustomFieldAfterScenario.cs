using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.Evergreen.Admin.Rings;
using DashworksTestAutomation.DTO.ItemDetails;
using DashworksTestAutomation.DTO.ManagementConsole;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
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
        private readonly DTO.RuntimeVariables.ItemDetails.CustomFields _customFields;

        private RemoveCustomFieldAfterScenario(DTO.RuntimeVariables.ItemDetails.CustomFields customFields, RestWebClient client)
        {
            _customFields = customFields;
            _client = client;
        }

        [AfterScenario("Cleanup", Order = 10)]
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

                    var response = _client.Evergreen.Delete(request);

                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        Logger.Write($"Custom field was not deleted: {response.StatusCode}, {response.ErrorMessage}");
                        try
                        {
                            var cfId = DatabaseHelper.GetCustomFieldId(customField.FieldName);
                            Logger.Write($"Custom filed with '{customField.FieldName}' name and '{cfId}' id is still present in the database");
                        }
                        catch
                        {
                            Logger.Write($"Custom filed with '{customField.FieldName}' was removed from database");
                        }
                    }
                }
                catch (Exception e)
                {
                    Logger.Write($"Unable to delete Custom Field via API: {e}");
                }
            }
        }
    }
}
