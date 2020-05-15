using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;
using DashworksTestAutomationCore.Pages.Evergreen.Base.BaseDialog;
using DashworksTestAutomation.Pages.Evergreen.Base;

namespace DashworksTestAutomationCore.Steps.Dashworks.AdminPage.SelfService.EndClient
{
    [Binding]
    class SelfServiceEndUserDialog : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public SelfServiceEndUserDialog(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        //Temporary step!!! Remove it when common autocomplete on EndUser will be implemented
        [Then(@"'(.*)' message is displayed under '(.*)' field on Self Service EndUser dialog")]
        public void ThenMessageIsDisplayedUnderFieldOnSelfServiceEndUserDialog(string message, string placeholder)
        {
            CheckErrorMessage(message, placeholder, "rgba(0, 0, 0, .87)");
        }

        //Temporary step!!! Remove it when common autocomplete on EndUser will be implemented
        [Then(@"'(.*)' error message is displayed under '(.*)' field on Self Service EndUser dialog")]
        public void ThenErrorMessageIsDisplayedUnderFieldOnSelfServiceEndUserDialog(string errorMessage, string placeholder)
        {
            CheckErrorMessage(errorMessage, placeholder, "rgba(242, 88, 49, 1)");
        }

        private void CheckErrorMessage(string errorMessage, string placeholder, string color)
        {
            var page = _driver.NowAt<BaseDialogDashboardPage>();

            Verify.AreEqual(errorMessage, page.GetSSTextboxInlineMessageElement(placeholder),
                $"Incorrect message is displayed in the '{placeholder}' field");

            Verify.AreEqual(color, page.GetSSTextboxInlineMessageElement(placeholder).GetCssValue("color"),
                $"Incorrect error message color for '{placeholder}' field");
        }
    }
}