using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.Projects.Tasks
{
    //Used to store created Tasks
    class Tasks
    {
        public List<TaskPropertiesDto> Value;

        public Tasks()
        {
            Value = new List<TaskPropertiesDto>();
        }
    }
}
