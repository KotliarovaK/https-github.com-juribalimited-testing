using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    class EvergreenJnr_ActionsPanel : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ActionsPanel(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Actions panel is displayed to the user")]
        public void ThenActionsPanelIsDisplayedToTheUser()
        {
            var columnElement = _driver.NowAt<ActionsElement>();
            Assert.IsTrue(columnElement.ActionsPanel.Displayed(), "Actions panel was not displayed");
            Logger.Write("Actions Panel panel is visible");
        }

        [When(@"User select all rows")]
        public void WhenUserSelectAllRows()
        {
            var dashboardPage = _driver.NowAt<BaseDashbordPage>();
            dashboardPage.SelectAllCheckbox.Click();
        }
    }
}
