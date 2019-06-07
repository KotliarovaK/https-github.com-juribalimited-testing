using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage
{
    [Binding]
    internal class EvergreenJnr_ItemDetailsPage_AggridHeaderCounter : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_ItemDetailsPage_AggridHeaderCounter (RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks Group By button on the Details page and selects ""(.*)"" value")]
        public void WhenUserClicksGroupByButtonOnTheDetailsPageAndSelectsValue(string value)
        {
            var page = _driver.NowAt<AggridHeaderCounterPage>();
            page.GroupByButton.Click();
            _driver.MouseHover(page.GetValueInGroupByFilterOnDetailsPage(value));
            page.GetValueInGroupByFilterOnDetailsPage(value).Click();
            var body = _driver.NowAt<BaseGridPage>();
            body.BodyContainer.Click();
        }
    }
}
