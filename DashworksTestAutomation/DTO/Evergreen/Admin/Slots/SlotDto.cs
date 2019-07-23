using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.Slots
{
    public class SlotDto
    {
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

        public string ObjectType { get; set; }

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
            set => PathsList = value.Split('‡').ToList();
        }
        public List<string> PathsList { get; set; }

        public string Teams
        {
            set => TeamsList = value.Split('‡').ToList();
        }
        public List<string> TeamsList { get; set; }

        public string Tasks
        {
            set => TasksList = value.Split('‡').ToList();
        }
        public List<string> TasksList { get; set; }

        public string Capacity
        {
            set => CapacityUnitsList = value.Split('‡').ToList();
        }
        public List<string> CapacityUnitsList { get; set; }
    }
}
