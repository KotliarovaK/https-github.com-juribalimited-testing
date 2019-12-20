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

        private static string LeftSubMenuSelector = ".//li[contains(@class,'das-mat-tree-node')]//a";
        private static string LeftParentMenuSelector = MainTabsOnDetailsPage;
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

        public IEnumerable<IWebElement> GetParentMenuByName()
        {
            Driver.WaitForElementsToBeDisplayed(By.XPath(LeftParentMenuSelector), 30, false);
            return Driver.FindElements(By.XPath(LeftParentMenuSelector))
                .Where(x => x.Displayed());
        }

        public IWebElement GetParentMenuByName(string name)
        {
            Driver.WaitForElementsToBeDisplayed(By.XPath(LeftParentMenuSelector), 30, false);
            return GetParentMenuByName().First(x => x.Text.Equals(name));
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

        public List<IWebElement> GetSubMenuItems(string parentName)
        {
            var parentMenu = GetParentMenuByName(parentName);
            var section = parentMenu.FindElement(By.XPath(".//ancestor::li[contains(@class,'das-mat-tree-parent')]"));
            var result = section.FindElements(By.XPath(LeftSubMenuSelector)).ToList();
            return result;
        }

        #endregion

        #region Sub menu count

        //Count of items in the particular submenu
        private IWebElement GetSubmenuItemsItemsCount(string subMenu)
        {
            var subMenuElement = GetSubMenuByName(subMenu);
            if (Driver.IsElementInElementDisplayed(subMenuElement, By.XPath(".//span[contains(text(),'(') and contains(text(),')')]")
                , WebDriverExtensions.WaitTime.Medium))
            {
                return subMenuElement.FindElement(By.XPath(".//span[contains(text(),'(') and contains(text(),')')]"));
            }
            else
            {
                return null;
            }
        }

        public bool IsSubmenuCountIsDisplayed(string subMenu)
        {
            var submenuCount = GetSubmenuItemsItemsCount(subMenu);
            return submenuCount != null && submenuCount.Displayed();
        }

        public int SubmenuItemsCount(string subMenu)
        {
            var submenuCount = GetSubmenuItemsItemsCount(subMenu).Text;
            submenuCount = submenuCount.TrimStart().TrimStart('(').TrimEnd(')');
            return int.Parse(submenuCount);
        }

        #endregion

        #region Disabled/Enabeld state

        public bool IsSubmenuDisabled(string subMenu)
        {
            var submenuCount = GetSubMenuByName(subMenu).FindElement(By.XPath(".//ancestor::mat-tree-node")).GetAttribute("class");
            return submenuCount.Contains("disabled");
        }

        public bool IsParentMenuDisabled(string menu)
        {
            var submenuCount = GetParentMenuByName(menu).FindElement(By.XPath(".//ancestor::mat-nested-tree-node")).GetAttribute("class");
            return submenuCount.Contains("disabled");
        }

        #endregion

        #region Expanded/Collapsed state

        public bool IsMenuExpanded(string tabName)
        {
            var result = Driver.ExecuteFunc(() => bool.Parse(GetLeftMenuByName(tabName)
                .FindElement(By.XPath(".//ancestor::*[contains(@class,'mat-nested-tree-node')]"))
                .GetAttribute("aria-expanded")));
            return result;
        }

        #endregion

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
    }
}