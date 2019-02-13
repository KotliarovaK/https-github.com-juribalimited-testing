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

        public Logout(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Signed Out page is displayed to the user")]
        public void ThenSignedOutPageIsDisplayedToTheUser()
        {
            var header = _driver.NowAt<DashworksHeaderMenuElement>();

            Assert.AreEqual("Logout - Dashworks", _driver.Title);

            Assert.AreEqual("Logout", header.PageHeader.Text);

            var logoutPage = _driver.NowAt<LogoutPage>();

            //Message is different depending on the language
            try
            {
                Assert.AreEqual("You have been successfully logged out", logoutPage.SignedOutMessage.Text);
            }
            catch
            {
                Assert.AreEqual("You have successfully been logged out", logoutPage.SignedOutMessage.Text);
            }

            Logger.Write("Dashworks Signed Out page is displayed");
        }

        [Then(@"User is logged out")]
        public void ThenUserIsLoggedOut()
        {
            var header = _driver.NowAt<DashworksHeaderMenuElement>();

            Assert.IsTrue(header.LoginLink.Displayed(), "Login link was not displayed");

            Logger.Write("User is successfully logged out");
        }
    }
}