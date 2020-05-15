using System.Collections.Generic;
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

        public IWebElement ComponentOfDialogPage(string componentName)
        {
            var selector = $"{BaseDialogPageSelectors.PopupSelector}//div[contains(@class,'mat-list-item-content') and text() = '{componentName}']";

            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
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

        #region Textbox

        public IWebElement GetTextbox(string placeholder, WebDriverExtensions.WaitTime wait = WebDriverExtensions.WaitTime.Medium)
        {
            return GetTextbox(placeholder, wait, this.GetStringByFor(() => this.PopupElement));
        }

        #endregion

        #region SsTextboxInlineMessageElement

        //Self Service EndUser page
        public IWebElement GetSSTextboxInlineMessageElement(string placeholder)
        {
            return GetSSTextboxInlineMessageElement(placeholder, this.GetStringByFor(() => this.PopupElement));
        }

        #endregion
    }
}