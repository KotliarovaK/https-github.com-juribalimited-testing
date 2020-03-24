using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.Evergreen.Admin.Slots;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using RestSharp;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Slots.AfterScenario
{
    [Binding]
    class RemoveSlotAfterScenario : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private readonly DTO.RuntimeVariables.Slots _slots;

        public RemoveSlotAfterScenario(RestWebClient client, DTO.RuntimeVariables.Slots slots)
        {
            _client = client;
            _slots = slots;
        }

        [AfterScenario("Cleanup")]
        public void DeleteNewlyCreatedSlot()
        {
            if (!_slots.Value.Any())
                return;

            foreach (SlotDto slot in _slots.Value)
            {
                try
                {
                    if (string.IsNullOrEmpty(slot.Id))
                        throw new Exception($"Unable to get '{slot.SlotName}' slot ID");

                    var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/projects/{DatabaseHelper.GetProjectId(slot.Project)}/deleteCapacitySlots";

                    var request = requestUri.GenerateRequest();
                    request.AddParameter("selectedObjectsList", slot.Id);

                    var response = _client.Evergreen.Post(request);

                    if (response.StatusCode != HttpStatusCode.OK)
                        Logger.Write($"Unable to delete '{slot.SlotName}' Slot via API");
                }
                catch (Exception e)
                {
                    Logger.Write($"Unable to delete Slot via API: {e}");
                }
            }
        }
    }
}
