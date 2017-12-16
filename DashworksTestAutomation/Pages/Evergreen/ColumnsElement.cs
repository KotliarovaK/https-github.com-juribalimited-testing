﻿using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class ColumnsElement : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='columns-panel']")]
        public IWebElement ColumnsPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@name='search']")]
        public IWebElement SearchTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='searchPanel input-wrapper']//button[@title='Close']")]
        public IWebElement SearchTextboxResetButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@title='Minimize Group']")]
        public IList<IWebElement> MinimizeGroupButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@title='Maximize Group']")]
        public IList<IWebElement> MaximizeGroupButton { get; set; }

        private const string GroupTitleSelector =
            ".//div[contains(@class,'filter-category-title filter-selection')]";
        [FindsBy(How = How.XPath, Using = GroupTitleSelector)]
        public IList<IWebElement> GroupTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@title='Reset Columns']")]
        public IWebElement ResetColumnsButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.ColumnsPanel),
                SelectorFor(this, p => p.SearchTextbox),
            };
        }

        public void AddColumn(string columnName)
        {
            SearchTextbox.SendKeys(columnName);
            var selector = String.Empty;
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
                {
                    subCategories = FilterCategory(categoryName)
                        .FindElements(By.XPath(".//div[@class='sub-categories ng-star-inserted']/div"));
                }
                else
                {
                    break;
                }
            }
        }

        public int GetSubcategoriesCountByCategoryName(string categoryName)
        {
            var filterCategory = FilterCategory(categoryName);
            return Convert.ToInt32(filterCategory.FindElement(By.XPath(".//strong")).Text);
        }

        public IWebElement MaximizeOrMinimizeButtonByCategory(string categoryName)
        {
            var filterCategory = FilterCategory(categoryName);
            return filterCategory.FindElement(By.XPath(".//button"));
        }

        public IWebElement GetDeleteColumnButton(string columnName)
        {
            return Driver.FindElement(By.XPath(
                $".//div[@class='columns-panel']//span[text()='{columnName}']/ancestor::div[@class='sub-categories-item selected-column ng-star-inserted']//button"));
        }

        public void ExpandColumnsSectionByName(string sectionsName)
        {
            try
            {
                Driver.FindElement(By.XPath(
                        $".//div[contains(@class, 'filter-category-label')][text()='{sectionsName}']//ancestor::div[contains(@class, 'filter-category-title')]//button[@title='Maximize Group']"))
                    .Click();
            }
            catch
            {
            }
        }

        public bool CategoryIsDisplayed(string sectionsName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//div[contains(@class, 'filter-category-label')][text()='{sectionsName}']"));
        }

        public void EnteredIntoSearchBox(string searchedText)
        {
            Driver.FindElement(By.XPath(".//input[@name='search']")).Click();
            Driver.FindElement(By.XPath(".//input[@name='search']")).SendKeys(searchedText);
        }
    }
}