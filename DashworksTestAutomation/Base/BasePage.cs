using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Base
{
    public class BasePage : SeleniumBasePage
    {
        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By> { };
        }

        //TODO Need need to be removed or updated later?
        public IWebElement GetCheckboxByText(string checkbox)
        {
            var selector = By.XPath($".//*[text()='{checkbox}']/preceding::div[@class='mat-checkbox-inner-container']//input");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}
