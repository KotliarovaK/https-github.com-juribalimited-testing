using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    class FiltersElement : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='filter-panel']")]
        public IWebElement FiltersPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'filter-add-group')]")]
        public IWebElement AddNewFilterButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@name='search']")]
        public IWebElement SearchTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@title='Minimize Group']")]
        public IWebElement MinimizeGroupButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='styleSelectDropdown']")]
        public IWebElement FilterTypeDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='None']")]
        public IWebElement NoneCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='A Star Packages']")]
        public IWebElement AStarPackegesCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='B Star Packages']")]
        public IWebElement BStarPackegesCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='mat-checkbox-label']")]
        public IWebElement AddCategoryColumnCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='mat-primary mat-raised-button']")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='mat-raised-button']")]
        public IWebElement CancelButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.FiltersPanel),
            };
        }

        public void AddFilter(string filterName)
        {
            AddNewFilterButton.Click();
            SearchTextbox.SendKeys(filterName);
            var selector = By.XPath($".//div[contains(@class, 'filter-add')][text()='{filterName}']");

            Driver.WaitWhileControlIsNotDisplayed(selector);
            Driver.FindElement(selector).Click();

            Driver.WaitForDataLoading();
        }

        public void SelectOption(string optionName)
        {
            if (optionName == "Add Category column")
            {
                AddCategoryColumnCheckbox.Click();
            }
            else
            {
                Driver.FindElement(By.XPath($".//span[text()='{optionName}']")).Click();
            }
        }

        public List<string> GetFiltersNames()
        {
            var namesListElements = Driver.FindElements(By.XPath(".//span[@class='filter-label-name']"));
            return namesListElements.Select(name => name.Text).ToList();
        }

        public List<string> GetFilterColumData()
        {
            var filterColumnDataElements =
                Driver.FindElements(By.XPath(".//div[@role='gridcell'][@colid='project_1_subCategory']"));
            return filterColumnDataElements.Select(name => name.Text).ToList();
        }
    }
}