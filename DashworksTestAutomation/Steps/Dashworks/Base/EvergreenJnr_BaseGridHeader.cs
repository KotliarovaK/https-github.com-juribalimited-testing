using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.Base;
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
            page.BodyContainer.Click();
        }
    }
}
