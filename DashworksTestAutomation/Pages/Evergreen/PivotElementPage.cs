using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen
{
    internal class PivotElementPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//h1")]
        public IWebElement PageHeader { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Pivot Name']")]
        public IWebElement PivotNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='SAVE']/ancestor::button")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                ".//div[@class='columns-panel']//div[contains(@class,'filter-category-label') and contains(@class,'bold')]")]
        public IList<IWebElement> PivotCategories { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'pivot-choice')]/button[contains(@class,'back')]")]
        public IWebElement CloseAddItemIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='nopivot ng-star-inserted']")]
        public IWebElement NoPivotTableMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='RESET']/ancestor::button")]
        public IWebElement ResetPivotButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[contains(@class, 'arrow_back')]/ancestor::button")]
        public IWebElement BackButtonOnPivotPanel { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.PageHeader)
            };
        }

        public IWebElement GetButtonByNameOnPivot(string button)
        {
            var selector = By.XPath($"//span[text()='{button}']/ancestor::button");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetCloseButtonForElementsByNameOnPivot(string button)
        {
            var selector = By.XPath($"//span[text()='{button}']/..//following-sibling::button");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetChipByNameOnPivot(string button)
        {
            var selector = By.XPath($"//span[@class='pivot-filter-name'][text()='{button}']");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetCloseButtonForValueElementsByNameOnPivot(string button)
        {
            var selector = By.XPath($"//div[text()='{button}']/..//following-sibling::button");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }

        public IWebElement GetPlusButtonOnPivotByName(string button)
        {
            var selector = By.XPath($"//div[@class='context-block-title'][text()='{button}']/following-sibling::div//button[contains(@class, 'plus')]");
            Driver.WaitWhileControlIsNotDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}
