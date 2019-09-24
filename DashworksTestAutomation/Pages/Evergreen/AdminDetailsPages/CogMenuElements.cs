using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class CogMenuElements : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div/h1")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='cell-menu-settings']")]
        public IWebElement CogMenu { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='menu']")]
        public IWebElement CogMenuDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div/ul[@class='menu-settings']//a")]
        public IWebElement CogMenuDropdownLabel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Move to position']")]
        public IWebElement MoveToPositionField { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p => p.PageTitle),
                //SelectorFor(this, p => p.CogMenu)
            };
        }

        public string GetCogMenuDropdownColor()
        {
            Driver.WaitForElementToBeDisplayed(CogMenuDropdown);
            return CogMenuDropdown.GetCssValue("background-color");
        }

        public string GetCogMenuDropdownLabelColor()
        {
            return CogMenuDropdownLabel.GetCssValue("background-color");
        }

        public IWebElement GetCogMenuByItem(string item)
        {
            var selector = By.XPath($".//div[@title='{item}']/./following-sibling::div//div[@class='cell-menu-settings']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetCogmenuOptionByName(string option)
        {
            var selector = By.XPath($"//*[contains(text(), '{option}')]/ancestor::li[@class='ng-star-inserted']");
            return Driver.FindElement(selector);
        }

        public bool CheckItemDisplay(string name)
        {
            return Driver.IsElementDisplayed(By.XPath($".//div[@role='gridcell']//a[text()='{name}']"));
        }
    }
}
