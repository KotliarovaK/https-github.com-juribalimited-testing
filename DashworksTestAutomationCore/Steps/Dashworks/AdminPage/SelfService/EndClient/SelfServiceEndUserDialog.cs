using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;
using DashworksTestAutomationCore.Pages.Evergreen.Base.BaseDialog;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomationCore.Pages.Evergreen.AdminDetailsPages.SelfService.EndClient;

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

        [Then(@"'(.*)' message is displayed under '(.*)' field on Self Service EndUser dialog")]
        public void ThenMessageIsDisplayedUnderFieldOnSelfServiceEndUserDialog(string message, string placeholder)
        {
            var page = _driver.NowAt<SelfServiceEndUserDialogPage>();
            page.BodyContainer.Click();

            Verify.AreEqual(message, page.GetTextboxInlineMessageElement(placeholder),
                $"Incorrect message is displayed in the '{placeholder}' field");
        }

        [Then(@"'(.*)' error message is displayed under '(.*)' field on Self Service EndUser dialog")]
        public void ThenErrorMessageIsDisplayedUnderFieldOnSelfServiceEndUserDialog(string errorMessage, string placeholder)
        {
            ThenMessageIsDisplayedUnderFieldOnSelfServiceEndUserDialog(errorMessage, placeholder);
            
            var page = _driver.NowAt<SelfServiceEndUserDialogPage>();

            Verify.AreEqual("rgba(242, 88, 49, 1)", page.GetTextboxInlineMessageElement(placeholder).GetCssValue("color"),
                $"Incorrect error message color for '{placeholder}' field");
        }
    }
}
