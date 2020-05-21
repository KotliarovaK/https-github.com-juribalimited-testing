using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.Base
{
    [Binding]
    public class EvergreenJnr_BaseGridHeader : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_BaseGridHeader(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks Group By button and set checkboxes state")]
        public void WhenUserClicksGroupByButtonAndSetCheckboxesState(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.ClickButtonWithAriaLabel("GroupBy");
            foreach (TableRow row in table.Rows)
            {
                page.SetCheckboxStateFromMenuPanel(row.Values.First(), bool.Parse(row.Values.Last()));
            }
            //Wait for option to be applied
            Thread.Sleep(400);
            _driver.ClickByJavascript(page.BodyContainer);
        }

        [Then(@"following Group By values ​​are displayed for User on menu panel")]
        public void ThenFollowingGroupByValuesAreDisplayedForUserOnMenuPanel(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.ClickButtonWithAriaLabel("GroupBy");

            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = page.GetAllOptionsFromMenuPanel().Select(x => x.Key).ToList();

            Verify.AreEqual(expectedList, actualList, "Group By values are not displayed correctly");

             _driver.ClickByJavascript(page.BodyContainer);
        }
    }
}