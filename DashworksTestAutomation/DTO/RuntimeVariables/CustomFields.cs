using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.ItemDetails;

namespace DashworksTestAutomation.DTO.RuntimeVariables
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
