using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.RuntimeVariables;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.Login
{
    [Binding]
    class EvergreenJnr_LoginApi : BaseLoginActions
    {
        public EvergreenJnr_LoginApi(UserDto user, UsedUsers usedUsers, RestWebClient client, AuthObject authObject) : 
            base(user, usedUsers, client, authObject) { }

        [Given(@"User is logged in to the Evergreen via API")]
        public void GivenUserIsLoggedInToTheEvergreen()
        {
            LoginViaApi(null);
        }
    }
}
