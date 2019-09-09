using System;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Capacity;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
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

        [When(@"User clicks on the Unlimited field on the Capacity Slots page")]
        public void WhenUserClicksOnTheUnlimitedFieldOnTheOnTheCapacitySlotsPage()
        {
            var projectElement = _driver.NowAt<CreateCapacitySlotPage>();
            projectElement.UnlimitedField.Click();
        }

        [Then(@"User sees next Slots on the Capacity Slots page:")]
        public void ThenUserSeesNextSlotsOnTheCapacitySlotsPage(Table slots)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            //Wait for table content to be fully loaded
            Thread.Sleep(1400);
            _driver.WaitForDataLoading();

            for (var i = 0; i < slots.RowCount; i++)
                Utils.Verify.That(page.GridSlotsNames[i].Text, Is.EqualTo(slots.Rows[i].Values.FirstOrDefault()),
                    "Slots are not the same");
        }

        [When(@"User clicks on ""(.*)"" dropdown on the Capacity Slots page")]
        public void WhenUserClicksOnDropdownOnTheCapacitySlotsPage(string dropdownName)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            page.ClickDropdownByName(dropdownName);
        }

        [When(@"User enters ""(.*)"" value to ""(.*)"" date field on Capacity Slot form page")]
        public void WhenUserEntersValueToDateFieldOnCapacitySlotFormPage(string value, string field)
        {
            var page = _driver.NowAt<CreateCapacitySlotPage>();
            page.EnterValueToTheDateByPlaceholder(value, field);
        }

        [Then(@"User sees ""(.*)"" value in the ""(.*)"" date field on Capacity Slot form page")]
        public void ThenUserSeesValueInTheDateFieldOnCapacitySlotFormPage(string valueExpected, string field)
        {
            var page = _driver.NowAt<CreateCapacitySlotPage>();

            Utils.Verify.That(page.GetValueFromDateByPlaceholder(field), Is.EqualTo(valueExpected));
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
            Utils.Verify.IsTrue(page.GetLanguageInTranslationsTableByName(language).Displayed, $"{language} is not displayed in Translations table");
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
            Utils.Verify.AreEqual(text, page.GetDisplayNameFieldByLanguage(language).GetAttribute("value"), $"'{text}' text is not displayed in Display Name field");
        }

        [When(@"User selects next items in the ""(.*)"" dropdown:")]
        public void WhenUserSelectsNextItemsInTheDropdown(string dropdownName, Table items)
        {
            WhenUserClicksOnDropdownOnTheCapacitySlotsPage(dropdownName);

            var page = _driver.NowAt<BaseGridPage>();
            foreach (var row in items.Rows)
            {
                page.DropdownItemDisplayed(row["Items"]).Click();
            }
        }
    }
}