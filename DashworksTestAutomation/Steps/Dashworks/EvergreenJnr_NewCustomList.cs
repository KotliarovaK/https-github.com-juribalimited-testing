using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    class EvergreenJnr_NewCustomList : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_NewCustomList(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Save to New Custom List element should NOT be displayed")]
        public void ThenSaveToNewCustomListElementShouldNOTBeDisplayed()
        {
            var page = _driver.NowAt<BaseDashbordPage>();

            Assert.IsFalse(page.SaveCustomListButton.Displayed(), "Save Custom list displayed when user just perform search");

            Logger.Write("The Save to Custom List Element was NOT displayed");
        }
    }
}
