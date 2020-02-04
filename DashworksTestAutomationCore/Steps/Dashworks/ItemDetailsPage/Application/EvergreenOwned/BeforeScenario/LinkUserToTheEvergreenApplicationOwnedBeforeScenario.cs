using System.Linq;
using DashworksTestAutomation.DTO.ItemDetails;
using DashworksTestAutomation.DTO.RuntimeVariables.ItemDetails;
using DashworksTestAutomation.Helpers;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage.Application.EvergreenOwned.BeforeScenario
{
    [Binding]
    public class LinkUserToTheEvergreenApplicationOwnedBeforeScenario : SpecFlowContext
    {
        private readonly DefaultApplicationOwnedUser _applicationOwnedUser;

        public LinkUserToTheEvergreenApplicationOwnedBeforeScenario(DefaultApplicationOwnedUser applicationOwnedUser)
        {
            _applicationOwnedUser = applicationOwnedUser;
        }

        [Given(@"Link user to the Evergreen application owned")]
        public void GivenLinkUserToTheEvergreenApplicationOwned(Table table)
        {
            //Data that we should change
            var aou = table.CreateSet<ApplicationOwnedUserDto>();

            //Save original data from the database
            foreach (ApplicationOwnedUserDto dto in aou)
            {
                var ownedUserFromDb = DatabaseHelper.GetApplicationOwnedUser(dto.PackageKey);
                ApplicationOwnedUserDto ownedUser = new ApplicationOwnedUserDto()
                {
                    OwnerUser = ownedUserFromDb.First(),
                    OwnerUserDirectoryObjectKey = ownedUserFromDb.Last(),
                    PackageKey = dto.PackageKey
                };
                _applicationOwnedUser.Value.Add(ownedUser);
            }

            //Change data
            foreach (ApplicationOwnedUserDto dto in aou)
            {
                DatabaseHelper.SetApplicationOwnedUser(dto);
            }
        }
    }
}