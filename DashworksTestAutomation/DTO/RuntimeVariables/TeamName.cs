using System.Collections.Generic;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    public class TeamName
    {
        public TeamName()
        {
            Value = new List<string>();
        }

        public List<string> Value { get; set; }
    }
}