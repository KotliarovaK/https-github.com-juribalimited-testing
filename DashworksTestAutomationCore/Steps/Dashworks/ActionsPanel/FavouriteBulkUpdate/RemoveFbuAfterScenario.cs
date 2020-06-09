using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomationCore.DTO.RuntimeVariables;
using System.Linq;
using TechTalk.SpecFlow;

namespace DashworksTestAutomationCore.Steps.Dashworks.ActionsPanel.FavouriteBulkUpdate
{
    [Binding]
    class RemoveFbuAfterScenario : SpecFlowContext
    {
        private readonly RemoveFbuMethods _removeFbuMethods;
        private readonly FavouriteBulkUpdateObjects _favouriteBulkUpdateObjects;

        private RemoveFbuAfterScenario(FavouriteBulkUpdateObjects favouriteBulkUpdateObjects, RestWebClient client)
        {
            _favouriteBulkUpdateObjects = favouriteBulkUpdateObjects;
            _removeFbuMethods = new RemoveFbuMethods(client);
        }

        [AfterScenario("Cleanup")]
        public void DeleteNewlyCreatedFbu()
        {
            if (_favouriteBulkUpdateObjects.Value.Any())
                _removeFbuMethods.DeleteFavouritesBulkUpdate(_favouriteBulkUpdateObjects.Value);
        }
    }
}
