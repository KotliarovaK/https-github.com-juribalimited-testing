using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Utils;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.CustomList.AfterScenario
{
    [Binding]
    class RemoveCustomListAfterScenario : SpecFlowContext
    {
        private readonly RemoveCustomListMethods _customListMethods;

        public RemoveCustomListAfterScenario(UsedUsers usedUsers, UsersWithSharedLists usersWithSharedLists)
        {
            _customListMethods = new RemoveCustomListMethods(usedUsers, usersWithSharedLists);
        }

        [AfterScenario("Cleanup", Order = 10)]
        public void DeleteAllCustomListsAfterScenarioRun()
        {
            try
            {
                _customListMethods.RemoveUserLists();
                _customListMethods.RemoveSharedLists();
            }
            catch (Exception e)
            {
                Logger.Write($"Error during Custom list deleting: {e}");
            }
        }
    }
}
