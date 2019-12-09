using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.Base
{
    [Binding]
    class EvergreenJnr_BaseInlineTipBannerElement : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly RunNowAutomationStartTime _automationStartTime;

        public EvergreenJnr_BaseInlineTipBannerElement(RemoteWebDriver driver, RunNowAutomationStartTime automationStartTime)
        {
            _driver = driver;
            _automationStartTime = automationStartTime;
        }

        #region Button

        [When(@"User clicks '(.*)' button on inline tip banner")]
        public void WhenUserClicksButtonOnInlineTipBanner(string button)
        {
            var page = _driver.NowAt<TopInlineTipBannerElement>();
            page.GetButton(button).Click();

            //For automation
            if (button.Equals("RUN"))
            {
                _automationStartTime.Value = DateTime.Now.AddSeconds(-10);
            }
        }

        [Then(@"'(.*)' button is displayed on inline tip banner")]
        public void ThenButtonIsDisplayedOnInlineTipBanner(string button)
        {
            var page = _driver.NowAt<TopInlineTipBannerElement>();
            Verify.IsTrue(page.IsButtonDisplayed(button),
                $"'{button}' button is displayed on inline tip banner");
        }

        #endregion

        #region Banner types display + text

        [Then(@"inline tip banner is not displayed")]
        public void ThenInlineTipBannerIsNotDisplayed()
        {
            TopInlineTipBannerElement page = _driver.NowAtWithoutWait<TopInlineTipBannerElement>();
            Verify.IsFalse(page.InlineTipElement.Displayed(), "Inline tip banner is displayed");
        }

        [Then(@"warning inline tip banner is displayed")]
        public void ThenWarningInlineTipBannerIsDisplayed()
        {
            _driver.WaitForDataLoading();

            TopInlineTipBannerElement page = _driver.NowAtWithoutWait<TopInlineTipBannerElement>();

            page.VerifyColor(MessageColors.Amber);
        }

        [Then(@"success inline tip banner is displayed")]
        public void ThenSuccessInlineTipBannerIsDisplayed()
        {
            TopInlineTipBannerElement page = _driver.NowAtWithoutWait<TopInlineTipBannerElement>();

            page.VerifyColor(MessageColors.Green);
        }

        [Then(@"error inline tip banner is displayed")]
        public void ThenErrorInlineTipBannerIsDisplayed()
        {
            TopInlineTipBannerElement page = _driver.NowAtWithoutWait<TopInlineTipBannerElement>();

            page.VerifyColor(MessageColors.Red);
        }

        [Then(@"'(.*)' text is displayed on success inline tip banner")]
        public void ThenTextIsDisplayedOnSuccessInlineTipBanner(string text)
        {
            TopInlineTipBannerElement page = _driver.NowAtWithoutWait<TopInlineTipBannerElement>();

            page.VerifyMessageTextAndColor(MessageColors.Green, text);
        }

        [Then(@"'(.*)' and '(.*)' texts are displayed on success inline tip banner")]
        public void ThenAndTextsAreDisplayedOnSuccessInlineTipBanner(string firstPart, string secondPart)
        {
            TopInlineTipBannerElement page = _driver.NowAtWithoutWait<TopInlineTipBannerElement>();

            page.VerifyMessageTextAndColor(MessageColors.Green, firstPart);
            page.VerifySecondPartOfText(MessageColors.Green, secondPart);
        }

        [Then(@"'(.*)' text in '(.*)' message is displayed on success inline tip banner")]
        public void ThenTextInMessageIsDisplayedOnSuccessInlineTipBanner(string text, string message)
        {
            var finalMessage = string.Format(message, text);

            TopInlineTipBannerElement page = _driver.NowAtWithoutWait<TopInlineTipBannerElement>();

            page.VerifyMessageTextAndColor(MessageColors.Green, finalMessage);
        }

        [Then(@"'(.*)' text is displayed on warning inline tip banner")]
        public void ThenTextIsDisplayedOnWarningInlineTipBanner(string text)
        {
            _driver.WaitForDataLoading(80);

            TopInlineTipBannerElement page = _driver.NowAtWithoutWait<TopInlineTipBannerElement>();

            page.VerifyMessageTextAndColor(MessageColors.Amber, text);
        }

        [Then(@"'(.*)' text is not displayed on warning inline tip banner")]
        public void ThenTextIsNotDisplayedOnWarningInlineTipBanner(string text)
        {
            _driver.WaitForDataLoading(80);

            TopInlineTipBannerElement page = _driver.NowAtWithoutWait<TopInlineTipBannerElement>();

            //If there is no banner on page then there are no message at all. All good
            if (!_driver.IsElementDisplayed(page.InlineTipElement, WebDriverExtensions.WaitTime.Short))
                return;

            _driver.WaitForElementToNotContainsText(page.InlineTipElement, text);
        }

        [Then(@"'(.*)' text is displayed on error inline tip banner")]
        public void ThenTextIsDisplayedOnErrorInlineTipBanner(string text)
        {
            _driver.WaitForDataLoading(80);

            TopInlineTipBannerElement page = _driver.NowAtWithoutWait<TopInlineTipBannerElement>();

            page.VerifyMessageTextAndColor(MessageColors.Red, text);
        }

        #endregion
    }
}
