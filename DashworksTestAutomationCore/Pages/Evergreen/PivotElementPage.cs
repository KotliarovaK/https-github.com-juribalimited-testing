using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class PivotElementPage : SeleniumBasePage
    {
        public const string AggregateOptionOnPivotPanel = "//option[@class='ng-star-inserted']";

        [FindsBy(How = How.XPath, Using = ".//h1")]
        public IWebElement PageHeader { get; set; }
        
        [FindsBy(How = How.XPath, Using = ".//button[contains(@id, 'pivot')]")]
        public IWebElement PivotButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[text()='Pivot']/ancestor::div[@id='context-container']")]
        public IWebElement PivotPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='device-context-panel']//button[2]")]
        public IWebElement ClosePivotPanelButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Pivot Name']")]
        public IWebElement PivotNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='SAVE']/ancestor::button")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@role, 'menuitem')][text()='SAVE AS NEW PIVOT']")]
        public IWebElement SaveNewListButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[contains(@role, 'menuitem')][text()='UPDATE PIVOT']")]
        public IWebElement UpdateListButton { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                ".//div[@class='columns-panel']//div[contains(@class,'filter-category-label') and contains(@class,'bold')]")]
        public IList<IWebElement> PivotCategories { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'pivot-choice')]/button[contains(@class,'back')]")]
        public IWebElement CloseAddItemIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='nopivot ng-star-inserted']")]
        public IWebElement NoPivotTableMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='RESET']/ancestor::button")]
        public IWebElement ResetPivotButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[contains(@class, 'arrow_back')]/ancestor::button")]
        public IWebElement BackButtonOnPivotPanel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div/select[contains(@class, 'ng-valid')]")]
        public IWebElement AggregateFunctionsSelectBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@style, 'left: 0px')]//div[@ref='agContainer']//span[text()='Empty']")]
        public IWebElement FirstEmptyValueHeaders { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ag-pinned-left-cols-container']//span[text()='Empty']")]
        public IWebElement FirstEmptyValueLeftPinned { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@class, 'pristine')]")]
        public IWebElement AggregateFunction{ get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[contains(@class, 'ag-row-group-leaf-indent')]//span[@class='ag-icon ag-icon-expanded']")]
        public IWebElement PlusButton { get; set; }

        [FindsBy(How = How.XPath, Using = AggregateOptionOnPivotPanel)]
        public IList<IWebElement> AggregateOptionsOnPivotPanel { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.PageHeader)
            };
        }

        public IWebElement GetButtonByNameOnPivot(string button)
        {
            var selector = By.XPath($"//span[text()='{button}']/ancestor::button");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetLeftPinnedExpandButtonByName(string text)
        {
            var selector = By.XPath($"//div[@role='gridcell']//span[contains(text(),'{text}')]//ancestor::div[@col-id='ag-Grid-AutoColumn']//span[@class='ag-icon ag-icon-contracted']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetColumnsDisplayedForAggregateFunctions(string text)
        {
            var selector = By.XPath($".//div[@ref='eLabel']/span[@role='columnheader'][text()='{text}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetTopLeftCornerText(string text)
        {
            var selector = By.XPath($".//div[@ref='agContainer']/span[text()='{text}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public void GetSubCategoryOnPivotByName(string name)
        {
            var selector = By.XPath($"//*[text()='{name}']/ancestor::div[contains(@class, 'sub-categories-item')]");
            Driver.WaitForElementToBeDisplayed(selector);
            Driver.MouseHover(selector);
            Driver.FindElement(selector).Click();
        }

        public IWebElement GetChipByNameOnPivot(string chipName)
        {
            var selector = By.XPath($".//span[contains(@class, 'pivot-filter-name')][text()='{chipName}']");
            return Driver.FindElement(selector);
        }

        public bool GetChipNameOnPivot(string chipName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//span[contains(@class, 'pivot-filter')][text()='{chipName}']"));
        }

        public bool GetChipValueNameOnPivot(string chipValueName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//div[contains(@class, 'pivot-filter')][text()='{chipValueName}']"));
        }

        public IWebElement GetCloseButtonForElementsByNameOnPivot(string button)
        {
            var selector = By.XPath($"//span[text()='{button}']/..//following-sibling::button");
            return Driver.FindElement(selector);
        }

        public IWebElement GetCloseButtonForValueElementsByNameOnPivot(string button)
        {
            var selector = By.XPath($".//*[text()='{button}']/..//ancestor::button");
            return Driver.FindElement(selector);
        }

        public IWebElement GetPanelByName(string button)
        {
            var selector = By.XPath($"//*[text()='{button}']/ancestor::div[@id='context-container']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetPlusButtonOnPivotByName(string button)
        {
            var selector = By.XPath($"//div[@class='context-block-title'][text()='{button}']/following-sibling::div//button[contains(@class, 'plus')]");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public List<string> GetColumnHeaders()
        {
            var headers =
                Driver.FindElements(By.XPath($".//div[@class='ag-header-container']//div[@class='ag-header-row'][{GetMainHeadersRowIndex()}]//span[@class='ag-header-group-text']"));
            //var headers = Driver.FindElements(By.XPath($".//div[@class='ag-header-container']/div/div//span[@class='ag-header-group-text']"));
            return headers.Select(x => x.Text).ToList();
        }

        public int GetMainHeadersRowIndex()
        {
            var headers = Driver.FindElements(By.XPath($".//div[@class='ag-header-container']//div[@class='ag-header-row']")).Count;
            return headers-1;
        }

        public List<string> GetColId()
        {
            var headers = Driver.FindElements(By.XPath($".//div[@ref='eCenterContainer']/div[1]/div"));
            return headers.Select(x => x.GetAttribute("col-id")).ToList();
        }

        public string GetColIdByColumnName(string columnName)
        {
            var columnHeaders = GetColumnHeaders();
            var colIds = GetColId();
            var index = columnHeaders.IndexOf(columnName);
            var colId = colIds[index];
            return colId;
        }

        public List<string> GetPivotColumnContent()
        {
            var by = By.XPath(
                ".//div[@class='ag-pinned-left-cols-viewport-wrapper']//div[@role='row']//span[@ref='eValue']");
            return Driver.FindElements(by).Select(x => x.Text).Where(x => !x.Contains("Empty")).ToList();
        }

        public List<string> GetLeftPinnedPivotColorColumnContent()
        {
            var by = By.XPath(
                ".//div[@class='ag-pinned-left-cols-container']//span[@class='ag-group-value']//div[@class='status']");
            return Driver.FindElements(by).Select(x => x.GetCssValue("background-color")).ToList();
        }

        public List<string> GetHeadersPivotBackgroundColor()
        {
            var by = By.XPath(
                ".//div[@class='ag-header-group-cell-label']//div[@class='status']");
            return Driver.FindElements(by).Select(x => x.GetCssValue("background-color")).ToList();
        }

        public List<string> GetPivotHeadersContentToList()
        {
            var by = By.XPath(".//div[@class='ag-header-row']//div[contains(@class, 'ag-header-group-cell ag-header-group-cell-with-group')]");
            return Driver.FindElements(by).Select(x => x.Text).Where(x => !x.Contains("Empty")).ToList();
        }

        public List<string> GetLeftPinnedColumnContentToList()
        {
            var by = By.XPath(".//div[contains(@class, 'ag-pinned-left-cols-container')]//span[@class='ag-group-value']");
            return Driver.FindElements(by).Select(x => x.Text).Where(x => !x.Contains("Empty")).ToList();
        }

        public IList<IWebElement> GetLeftPinnedColumnContentOnPivot()
        {
            var selector = By.XPath(".//div[contains(@class, 'ag-pinned-left-cols-container')]//span[@class='ag-group-value']");
            Driver.WaitForDataLoading();
            return Driver.FindElements(selector);
        }

        public IList<IWebElement> GetColumnContentOnPivotByName(string columnName)
        {
            var selector = By.XPath($".//div[@role='gridcell'][@col-id='{GetColIdByColumnName(columnName)}']");
            Driver.WaitForDataLoading();
            return Driver.FindElements(selector);
        }

        public IWebElement SelectAggregateFunctionByName(string functionName)
        {
            var selector = By.XPath($".//option[@class='ng-star-inserted'][text()='{functionName}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public string GetPivotNumberByColor(string BackgroundColorItem)
        {
            switch (BackgroundColorItem)
            {
                case "rgba(55, 61, 69, 0.5)": //Out Of Scope
                    return "1";
                case "rgba(47, 133, 184, 0.5)": //Blue
                    return "2";
                case "rgba(71, 209, 209, 0.5)": //Light Blue
                    return "3";
                case "rgba(245, 96, 86, 0.5)": //Red
                    return "4";
                case "rgba(153, 118, 84, 0.5)": //Brown
                    return "5";
                case "rgba(235, 175, 37, 0.5)": //Amber
                    return "6";
                case "rgba(226, 123, 54, 0.5)": //Really Extremely Orange
                    return "7";
                case "rgba(186, 94, 186, 0.5)": //Purple
                    return "8";
                case "rgba(126, 189, 56, 0.5)": //Green
                    return "9";
                case "rgba(128, 139, 153, 0.5)": //Grey
                    return "10";
                case "rgba(198, 203, 210, 0.5)": //None
                    return "11";
                default: throw new Exception($"{BackgroundColorItem} is not valid Color");
            }
        }
    }
}
