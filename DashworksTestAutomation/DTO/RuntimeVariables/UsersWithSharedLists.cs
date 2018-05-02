using System.Collections.Generic;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //If we assigne list to any user we nned to add it to this list
    //to be able to remove list after test execution
    internal class UsersWithSharedLists
    {
        public UsersWithSharedLists()
        {
            Value = new List<string>();
        }

        public List<string> Value { get; set; }
    }
}