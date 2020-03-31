using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService.EndClient;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.EndClient
{
    [Binding]
    class EndUserPageTextComponent : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly SelfServicePages _selfServicePages;

        public EndUserPageTextComponent(RemoteWebDriver driver, SelfServicePages selfServicePages)
        {
            _driver = driver;
            _selfServicePages = selfServicePages;
        }

        [Then(@"User sees '(.*)' text component '(.*)' on end user page")]
        public void ThenUserSeesTextComponentOnEndUserPage(string textComponentName, string pageName)
        {
            var page = _driver.NowAt<SelfServiceEndUserTextComponentPage>();
            var sSpage = _selfServicePages.Value.First(x => x.Name.Equals(pageName));

            Verify.IsTrue(page.СheckThatComponentIsDisplayedOnEndUserPage(sSpage, textComponentName), $"Text component '{textComponentName}' on '{pageName}' end user page is missing");
        }

        [Then(@"User sees '(.*)' text styled as '(.*)' in '(.*)' Text Component of '(.*)' on end user page")]
        public void ThenUserSeesTextStyledAsInTextComponentOfOnEndUserPage(string text, string style, string textComponentName, string pageName)
        {
            var page = _driver.NowAt<SelfServiceEndUserTextComponentPage>();
            var sSpage = _selfServicePages.Value.First(x => x.Name.Equals(pageName));

            Verify.IsTrue(page.CheckThatStyledTextFromEndUserTextComponentIsDisplayed(sSpage, style, text, textComponentName), $"The text itself or text styled as '{style}' is missing");
        }

        [Then(@"User sees '(.*)' text styled as '(.*)' in the Text Component '(.*)' that placed on '(.*)' position on '(.*)' End User page")]
        public void ThenUserSeesTextStyledAsInTheTextComponentThatPlacedOnPositionOnEndUserPage(string text, string style, string textComponentName, int order, string pageName)
        {
            var page = _driver.NowAt<SelfServiceEndUserTextComponentPage>();
            var sSpage = _selfServicePages.Value.First(x => x.Name.Equals(pageName));

            Verify.IsTrue(page.CheckThatStyledTextFromEndUserTextComponentIsDisplayed(sSpage, style, text, textComponentName), $"The text styled as '{style}' in the Text Component that placed on '{order}' position with '{pageName}' end user page name is missing");
        }

        [Then(@"User sees '(.*)' text styled as '(.*)' in the Text Component '(.*)' that moved to '(.*)' position on '(.*)' End User page")]
        public void ThenUserSeesTextStyledAsInTheTextComponentThatMovedToPositionOnEndUserPage(string text, string style, string textComponentName, int order, string pageName)
        {
            var page = _driver.NowAt<SelfServiceEndUserTextComponentPage>();
            var sSpage = _selfServicePages.Value.First(x => x.Name.Equals(pageName));
            page.SetExpectedComponentOrderInDto(sSpage, order, textComponentName);

            Verify.IsTrue(page.CheckThatStyledTextFromEndUserTextComponentIsDisplayed(sSpage, style, text, textComponentName), $"The text styled as '{style}' in the Text Component that placed on '{order}' position with '{pageName}' end user page name is missing");
        }
    }
}