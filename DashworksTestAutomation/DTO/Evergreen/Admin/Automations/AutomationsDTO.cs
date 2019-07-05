﻿using System.Linq;
using DashworksTestAutomation.Helpers;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.Automations
{
    public class AutomationsDto
    {
        private string _scheduleTypeId;

        public bool active { get; set; }
        public int automationId => -1;
        public string automationName { get; set; }

        public string automationScheduleTypeId
        {
            get => _scheduleTypeId;
            set => _scheduleTypeId = GetScheduleTypeId(value);
        }

        public string automationSqlAgentJobId { get; set; }
        public string description { get; set; }
        public string listId { get; set; }
        public string objectTypeId { get; set; }
        public bool stopOnFailedAction { get; set; }

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

        private string GetProjectListIdScope(string listName)
        {
            return DatabaseHelper.ExecuteReader(
                $"select [ListId] from [DesktopBI].[dbo].[EvergreenList] where [ListName]='{listName}'", 0).LastOrDefault();
        }

        private string GetListId(string listName)
        {
            if (listName.Equals("All Devices") || listName.Equals("All Users") || listName.Equals("All Mailboxes") || listName.Equals("All Mailboxes"))
                return "-1";
            else
            {
                GetProjectListIdScope(listName);
            }
            return "NOT FOUND";
        }

        private string GetObjectTypeId(string scope)
        {
            if (scope.Equals("All Devices"))
                return "2";
            if (scope.Equals("All Users"))
                return "1";
            if (scope.Equals("All Mailboxes"))
                return "4";
            if (scope.Equals("All Applications"))
                return "3";
            return "NOT FOUND";
        }
    }
}