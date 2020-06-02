using System.Linq;
using DashworksTestAutomation.DTO.ItemDetails;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Helpers;
using TechTalk.SpecFlow;

namespace DashworksTestAutomationCore.Steps.Dashworks.ItemDetailsPage.Resync.BeforeScenario
{
    [Binding]
    class ResyncObject : SpecFlowContext
    {
        private readonly ResyncMethods.ResyncMethods _resyncMethods;
        private readonly ResyncObjects _resyncObjects;

        public ResyncObject(RestWebClient client, ResyncObjects resyncObjects)
        {
            _resyncMethods = new ResyncMethods.ResyncMethods(client);
            _resyncObjects = resyncObjects;
        }

        [When(@"User resync '(.*)' objects for '(.*)' project")]
        public void WhenUserResyncObjectsForProject(string listName, string projectName, Table table)
        {
            var projId = DatabaseHelper.GetProjectId(projectName);

            var resyncObjects = new ResyncItemst
            {
                List = listName,
                ProjectName = projectName
            };

            foreach (string itemName in table.Rows.Select(x => x.Values.First()))
            {
                resyncObjects.Objects.Add(itemName);
            }

            _resyncObjects.Value.Add(resyncObjects);
            _resyncMethods.Resync(resyncObjects);
        }
    }
}
