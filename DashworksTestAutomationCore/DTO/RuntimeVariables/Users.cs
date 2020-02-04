using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //Store created users here
    class Users
    {
        public List<UserDto> Value { get; set; }

        public Users()
        {
            Value = new List<UserDto>();
        }
    }
}
