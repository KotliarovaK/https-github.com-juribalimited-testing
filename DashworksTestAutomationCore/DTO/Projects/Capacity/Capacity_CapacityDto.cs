using System.ComponentModel;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class Capacity_CapacityDto
    {
        public string Team { get; set; }
        public RequestTypeEnum RequestType;
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool MondayCheckbox { get; set; }
        public bool TuesdayCheckbox { get; set; }
        public bool WednesdayCheckbox { get; set; }
        public bool ThursdayCheckbox { get; set; }
        public bool FridayCheckbox { get; set; }
        public bool SaturdayCheckbox { get; set; }
        public bool SundayCheckbox { get; set; }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }
    }

    public enum RequestTypeEnum
    {
        [Description("[Select]")]
        Select,
        [Description("[Default (Computer)]")]
        DefaultComputer,
        [Description("[Default (Mailbox)]")]
        DefaultMailbox
    }
}