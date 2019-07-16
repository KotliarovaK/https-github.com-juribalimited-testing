﻿using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Forms;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System.Threading;
using DashworksTestAutomation.DTO;
using TechTalk.SpecFlow;

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

        [When(@"User clicks Create button on the Create Ring page")]
        public void WhenUserClicksCreateButtonOnTheCreateRingPage()
        {
            var page = _driver.NowAt<CreateRingPage>();
            _driver.WaitForElementToBeDisplayed(page.CreateRingButton);
            page.CreateRingButton.Click();
            Thread.Sleep(2000);
            _driver.WaitForDataLoading();
            Logger.Write("Create Ring button was clicked");
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
            Assert.AreEqual(ringName, page.MapsToEvergreenField.GetAttribute("value"), $"'{ringName}' text is not displayed in Maps to Evergreen Ring field");
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