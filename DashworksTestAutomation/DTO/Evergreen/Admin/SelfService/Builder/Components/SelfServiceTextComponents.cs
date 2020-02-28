using System.Collections.Generic;

namespace DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder.Components
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
