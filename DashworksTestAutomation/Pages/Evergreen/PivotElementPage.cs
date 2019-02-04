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
    internal class PivotElementPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h1")]
        public IWebElement PageHeader { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(@id, 'pivot')]")]
        public IWebElement PivotButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Pivot Name']")]
        public IWebElement PivotNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='SAVE']/ancestor::button")]
        public IWebElement SaveButton { get; set; }

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

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-header-icon ag-sort-ascending-icon']")]
        public IWebElement AscendingSortingIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-header-icon ag-sort-descending-icon']")]
        public IWebElement DescendingSortingIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[@class='ng-untouched ng-pristine ng-valid']")]
        public IWebElement ValueSectionSelectBox { get; set; }

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
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetCloseButtonForElementsByNameOnPivot(string button)
        {
            var selector = By.XPath($"//span[text()='{button}']/..//following-sibling::button");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetChipByNameOnPivot(string button)
        {
            var selector = By.XPath($"//span[@class='pivot-filter-name'][text()='{button}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetCloseButtonForValueElementsByNameOnPivot(string button)
        {
            var selector = By.XPath($"//div[text()='{button}']/..//following-sibling::button");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetPlusButtonOnPivotByName(string button)
        {
            var selector = By.XPath($"//div[@class='context-block-title'][text()='{button}']/following-sibling::div//button[contains(@class, 'plus')]");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public List<string> GetPivotColumnContent()
        {
            var by = By.XPath(
                $".//div[@class='ag-pinned-left-cols-viewport-wrapper']//div[@role='row']//span[@ref='eValue']");
            return Driver.FindElements(by).Select(x => x.Text).Where(x => !x.Contains("Empty")).ToList();
        }

        public List<string> GetLeftPinnedPivotColorColumnContent()
        {
            var by = By.XPath(
                $".//div[@class='ag-pinned-left-cols-container']//span[@class='ag-group-value']//div[@class='status']");
            return Driver.FindElements(by).Select(x => x.GetCssValue("background-color")).ToList();
        }

        public List<string> GetHeadersPivotColorContent()
        {
            var by = By.XPath(
                $".//div[@class='ag-header-group-cell-label']//div[@class='status']");
            return Driver.FindElements(by).Select(x => x.GetCssValue("background-color")).ToList();
        }

        public List<string> GetPivotHeadersContent()
        {
            var by = By.XPath($".//div[@class='ag-header-row']//div[contains(@class, 'ag-header-group-cell ag-header-group-cell-with-group')]");
            return Driver.FindElements(by).Select(x => x.Text).Where(x => !x.Contains("Empty")).ToList();
        }

        public void SelectAggregateFunctionByName(string functionName)
        {
            ValueSectionSelectBox.Click();
            var byControl = By.XPath($".//option[value='{functionName}']");
            Driver.WaitWhileControlIsNotDisplayed(byControl);
            Driver.FindElement(byControl).Click();
        }

        public string GetPivotNumberByColor(string BackgroundColorItem)
        {
            switch (BackgroundColorItem)
            {
                case "rgba(47, 133, 184, 0.5)": //Blue
                    return "1";
                case "rgba(71, 209, 209, 0.5)": //Light Blue
                    return "2";
                case "rgba(245, 96, 86, 0.5)": //Red
                    return "3";
                case "rgba(153, 118, 84, 0.5)": //Brown
                    return "4";
                case "rgba(235, 175, 37, 0.5)": //Amber
                    return "5";
                case "rgba(226, 123, 54, 0.5)": //Really Extremely Orange
                    return "6";
                case "rgba(186, 94, 186, 0.5)": //Purple
                    return "7";
                case "rgba(126, 189, 56, 0.5)": //Green
                    return "8";
                case "rgba(128, 139, 153, 0.5)": //Grey
                    return "9";
                case "rgba(198, 203, 210, 0.5)": //None
                    return "10";
                case "rgba(55, 61, 69, 0.5)": //Out Of Scope
                    return "11";
                default: throw new Exception($"{BackgroundColorItem} is not valid Color");
            }
        }
    }
}
