using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.Base
{
    internal class CogMenuElements : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div/h1")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='cell-menu-settings']")]
        public IWebElement CogMenu { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@aria-label='Dialog']//div[contains(class, menu)]")]
        public IWebElement CogMenuList { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div/ul[@class='menu-settings']//a")]
        public IWebElement CogMenuDropdownLabel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@placeholder='Move to position']")]
        public IWebElement MoveToPositionField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//ul[contains(@class,'menu-settings')]//*[string-length(text()) > 0]")]
        public IList<IWebElement> CogMenuItems { get; set; }

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
            Driver.WaitForElementToBeDisplayed(CogMenuList);
            return CogMenuList.GetCssValue("background-color");
        }

        public string GetCogMenuDropdownLabelColor()
        {
            return CogMenuDropdownLabel.GetCssValue("background-color");
        }

        public IWebElement GetCogMenuByItem(string column, string item)
        {
            var page = Driver.NowAt<BaseGridPage>();

            var cell = page.GetCellFromColumn(column, item);
            var selector = cell
                .FindElement(By.XPath(".//ancestor::div[@role='gridcell']//following-sibling::div//div[@class='cell-menu-settings']"));
            Driver.WaitForElementToBeDisplayed(selector);
            return selector;
        }

        public IWebElement GetCogMenuOptionByName(string option)
        {
            Driver.WaitForElementsToBeDisplayed(CogMenuItems);

            if (CogMenuItems.Any(x => x.Text.Equals(option)))
            {
                return CogMenuItems.FirstOrDefault(x => x.Text.Equals(option));
            }

            throw new Exception($"'{option}' cog-menu item was not found");
        }

        public bool CheckItemDisplay(string name)
        {
            return Driver.IsElementDisplayed(By.XPath($".//div[@role='gridcell']//a[text()='{name}']"));
        }
    }
}
