using System.Collections.Generic;
using DashworksTestAutomation.DTO.Evergreen.Admin.Readiness;

namespace DashworksTestAutomation.DTO.RuntimeVariables.Readiness
{
    //Created readiness DTO are stored here
    public class Readiness
    {
        public List<ReadinessDto> Value { get; set; }

        public Readiness()
        {
            Value = new List<ReadinessDto>();
        }
    }
}
