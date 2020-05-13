using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;
using DashworksTestAutomationCore.Pages.Evergreen.Base.BaseDialog;

namespace DashworksTestAutomationCore.Steps.Dashworks.AdminPage.SelfService.EndClient
{
    [Binding]
    class SelfServiceEndUserDialog
    {

        [Then(@"'(.*)' error message is displayed under '(.*)' field on Self Service EndUser dialog")]
        public void ThenErrorMessageIsDisplayedForField(string errorMessage, string placeholder)
        {
            var page = _driver.NowAt<BaseDashboardPage>();

            Verify.AreEqual(message, page.GetTextboxErrorMessage(placeholder),
                $"Incorrect message is displayed in the '{placeholder}' field");
            ThenMessageIsDisplayedForField(errorMessage, placeholder);

            var page = _driver.NowAt<BaseDashboardPage>();

            Verify.AreEqual("rgba(242, 88, 49, 1)", page.GetTextboxErrorMessageElement(placeholder).GetCssValue("color"),
                $"Incorrect error message color for '{placeholder}' field");
        }
    }
}
