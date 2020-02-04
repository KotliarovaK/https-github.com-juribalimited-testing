using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.Evergreen.Admin.CapacityUnits;
using DashworksTestAutomation.DTO.Evergreen.Admin.Slots;
using DashworksTestAutomation.DTO.Evergreen.Admin.Teams;
using DashworksTestAutomation.DTO.Projects;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Slots.Api
{
    [Binding]
    class CreateSlotViaApi : SpecFlowContext
    {
        private readonly RestWebClient _client;
        private readonly DTO.RuntimeVariables.Slots _slots;

        public CreateSlotViaApi(RestWebClient client, DTO.RuntimeVariables.Slots slots)
        {
            _client = client;
            _slots = slots;
        }

        [When(@"User creates new Slot via Api")]
        public void WhenUserCreatesNewSlotViaApi(Table table)
        {
            var slots = table.CreateSet<SlotDto>();
            _slots.Value.AddRange(slots);

            foreach (SlotDto slot in slots)
            {
                var requestUri = $"{UrlProvider.RestClientBaseUrl}admin/projects/{DatabaseHelper.GetProjectId(slot.Project)}/createCapacitySlot";

                var request = requestUri.GenerateRequest();

                if (slot.CapacityType.Equals("Capacity Units") || slot.PathsList.Any())
                    request.AddParameter("allRequestTypes", false);
                else
                    request.AddParameter("allRequestTypes", true);

                if (slot.CapacityType.Equals("Capacity Units") || slot.TeamsList.Any())
                    request.AddParameter("allTeams", false);
                else
                    request.AddParameter("allTeams", true);

                if (slot.CapacityType.Equals("Teams and Paths") || slot.CapacityUnitsList.Any())
                    request.AddParameter("allUnits", false);
                else
                    request.AddParameter("allUnits", true);

                request.AddParameter("capacityType", slot.CapacityTypeId);
                request.AddParameter("slotName", slot.SlotName);
                request.AddParameter("displayName", slot.DisplayName);
                request.AddParameter("monday", string.IsNullOrEmpty(slot.Monday) ? -1 : int.Parse(slot.Monday));
                request.AddParameter("tuesday", string.IsNullOrEmpty(slot.Tuesday) ? -1 : int.Parse(slot.Tuesday));
                request.AddParameter("wednesday", string.IsNullOrEmpty(slot.Wednesday) ? -1 : int.Parse(slot.Wednesday));
                request.AddParameter("thursday", string.IsNullOrEmpty(slot.Thursday) ? -1 : int.Parse(slot.Thursday));
                request.AddParameter("friday", string.IsNullOrEmpty(slot.Friday) ? -1 : int.Parse(slot.Friday));
                request.AddParameter("saturday", string.IsNullOrEmpty(slot.Saturday) ? -1 : int.Parse(slot.Saturday));
                request.AddParameter("sunday", string.IsNullOrEmpty(slot.Sunday) ? -1 : int.Parse(slot.Sunday));
                //TODO this should be separate list with TranslationDto
                request.AddParameter("translationsObject", "[]");
                request.AddParameter("objectType", slot.ObjectTypeId);

                if (slot.SlotAvailableFrom != DateTime.MinValue)
                    request.AddParameter("slotAvailableFrom", slot.SlotAvailableFrom.ToString("yyyy-MM-dd"));

                if (slot.SlotAvailableTo != DateTime.MinValue)
                    request.AddParameter("slotAvailableTo", slot.SlotAvailableTo.ToString("yyyy-MM-dd"));

                if (!string.IsNullOrEmpty(slot.SlotStartTime))
                    request.AddParameter("slotStartTime", slot.SlotStartTime);

                if (!string.IsNullOrEmpty(slot.SlotEndTime))
                    request.AddParameter("slotEndTime", slot.SlotEndTime);

                //This is 'Paths' field on UI
                if (slot.CapacityType.Equals("Capacity Units") || !slot.PathsList.Any())
                    request.AddParameter("requestTypes", "");
                else
                {
                    if (slot.PathsList.Any(x => !string.IsNullOrEmpty(x)))
                    {
                        var paths = slot.PathsList.Where(x => !string.IsNullOrEmpty(x));
                        var ids = String.Join(",",
                            new List<string>(paths.Select(x =>
                                DatabaseHelper.GetRequestTypeId(x, DatabaseHelper.GetProjectId(slot.Project)))));
                        request.AddParameter("requestTypes", ids);
                    }
                    else
                        request.AddParameter("requestTypes", "");
                }

                if (slot.CapacityType.Equals("Capacity Units") || !slot.TeamsList.Any())
                    request.AddParameter("teams", "");
                else
                {
                    if (slot.TeamsList.Any(x => !string.IsNullOrEmpty(x)))
                    {
                        var teams = slot.TeamsList.Where(x => !string.IsNullOrEmpty(x));
                        var teamsIds = String.Join(",",
                            new List<string>(teams.Select(team => new TeamDto() { TeamName = team }.GetId())));
                        request.AddParameter("teams", teamsIds);
                    }
                    else
                        request.AddParameter("teams", "");
                }

                if (slot.CapacityType.Equals("Teams and Paths") || !slot.CapacityUnitsList.Any())
                    request.AddParameter("units", "");
                else
                {
                    if (slot.CapacityUnitsList.Any(x => !string.IsNullOrEmpty(x)))
                    {
                        var cunits = slot.CapacityUnitsList.Where(x => !string.IsNullOrEmpty(x));
                        var ids = String.Join(",",
                            new List<string>(cunits.Select(team => new CapacityUnitDto() { Name = team, Project = slot.Project }.GetId())));
                        request.AddParameter("units", ids);
                    }
                    else
                        request.AddParameter("units", "");
                }

                if (slot.TasksList.Any())
                {
                    if (slot.TasksList.Any(x => !string.IsNullOrEmpty(x)))
                    {
                        var tasks = slot.TasksList.Where(x => !string.IsNullOrEmpty(x));
                        var ids = String.Join(",",
                            new List<string>(tasks.Select(task => new TaskPropertiesDto()
                            {
                                Name = task.Split('\\').Last().TrimStart(),
                                ProjectId = DatabaseHelper.GetProjectId(slot.Project)
                            }.Id).ToList()));
                        request.AddParameter("tasks", ids);
                    }
                    else
                        request.AddParameter("tasks", "");
                }
                else
                {
                    request.AddParameter("tasks", "");
                }

                var response = _client.Evergreen.Post(request);

                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception($"Slot with '{slot.SlotName}' name was not created via API");
            }
        }
    }
}
