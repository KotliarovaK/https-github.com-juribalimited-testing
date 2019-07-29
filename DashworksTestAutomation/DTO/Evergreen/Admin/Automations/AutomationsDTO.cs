using System;
using System.Drawing.Text;
using System.Linq;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Utils;
using Newtonsoft.Json;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.Automations
{
    public class AutomationsDto
    {
        [JsonProperty("active")]
        public bool Active { get; set; }
        public int automationId => -1;
        public string automationName { get; set; }
        public string automationSqlAgentJobId { get; set; }
        public string description { get; set; }
        private string AutomationlistId { get; set; }
        private string AutomationListName { get; set; }
        private string _objectTypeId;
        public bool stopOnFailedAction { get; set; }

        [JsonProperty("automationScheduleTypeId")]
        public int AutomationScheduleTypeId { get; private set; }
        private string _run;
        public string Run
        {
            get => _run;
            set
            {
                AutomationScheduleTypeId = GetScheduleTypeId(value);
                _run = value;
            }
        }

        [JsonProperty("listId")]
        public string Scope
        {
            get => AutomationlistId;
            set
            {
                AutomationListName = value;
                AutomationlistId = GetAutomationListId(value);
            }
        }

        [JsonProperty("objectTypeId")]
        public int Object
        {
            get
            {
                if (string.IsNullOrEmpty(_objectTypeId))
                    _objectTypeId = SetListIdForObjectTypeId();

                return int.Parse(_objectTypeId);
            }
        }

        private string SetListIdForObjectTypeId()
        {
            try
            {
                if (GetAutomationListId(AutomationListName).Equals("-1"))
                {
                    return DatabaseHelper.ExecuteReader(
                            $"select[ObjectTypeID] from[PM].[dbo].[ObjectTypes] where [ObjectType] = '{GetProjectObjectTypeScope(this.AutomationListName)}'",
                            0)
                        .LastOrDefault();
                }

                return DatabaseHelper
                    .ExecuteReader(
                        $"select[ObjectTypeId] from[DesktopBI].[dbo].[EvergreenList] where[ListId] = '{this.AutomationListName}'",
                        0).LastOrDefault();
            }
            catch (Exception e)
            {
                Logger.Write($"Unable to execute query {e}");
                throw e;
            }

            //else 
            //    throw new NotImplementedException();
        }

        private string GetProjectObjectTypeScope(string listName)
        {
            switch (listName)
            {
                case "All Devices":
                    return "Computer";
                case "All Users":
                    return "User";
                case "All Mailboxes":
                    return "Mailbox";
                case "All Applications":
                    return "Application";
                default:
                    return "NOT FOUND";
            }
        }

        private int GetScheduleTypeId(string runType)
        {
            switch (runType)
            {
                case "Manual":
                    return 1;
                case "After Transform":
                    return 2;
                case "Dashworks Daily":
                    return 3;
                default:
                    throw new Exception($"'{runType}' is not defined Run Type");
            }
        }

        private string GetAutomationListId(string listName)
        {
            if (new string[] { "All Devices", "All Users", "All Mailboxes" }.Contains(listName))
            {
                return "-1";
            }
            else
            {
                return DatabaseHelper.ExecuteReader(
                    $"select [ListId] from [DesktopBI].[dbo].[EvergreenList] where [ListName]='{listName}'", 0).LastOrDefault();
            }
        }
    }
}