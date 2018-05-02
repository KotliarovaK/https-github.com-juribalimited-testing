using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class ColumnsElement : SeleniumBasePage
    {
        private const string GroupTitleSelector =
            ".//div[contains(@class,'filter-category-title filter-selection')]";

        [FindsBy(How = How.XPath, Using = ".//div[@class='columns-panel']")]
        public IWebElement ColumnsPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@name='search']")]
        public IWebElement SearchTextbox { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                ".//div[@class='searchPanel input-wrapper']//button[@class='btn btn-default input-toggle mat-icon-button ng-star-inserted']")]
        public IWebElement SearchTextboxResetButton { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//div[@class='columns-panel']//i[@class='material-icons mat-clear mat-18']")]
        public IList<IWebElement> MinimizeGroupButton { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//div[@class='columns-panel']//i[@class='material-icons mat-item_add mat-18']")]
        public IList<IWebElement> MaximizeGroupButton { get; set; }

        [FindsBy(How = How.XPath, Using = GroupTitleSelector)]
        public IList<IWebElement> GroupTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='RESET']")]
        public IWebElement ResetColumnsButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.ColumnsPanel),
                SelectorFor(this, p => p.SearchTextbox)
            };
        }

        public void AddColumn(string columnName)
        {
            SearchTextbox.SendKeys(columnName);
            var selector = string.Empty;
            if (columnName.Contains("'"))
            {
                var strings = columnName.Split('\'');
                selector =
                    $".//div[@class='columns-panel']//span[contains(text(),'{strings[0]}')][contains(text(), '{strings[1]}')]";
            }
            else
            {
                selector = $".//div[@class='columns-panel']//span[text()='{columnName}']";
            }

            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();

            Driver.WaitForDataLoading();
        }

        public void AddColumnFromExpandedSection(string columnName)
        {
            var selector = string.Empty;
            if (columnName.Contains("'"))
            {
                var strings = columnName.Split('\'');
                selector =
                    $".//div[@class='columns-panel']//span[contains(text(),'{strings[0]}')][contains(text(), '{strings[1]}')]";
            }
            else
            {
                selector = $".//div[@class='columns-panel']//span[text()='{columnName}']";
            }

            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
            Driver.FindElement(By.XPath(selector)).Click();

            Driver.WaitForDataLoading();
        }

        private IWebElement FilterCategory(string filterCategoryName)
        {
            return Driver.FindElement(By.XPath(
                $".//div[contains(@class,'filter-category-label blue-color bold-text')][text()='{filterCategoryName}']/ancestor::div[@class='filter-category ng-star-inserted']"));
        }

        public void AddAllColumnsFromCategory(string categoryName)
        {
            var filterCategory = FilterCategory(categoryName);
            filterCategory.FindElement(By.XPath(GroupTitleSelector)).Click();

            //Small wait for subcategoris display
            Thread.Sleep(350);
            var subCategories =
                filterCategory.FindElements(By.XPath(".//div[@class='sub-categories ng-star-inserted']/div"));
            while (subCategories.Any())
            {
                subCategories.First().Click();
                Driver.WaitForDataLoading();
                if (Driver.IsElementExists(By.XPath(
                    $".//div[contains(@class,'filter-category-label blue-color bold-text')][text()='{categoryName}']/ancestor::div[@class='filter-category ng-star-inserted']")
                ))
                    subCategories = FilterCategory(categoryName)
                        .FindElements(By.XPath(".//div[@class='sub-categories ng-star-inserted']/div"));
                else
                    break;
            }
        }

        public int GetSubcategoriesCountByCategoryName(string categoryName)
        {
            var filterCategory = FilterCategory(categoryName);
            Driver.MouseHover(filterCategory);
            return Convert.ToInt32(filterCategory.FindElement(By.XPath(".//strong")).Text);
        }

        public IWebElement MaximizeOrMinimizeButtonByCategory(string categoryName)
        {
            var filterCategory = FilterCategory(categoryName);
            return filterCategory.FindElement(By.XPath(".//button"));
        }

        public IWebElement MinimizeButtonByCategory(string categoryName)
        {
            var filterCategory = FilterCategory(categoryName);
            return filterCategory.FindElement(By.XPath(".//i[@class='material-icons mat-clear mat-18']"));
        }

        public IWebElement MaximizeButtonByCategory(string categoryName)
        {
            var filterCategory = FilterCategory(categoryName);
            return filterCategory.FindElement(By.XPath(".//i[@class='material-icons mat-item_add mat-18']"));
        }

        public IWebElement GetDeleteColumnButton(string columnName)
        {
            //Workaround to avoid appearing 'Remove' tooltip
            Driver.MouseHover(By.TagName("body"));
            var selector =
                $".//div[@class='columns-panel']//span[text()='{columnName}']/ancestor::div[@class='sub-categories-item selected-column ng-star-inserted']//button";
            return Driver.FindElement(By.XPath(selector));
        }

        public void ExpandColumnsSectionByName(string sectionsName)
        {
            try
            {
                Driver.FindElement(By.XPath(
                        $".//div[contains(@class, 'filter-category-label')][text()='{sectionsName}']//ancestor::div[contains(@class, 'filter-category-title')]//i[@class='material-icons mat-item_add mat-18']"))
                    .Click();
            }
            catch
            {
            }
        }

        public bool CategoryIsDisplayed(string sectionsName)
        {
            return Driver.IsElementDisplayed(
                By.XPath($".//div[contains(@class, 'filter-category-label')][text()='{sectionsName}']"));
        }

        public bool SubcategoryIsSelected(string subCategoryName)
        {
            return Driver.IsElementDisplayed(By.XPath(
                $".//div[@class='sub-categories ng-star-inserted']/div/div//span[text()='{subCategoryName}']"));
        }
    }
}