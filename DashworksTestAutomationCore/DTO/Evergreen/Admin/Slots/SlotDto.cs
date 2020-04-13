using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Helpers;
using NUnit.Framework.Constraints;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.Slots
{
    public class SlotDto
    {
        private string _project;

        public string Project
        {
            get
            {
                if (string.IsNullOrEmpty(_project))
                {
                    if (string.IsNullOrEmpty(Id))
                    {
                        return null;
                    }
                    else
                    {
                        var projectId = DatabaseHelper.GetSlotProjectId(Id);
                        _project = DatabaseHelper.GetProjectName(projectId);
                        return _project;
                    }
                }
                else
                {
                    return _project;
                }
            }
            set => _project = value;
        }

        public string SlotName { get; set; }
        public string DisplayName { get; set; }

        private string _capacityType;
        public string CapacityType
        {
            get
            {
                if (string.IsNullOrEmpty(_capacityType))
                    _capacityType = "Capacity Units";
                return _capacityType;
            }
            set => _capacityType = value;
        }

        public int CapacityTypeId
        {
            get
            {
                switch (CapacityType)
                {
                    case "Capacity Units":
                        return 2;
                    case "Teams and Paths":
                        return 1;
                    default:
                        throw new Exception($"Unknown Capacity type: {CapacityType}");
                }
            }
        }

        private string _objectType;
        public string ObjectType
        {
            get
            {
                if (string.IsNullOrEmpty(_objectType))
                    _objectType = "Device";
                return _objectType;
            }
            set => _objectType = value;
        }

        public int ObjectTypeId
        {
            get
            {
                switch (ObjectType)
                {
                    case "User":
                        return 1;
                    case "Device":
                        return 2;
                    case "Application":
                        return 3;
                    default:
                        throw new Exception($"Unknown Object type: {ObjectType}");
                }
            }
        }

        public DateTime SlotAvailableFrom { get; set; }

        public DateTime SlotAvailableTo { get; set; }

        public string SlotStartTime { get; set; }
        public string SlotEndTime { get; set; }

        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }

        public string Paths
        {
            set => PathsList = value.Split('‡').Where(x => !string.IsNullOrEmpty(x)).ToList();
        }
        public List<string> PathsList { get; set; }

        public string Teams
        {
            set => TeamsList = value.Split('‡').Where(x => !string.IsNullOrEmpty(x)).ToList();
        }
        public List<string> TeamsList { get; set; }

        public string Tasks
        {
            set => TasksList = value.Split('‡').Where(x => !string.IsNullOrEmpty(x)).ToList();
        }
        public List<string> TasksList { get; set; }

        public string CapacityUnits
        {
            set => CapacityUnitsList = value.Split('‡').Where(x => !string.IsNullOrEmpty(x)).ToList();
        }
        public List<string> CapacityUnitsList { get; set; }

        private string _id;
        public string Id
        {
            get
            {
                if (string.IsNullOrEmpty(_id))
                {
                    _id = string.IsNullOrEmpty(_project) ? DatabaseHelper.GetSlotId(SlotName) :
                        DatabaseHelper.GetSlotId(this.SlotName, DatabaseHelper.GetProjectId(_project));
                }
                return _id;
            }
        }

        public SlotDto()
        {
            PathsList = new List<string>();
            TeamsList = new List<string>();
            TasksList = new List<string>();
            CapacityUnitsList = new List<string>();
        }
    }
}
