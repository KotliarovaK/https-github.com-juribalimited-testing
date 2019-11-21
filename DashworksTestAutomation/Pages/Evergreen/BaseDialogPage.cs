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
    public class BaseDialogPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//mat-dialog-container[contains(@class, 'dialogContainer')]")]
        public IWebElement DialogPopUp { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='field-category']")]
        public IWebElement FieldContainer { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p => p.DialogPopUp)
            };
        }

        //TODO why this is method but not webElement?
        public string GetPopupText()
        {
            return Driver.FindElement(By.XPath(".//div[@class='mat-dialog-content']")).Text;
        }

        public IWebElement GetExpandableField(string fieldTitle)
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

        public IWebElement ExpandField(string titleText)
        {
            var buttonSelector = By.XPath(".//button");

            var element = GetExpandableField(titleText);

            var button = element.FindElement(buttonSelector);
            return button;
        }
    }
}