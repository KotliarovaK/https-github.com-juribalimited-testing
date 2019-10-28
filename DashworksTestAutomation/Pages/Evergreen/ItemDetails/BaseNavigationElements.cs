using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ItemDetails
{
    //Left menu
    internal class BaseNavigationElements : SeleniumBasePage
    {
        public const string MainTabsOnDetailsPage = "//div[contains(@class, 'das-mat-tree-node')]/a";

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-drawer-inner-container']")]
        public IWebElement PageIdentitySelectors { get; set; }

        [FindsBy(How = How.XPath, Using = MainTabsOnDetailsPage)]
        public IList<IWebElement> MainTabsOnDetailsPageList { get; set; }

        //TODO probably should be replaced by LeftMenuSelector
        private static string MenuSelector = ".//a[text()='{0}']//span[@class='ng-star-inserted']";
        private static string LeftSubMenuSelector = ".//li[contains(@class,'das-mat-tree-node')]//a";
        private static string LeftParentMenuSelector = ".//li[contains(@class,'das-mat-tree-parent')]//a";
        private static string LeftMenuSelector = ".//li[contains(@class, 'das-mat-tree')]//a[text()='{0}']";

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p => p.PageIdentitySelectors)
            };
        }

        #region Get Parent/Sub menu

        //TODO Please do not use this method and try to switch to some other more specific
        public IWebElement GetLeftMenuByName(string name)
        {
            var selector = By.XPath(string.Format(LeftMenuSelector, name));
            if (!Driver.IsElementDisplayed(selector, WebDriverExtensions.WaitTime.Long))
            {
                Logger.Write(Driver.PageSource);
                throw new Exception($"'{name}' left menu was not displayed");
            }
            return Driver.FindElement(selector);
        }

        public IWebElement GetSubMenuByName(string name)
        {
            Driver.WaitForElementsToBeDisplayed(By.XPath(LeftSubMenuSelector), 30, false);
            if (!Driver.FindElements(By.XPath(LeftSubMenuSelector))
                .Any(x => x.Text.RemoveBracketsText().Equals(name) && x.Displayed()))
            {
                throw new Exception($"Sub menu with '{name}' is not displayed");
            }
            return Driver.FindElements(By.XPath(LeftSubMenuSelector))
                .First(x => x.Text.RemoveBracketsText().Equals(name) && x.Displayed());
        }

        public IWebElement GetParentMenuByName(string name)
        {
            Driver.WaitForElementsToBeDisplayed(By.XPath(LeftParentMenuSelector), 30, false);
            return Driver.FindElements(By.XPath(LeftParentMenuSelector))
                .First(x => x.Text.Equals(name) && x.Displayed());
        }

        public List<IWebElement> GetSubMenuItems(string parentName)
        {
            var parentMenu = GetParentMenuByName(parentName);
            var section = parentMenu.FindElement(By.XPath(".//ancestor::li[contains(@class,'das-mat-tree-parent')]"));
            var result = section.FindElements(By.XPath(LeftSubMenuSelector)).ToList();
            return result;
        }

        #endregion

        public IWebElement GetNavigationLinkByName(string linkName)
        {
            var link = By.XPath($".//div[@class='title-container']//a[text()='{linkName}']");
            if (!Driver.IsElementDisplayed(link, WebDriverExtensions.WaitTime.Long))
                throw new Exception($"'{linkName}' Navigation link was not displayed");
            return Driver.FindElement(link);
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
            if (!GetCountOfItemsDisplayStatusByTabName(tabName))
                throw new Exception($"Count is not displayed for '{tabName}' tab");

            var text = Driver.FindElement(By.XPath(string.Format(string.Format(MenuSelector, tabName)))).Text;
            text = text.TrimStart().TrimStart('(').TrimEnd(')');
            return int.Parse(text);
        }

        public bool GetCountOfItemsDisplayStatusByTabName(string tabName)
        {
            return Driver.IsElementDisplayed(By.XPath(string.Format(MenuSelector, tabName)), WebDriverExtensions.WaitTime.Short);
        }

        public bool GetDisplayStatusForDisabledSubTabByName(string tabName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//a[text()='{tabName}']/ancestor::mat-tree-node[contains(@class, 'disabled')]"));
        }

        public bool GetDisplayStatusForDisabledMainTabByName(string tabName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//a[text()='{tabName}']/ancestor::mat-nested-tree-node[contains(@class, 'disabled')]"));
        }

        public bool IsMenuExpanded(string tabName)
        {
            var result = Driver.ExecuteFunc(() => bool.Parse(GetLeftMenuByName(tabName)
                .FindElement(By.XPath(".//ancestor::*[contains(@class,'mat-nested-tree-node')]"))
                .GetAttribute("aria-expanded")));
            return result;
        }
    }
}