using System.Collections.Generic;

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
