using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.ManagementConsole;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    public class SeniorCustomFields
    {
        public List<SeniorCustomFieldDto> Value { get; set; }

        public SeniorCustomFields()
        {
            Value = new List<SeniorCustomFieldDto>();
        }
    }
}
