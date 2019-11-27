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

        [Then(@"Dialog Pop-up is displayed for User")]
        public void ThenDialogPop_UpIsDisplayedForUser()
        {
            var dialogContainer = _driver.NowAt<BaseDialogPage>();
            Verify.IsTrue(dialogContainer.PopupElement.Displayed(), "Dialog Pop-up is not displayed");
        }

        [Then(@"Popup with '(.*)' title is displayed")]
        public void ThenPopupWithTitleIsDisplayed(string title)
        {
            var page = _driver.NowAt<BaseDialogPage>();
            _driver.WaitForElementToContainsText(page.PopupTitle, title);
        }

        [Then(@"following text '(.*)' is displayed in Dialog Pop-up")]
        public void ThenFollowingTextIsDisplayedInDialogPop_Up(string text)
        {
            var dialogContainer = _driver.NowAt<BaseDialogPage>();
            var actualText = dialogContainer.PopupElement.Text.Replace("\r\n", " ");
            Verify.Contains(text, actualText, $"'{text}' in Dialog Pop-up is not displayed correctly!");
        }

        #region Button

        [When(@"User clicks '(.*)' button on popup")]
        public void WhenUserClicksButtonInDialogPopUp(string buttonName)
        {
            var dialogContainer = _driver.NowAt<BaseDialogPage>();
            dialogContainer.GetButtonByNameOnPopup(buttonName).Click();
        }

        [Then(@"'(.*)' popup button color is '(.*)'")]
        public void ThenPopupButtonColorIs(string button, string color)
        {
            var page = _driver.NowAt<BaseDialogPage>();
            var getColor = page.GetButtonByNameOnPopup(button).GetCssValue("background-color");
            Verify.AreEqual(color, getColor,
                $"'{button}' sah incorrect color");
        }

        #endregion
    }
}