using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ProfileDetailsPages
{
    internal class PreferencesPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath,
            Using =
                "//div[contains(@class, 'SelectDropdown')]//mat-select[contains(@aria-label, 'Lang')]")]
        public IWebElement LanguageDropdown { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                "//div[contains(@class, 'SelectDropdown')]//mat-select[contains(@aria-label, 'Mode')]")]
        public IWebElement DisplayModeDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(@class, 'mat-raised-button')]")]
        public IWebElement UpdateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[text()='Preferences']/parent::li")]
        public IWebElement PreferencesLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//mat-option/span[text()='Normal']")]
        public IWebElement DisplayModeNormal { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-success ng-star-inserted']")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//button/span[text()='METTRE À JOUR']")]
        public IWebElement UpdateButtonOnFrench { get; set; }

        [FindsBy(How = How.XPath, Using = "//a/span[text()='Boîtes aux lettres']")]
        public IWebElement LeftHandMenuOnFrench { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[text()='Préférences']")]
        public IWebElement CaptionOnFrench { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.LanguageDropdown),
                SelectorFor(this, p => p.DisplayModeDropdown),
                SelectorFor(this, p => p.UpdateButton)
            };
        }

        public string GetSuccessMessageColor()
        {
            return SuccessMessage.GetCssValue("background-color");
        }

        public string GetUpdateButtonColor()
        {
            return UpdateButton.GetCssValue("background-color");
        }

        public string GetLinkMenuColor()
        {
            return PreferencesLink.GetCssValue("background-color");
        }
    }
}