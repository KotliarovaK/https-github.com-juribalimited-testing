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

        public IWebElement GetPopupButtonByName(string button)
        {
            var selector = By.XPath(
                $".//mat-dialog-container//span[text()='{button}']/ancestor::button");
            Driver.WaitForDataLoading();
            Driver.WaitForElementsToBeDisplayed(selector, 30, false);
            return Driver.FindElements(selector).First(x => x.Displayed());
        }

        public void ClickPopupButtonByName(string buttonName)
        {
            var button = GetPopupButtonByName(buttonName);
            Driver.WaitForElementToBeEnabled(button);
            button.Click();
            Driver.WaitForDataLoading(50);
        }
    }
}