using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

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

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'select-content')]//*/span")]
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

        public void SelectDropdownOption(string dropdownName, string optionName)
        {
            GetDropdownByName(dropdownName).Click();
            DropdownOptions.First(x => x.Text.Equals(optionName)).Click();
        }

        private IWebElement GetDropdownByName(string name)
        {
            return Driver.FindElement(By.XPath($".//div[@class='form']//*/mat-select[@aria-label='{name}']//*/span"));
        }
    }
}