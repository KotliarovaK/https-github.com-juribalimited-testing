using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.ManagementConsole;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Utils;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Senior.CustomFields.AfterScenario
{
    [Binding]
    class RemoveCustomFieldAfterScenario : SpecFlowContext
    {
        private readonly SeniorCustomFields _customFields;

        public RemoveCustomFieldAfterScenario(SeniorCustomFields customFields)
        {
            _customFields = customFields;
        }

        [AfterScenario("Cleanup", Order = 10)]
        public void DeleteNewlyCreatedCustomField()
        {
            if (!_customFields.Value.Any())
                return;

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
