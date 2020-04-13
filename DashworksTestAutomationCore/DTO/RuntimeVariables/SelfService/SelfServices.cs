using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService;

namespace DashworksTestAutomation.DTO.RuntimeVariables.SelfService
{
    public class SelfServices
    {
        public List<SelfServiceDto> Value { get; set; }

        public SelfServices()
        {
            Value = new List<SelfServiceDto>();
        }
    }
}
