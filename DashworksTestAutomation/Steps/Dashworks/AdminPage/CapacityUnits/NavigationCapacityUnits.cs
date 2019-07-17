using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.CapacityUnits
{
    [Binding]
    class NavigationCapacityUnits : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly DTO.RuntimeVariables.CapacityUnits.CapacityUnits _capacityUnits;

        public NavigationCapacityUnits(RemoteWebDriver driver, DTO.RuntimeVariables.CapacityUnits.CapacityUnits capacityUnits)
        {
            _driver = driver;
            _capacityUnits = capacityUnits;
        }

        [When(@"User navigates to newly created Capacity Unit")]
        public void WhenUserNavigatesToNewlyCreatedCapacityUnit()
        {
            if (!_capacityUnits.Value.Any())
                throw new Exception("There are no created Capacity Units to navigate");

            var url = $"{UrlProvider.EvergreenUrl}/#/admin/capacityUnit/{_capacityUnits.Value.Last().GetId()}/settings";
            _driver.NavigateToUrl(url);
            _driver.WaitForDataLoading();
        }
    }
}
