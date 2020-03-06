﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.Base
{
    [Binding]
    internal class EvergreenJnr_BaseDialog : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_BaseDialog(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"popup is displayed to User")]
        public void ThenPopupIsDisplayedToUser()
        {
            var dialogContainer = _driver.NowAt<BaseDialogPage>();
            Verify.IsTrue(dialogContainer.PopupElement.Displayed(), "Dialog Pop-up is not displayed");
        }

        [Then(@"popup is not displayed to User")]
        public void ThenPopupIsNotDisplayedToUser()
        {
            var dialogContainer = _driver.NowAtWithoutWait<BaseDialogPage>();
            Verify.IsFalse(dialogContainer.PopupElement.Displayed(), "Dialog Pop-up was displayed");
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
            _driver.WaitForDataLoading();
        }

        [Then(@"'(.*)' popup button color is '(.*)'")]
        public void ThenPopupButtonColorIs(string button, string color)
        {
            var page = _driver.NowAt<BaseDialogPage>();
            var getColor = page.GetButton(button).GetCssValue("background-color");
            Verify.AreEqual(color, getColor,
                $"'{button}' sah incorrect color");
        }

        [Then(@"'(.*)' button is disabled on popup")]
        public void ThenButtonIsDisabledOnPopup(string buttonName)
        {
            var page = _driver.NowAt<BaseDialogPage>();
            Verify.IsTrue(page.GetButton(buttonName).Disabled(),
                $"'{buttonName}' button is displayed on popup");
        }

        [Then(@"'(.*)' button is not disabled on popup")]
        public void ThenButtonIsNotDisabledOnPopup(string buttonName)
        {
            var page = _driver.NowAt<BaseDialogPage>();
            var button = page.GetButton(buttonName);
            Verify.IsTrue(button.Displayed(),
                $"'{buttonName}' button is not displayed on popup");
            Verify.IsFalse(button.Disabled(),
                $"'{buttonName}' button is displayed  on popup");
        }

        #endregion

        #region ToolTip

        [Then(@"Button '(.*)' has '(.*)' tooltip on popup")]
        public void ButtonHasTooltipOnPopup(string button, string tooltip)
        {
            var page = _driver.NowAt<BaseDialogPage>();
            _driver.MouseHover(page.GetButton(button));
            _driver.WaitForDataLoading();
            var toolTipText = _driver.GetTooltipText();
            Verify.That(tooltip, Is.EqualTo(toolTipText), $"Popup '{button}' button has incorrect tooltip");
        }

        #endregion

        #region Components

        [Then(@"User sees '(.*)' component on dialog")]
        public void ThenUserSeesItemOnDialogPage(string componentName)
        {
            var dialogContainer = _driver.NowAt<BaseDialogPage>();
            Verify.IsTrue(dialogContainer.IsItemInListOfDialogPageDisplayed(componentName), $"'{componentName}' wasn't displayed");
        }

        [Then(@"User does not see '(.*)' component on dialog")]
        public void ThenUserDoesnotComponentOnDialogPage(string componentName)
        {
            var dialogContainer = _driver.NowAt<BaseDialogPage>();
            Verify.IsFalse(dialogContainer.IsItemInListOfDialogPageDisplayed(componentName), $"'{componentName}' was displayed");
        }

        [When(@"User clicks on '(.*)' component on dialog")]
        public void ThenUserClicksOnComponentOnDialogPage(string componentName)
        {
            var dialogContainer = _driver.NowAt<BaseDialogPage>();
            var component = dialogContainer.ComponentOfDialogPage(componentName);
            _driver.ClickByActions(component);
        }

        [Then(@"'(.*)' component on dialog is highlighted")]
        public void ThenComponentOnDialogPageIsHighlighted(string componentName)
        {
            var dialogContainer = _driver.NowAt<BaseDialogPage>();

            Verify.IsTrue(dialogContainer.IsComponentOfDialogPageHighlighted(componentName), $"'{componentName}' component wasn't highlighted");
        }

        [Then(@"'(.*)' component on dialog is disabled")]
        public void ThenComponentOnDialogPageIsdisabled(string componentName)
        {
            var dialogContainer = _driver.NowAt<BaseDialogPage>();

            Verify.IsTrue(dialogContainer.IsComponentOfDialogPageDisabled(componentName), $"'{componentName}' component wasn't disabled");
        }

        #endregion
    }
}