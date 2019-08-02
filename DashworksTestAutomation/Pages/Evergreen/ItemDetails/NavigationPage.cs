using System;
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
    internal class NavigationPage : SeleniumBasePage
    {
        public const string MainTabsOnDetailsPage = "//div[contains(@class, 'das-mat-tree-node')]/a";

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-drawer-inner-container']")]
        public IWebElement PageIdentitySelectors { get; set; }

        [FindsBy(How = How.XPath, Using = MainTabsOnDetailsPage)]
        public IList<IWebElement> MainTabsOnDetailsPageList { get; set; }

        private static string TabCountSelector = ".//a[text()='{0}']//span[@class='ng-star-inserted']";

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p => p.PageIdentitySelectors)
            };
        }

        public IWebElement  GetNavigationLinkByName(string linkName)
        {
            var link = By.XPath($".//div[@class='title-container']//a[text()='{linkName}']");
            Driver.WaitForElementToBeDisplayed(link);
            return Driver.FindElement(link);
        }

        public IWebElement GetTabMenuByName(string name)
        {
            var selector = By.XPath($".//li[contains(@class, 'das-mat-tree')]//a[text()='{name}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetSubMenuByName(string name)
        {
            var selector = By.XPath($".//ul[@class='das-mat-tree-submenu']//a[text()='{name}']");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public bool GetExpandedTabByName(string tabName)
        {
            return Driver.IsElementDisplayed(By.XPath($"//li[@class='das-mat-tree-parent']/div[contains(@class, 'collapsed')]/a[text()='{tabName}']"));
        }
        public bool GetTabByName(string tabName)
        {
            return Driver.IsElementDisplayed(By.XPath($"//a[@class='ng-star-inserted'][text()='{tabName}']"));
        }

        public bool GetDisplayStatusSubTabByName(string tabName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//ul[@class='das-mat-tree-submenu']//a[text()='{tabName}']"));
        }

        public bool GetDisplayStatusOfTabWithCountOfItemsByName(string name, string countOfItems)
        {
            return Driver.IsElementDisplayed(By.XPath($"//li[contains(@class, 'das-mat-tree')]//a[text()='{name}']//span[contains(text(),'{countOfItems}')]"));
        }

        public int GetCountOfItemsByTabName(string tabName)
        {
            if(!GetCountOfItemsDisplayStatusByTabName(tabName))
                throw new Exception($"Count is not displayed for '{tabName}' tab");

            var text = Driver.FindElement(By.XPath(string.Format(string.Format(TabCountSelector, tabName)))).Text;
            text = text.TrimStart().TrimStart('(').TrimEnd(')');
            return int.Parse(text);
        }

        public bool GetCountOfItemsDisplayStatusByTabName(string tabName)
        {
            return Driver.IsElementDisplayed(By.XPath(string.Format(TabCountSelector, tabName)));
        }

        public bool GetDisplayStatusForDisabledSubTabByName(string tabName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//a[text()='{tabName}']/ancestor::mat-tree-node[contains(@class, 'disabled')]"));
        }
        public bool GetDisplayStatusForDisabledMainTabByName(string tabName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//a[text()='{tabName}']/ancestor::mat-nested-tree-node[contains(@class, 'disabled')]"));
        }
    }
}
