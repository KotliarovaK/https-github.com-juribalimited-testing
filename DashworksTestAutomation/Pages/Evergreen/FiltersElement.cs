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

        [FindsBy(How = How.XPath, Using = ".//button[@class='mat-primary mat-raised-button']")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='mat-raised-button']")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-checkbox-frame']")]
        public IWebElement AddCategoryColumnCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='filterAddPanel']//button[@title='Remove Filter']")]
        public IWebElement RemoveFilterButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@title='Reset Filter']")]
        public IWebElement ResetFiltersButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='filter-label-value']")]
        public IList<IWebElement> FilterValues { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='filter-label-op']")]
        public IList<IWebElement> FilterOptions { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='mat-select-value-text']")]
        public IWebElement OperatorDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'mat-select-content')]/md-option")]
        public IList<IWebElement> OperatorOptions { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.FiltersPanel),
            };
        }

        public List<string> GetFilterValuesByFilterName(string filterName)
        {
            return Driver.FindElements(By.XPath(
                    $".//span[@class='filter-label-name'][text()='{filterName}']/ancestor::div[@class='filter-label']//span[@class='filter-label-value']"))
                .Select(x => x.Text.TrimStart(' ').TrimEnd(' ')).ToList();
        }

        public void AddFilter(string filterName)
        {
            if (AddNewFilterButton.Displayed())
            {
                AddNewFilterButton.Click();
            }
            SearchTextbox.SendKeys(filterName);
            var selector = string.Empty;
            if (filterName.Contains("'"))
            {
                var strings = filterName.Split('\'');
                selector =
                    $".//div[contains(@class, 'filter-add')][contains(text(),'{strings[0]}')][contains(text(), '{strings[1]}')]";
            }
            else
            {
                selector = $".//div[contains(@class, 'filter-add')][text()='{filterName}']";
            }
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();

            Driver.WaitForDataLoading();
            Driver.WaitWhileControlIsDisplayed<FiltersElement>(() => AddNewFilterButton);
        }

        public bool CheckFilterAvailability(string filterName)
        {
            if (AddNewFilterButton.Displayed())
            {
                AddNewFilterButton.Click();
            }
            SearchTextbox.Clear();
            SearchTextbox.SendKeys(filterName);
            var selector = By.XPath($".//div[contains(@class, 'filter-add')][text()='{filterName}']");
            return Driver.IsElementDisplayed(selector);
        }

        public List<string> GetFiltersNames()
        {
            var namesListElements = Driver.FindElements(By.XPath(".//span[@class='filter-label-name']"));
            return namesListElements.Select(name => name.Text).ToList();
        }

        public bool CheckThatFilterIsRemoved(string filterName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//span[@class='filter-label-name'][text()='{filterName}]"));
        }

        public IWebElement GetEditFilterButton(string filterName)
        {
            var editFilterSelector =
                $".//span[@class='filter-label-name'][text()='{filterName}']//ancestor::div[@class='filter-group no-border-bottom']//button";
            return Driver.FindElement(By.XPath(editFilterSelector));
        }

        public IWebElement GetBooleanCheckboxImg(string booleanValue)
        {
            var imgSelector =
                $".//li//span[text()='{booleanValue}']/ancestor::span[@class='boolean-icon text-container']/img";
            return Driver.FindElement(By.XPath(imgSelector));
        }

        public IList<IWebElement> GetAssociationsList()
        {
            Driver.FindElement(By.XPath(".//div[@id='context']//input[@placeholder='Search']")).Click();
            return Driver.FindElements(By.XPath(
                ".//div[@id='context']//input[@placeholder='Search']//ancestor::div[@class='associationmultiselect-parent btn-group dropdown-associationmultiselect']//li//span"));
        }

        public IList<IWebElement> GetSelectBoxes()
        {
            return Driver.FindElements(By.XPath(".//span[@class='text-container']"));
        }
    }
}