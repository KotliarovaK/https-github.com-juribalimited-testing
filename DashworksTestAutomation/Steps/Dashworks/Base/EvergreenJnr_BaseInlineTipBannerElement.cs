using System;
using System.Collections.Generic;
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
            var page = _driver.NowAt<BaseInlineTipBannerElement>();
            page.GetButton(button).Click();

            //For automation
            if (button.Equals("RUN"))
            {
                _automationStartTime.Value = DateTime.Now.AddSeconds(-10);
            }
        }

        #endregion

        #region Banner types display + text

        [Then(@"inline tip banner is not displayed")]
        public void ThenInlineTipBannerIsNotDisplayed()
        {
            BaseInlineTipBannerElement page = _driver.NowAtWithoutWait<BaseInlineTipBannerElement>();
            Verify.IsFalse(page.InlineTipElement.Displayed(), "Inline tip banner is displayed");
        }

        [Then(@"'(.*)' text is displayed on warning inline tip banner")]
        public void ThenTextIsDisplayedOnWarningInlineTipBanner(string text)
        {
            _driver.WaitForDataLoading(80);

            BaseInlineTipBannerElement page = _driver.NowAt<BaseInlineTipBannerElement>();

            Verify.AreEqual("rgba(235, 175, 37, 1)", page.GetColor(),
                "Warning inline tip banner is not Amber");

            Verify.IsTrue(page.IsTextPresent(text),
                $"Warning inline tip banner with '{text}' text is not displayed");
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

            BaseInlineTipBannerElement page = _driver.NowAt<BaseInlineTipBannerElement>();

            Verify.AreEqual("rgba(242, 88, 49, 1)", page.GetColor(),
                "Error inline tip banner is not Red");

            Verify.IsTrue(page.IsTextPresent(text),
                $"Error inline tip banner with '{text}' text is not displayed");
        }

        #endregion
    }
}
