using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.Base
{
    [Binding]
    internal class EvergreenJnr_BaseDialog : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_BaseDialog (RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"popup is displayed to User")]
        public void ThenPopupIsDisplayedToUser()
        {
            var dialogContainer = _driver.NowAt<BaseDialogPage>();
            Verify.IsTrue(dialogContainer.PopupElement.Displayed(), "Dialog Pop-up is not displayed");
        }

        [Then(@"popup with '(.*)' title is displayed")]
        public void ThenPopupWithTitleIsDisplayed(string title)
        {
            var page = _driver.NowAt<BaseDialogPage>();
            _driver.WaitForElementToContainsText(page.PopupTitle, title);
        }

        [Then(@"'(.*)' text is displayed on popup")]
        public void ThenTextIsDisplayedOnPopup(string text)
        {
            var dialogContainer = _driver.NowAt<BaseDialogPage>();
            var actualText = dialogContainer.PopupElement.Text.Replace("\r\n", " ");
            Verify.Contains(text, actualText, $"'{text}' in Dialog Pop-up is not displayed correctly!");
        }

        #region Button

        [When(@"User clicks '(.*)' button on popup")]
        public void WhenUserClicksButtonOnPopup(string buttonName)
        {
            var dialogContainer = _driver.NowAt<BaseDialogPage>();
            dialogContainer.GetButton(buttonName).Click();
        }

        [Then(@"'(.*)' popup button color is '(.*)'")]
        public void ThenPopupButtonColorIs(string button, string color)
        {
            var page = _driver.NowAt<BaseDialogPage>();
            var getColor = page.GetButton(button).GetCssValue("background-color");
            Verify.AreEqual(color, getColor,
                $"'{button}' sah incorrect color");
        }

        #endregion
    }
}