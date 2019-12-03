using System.Collections.Generic;
using DashworksTestAutomation.DTO.ItemDetails;

namespace DashworksTestAutomation.DTO.RuntimeVariables.ItemDetails
{
    public class CustomFields
    {
        public List<CustomFieldDto> Value { get; set; }

        public CustomFields()
        {
            Value = new List<CustomFieldDto>();
        }
    }
}
