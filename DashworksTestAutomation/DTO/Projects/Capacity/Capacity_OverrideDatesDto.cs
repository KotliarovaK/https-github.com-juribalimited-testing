using System.ComponentModel;
using DashworksTestAutomation.Extensions;

namespace DashworksTestAutomation.DTO.Projects
{
    public class Capacity_OverrideDatesDto
    {
        //TODO filter?
        public string Date { get; set; }
        public string OverrideTeam;
        public string OverrideRequestType;
        public int Capacity { get; set; }
        public string Comment { get; set; }
    }
}