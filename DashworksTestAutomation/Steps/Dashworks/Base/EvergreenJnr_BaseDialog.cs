using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
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
            Verify.IsTrue(dialogContainer.DialogPopUp.Displayed(), "Dialog Pop-up is not displayed");
            Logger.Write("Dialog Pop-up is displayed on the Item Details page");
        }

        [Then(@"following text '(.*)' is displayed in Dialog Pop-up")]
        public void ThenFollowingTextIsDisplayedInDialogPop_Up(string text)
        {
            var dialogContainer = _driver.NowAt<BaseDialogPage>();
            var actualText = dialogContainer.GetPopupText().Replace("\r\n", " ");
            Verify.Contains(text, actualText, $"'{text}' in Dialog Pop-up is not displayed correctly!");
        }

        [When(@"User clicks '(.*)' button in Dialog Pop-up")]
        public void WhenUserClicksButtonInDialogPopUp(string buttonName)
        {
            var dialogContainer = _driver.NowAt<BaseDialogPage>();
            dialogContainer.ClickPopupButtonByName(buttonName);
        }
    }
}