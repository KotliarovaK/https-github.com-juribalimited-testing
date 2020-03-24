using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.Evergreen.Admin.Rings;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.ManagementConsole.Users.AfterScenario
{
    [Binding]
    class RemoveUserAfterScenario : SpecFlowContext
    {
        private readonly DTO.RuntimeVariables.Users _users;

        public RemoveUserAfterScenario(DTO.RuntimeVariables.Users users)
        {
            _users = users;
        }

        [AfterScenario("Cleanup", Order = 30)]
        public void DeleteNewlyCreatedUser()
        {
            if (!_users.Value.Any())
                return;

            foreach (UserDto user in _users.Value)
            {
                try
                {
                    DatabaseHelper.DeleteUser(user);
                }
                catch (Exception e)
                {
                    Logger.Write($"Unable to delete User via API: {e}");
                }
            }
        }
    }
}
