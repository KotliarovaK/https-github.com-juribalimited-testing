using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.ItemDetails;

namespace DashworksTestAutomation.DTO.RuntimeVariables.ItemDetails
{
    //We store User details and ProjectId of all items which we have linked in test
    public class DefaultApplicationOwnedUser
    {
        public List<ApplicationOwnedUserDto> Value { get; set; }

        public DefaultApplicationOwnedUser()
        {
            Value = new List<ApplicationOwnedUserDto>();
        }
    }
}