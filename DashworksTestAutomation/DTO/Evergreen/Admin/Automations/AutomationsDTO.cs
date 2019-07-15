using System.Drawing.Text;
using System.Linq;
using DashworksTestAutomation.Helpers;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.Automations
{
    public class AutomationsDto
    {
        public bool active { get; set; }
        public int automationId => -1;
        public string automationName { get; set; }
        private string _scheduleTypeId;
        public string automationSqlAgentJobId { get; set; }
        public string description { get; set; }
        private int automationlistId => -1;
        private string _automationObjectTypeId;
        public bool stopOnFailedAction { get; set; }


        public string automationScheduleTypeId
        {
            get => _scheduleTypeId;
            set => _scheduleTypeId = GetScheduleTypeId(value);
        }

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

        //public string listId
        //{
        //    get => _automationlistId;
        //    set => _automationlistId = GetAutomationListId(value);
        //}

        //private string GetAutomationListId(string listName)
        //{
        //    return DatabaseHelper.ExecuteReader(
        //            $"select [ListId] from [DesktopBI].[dbo].[EvergreenList] where [ListName]='{listName}'", 0)
        //        .LastOrDefault();
        //}

        public string objectTypeId
        {
            get => _automationObjectTypeId;
            set => _automationObjectTypeId = GetObjectTypeId(value);
        }

        private string GetObjectTypeId(string listName)
        {
            return DatabaseHelper.ExecuteReader(
                    $"select[ObjectTypeID] from[PM].[dbo].[ObjectTypes] where[ObjectType] = '{listName}'", 0)
                .LastOrDefault();
        }
    }
}