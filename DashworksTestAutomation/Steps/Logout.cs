using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps
{
    [Binding]
    internal class Logout : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public Logout(RemoteWebDriver driver, BrowsersList browsersList)
        {
            _driver = browsersList.GetBrowser();
        }

        [Then(@"Signed Out page is displayed to the user")]
        public void ThenSignedOutPageIsDisplayedToTheUser()
        {
            var header = _driver.NowAt<DashworksHeaderMenuElement>();

            Verify.AreEqual("Logout - Dashworks", _driver.Title, "PLEASE ADD EXCEPTION MESSAGE");

            Verify.AreEqual("Logout", header.PageHeader.Text, "PLEASE ADD EXCEPTION MESSAGE");

            var logoutPage = _driver.NowAt<LogoutPage>();

            //Message is different depending on the language
            try
            {
                Verify.AreEqual("You have been successfully logged out", logoutPage.SignedOutMessage.Text, "PLEASE ADD EXCEPTION MESSAGE");
            }
            catch
            {
                Verify.AreEqual("You have successfully been logged out", logoutPage.SignedOutMessage.Text, "PLEASE ADD EXCEPTION MESSAGE");
            }

            Logger.Write("Dashworks Signed Out page is displayed");
        }

        [Then(@"User is logged out")]
        public void ThenUserIsLoggedOut()
        {
            var header = _driver.NowAt<DashworksHeaderMenuElement>();

            Verify.IsTrue(header.LoginLink.Displayed(), "Login link was not displayed");

            Logger.Write("User is successfully logged out");
        }
    }
}