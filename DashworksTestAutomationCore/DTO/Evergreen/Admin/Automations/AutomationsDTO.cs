using System;
using System.Linq;
using AutomationUtils.Utils;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Utils;
using Newtonsoft.Json;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.Automations
{
    public class AutomationsDto
    {
        private string _id;
        public string Id
        {
            get
            {
                if (string.IsNullOrEmpty(_id))
                {
                    try
                    {
                        _id = DatabaseHelper.GetAutomationId(name);
                    }
                    catch { }
                }
                return _id;
            }
            set => _id = value;
        }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }
        public int id => -1;
        public string name { get; set; }
        public string sqlAgentJobId { get; set; }
        public string description { get; set; }
        private string AutomationListName { get; set; }
        public bool stopOnFailedAction { get; set; }

        [JsonProperty("scheduleTypeId")]
        public int ScheduleTypeId { get; private set; }
        private string _run;
        public string Run
        {
            get => _run;
            set
            {
                ScheduleTypeId = GetScheduleTypeId(value);
                _run = value;
            }
        }

        public string Scope
        {
            get => AutomationListName;
            set
            {
                AutomationListName = value;
                ListId = int.Parse(DatabaseHelper.GetListId(value));
            }
        }

        [JsonProperty("listId")]
        public int ListId { get; set; }

        private string _objectTypeId;
        [JsonProperty("objectTypeId")]
        public int ObjectTypeId
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
                if (DatabaseHelper.GetListId(AutomationListName).Equals("-1"))
                {
                    return DatabaseHelper.ExecuteReader(
                            $"select[ObjectTypeID] from[PM].[dbo].[ObjectTypes] where [ObjectType] = '{GetProjectObjectTypeScope(this.AutomationListName)}'",
                            0)
                        .LastOrDefault();
                }

                return DatabaseHelper
                    .ExecuteReader(
                        $"select[ObjectTypeId] from[DesktopBI].[dbo].[EvergreenList] where [ListId] = '{this.ListId}'",
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
    }
}