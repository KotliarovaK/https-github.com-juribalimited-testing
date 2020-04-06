using System;
using System.Linq;
using DashworksTestAutomation.DTO.ItemDetails;
using DashworksTestAutomation.DTO.RuntimeVariables;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage.Resynk.AfterScenario
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

        [AfterScenario("Cleanup", Order = 10)]
        public void ResyncItems()
        {
            if (!_resyncObjects.Value.Any())
                return;

            foreach (var resyncObject in _resyncObjects.Value)
            {
                try
                {
                    _resyncMethods.Resync(resyncObject);
                }
                catch (Exception e)
                {
                    AutomationUtils.Utils.Logger.Write($"Unable to resync object: {e}");
                }
            }
        }
    }
}
