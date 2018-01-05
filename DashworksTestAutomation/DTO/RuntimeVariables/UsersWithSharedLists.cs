using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashworksTestAutomation.DTO.RuntimeVariables
{
    //If we assigne list to any user we nned to add it to this list
    //to be able to remove list after test execution
    class UsersWithSharedLists
    {
        public List<string> Value { get; set; }
    }
}
