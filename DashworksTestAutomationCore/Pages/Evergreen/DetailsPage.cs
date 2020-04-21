using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AutomationUtils.Utils;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class DetailsPage : SeleniumBasePage
    {
        public const string ItemImageSelector = ".//i";

        public const string ColumnWithImageAndLinkSelector = ".//div[@col-id='userName'][@role='gridcell']";

        public const string FieldOnDetailsPageSelector = ".//td[@class='fld-label' or contains(@class, 'mat-column-key')]";

        public const string ColumnHeader = "//div[@class='ag-header-cell-label']";

        public const string EditButton = ".//*[text()='{0}']//ancestor::tr//span[@class='editIcon']";
        
        public const string EditArrow = ".//*[text()='{0}']//ancestor::tr//div[contains(@class, 'select-arrow')]";

        private string FieldContent = ".//td//span[text()='{0}']//ancestor::tr//td//*[contains(text(),'{0}')]";

        [FindsBy(How = How.XPath, Using = "//div[@class='mat-drawer-inner-container']")]
        public IWebElement TabContainer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='object-icon']//i")]
        public IWebElement GroupIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'box-counter')]//span[@class='ng-star-inserted']")]
        public IWebElement RowsLabel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='empty-message ng-star-inserted']")]
        public IWebElement NoFoundContent { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'details-wrap')]")]
        public IWebElement ItemDetailsContainer { get; set; }

        [FindsBy(How = How.XPath, Using = ".//tbody//tr")]
        public IList<IWebElement> TableRowDetails { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'field-category collapsed')]")]
        public IWebElement OpenedSection { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='chartContainer ng-star-inserted']")]
        public IWebElement GraphicInOpenedSection { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//div[@id='aggridHeaderCounter']//span[@class='ng-star-inserted' and count(*)=0]")]

        [FindsBy(How = How.XPath,
            Using =
                ".//table[@class='table projectDetails']/*//span[text()='Evergreen Bucket']/ancestor::tr/td[@class='fld-value']")]
        public IWebElement ProjectSummaryBucketValue { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='mat-checkbox-label']/ancestor::mat-checkbox")]
        public IWebElement SelectAllCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = FieldOnDetailsPageSelector)]
        public IList<IWebElement> FieldListOnDetailsPage { get; set; }

        [FindsBy(How = How.XPath, Using = ColumnHeader)]
        public IList<IWebElement> ColumnHeadersList { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.TabContainer)
            };
        }

        public string GetInstalledBucketWindowWidth()
        {
            return Driver.FindElement(By.XPath("//mat-dialog-container[contains(@class, 'mat-dialog-container')]"))
                .GetCssValue("width");
        }

        public IWebElement GetCellByTextFromKeyValueGrid(string text)
        {
            return Driver.FindElement(By.XPath($".//tbody/*/td//span[text()='{text}']"));
        }

        public void ExpandAllSections()
        {
            Driver.WaitForElementToBeDisplayed(
                By.XPath(".//i[@class='material-icons mat-item_add mat-18']/ancestor::button"));
            var expandButtons =
                Driver.FindElements(By.XPath(".//i[@class='material-icons mat-item_add mat-18']/ancestor::button"));

            if (!expandButtons.Any()) return;
            foreach (var button in expandButtons)
            {
                //Driver.WaitForElementToBeDisplayed(button);
                Driver.MouseHover(button);
                button.Click();
                Driver.WaitForDataLoading();
            }
        }

        public List<KeyValuePair<string, string>> GetFieldsWithContent(string categoryName)
        {
            //Hover on header to be able to see all table with all values
            //In other case elements outside the bounds of the screen will have empty text
            Driver.MouseHover(By.XPath(
                $".//span[contains(@class,'filter-category-label blue-color bold-text')][text()='{categoryName}']"));
            var allHeaders = Driver
                .FindElements(By.XPath(
                    $".//span[contains(@class,'filter-category-label blue-color bold-text')][text()='{categoryName}']/../..//tbody/tr/td[1]"))
                .Select(x => x.Text).ToList();
            var allContent = Driver
                .FindElements(By.XPath(
                    $".//span[contains(@class,'filter-category-label blue-color bold-text')][text()='{categoryName}']/../..//tbody/tr/td[2]"))
                .Select(x => x.Text).ToList();

            return allHeaders.Select((t, i) => new KeyValuePair<string, string>(t, allContent[i])).ToList();
        }

        public void CheckThatAllContentIsNotEmpty()
        {
            var allFieldsContent = Driver.FindElements(By.XPath(".//tbody/tr/td[2]"));

            foreach (var element in allFieldsContent) Verify.IsFalse(string.IsNullOrEmpty(element.Text), "PLEASE ADD EXCEPTION MESSAGE");
        }

        public string GetHrefByColumnName(string columnName)
        {
            var byControl =
                By.XPath(
                    $".//div[@col-id='{GetColIdByColumnName(columnName)}' and @role='gridcell']//a");

            Driver.WaitForDataLoading();
            Driver.WaitForElementToBeDisplayed(byControl);
            var attribute = Driver.FindElement(byControl).GetAttribute("href");
            return attribute;
        }

        private string GetColIdByColumnName(string columnName)
        {
            var by = By.XPath($".//span[text()=\"{columnName}\"]/ancestor::div[@col-id]");
            return Driver.FindElement(by).GetAttribute("col-id");
        }

        public bool IsFieldPresent(string fieldName)
        {
            return Driver.IsElementDisplayed(
                By.XPath($".//div[@class='ng-star-inserted']//td[@class='fld-label']//span[text()='{fieldName}']"));
        }

        #region  Edit/Pen button for field

        public IWebElement GetEditFieldButton(string fieldName)
        {
            var selector = By.XPath(string.Format(EditButton, fieldName));
            if (!Driver.IsElementDisplayed(selector, WebDriverExtensions.WaitTime.Medium))
            {
                throw new Exception($"Edit button is not displayed for '{fieldName}' field");
            }

            return Driver.FindElement(selector);
        }

        public void ClickEditFieldButton(string fieldName)
        {
            try
            {
                GetEditFieldButton(fieldName).Click();
            }
            catch
            {
                Driver.MouseHover(GetEditFieldButton(fieldName));
                GetEditFieldButton(fieldName).Click();
            }
        }

        public bool EditFieldButtonDisplaying(string fieldName)
        {
            return Driver.IsElementDisplayed(By.XPath(string.Format(EditButton, fieldName)));
        }

        public bool EditArrowDisplaying(string fieldName)
        {
            return Driver.IsElementDisplayed(By.XPath(string.Format(EditArrow, fieldName)));
        }

        #endregion

        public IWebElement LinkIsDisplayed(string linkName)
        {
            var selector = By.XPath($"//div[contains(@class, 'editText')]//span[text()='{linkName}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }
        public IWebElement GetCompareContentOnTheDetailsPage(string title, string value, WebDriverExtensions.WaitTime wait = WebDriverExtensions.WaitTime.Short)
        {
            var selector = By.XPath(string.Format(FieldContent, title, value));
            if (!Driver.IsElementDisplayed(selector, wait))
                throw new Exception($"'{value}' value is not displayed for '{title}' title");
            Driver.WaitForElementToBeEnabled(selector);
            return Driver.FindElement(selector);
        }

        public string GetFieldWithEmptyValueByName(string title)
        {
            var selector = By.XPath($".//span[text()='{title}']//ancestor::tr/td[contains(@class, 'column-value')]");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector).Text;
        }

        public List<string> GetDetailsColorHeadersContentToList()
        {
            var by = By.XPath(".//th[@role='columnheader']//span[contains(@class, 'status-text')]");
            return Driver.FindElements(by).Select(x => x.Text).ToList();
        }
    }
}