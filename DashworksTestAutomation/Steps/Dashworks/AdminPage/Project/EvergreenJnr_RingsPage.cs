using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Forms;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System.Threading;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO;
using TechTalk.SpecFlow;
using Logger = DashworksTestAutomation.Utils.Logger;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_RingsPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        
        public EvergreenJnr_RingsPage(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User sets ""(.*)"" value in Maps to evergreen ring field")]
        public void WhenUserSetsMapsToEvergreenRingValue(string option)
        {
            var page = _driver.NowAt<CreateRingPage>();
            page.MapsToEvergreenField.Clear();
            page.MapsToEvergreenField.SendKeys(option);
            page.SelectOptionInMapsToEvergreenRingDropdown(option);
            Logger.Write("Create Ring button was clicked");
        }

        [Then(@"Ring settings Maps to evergreen ring is displayed as ""(.*)""")]
        public void ThenRingSettingsMapsToEvergreenIsDisplayedCorrectly(string ringName)
        {
            var page = _driver.NowAt<CreateRingPage>();
            Verify.AreEqual(ringName, page.MapsToEvergreenField.GetAttribute("value"), $"'{ringName}' text is not displayed in Maps to Evergreen Ring field");
        }

        [When(@"User doubleclicks Create button on Create Ring page")]
        public void WhenUserDoubleclicksCreateButtonOnTheCreateRingPage()
        {
            var page = _driver.NowAt<CreateRingPage>();
            page.Actions.Click(page.CreateRingButton).DoubleClick().Build().Perform();
        }

        [When(@"User clicks Default Ring checkbox")]
        public void WhenUserClicksDefaultRingCheckbox()
        {
            var page = _driver.NowAt<CreateRingPage>();
            page.DefaultRingCheckbox.Click();
        }
    }
}