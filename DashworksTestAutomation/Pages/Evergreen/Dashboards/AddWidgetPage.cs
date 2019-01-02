using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages
{
    internal class AddWidgetPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='WidgetType']")]
        public IWebElement WidgetType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Title']")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='List']")]
        public IWebElement List { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='SplitBy']")]
        public IWebElement SplitBy { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='AggregateBy']")]
        public IWebElement AggregateBy { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='AggregateFunction']")]
        public IWebElement AggregateFunction { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='OrderBy']")]
        public IWebElement OrderBy { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='TableOrientation']")]
        public IWebElement TableOrientation { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Max Values']")]
        public IWebElement MaxValues { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='ColorScheme']")]
        public IWebElement ColorScheme { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='form-item ng-star-inserted']//div[@class='mat-checkbox-inner-container']")]
        public IWebElement ShowLegend { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[contains(text(), 'CREATE')]")]
        public IWebElement ConfirmCreateWidgetButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-error ng-star-inserted')]")]
        public IWebElement ErrorMessage { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.WidgetType),
            };
        }




        public void SelectObjectForWidgetCreation(string objectName)
        {
            var listNameSelector = $".//span[@class='mat-option-text'][contains(text(), '{objectName}')]";
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(listNameSelector));
            Driver.FindElement(By.XPath(listNameSelector)).Click();
        }

    }
}