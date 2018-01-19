using System.Collections.Generic;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //User credentials that used during test execution
    internal class UsedUsers
    {
        public List<UserDto> Value { get; set; }

        public UsedUsers()
        {
            Value = new List<UserDto>();
        }
    }
}