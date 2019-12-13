using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Utils;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.CustomList.AfterScenario
{
    [Binding]
    class RemoveCustomListAfterScenario : SpecFlowContext
    {
        protected readonly UsedUsers _usedUsers;
        protected readonly UsersWithSharedLists _usersWithSharedLists;

        public RemoveCustomListAfterScenario(UsedUsers usedUsers, UsersWithSharedLists usersWithSharedLists)
        {
            _usedUsers = usedUsers;
            _usersWithSharedLists = usersWithSharedLists;
        }

        [AfterScenario("Cleanup")]
        public void DeleteAllCustomListsAfterScenarioRun()
        {
            try
            {
                RemoveUserLists();
                RemoveSharedLists();
            }
            catch (Exception e)
            {
                Logger.Write($"Error during Custom list deleting: {e}");
            }
        }

        private void RemoveUserLists()
        {
            //If non users were logged in then just return. None lists were created
            if (_usedUsers.Value == null || !_usedUsers.Value.Any())
                return;

            foreach (var userDto in _usedUsers.Value)
            {
                try
                {
                    //All lists for all users
                    //var listsIds = DatabaseHelper.ExecuteReader("SELECT [ListId] FROM[DesktopBI].[dbo].[EvergreenList]", 0);
                    //All lists for specific user
                    var listsIds = DatabaseHelper.ExecuteReader(
                        $"select l.ListId from [aspnetdb].[dbo].[aspnet_Users] u join [DesktopBI].[dbo].[EvergreenList] l on u.UserId = l.UserId where u.LoweredUserName = '{userDto.Username}'",
                        0);
                    DatabaseHelper.RemoveLists(listsIds);
                }
                catch (Exception e)
                {
                    Logger.Write($"Error during Custom list deleting: {e}");
                }
            }
        }

        private void RemoveSharedLists()
        {
            //If none lists were shared
            if (_usersWithSharedLists.Value == null || !_usersWithSharedLists.Value.Any())
                return;

            foreach (var user in _usersWithSharedLists.Value)
            {
                try
                {
                    //All lists for all users
                    //var listsIds = DatabaseHelper.ExecuteReader("SELECT [ListId] FROM[DesktopBI].[dbo].[EvergreenList]", 0);
                    //All lists for specific user
                    var listsIds = DatabaseHelper.ExecuteReader(
                        $"select l.ListId from[aspnetdb].[dbo].[aspnet_Users] u join[DesktopBI].[dbo].[EvergreenList] l on u.UserId = l.UserId where u.LoweredUserName = '{user}'",
                        0);
                    DatabaseHelper.RemoveLists(listsIds);
                }
                catch (Exception e)
                {
                    Logger.Write($"Error during Shared Custom list deleting: {e}");
                }
            }
        }
    }
}
