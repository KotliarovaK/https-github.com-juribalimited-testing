using System;
using System.Linq;
using DashworksTestAutomation.DTO.ManagementConsole;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Utils;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Senior.Manage.CustomFields.AfterScenario
{
    [Binding]
    class RemoveCustomFieldAfterScenario : SpecFlowContext
    {
        private readonly SeniorCustomFields _customFields;

        public RemoveCustomFieldAfterScenario(SeniorCustomFields customFields)
        {
            _customFields = customFields;
        }

        //Order 20 because we delete CF on Evergreen first
        [AfterScenario("Cleanup", Order = 20)]
        public void DeleteNewlyCreatedCustomField()
        {
            if (_customFields.Value.Any())
            {
                foreach (SeniorCustomFieldDto fieldDto in _customFields.Value)
                {
                    try
                    {
                        DatabaseHelper.DeleteCustomField(fieldDto.Id);
                    }
                    catch (Exception e)
                    {
                        Logger.Write($"Unable to delete Custom Field with '{fieldDto.FieldName}' name: {e}");
                    }
                }
            }
        }
    }
}
