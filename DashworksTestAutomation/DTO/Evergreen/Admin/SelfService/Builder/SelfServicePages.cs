using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder
{
    public class SelfServicePages
    {
        public List<SelfServicePageDto> Value { get; set; }

        public SelfServicePages()
        {
            Value = new List<SelfServicePageDto>();
        }
    }
}
