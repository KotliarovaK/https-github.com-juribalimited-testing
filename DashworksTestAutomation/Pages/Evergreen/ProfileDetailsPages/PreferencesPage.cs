using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace DashworksTestAutomation.Pages.Evergreen.ProfileDetailsPages
{
    internal class PreferencesPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath,
            Using = ".//span[text()='Language']/ancestor::div[@class='form-item']//div[@class='dropdown-wrapper']")]
        public IWebElement LanguageDropdown { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//span[text()='Display Mode']/ancestor::div[@class='form-item']//div[@class='dropdown-wrapper']")]
        public IWebElement DisplayModeDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@title='UPDATE']")]
        public IWebElement UpdateButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='inline-success']")]
        public IWebElement SuccessMessage { get; set; }

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