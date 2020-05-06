using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Onboarding
{
    class OnboardObjects
    {
        private readonly OnboardObjectsToProjectAPIMethods _onboardObjectsToProjectApiMethods;

        //| Device names |
        [When(@"User onboards devices to '(.*)' project")]
        public void WhenUserOnboardsDevicesToTheProject(string projectName, Table table)
        {
            _onboardObjectsToProjectApiMethods
                .OnboardObjectsToProjectAPI(OnboardObjectsToProjectAPIMethods.ObjectType.Devices, projectName, table, out var exception);
        }

        //| Users names |
        [When(@"User onboards devices to '(.*)' project")]
        public void WhenUserOnboardsUsersToTheProject(string projectName, Table table)
        {
            _onboardObjectsToProjectApiMethods
                .OnboardObjectsToProjectAPI(OnboardObjectsToProjectAPIMethods.ObjectType.Users, projectName, table, out var exception);
        }

        //| Applications names |
        [When(@"User onboards devices to '(.*)' project")]
        public void WhenUserOnboardsApplicationsToTheProject(string projectName, Table table)
        {
            _onboardObjectsToProjectApiMethods
                .OnboardObjectsToProjectAPI(OnboardObjectsToProjectAPIMethods.ObjectType.Applications, projectName, table, out var exception);
        }
    }
}