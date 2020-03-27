using System.Collections.Generic;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using AutomationUtils.Extensions;

namespace DashworksTestAutomation.Pages.Evergreen
{
    public class BaseDialogPage : BaseDashboardPage
    {
        private const string PopupSelector = ".//mat-dialog-container[contains(@class, 'dialogContainer')]";

        [FindsBy(How = How.XPath, Using = PopupSelector)]
        public IWebElement PopupElement { get; set; }

        [FindsBy(How = How.XPath, Using = PopupSelector + "//div[@mat-dialog-title]")]
        public IWebElement PopupTitle { get; set; }

        public IWebElement ComponentOfDialogPage(string componentName)
        {
            var selector = $"{PopupSelector}//div[contains(@class,'mat-list-item-content') and text() = '{componentName}']";

            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        //Currently are using only for Self Service Dialog Page
        public bool IsItemInListOfDialogPageDisplayed(string itemName)
        {
            try
            {
                var selector = $"{PopupSelector}//div[contains(@class,'mat-list-item-content') and text() = '{itemName}']";

                return Driver.FindElement(By.XPath(selector)).Displayed();
            }
            catch
            {
                return false;
            }
        }

        public bool IsComponentOfDialogPageHighlighted(string componentName)
        {
            var bgColor = ComponentOfDialogPage(componentName).FindElement(By.XPath(".//ancestor::button[contains(@class, mat-list-item)]")).GetCssValue("background");
            var result = bgColor.Contains("rgb(49, 122, 193)");
            return result;
        }

        public bool IsComponentOfDialogPageDisabled(string componentName)
        {
            var componentState = ComponentOfDialogPage(componentName).FindElement(By.XPath("ancestor::button[contains(@class, mat-list-item)]")).IsAttributePresent("disabled");
            
            return componentState;
        }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p => p.PopupElement)
            };
        }

        #region Button

        public IWebElement GetButton(string button)
        {
            return GetButton(button, this.GetStringByFor(() => this.PopupElement));
        }

        #endregion
    }
}