using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder
{
    public class SelfServiceTextComponents
    {
        public List<SelfServiceTextComponent> Value { get; set; }

        public SelfServiceTextComponents()
        {
            Value = new List<SelfServiceTextComponent>();
        }
    }
}
