using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Providers;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Slots
{
    [Binding]
    class NavigationSlots : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly DTO.RuntimeVariables.Slots _slots;

        public NavigationSlots(RemoteWebDriver driver, DTO.RuntimeVariables.Slots slots)
        {
            _driver = driver;
            _slots = slots;
        }

        [When(@"User navigates to newly created Slot")]
        public void WhenUserNavigatesToNewlyCreatedCapacityUnit()
        {
            if (!_slots.Value.Any())
                throw new Exception("There are no created Slots to navigate");

            var url = $"{UrlProvider.EvergreenUrl}/#/admin/project/{DatabaseHelper.GetProjectId(_slots.Value.Last().Project)}/capacity/slots/slot/{_slots.Value.Last().Id}";
            _driver.NavigateToUrl(url);
            _driver.WaitForDataLoading();
        }
    }
}