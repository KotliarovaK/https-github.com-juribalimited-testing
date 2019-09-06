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

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p => p.DialogPopUp)
            };
        }

        public string GetPopupText()
        {
            return Driver.FindElement(By.XPath(".//div[@class='mat-dialog-content']")).Text;
        }

        public IWebElement GetDialogPopUpCheckbox(string checkbox)
        {
            var selector = By.XPath($".//*[text()='{checkbox}']/preceding::div[@class='mat-checkbox-inner-container']//input");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}