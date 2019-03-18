using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_LeavePageWarning : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_LeavePageWarning(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks Yes button in Leave Page Warning")]
        public void WhenUserClicksYesButtonInLeavePageWarning()
        {
            var leavePageWarning = _driver.NowAt<LeavePageWarning>();
            leavePageWarning.ButtonYes.Click();
        }
    }
}