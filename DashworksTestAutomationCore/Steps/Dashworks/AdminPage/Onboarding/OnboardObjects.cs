using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.DTO.RuntimeVariables.Onboarding;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Onboarding
{
    [Binding]
    class OnboardObjects : SpecFlowContext
    {
        private readonly OnboardedObjects _onboardedObjects;
        private readonly OnboardObjectsToProjectAPIMethods _onboardObjectsToProjectApiMethods;

        public OnboardObjects(OnboardedObjects onboardedObjects, RestWebClient client)
        {
            _onboardedObjects = onboardedObjects;
            _onboardObjectsToProjectApiMethods = new OnboardObjectsToProjectAPIMethods(client, onboardedObjects);
        }

        //| DeviceObjects | OR | UserObjects | OR | ApplicationObjects |
        [When(@"User onboard objects to '(.*)' project")]
        public void WhenUserOnboardObjectsToTheProject(string projectName, Table table)
        {
            _onboardObjectsToProjectApiMethods.OnboardObjectsToProjectAPI(projectName, table);
        }
    }
}