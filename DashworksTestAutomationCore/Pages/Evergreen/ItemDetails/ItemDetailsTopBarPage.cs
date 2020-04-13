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
    //Can be generic element but for now used only on ItemDetails
    internal class ItemDetailsTopBarPage : SeleniumBasePage
    {
        public const string TopBarTitleSelector = ".//div[contains(@class,'topbar-item-label')]";

        public const string TopBarTextSelector = ".//div[contains(@class,'topbar-item-value')]";

        [FindsBy(How = How.XPath, Using = ".//div[@id='topbar']")]
        public IWebElement TopBarElement { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By> { };
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
                .FindElement(By.XPath(TopBarTextSelector));
        }

        public List<string> GetTopBarItemsText()
        {
            var list = GetTopBarItems()
                .Select(x => x.FindElement(By.XPath(TopBarTitleSelector)))
                .Select(x => x.Text).ToList();
            return list;
        }
    }
}
