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

        enum MessageColors
        {
            [Description("rgba(235, 175, 37, 1)")]
            Amber,
            [Description("rgba(242, 88, 49, 1)")]
            Red,
            [Description("rgba(126, 189, 56, 1)")]
            Green
        }

        public EvergreenJnr_BaseInlineTipBannerElement(RemoteWebDriver driver, RunNowAutomationStartTime automationStartTime)
        {
            _driver = driver;
            _automationStartTime = automationStartTime;
        }

        #region Button

        [When(@"User clicks '(.*)' button on inline tip banner")]
        public void WhenUserClicksButtonOnInlineTipBanner(string button)
        {
            var page = _driver.NowAt<BaseInlineTipBannerElement>();
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
            var page = _driver.NowAt<BaseInlineTipBannerElement>();
            Verify.IsTrue(page.IsButtonDisplayed(button),
                $"'{button}' button is displayed on inline tip banner");
        }

        #endregion

        #region Banner types display + text

        [Then(@"inline tip banner is not displayed")]
        public void ThenInlineTipBannerIsNotDisplayed()
        {
            BaseInlineTipBannerElement page = _driver.NowAtWithoutWait<BaseInlineTipBannerElement>();
            Verify.IsFalse(page.InlineTipElement.Displayed(), "Inline tip banner is displayed");
        }

        [Then(@"warning inline tip banner is displayed")]
        public void ThenWarningInlineTipBannerIsDisplayed()
        {
            BaseInlineTipBannerElement page = _driver.NowAtWithoutWait<BaseInlineTipBannerElement>();

            Verify.AreEqual(MessageColors.Amber.GetValueAndDescription().Value, page.GetColor(),
                "Warning inline tip banner is not Amber");
        }

        [Then(@"success inline tip banner is displayed")]
        public void ThenSuccessInlineTipBannerIsDisplayed()
        {
            BaseInlineTipBannerElement page = _driver.NowAtWithoutWait<BaseInlineTipBannerElement>();

            Verify.AreEqual(MessageColors.Green.GetValueAndDescription().Value, page.GetColor(),
                "Success inline tip banner is not Green");
        }

        [Then(@"error inline tip banner is displayed")]
        public void ThenErrorInlineTipBannerIsDisplayed()
        {
            BaseInlineTipBannerElement page = _driver.NowAtWithoutWait<BaseInlineTipBannerElement>();

            Verify.AreEqual(MessageColors.Red.GetValueAndDescription().Value, page.GetColor(),
                "Error inline tip banner is not Red");
        }

        [Then(@"'(.*)' text is displayed on success inline tip banner")]
        public void ThenTextIsDisplayedOnSuccessInlineTipBanner(string text)
        {
            VerifyMessageTextAndColor(MessageColors.Green, text);
        }

        [Then(@"'(.*)' text in '(.*)' message is displayed on success inline tip banner")]
        public void ThenTextInMessageIsDisplayedOnSuccessInlineTipBanner(string text, string message)
        {
            var finalMessage = string.Format(message, text);

            VerifyMessageTextAndColor(MessageColors.Green, finalMessage);
        }

        [Then(@"'(.*)' text is displayed on warning inline tip banner")]
        public void ThenTextIsDisplayedOnWarningInlineTipBanner(string text)
        {
            _driver.WaitForDataLoading(80);

            VerifyMessageTextAndColor(MessageColors.Amber, text);
        }

        [Then(@"'(.*)' text is not displayed on warning inline tip banner")]
        public void ThenTextIsNotDisplayedOnWarningInlineTipBanner(string text)
        {
            _driver.WaitForDataLoading(80);

            BaseInlineTipBannerElement page = _driver.NowAtWithoutWait<BaseInlineTipBannerElement>();

            //If there is no banner on page then there are no message at all. All good
            if (!_driver.IsElementDisplayed(page.InlineTipElement, WebDriverExtensions.WaitTime.Short))
                return;

            _driver.WaitForElementToNotContainsText(page.InlineTipElement, text);
        }

        [Then(@"'(.*)' text is displayed on error inline tip banner")]
        public void ThenTextIsDisplayedOnErrorInlineTipBanner(string text)
        {
            _driver.WaitForDataLoading(80);

            VerifyMessageTextAndColor(MessageColors.Red, text);
        }

        private void VerifyMessageTextAndColor(MessageColors messageColor, string expectedText)
        {
            BaseInlineTipBannerElement page = _driver.NowAt<BaseInlineTipBannerElement>();

            Verify.AreEqual(messageColor.GetValueAndDescription().Value, page.GetColor(),
                $"Inline tip banner is not {messageColor.ToString()}");

            Verify.IsTrue(page.IsTextPresent(expectedText),
                $"{messageColor.ToString()} inline tip banner with '{expectedText}' text is not displayed");
        }

        #endregion
    }
}
