using System;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.Base;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;

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
            var page = _driver.NowAt<BaseInlineBannerElement>();
            page.GetButton(MessageType.Tip, button).Click();

            //For automation
            if (button.Equals("RUN"))
            {
                _automationStartTime.Value = DateTime.Now.AddSeconds(-10);
            }
        }

        [Then(@"'(.*)' button is displayed on inline tip banner")]
        public void ThenButtonIsDisplayedOnInlineTipBanner(string button)
        {
            var page = _driver.NowAt<BaseInlineBannerElement>();
            Verify.IsTrue(page.IsButtonDisplayed(MessageType.Tip, button),
                $"'{button}' button is displayed on inline tip banner");
        }

        #endregion

        #region Link

        [Then(@"'(.*)' link is displayed on inline success banner")]
        public void ThenLinkIsDisplayedOnInlineSuccessBanner(string link)
        {
            var page = _driver.NowAt<BaseInlineBannerElement>();
            Verify.IsTrue(page.IsLinkDisplayed(MessageType.Success, link),
                $"'{link}' link is not displayed on inline success banner");
        }

        [Then(@"User clicks on '(.*)' link on inline success banner")]
        public void ThenUserClicksOnLinkOnInlineSuccessBanner(string link)
        {
            var page = _driver.NowAt<BaseInlineBannerElement>();
            page.GetLinkByText(MessageType.Success, link).Click();
        }

        #endregion

        #region Banner types display + text

        [Then(@"inline tip banner is not displayed")]
        public void ThenInlineTipBannerIsNotDisplayed()
        {
            ThenInlineBannerIsNotDisplayed(MessageType.Tip);
        }

        [Then(@"inline error banner is not displayed")]
        public void ThenInlineErrorBannerIsNotDisplayed()
        {
            ThenInlineBannerIsNotDisplayed(MessageType.Error);
        }

        [Then(@"inline success banner is not displayed")]
        public void ThenInlineSuccessBannerIsNotDisplayed()
        {
            ThenInlineBannerIsNotDisplayed(MessageType.Success);
        }

        [Then(@"inline info banner is not displayed")]
        public void ThenInlineInfoBannerIsNotDisplayed()
        {
            ThenInlineBannerIsNotDisplayed(MessageType.Info);
        }

        public void ThenInlineBannerIsNotDisplayed(MessageType messageType)
        {
            BaseInlineBannerElement page = _driver.NowAtWithoutWait<BaseInlineBannerElement>();
            Verify.IsFalse(page.GetInlineBanner(messageType).Displayed(), "Inline tip banner is displayed");
        }

        [Then(@"inline warning banner is displayed")]
        public void ThenInlineWarningBannerIsDisplayed()
        {
            _driver.WaitForDataLoading();

            BaseInlineBannerElement page = _driver.NowAt<BaseInlineBannerElement>();

            page.VerifyColor(MessageType.Tip);
        }

        //TODO DO NOT USE THIS STEP!!!!!!
        [Then(@"inline success banner is displayed")]
        public void ThenInlineSuccessBannerIsDisplayed()
        {
            BaseInlineBannerElement page = _driver.NowAt<BaseInlineBannerElement>();

            page.VerifyColor(MessageType.Success);
        }

        //TODO Remove and do not use this step!!!
        [Then(@"inline error banner is displayed")]
        public void ThenInlineErrorBannerIsDisplayed()
        {
            BaseInlineBannerElement page = _driver.NowAt<BaseInlineBannerElement>();

            page.VerifyColor(MessageType.Error);
        }

        [Then(@"'(.*)' text is displayed on inline success banner")]
        public void ThenTextIsDisplayedOnInlineSuccessBanner(string text)
        {
            BaseInlineBannerElement page = _driver.NowAtWithoutWait<BaseInlineBannerElement>();

            page.VerifyMessageTextAndColor(MessageType.Success, text);
        }

        [Then(@"inline success banner contains '(.*)' text")]
        public void ThenInlineSuccessBannerContainsText(string text)
        {
            BaseInlineBannerElement page = _driver.NowAtWithoutWait<BaseInlineBannerElement>();

            page.VerifyMessageTextAndColor(MessageType.Success, text);
        }

        [Then(@"'(.*)' and '(.*)' texts are displayed on inline success banner")]
        public void ThenAndTextsAreDisplayedOnInlineSuccessBanner(string firstPart, string secondPart)
        {
            BaseInlineBannerElement page = _driver.NowAtWithoutWait<BaseInlineBannerElement>();

            page.VerifyMessageTextAndColor(MessageType.Success, firstPart);
            page.VerifySecondPartOfText(MessageType.Success, secondPart);
        }

        [Then(@"'(.*)' text in '(.*)' message is displayed on inline success banner")]
        public void ThenTextInMessageIsDisplayedOnInlineSuccessBanner(string text, string message)
        {
            var finalMessage = string.Format(message, text);

            BaseInlineBannerElement page = _driver.NowAtWithoutWait<BaseInlineBannerElement>();

            page.VerifyMessageTextAndColor(MessageType.Success, finalMessage);
        }

        [Then(@"'(.*)' text is displayed on inline tip banner")]
        public void ThenTextIsDisplayedOnWarningInlineTipBanner(string text)
        {
            _driver.WaitForDataLoading(80);

            BaseInlineBannerElement page = _driver.NowAt<BaseInlineBannerElement>();

            page.VerifyMessageTextAndColor(MessageType.Tip, text);
        }

        [Then(@"'(.*)' text is not displayed on warning inline tip banner")]
        public void ThenTextIsNotDisplayedOnInlineTipBanner(string text)
        {
            _driver.WaitForDataLoading(80);

            BaseInlineBannerElement page = _driver.NowAtWithoutWait<BaseInlineBannerElement>();

            //If there is no banner on page then there are no message at all. All good
            if (!_driver.IsElementDisplayed(page.GetInlineBanner(MessageType.Info), WebDriverExtensions.WaitTime.Short))
                return;

            _driver.WaitForElementToNotContainsText(page.GetInlineBanner(MessageType.Info), text);
        }

        [Then(@"'(.*)' text is displayed on inline error banner")]
        public void ThenTextIsDisplayedOnInlineErrorBanner(string text)
        {
            _driver.WaitForDataLoading(80);

            BaseInlineBannerElement page = _driver.NowAtWithoutWait<BaseInlineBannerElement>();

            page.VerifyMessageTextAndColor(MessageType.Error, text);
        }

        #endregion
    }
}