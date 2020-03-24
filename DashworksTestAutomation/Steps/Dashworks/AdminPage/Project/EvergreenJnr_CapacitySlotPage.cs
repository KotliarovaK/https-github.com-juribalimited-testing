using System;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Capacity;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System.Linq;
using System.Threading;
using AutomationUtils.Utils;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Utils;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_CapacitySlotPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_CapacitySlotPage(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User clicks ""(.*)"" link on the Capacity Slot page")]
        public void WhenUserClicksLinkOnTheCapacitySlotPage(string linkName)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            page.GetLanguageLinkByName(linkName).Click();
        }

        [Then(@"See Translations link on the Capacity Slot page is not displayed")]
        public void ThenSeeTranslationsLinkOnTheCapacitySlotPageIsNotDisplayed()
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            var isLinkDisplayed = _driver.ExecuteFunc(() => page.GetLanguageLinkByName("See Translations").Displayed());
            if (isLinkDisplayed)
                throw new Exception("'See Translations' link is displayed");
        }

        [Then(@"""(.*)"" Language is displayed in Translations table on the Capacity Slot page")]
        public void ThenLanguageIsDisplayedInTranslationsTableOnTheCapacitySlotPage(string language)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            Verify.IsTrue(page.GetLanguageInTranslationsTableByName(language).Displayed, $"{language} is not displayed in Translations table");
        }

        [When(@"User types ""(.*)"" in Display Name field for ""(.*)"" Language in Translations table on the Capacity Slot page")]
        public void WhenUserTypesInDisplayNameFieldForLanguageInTranslationsTableOnTheCapacitySlotPage(string text, string language)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            page.GetDisplayNameFieldByLanguage(language).Clear();
            page.GetDisplayNameFieldByLanguage(language).SendKeys(text);
        }

        [Then(@"""(.*)"" is displayed in Display Name field for ""(.*)"" Language in Translations table on the Capacity Slot page")]
        public void ThenIsDisplayedInDisplayNameFieldForLanguageInTranslationsTableOnTheCapacitySlotPage(string text, string language)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            Verify.AreEqual(text, page.GetDisplayNameFieldByLanguage(language).GetAttribute("value"), $"'{text}' text is not displayed in Display Name field");
        }
    }
}