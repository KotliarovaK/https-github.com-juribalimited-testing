using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
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

        [FindsBy(How = How.XPath, Using = ".//div[@class='form']//*/mat-select[@aria-label='Import']//*/span")]
        public IWebElement DropdownImport { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'select-content')]//*/span")]
        public IList<IWebElement> ValuesDropdownImport { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='form']//*/mat-select[@aria-label='Buckets']//*/span")]
        public IWebElement DropdownBuckets { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'select-content')]//*/span")]
        public IList<IWebElement> ValuesDropdownBuckets { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='form']/div[contains(@class,'input')]/input")]
        public IWebElement ButtonChooseFile { get; set; }


        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.ImportProjectFormTitle)
            };
        }

        public List<string> GetBucketsDropdownOptions()
        {
            DropdownBuckets.Click();

            return ValuesDropdownBuckets.Select(x => x.Text).ToList();
        }

        public void SelectImportOption(string optionName)
        {
            DropdownImport.Click();
            ValuesDropdownImport.Where(x => x.Text.Equals(optionName)).First().Click();
        }

    }
}