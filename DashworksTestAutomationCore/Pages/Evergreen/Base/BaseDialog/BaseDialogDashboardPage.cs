using System;
using System.Collections.Generic;
using System.Linq;
using AutomationUtils.Extensions;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomationCore.Pages.Evergreen.Base.BaseDialog
{
    public class BaseDialogDashboardPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = BaseDialogPageSelectors.PopupSelector + "//div[@mat-dialog-title]")]
        public IWebElement PopupTitle { get; set; }

        [FindsBy(How = How.XPath, Using = BaseDialogPageSelectors.PopupSelector)]
        public IWebElement PopupElement { get; set; }

        [FindsBy(How = How.XPath, Using = FieldSelector)]
        public IList<IWebElement> TableRowsName { get; set; }

        private const string RowSelector = ".//tr[@role='row'][not(@hidden)]";
        private const string FieldSelector = ".//td[contains(@class, 'mat-column-name')]";
        private const string ValueSelector = "./td[contains(@class,'column-value')]";
        public IWebElement ComponentOfDialogPage(string componentName)
        {
            var selector = $"{BaseDialogPageSelectors.PopupSelector}//div[contains(@class,'mat-list-item-content') and text() = '{componentName}']";

            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        //Currently are using only for Self Service Dialog Page
        public bool IsItemInListOfDialogPageDisplayed(string itemName)
        {
            try
            {
                var selector = $"{BaseDialogPageSelectors.PopupSelector}//div[contains(@class,'mat-list-item-content') and text() = '{itemName}']";

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

        #region Fields
        public string CompareFieldContent(string fieldName)
        {
            var allRows = Driver.FindElements(By.XPath(RowSelector));

            if (allRows.Any(x => x.FindElement(By.XPath(FieldSelector)).Text.Equals(fieldName)))
            {
                var row = allRows.First(x => x.FindElement(By.XPath(FieldSelector)).Text.Equals(fieldName));
                var content = row.FindElement(By.XPath(ValueSelector)).Text;
                return content;
            }
            else
                throw new Exception($"There are no field with '{fieldName}'");
        }
        #endregion
    }
}