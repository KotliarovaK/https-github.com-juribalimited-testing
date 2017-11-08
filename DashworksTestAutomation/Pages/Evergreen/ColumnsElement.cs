﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Plugins;

namespace DashworksTestAutomation.Pages.Evergreen
{
    class ColumnsElement : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='columns-panel']")]
        public IWebElement ColumnsPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@name='search']")]
        public IWebElement SearchTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@title='Minimize Group']")]
        public IWebElement MinimizeGroupButton { get; set; }

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
                $".//div[contains(@class,'filter-category-label')][text()='{filterCategoryName}']/ancestor::div[@class='filter-category']"));
        }

        public void AddAllColumnsFromCategory(string categoryName)
        {
            var filterCategory = FilterCategory(categoryName);
            filterCategory.FindElement(By.XPath(".//div[contains(@class,'filter-category-title')]")).Click();
            //Small wait for subcategoris display
            Thread.Sleep(350);
            var subCategories = filterCategory.FindElements(By.XPath(".//div[@class='sub-categories']/div"));
            while (subCategories.Any())
            {
                subCategories.First().Click();
                Driver.WaitForDataLoading();
                subCategories = filterCategory.FindElements(By.XPath(".//div[@class='sub-categories']/div"));
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
                $".//div[@class='columns-panel']//span[text()='{columnName}']/ancestor::div[@class='sub-categories-item selected-column']//button"));
        }

        public void ExpandColumnsSectionByName(string sectionsName)
        {
            try
            {
                Driver.FindElement(By.XPath(
                        $".//div[contains(@class, 'filter-category-label')][text()='{sectionsName}']//ancestor::div[contains(@class, 'filter-category-title')]//button[@title='Maximize Group']"))
                    .Click();
            }
            catch {}
        }
    }
}