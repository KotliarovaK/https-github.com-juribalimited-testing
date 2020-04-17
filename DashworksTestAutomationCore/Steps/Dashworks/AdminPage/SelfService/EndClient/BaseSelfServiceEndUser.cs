using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutomationUtils.Utils;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.SelfService.EndClient;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using DashworksTestAutomation.Providers;
using TechTalk.SpecFlow;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.DTO.RuntimeVariables.SelfService;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder;
using DashworksTestAutomation.DTO.Evergreen.Admin.SelfService.Builder.Components;
using AutomationUtils.Extensions;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.SelfService.EndClient
{
    [Binding]
    class BaseSelfServiceEndUser : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly SelfServices _selfServices;
        private readonly ComponentsOfSelfServicePageDto _componentsOfSelfServicePageDto;
        private readonly SelfServicePages _selfServicePages;
        

        public BaseSelfServiceEndUser(RemoteWebDriver driver, SelfServices selfServices, ComponentsOfSelfServicePageDto componentsOfSelfServicePageDto, SelfServicePages selfServicePages)
        {
            _driver = driver;
            _selfServices = selfServices;
            _componentsOfSelfServicePageDto = componentsOfSelfServicePageDto;
            _selfServicePages = selfServicePages;
        }

        [When(@"User navigates to End User landing page with '(.*)' Self Service Identifier")]
        public void WhenUserNavigatesToFirsEndUserPageWithSelfServiceIdentifier(string selfServiceIdentifier)
        {
            SelfServicePageDto page = _selfServicePages.Value.First(x => x.Name.Equals("Welcome"));
            SelfServiceApplicationOwnershipComponent appOwnershipComponent = (SelfServiceApplicationOwnershipComponent)page.Components.First(x => x.ComponentType.Equals("Application Ownership"));
            int appOwnershipcomponentId = appOwnershipComponent.ComponentId;
            string ssGuid = DatabaseHelper.GetSelfServiceObjectGuid(selfServiceIdentifier, appOwnershipcomponentId);
            string navigationUrl = $"{UrlProvider.EvergreenUrl}#/selfservice/{selfServiceIdentifier}?ObjectId={ssGuid}";

            _driver.NavigateToUrl(navigationUrl);
        }

        //TO DO: Remove this step as soon as DAS-20451 will be implemented
        [When(@"User navigates to End User landing page with '(.*)' Self Service Identifier, '(.*)' scope list and '(.*)' project name")]
        public void WhenUserNavigatesToEndUserLandingPageWithSelfServiceIdentifierScopeListAndProjectName(string selfServiceIdentifier, string scopeList, string projectName)
        {
            int listId = Int32.Parse(DatabaseHelper.GetProjectListIdScope(scopeList)) + 1;
            var projectId = DatabaseHelper.GetProjectId(projectName);

            string ssGuid = DatabaseHelper.TempGetSelfServiceObjectGuid(listId.ToString(), projectId);
            string navigationUrl = $"{UrlProvider.EvergreenUrl}#/selfservice/{selfServiceIdentifier}?ObjectId={ssGuid}";

            _driver.NavigateToUrl(navigationUrl);
        }

        [Then(@"Self Service Tools Panel displayed for end client")]
        public void ThenSelfServiceToolsPanelDisplayedForEndClient()
        {
            var page = _driver.NowAt<SelfServiceEndClientBasePage>();
            Verify.IsTrue(page.SelfServiceToolsPanel.Displayed(), "Self Service Tools Panel is missing");
        }

        [When(@"User clicks on '(.*)' button on end user Self Service page")]
        public void WhenUserClicksOnButtonOnEndUserSelfServicePage(string buttonName)
        {
            var page = _driver.NowAt<SelfServiceEndClientBasePage>();
            var button = page.GetButtonOnEndUserPage(buttonName);
            _driver.WaitForElementToBeEnabled(button);
            button.Click();
        }

        [Then(@"'(.*)' button displayed for End User")]
        public void ThenButtonDisplayedForEndUser(string buttonTitle)
        {
            var page = _driver.NowAt<SelfServiceEndClientBasePage>();

            Verify.IsTrue(page.IsButtonDisplayed(buttonTitle), $"'{buttonTitle}' button wasn't displayed to End User");
        }

        [Then(@"'(.*)' button is not displayed for End User")]
        public void ThenButtonIsNotDisplayedForEndUser(string buttonTitle)
        {
            var page = _driver.NowAt<SelfServiceEndClientBasePage>();

            Verify.IsFalse(page.IsButtonDisplayed(buttonTitle), $"'{buttonTitle}' button was displayed for End User");
        }

        [Then(@"'(.*)' button is disabled for End User")]
        public void ThenButtonIsDisabledForEndUser(string buttonTitle)
        {
            var page = _driver.NowAt<SelfServiceEndClientBasePage>();

            Verify.IsTrue(page.GetButtonOnEndUserPage(buttonTitle).Disabled(), $"'{buttonTitle}' button was not disabled for End User");
        }

        [Then(@"'(.*)' button is enabled for End User")]
        public void ThenButtonIsEnabledForEndUser(string buttonTitle)
        {
            var page = _driver.NowAt<SelfServiceEndClientBasePage>();

            Verify.IsFalse(page.GetButtonOnEndUserPage(buttonTitle).Disabled(), $"'{buttonTitle}' button wasn't enabled for End User");
        }

        [Then(@"'(.*)' button has tooltip with '(.*)' text on end user Self Service page")]
        public void ThenButtonHasTooltipWithTextOnEndUserSelfServicePage(string buttonName, string tooltipText)
        {
            var page = _driver.NowAt<SelfServiceEndClientBasePage>();
            var button = page.GetButtonOnEndUserPage(buttonName);
            _driver.MouseHover(button);
            var toolTipText = _driver.GetTooltipText();
            Verify.AreEqual(tooltipText, toolTipText,
                $"'{buttonName}' button tooltip is incorrect");
        }

        [Then(@"tooltip is not displayed for '(.*)' button on end user Self Service page")]
        public void TooltipIsNotDisplayedForButtonOnEndUserSelfServicePage(string buttonName)
        {
            var page = _driver.NowAt<SelfServiceEndClientBasePage>();
            var button = page.GetButtonOnEndUserPage(buttonName);
            _driver.MouseHover(button);
            Verify.IsFalse(_driver.IsTooltipDisplayed(),
                $"Tooltip for '{buttonName}' button is displayed");
        }

        [Then(@"Header is displayed on End User page")]
        public void ThenHeaderIsDisplayedOnEndUserPage()
        {
            var page = _driver.NowAt<SelfServiceEndClientBasePage>();

            Verify.IsTrue(page.Header.Displayed(), $"Header was not displayed for End User");
        }

        [Then(@"Subject Title '(.*)' is displayed on End User page")]
        public void ThenSubjectTitleIsDisplayedOnEndUserPage(string subjTitle)
        {
            var page = _driver.NowAt<SelfServiceEndClientBasePage>();

            Verify.IsTrue(page.SubjectTitleOnEndUserPage(subjTitle).Displayed(), $"'{subjTitle}' subject title was not displayed for End User");
        }
    }
}
