using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.Projects.Tasks
{
    //Used to store created Tasks
    public class Stages
    {
        public List<StagePropertiesDto> Value;

        public Stages()
        {
            Value = new List<StagePropertiesDto>();
        }
    }
}
