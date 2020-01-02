﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ItemDetails
{
    internal class ItemDetailsTopBarPage : SeleniumBasePage
    {
        public const string TopBarTitleSelector = ".//div[contains(@class,'topbar-item-label')]";

        [FindsBy(How = How.XPath, Using = ".//div[@id='pagetitle']")]
        public IWebElement PageIdentitySelectors { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='topbar']")]
        public IWebElement TopBarOnItemDetailsPage { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.PageIdentitySelectors)
            };
        }

        public IList<IWebElement> GetTopBarItems()
        {
            var selector = By.XPath(".//div[contains(@class,'topbar-items')]/div[contains(@class,'topbar-item')]");
            Driver.WaitForElementsToBeDisplayed(selector);
            return Driver.FindElements(selector);
        }

        public IWebElement GetTopBarElementWithTitle(string title)
        {
            if (GetTopBarItems()
                .Any(x => x.FindElement(By.XPath(TopBarTitleSelector)).Text.Equals(title)))
            {
                return
                    GetTopBarItems().First(x =>
                        x.FindElement(By.XPath(TopBarTitleSelector)).Text.Equals(title));
            }

            throw new Exception($"Unable to find top toolbar item with '{title}' title");
        }

        public IWebElement GetTobBarItemTextElement(string tobBarTitle)
        {
            return GetTopBarElementWithTitle(tobBarTitle)
                .FindElement(By.XPath(".//div[contains(@class,'topbar-item-value')]"));
        }

        public List<string> GetComplianceItemsOnTopBar()
        {
            var selector = By.XPath(".//div[@class='topbar-item-label']");
            return Driver.FindElements(selector).Select(x => x.Text).ToList();
        }

        public IList<IWebElement> GetValuesColumnDataOfItemDetails()
        {
            var selector = By.XPath(".//td[contains(@class, 'mat-column-value')]");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElements(selector);
        }
    }
}
