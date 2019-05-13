using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.ItemDetails
{
    internal class NavigationPage : SeleniumBasePage
    {
        public const string MainTabsOnDetailsPage = "//div[contains(@class, 'das-mat-tree-node')]/a";

        public const string SubTabsOnDetailsPage = "//ul[@class='das-mat-tree-submenu']//li[contains(@class,'das-mat-tree-node')]/a";

        [FindsBy(How = How.XPath, Using = ".//div[@class='mat-drawer-inner-container']")]
        public IWebElement PageIdentitySelectors { get; set; }

        [FindsBy(How = How.XPath, Using = MainTabsOnDetailsPage)]
        public IList<IWebElement> MainTabsOnDetailsPageList { get; set; }

        [FindsBy(How = How.XPath, Using = SubTabsOnDetailsPage)]
        public IList<IWebElement> SubTabsOnDetailsPageList { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p => p.PageIdentitySelectors)
            };
        }

        public IWebElement GetNavigationLinkByName(string linkName)
        {
            var link = By.XPath($".//div[@class='title-container']//a[text()='{linkName}']");
            Driver.WaitWhileControlIsNotDisplayed(link);
            return Driver.FindElement(link);
        }

        public IWebElement GetTabMenuByName(string name)
        {
            var selector = By.XPath($".//li[contains(@class, 'das-mat-tree')]//a[text()='{name}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetSubMenuByName(string name)
        {
            var selector = By.XPath($".//ul[@class='das-mat-tree-submenu']//a[text()='{name}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
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

        public bool GetDisplayStatusOfTabWithCountOfItemsByName(string name, string countOfItems)
        {
            return Driver.IsElementDisplayed(By.XPath($"//li[contains(@class, 'das-mat-tree')]//a[text()='{name}']//span[contains(text(),'{countOfItems}')]"));
        }
    }
}
