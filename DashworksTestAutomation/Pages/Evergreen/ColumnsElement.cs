using System;
using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;

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

        public IWebElement GetDeleteColumnButton(string columnName)
        {
            return Driver.FindElement(By.XPath(
                $".//div[@class='columns-panel']//span[text()='{columnName}']/ancestor::div[@class='sub-categories-item selected-column']//button"));
        }

        public void ExpandFilterSectionsByName(string sectionsName)
        {
            Driver.FindElement(By.XPath($".//div[contains(@class, 'filter-category-label')][text()='{sectionsName}']")).Click();
        }
    }
}