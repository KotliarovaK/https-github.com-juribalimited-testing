using System.Collections.Generic;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //If we assigne list to any user we need to add it to this list
    //to be able to remove list after test execution
    public class UsersWithSharedLists
    {
        public UsersWithSharedLists()
        {
            Value = new List<string>();
        }

        public List<string> Value { get; set; }
    }
}