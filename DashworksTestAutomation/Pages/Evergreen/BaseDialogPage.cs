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

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p => p.PopupElement)
            };
        }

        #region Button

        public IWebElement GetButtonByNameOnPopup(string button)
        {
            return GetButtonByName(button, this.GetStringByFor(() => this.PopupElement));
        }

        #endregion
        
        public IWebElement GetCollapsedField(string fieldTitle)
        {
            var selector =
                By.XPath($".//div[contains(@class,'field-category')]//span[contains(text(),'{fieldTitle}')]/..");
            if (!Driver.IsElementDisplayed(selector, WebDriverExtensions.WaitTime.Medium))
                throw new Exception($"'{fieldTitle}' field was not found!");
            return Driver.FindElement(selector);
        }

        public IWebElement GetExpandedField(string fieldTitle)
        {
            var selector =
                By.XPath($"//mat-dialog-container//div[@class='field-category collapsed']//span[contains(text(),'{fieldTitle}')]/..");
            if (!Driver.IsElementDisplayed(selector, WebDriverExtensions.WaitTime.Medium))
                throw new Exception($"'{fieldTitle}' field was not found!");
            return Driver.FindElement(selector);
        }

        public IWebElement ExpandFieldInDialogPopup(string titleText)
        {
            var buttonSelector = By.XPath(".//button");

            var element = GetCollapsedField(titleText);

            var button = element.FindElement(buttonSelector);
            return button;
        }
    }
}