using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Forms
{
    internal class ImportProjectPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'action-container')]/h2")]
        public IWebElement ImportProjectFormTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class,'mat-primary mat-raised-button')]")]
        public IWebElement ImportProjectButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'mat-raised-button')]/span[text()='CANCEL']")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder=\"Project Name\"]")]
        public IWebElement ProjectNameField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-option[contains(@class, 'mat-option ng-star-inserted')]/span")]
        public IList<IWebElement> DropdownOptions { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='form']/div[contains(@class,'input')]/input")]
        public IWebElement ButtonChooseFile { get; set; }

        [FindsBy(How = How.XPath, Using = "//div//mat-select[@aria-label='Select Existing Project']")]
        public IWebElement SelectExistingProjectDropdown { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.ImportProjectFormTitle)
            };
        }

        public List<string> GetDropdownOptions(string dropdownName)
        {
            GetDropdownByName(dropdownName).Click();

            return DropdownOptions.Select(x => x.Text).ToList();
        }

        //TODO should be moved to BasePage
        public void SelectDropdownOption(string dropdownName, string optionName)
        {
            GetDropdownByName(dropdownName).Click();
            GetDropdownItemByName(optionName).Click();
        }

        private IWebElement GetDropdownByName(string name)
        {
            var selector =
                By.XPath(
                    $".//span[@class='mat-form-field-label-wrapper']//label[text()='{name}']/ancestor::div/mat-select");
            if (!Driver.IsElementDisplayed(selector, WebDriverExtensions.WaitTime.Short))
                throw new Exception($"'{name}' selectbox was not displayed");
            return Driver.FindElement(selector);
        }

        private IWebElement GetDropdownItemByName(string name)
        {
            var selector = By.XPath($".//mat-option/span[text()='{name}']");
            if (!Driver.IsElementDisplayed(selector, WebDriverExtensions.WaitTime.Short))
                throw new Exception($"'{name}' item was not displayed in selectobox");
            return Driver.FindElement(selector);
        }
    }
}