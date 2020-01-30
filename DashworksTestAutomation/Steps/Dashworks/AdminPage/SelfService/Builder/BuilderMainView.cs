using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService.Builder;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.Builder
{
    [Binding]
    class BuilderMainView : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public BuilderMainView(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then("User sees page preview with '(.*)' title on the main Builder Page")]
        public void ThenSelfServiceDetailsPageIsDisplayedCorrectly(string title)
        {
            var pageTitle = _driver.NowAt<BuilderMainViewPage>();
            _driver.WaitForElementToBeDisplayed(pageTitle.BuilderPagePreviewTitle(title));

            Verify.IsTrue(pageTitle.BuilderPagePreviewTitle(title).Displayed(), $"Page preview with '{title}' name is missing");
        }
    }
}