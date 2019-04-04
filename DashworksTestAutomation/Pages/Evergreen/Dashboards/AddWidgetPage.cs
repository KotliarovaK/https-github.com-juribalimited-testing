using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages
{
    internal class AddWidgetPage : SeleniumBasePage
    {
        public const string ColorSchemeDropdownContent = ".//div/mat-option[contains(@class, 'colour-scheme')]//div[contains(@class, 'inner-colour')]";

        public const string ColorSchemeDropdownContainer = ".//div[@class='cdk-overlay-pane']";

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='WidgetType']")]
        public IWebElement WidgetType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Title']")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='List']")]
        public IWebElement List { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='SplitBy']")]
        public IWebElement SplitBy { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='Type']")]
        public IWebElement Type { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='AggregateBy']")]
        public IWebElement AggregateBy { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='AggregateFunction']")]
        public IWebElement AggregateFunction { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='OrderBy']")]
        public IWebElement OrderBy { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='TableOrientation']")]
        public IWebElement TableOrientation { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='Drilldown']")]
        public IWebElement Drilldown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Max Rows']")]
        public IWebElement MaxRows { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Max Columns']")]
        public IWebElement MaxColumns { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Max Values']")]
        public IWebElement MaxValues { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='ColorScheme']")]
        public IWebElement ColorScheme { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='form-item ng-star-inserted']//div[@class='mat-checkbox-inner-container']")]
        public IWebElement ShowLegend { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='actions']/button[contains(@class,'star')]")]
        public IWebElement CreateUpdateWidgetButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-error ng-star-inserted')]")]
        public IWebElement ErrorMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//deactivate-guard-dialog/parent::mat-dialog-container")]
        public IWebElement UnsavedChangesAlert { get; set; }
        
        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.WidgetType),
            };
        }

        public IWebElement GetDropdownForWidgetByName(string dropdownName)
        {
            var dropdownSelector = By.XPath($".//div[contains(@class, 'mat-form')]/span/label[text()='{dropdownName}']");
            return Driver.FindElement(dropdownSelector);
        }

        public void SelectObjectForWidgetCreation(string objectName)
        {
            var listNameSelector = $".//span[@class='mat-option-text'][contains(text(), '{objectName}')]";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(listNameSelector));
            Driver.FindElement(By.XPath(listNameSelector)).Click();
        }

        public void SelectListForWidgetCreation(string listName)
        {
            var listNameSelector = $".//span[@class='mat-option-text']//span[contains(text(), '{listName}')]";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(listNameSelector));
            Driver.FindElement(By.XPath(listNameSelector)).Click();
        }


        public IWebElement GetUnsavedChangesAlertText()
        {
            var selector = $".//deactivate-guard-dialog/parent::mat-dialog-container//p";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        public IWebElement UnsavedChangesAlertButton(string buttonTitle)
        {
            var selector = $".//deactivate-guard-dialog/parent::mat-dialog-container//span[text()='{buttonTitle}']";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }
    }
}