using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //User credentials that used during test execution
    class UsedUsers
    {
        public List<UserDto> Value { get; set; }

        public UsedUsers()
        {
            Value = new List<UserDto>();
        }
    }
}
