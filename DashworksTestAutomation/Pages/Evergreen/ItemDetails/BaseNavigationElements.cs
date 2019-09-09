using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
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

        private static string TabCountSelector = ".//a[text()='{0}']//span[@class='ng-star-inserted']";
        private static string SubMenuByNameSelector = ".//ul[@class='das-mat-tree-submenu']//a[text()='{0}']";
        private static string TabMenuByNameSelector = ".//li[contains(@class, 'das-mat-tree')]//a[text()='{0}']";

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
            if (!Driver.IsElementDisplayed(link, WebDriverExtensions.WaitTime.Long))
                throw new Exception($"'{linkName}' Navigation link was not displayed");
            return Driver.FindElement(link);
        }

        public IWebElement GetTabMenuByName(string name)
        {
            var selector = By.XPath(string.Format(TabMenuByNameSelector, name));
            if (!Driver.IsElementDisplayed(selector, WebDriverExtensions.WaitTime.Long))
                throw new Exception($"'{name}' Tab menu was not displayed");
            return Driver.FindElement(selector);
        }

        public IWebElement GetSubMenuByName(string name)
        {
            var selector = By.XPath(string.Format(SubMenuByNameSelector, name));
            if (!Driver.IsElementDisplayed(selector, WebDriverExtensions.WaitTime.Long))
                throw new Exception($"'{name}' Sub menu was not displayed");
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
            if (!GetCountOfItemsDisplayStatusByTabName(tabName))
                throw new Exception($"Count is not displayed for '{tabName}' tab");

            var text = Driver.FindElement(By.XPath(string.Format(string.Format(TabCountSelector, tabName)))).Text;
            text = text.TrimStart().TrimStart('(').TrimEnd(')');
            return int.Parse(text);
        }

        public bool GetCountOfItemsDisplayStatusByTabName(string tabName)
        {
            return Driver.IsElementDisplayed(By.XPath(string.Format(TabCountSelector, tabName)), WebDriverExtensions.WaitTime.Short);
        }

        public bool GetDisplayStatusForDisabledSubTabByName(string tabName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//a[text()='{tabName}']/ancestor::mat-tree-node[contains(@class, 'disabled')]"));
        }
        public bool GetDisplayStatusForDisabledMainTabByName(string tabName)
        {
            return Driver.IsElementDisplayed(By.XPath($".//a[text()='{tabName}']/ancestor::mat-nested-tree-node[contains(@class, 'disabled')]"));
        }

        public List<Point> LoadingIndicatorCoordinates()
        {
            Thread.Sleep(2000);
            List<Point> points = new List<Point>();
            IList<IWebElement> links = Driver.FindElements(By.XPath(".//li[contains(@class, 'das-mat-tree')]//a[contains(@href, 'details')]"));

            int attempt = 0;

            while (attempt != 3 && points.Count == 0)
            {
                foreach (var link in links)
                {
                    try
                    {
                        link.Click();
                    }
                    catch (Exception)
                    {
                        break;
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        try
                        {
                            if (Driver.FindElements(
                                        By.XPath(".//div[contains(@class,'spinner') and not(contains(@class,'small'))]"))
                                    .Count > 0)
                            {
                                points.Add(Driver.FindElements(By.XPath(".//div[contains(@class,'spinner') and not(contains(@class,'small'))]")).First().Location);
                            }
                        }
                        catch (Exception)
                        {
                            break;
                        }
                    }
                    Driver.WaitForDataLoading();
                }
            }

            return points;
        }
    }
}
