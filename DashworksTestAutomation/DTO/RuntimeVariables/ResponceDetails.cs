using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //We store responce data in the variable to assert its parts in further steps
    class ResponceDetails
    {
        public IRestResponse Value { get; set; }
    }
}
