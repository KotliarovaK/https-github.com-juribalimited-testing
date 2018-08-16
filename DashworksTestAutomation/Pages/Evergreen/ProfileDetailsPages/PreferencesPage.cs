using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ProfileDetailsPages
{
    internal class PreferencesPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath,
            Using = ".//label[contains(text(), 'Lang')]/ancestor::div[@class='form-item']//div[@class='styleSelectDropdown']")]
        public IWebElement LanguageDropdown { get; set; } 

        [FindsBy(How = How.XPath,
            Using =
                ".//label[contains(text(), 'Mode')]/ancestor::div[@class='form-item']//div[@class='styleSelectDropdown']")]
        public IWebElement DisplayModeDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='UPDATE']/ancestor::button")]
        public IWebElement UpdateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-success ng-star-inserted']")]
        public IWebElement SuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//button/span[text()='METTRE À JOUR']")]
        public IWebElement UpdateButtonOnFrench { get; set; }

        [FindsBy(How = How.XPath, Using = "//a/span[text()='Boîtes aux lettres']")]
        public IWebElement LeftHandMenuOnFrench { get; set; }

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
    }
}