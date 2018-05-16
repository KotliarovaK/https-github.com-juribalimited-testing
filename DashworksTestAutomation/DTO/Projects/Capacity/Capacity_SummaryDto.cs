using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.Projects.Capacity
{
    public class Capacity_SummaryDto
    {
        public RequestTypeEnum RequestType;
    }

    public enum RequestTypeEnum
    {
        [Description("[Select]")]
        Select,
        [Description("[Default (Computer)]")]
        DefaultComputer
    }
}
