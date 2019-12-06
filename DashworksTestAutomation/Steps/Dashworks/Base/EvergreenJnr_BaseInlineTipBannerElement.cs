using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

        public EvergreenJnr_BaseInlineTipBannerElement(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        #region Button

        [When(@"User clicks '(.*)' button on inline tip banner")]
        public void WhenUserClicksButtonOnInlineTipBanner(string button)
        {
            var page = _driver.NowAt<BaseInlineTipBannerElement>();
            page.GetButton(button).Click();
        }

        #endregion

        #region Banner types with text

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

        #endregion
    }
}
