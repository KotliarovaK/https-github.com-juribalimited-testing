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
            int order = page.GetTextComponentOrderByName(_selfServicePages.Value.First(x => x.Name.Equals(pageName)).Components.First(x => x.ComponentName.Equals(textComponentName)));

            Verify.IsTrue(page.СheckThatComponentIsDisplayedOnEndUserPage(pageName, order), $"Text component '{textComponentName}' on '{pageName}' end user page is missing");
        }

        [Then(@"User sees '(.*)' text styled as '(.*)' in '(.*)' Text Component of '(.*)' on end user page")]
        public void ThenUserSeesTextStyledAsInTextComponentOfOnEndUserPage(string text, string style, string textComponentName, string pageName)
        {
            var page = _driver.NowAt<SelfServiceEndUserTextComponentPage>();
            int order = page.GetTextComponentOrderByName(_selfServicePages.Value.First(x => x.Name.Equals(pageName)).Components.First(x => x.ComponentName.Equals(textComponentName)));

            Verify.IsTrue(page.CheckThatStyledTextFromEndUserTextComponentIsDisplayed(pageName, style, text, order), $"The text itself or text styled as '{style}' is missing");
        }

        [Then(@"User sees '(.*)' text styled as '(.*)' in the Text Component that placed on '(.*)' position with '(.*)' end user page name")]
        public void ThenUserSeesTextStyledAsInTheTextComponentThatPlacedOnPositionWithEndUserPageName(string text, string style, int position, string pageName)
        {
            var page = _driver.NowAt<SelfServiceEndUserTextComponentPage>();

            Verify.IsTrue(page.CheckThatStyledTextFromEndUserTextComponentIsDisplayed(pageName, style, text, position), $"The text styled as '{style}' in the Text Component that placed on '{position}' position with '{pageName}' end user page name is missing");
        }
    }
}

