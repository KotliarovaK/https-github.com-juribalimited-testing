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
        private string _scheduleTypeId;
        public string automationSqlAgentJobId { get; set; }
        public string description { get; set; }
        private string AutomationlistId { get; set; }
        private string AutomationListName { get; set; }
        //private string ObjectTypeId { get; set; }
        public bool stopOnFailedAction { get; set; }

        [JsonProperty("automationScheduleTypeId")]
        public string Run
        {
            get => _scheduleTypeId;
            set => _scheduleTypeId = GetScheduleTypeId(value);
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
        public string ObjectTypeId => SetListIdForObjectTypeId();

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

        //select[ObjectTypeId] from[DesktopBI].[dbo].[EvergreenList] where[ListId] = 2

        private string GetScheduleTypeId(string runType)
        {
            if (runType.Equals("Manual"))
                return "1";
            if (runType.Equals("After Transform"))
                return "2";
            if (runType.Equals("Dashworks Daily"))
                return "3";
            return "NOT FOUND";
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