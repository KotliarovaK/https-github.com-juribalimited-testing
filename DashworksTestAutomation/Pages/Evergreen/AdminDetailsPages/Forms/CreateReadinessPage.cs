using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Forms
{
    internal class CreateReadinessPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'action-container')]/h2")]
        public IWebElement CreateReadinessFormTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//label[@class='mat-checkbox-layout']/span[text()='Default for applications']")]
        public IWebElement DefaultForAppCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-select[@id='colorTemplate']")]
        public IWebElement ColourDropbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='mat-option-text']//span")]
        public IList<IWebElement> ColourPicker { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.CreateReadinessFormTitle)
            };
        }

        public void SelectObjectForReadinessCreation(string objectName)
        {
            var listNameSelector = $".//span[@class='mat-option-text']//span[contains(text(), '{objectName}')]";
            Driver.WaitForElementToBeDisplayed(By.XPath(listNameSelector));
            Driver.FindElement(By.XPath(listNameSelector)).Click();
        }

        public int GetColourStatusNumber()
        {
            var statusSelector = $".//mat-option[@role='option']//div[@class='status']";
            Driver.WaitForElementToBeDisplayed(By.XPath(statusSelector));
            return Driver.FindElements(By.XPath(statusSelector)).Count;
        }

        public int GetColourStatusTextNumber()
        {
            var statusTextSelector = $"//mat-option[@role='option']//span[@class='status-text']";
            //Driver.WaitForElementToBeDisplayed(By.XPath(statusTextSelector));
            return Driver.FindElements(By.XPath(statusTextSelector)).Count;
        }
    }
}