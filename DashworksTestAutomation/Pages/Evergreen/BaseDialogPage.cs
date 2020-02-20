using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    public class BaseDialogPage : BaseDashboardPage
    {
        private const string PopupSelector = ".//mat-dialog-container[contains(@class, 'dialogContainer')]";

        [FindsBy(How = How.XPath, Using = PopupSelector)]
        public IWebElement PopupElement { get; set; }

        [FindsBy(How = How.XPath, Using = PopupSelector + "//div[@mat-dialog-title]")]
        public IWebElement PopupTitle { get; set; }

        public IWebElement ConponentOfDialogPage(string componentName, bool getCss = false)
        {
            var selector = $"{PopupSelector}//div[contains(@class,'mat-list-item-content') and text() = '{componentName}']";

            if (getCss.Equals(true))
            {
                selector = $"{PopupSelector}//div[contains(@class,'mat-list-item-content') and text() = '{componentName}']/ancestor::button[contains(@class, mat-list-item)]";
            }

            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        public bool IsConponentOfDialogPageHighlighted(string componentName)
        {
            var bgColor = ConponentOfDialogPage(componentName, true).GetCssValue("background");
            var result = bgColor.Contains("rgb(128, 139, 153)");
            return result;
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