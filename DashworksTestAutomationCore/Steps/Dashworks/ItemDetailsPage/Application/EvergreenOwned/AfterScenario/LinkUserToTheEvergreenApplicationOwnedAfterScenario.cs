using System.Linq;
using DashworksTestAutomation.DTO.ItemDetails;
using DashworksTestAutomation.DTO.RuntimeVariables.ItemDetails;
using DashworksTestAutomation.Helpers;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage.Application.EvergreenOwned.AfterScenario
{
    [Binding]
    public class LinkUserToTheEvergreenApplicationOwnedAfterScenario : SpecFlowContext
    {
        private readonly DefaultApplicationOwnedUser _applicationOwnedUser;

        public LinkUserToTheEvergreenApplicationOwnedAfterScenario(DefaultApplicationOwnedUser applicationOwnedUser)
        {
            _applicationOwnedUser = applicationOwnedUser;
        }

        [AfterScenario("Set_Application_Owned_User", Order = 1)]
        public void SetApplicationOwnedUser()
        {
            if (!_applicationOwnedUser.Value.Any())
                return;

            foreach (ApplicationOwnedUserDto dto in _applicationOwnedUser.Value)
            {
                DatabaseHelper.SetApplicationOwnedUser(dto);
            }
        }
    }
}