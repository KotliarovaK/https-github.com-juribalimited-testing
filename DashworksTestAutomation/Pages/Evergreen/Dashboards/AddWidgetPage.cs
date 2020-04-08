using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.Dashboards
{
    internal class AddWidgetPage : BaseWidgetPage
    {
        public const string ColorSchemeDropdownContent = ".//div/mat-option[contains(@class, 'colour-scheme')]//div[contains(@class, 'inner-colour')]";
        public const string ColorSchemeDropdownContainer = ".//div[@class='cdk-overlay-pane']";

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='WidgetType']")]
        public IWebElement WidgetType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@formcontrolname='colourSchemeId']")]
        public IWebElement ColorSchemeDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@formcontrolname='colourSchemeId']//span")]
        public IWebElement ColorSchemePlaceholder { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-checkbox[@formcontrolname='showLegend']/label")]
        public IWebElement ShowLegend { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-checkbox[@formcontrolname='showLegend']/label/span")]
        public IWebElement ShowLegendLabel { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-checkbox[@formcontrolname='displayDataLabels']/label/span")]
        public IWebElement ShowDataLabel { get; set; }

        #region Messages

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'inline-error ng-star-inserted')]")]
        public IWebElement ErrorMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[text()='This list does not exist or you do not have access to it']")]
        public IWebElement ListDoesNotExistMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'empty-message')]")]
        public IWebElement PreviewPaneMessageText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@role='alert']/div[last()]")]
        public IWebElement PreviewPaneAlertText { get; set; }

        #endregion

        [FindsBy(How = How.XPath, Using = ".//div[@class='widget-preview']//*[text()='No preview available']")]
        public IWebElement WidgetPreviewEmpty { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.WidgetType),
            };
        }

        public IWebElement GetColorFromColorScheme(string colorTitle)
        {
            var selector = $".//div[@class='inner-colour'][text()='{colorTitle}']";
            Driver.WaitForElementToBeDisplayed(By.XPath(selector));
            return Driver.FindElement(By.XPath(selector));
        }

        public IList<IWebElement> GetDropdownOptions()
        {
            return Driver.FindElements(By.XPath(".//mat-option/span"));
        }

        public void ClickColorSchemeByIndex(int index)
        {
            Driver.FindElement(By.XPath($".//mat-option[{index}]")).Click();
        }

        public void ClickColorSchemeByColorCode(string code)
        {
            ColorSchemePartByCode(code).FindElement(By.XPath("./parent::span")).Click();
        }

        public IWebElement ColorSchemePartByCode(string code)
        {
            return Driver.FindElements(By.XPath($".//mat-option/span/div")).First(x => x.GetAttribute("style").Contains(code));
        }

        public IWebElement GetDashboardCheckboxByName(string checkboxName)
        {
            var selector = By.XPath($".//mat-checkbox//span[text()='{checkboxName}']//ancestor::mat-checkbox");
            return Driver.FindElement(selector);
        }

        public IWebElement GetTableWidgetPreview()
        {
            return Driver.FindElement(By.XPath(".//div[@class='table-responsive']"));
        }

        public IWebElement GetWidgetPreviewText()
        {
            try
            {
                return Driver.FindElement(
                    By.XPath(".//div[contains(@class, 'widget-value')]//span[contains(@class, 'text')]"));
            }
            catch (NoSuchElementException)
            {
                return Driver.FindElement(By.XPath(".//div[contains(@class, 'widget-data')]"));
            }
        }

        public string GetOrderBySelectedOption()
        {
            var option = By.XPath($".//mat-select[@aria-label='OrderBy']//span/*");
            Driver.WaitForDataLoading();

            try
            {
                return Driver.FindElement(option).Text;
            }
            catch (NoSuchElementException)
            {
                return string.Empty;
            }
        }

        public IList<IWebElement> GetMainCategoriesOfListDDL()
        {
            var listCategories = ".//*[contains(@id, 'mat-optgroup-label')]";
            Driver.WaitForElementToBeDisplayed(By.XPath(listCategories));
            return Driver.FindElements(By.XPath(listCategories));
        }

        public void SelectSplitByItem(string item)
        {
            var splitByDdl = By.XPath(".//*[@aria-label='SplitBy']");
            var expandedItems = By.XPath(".//span[@class='mat-option-text']");
            var itemToBeSelected = By.XPath($".//mat-option//span[contains(text(), '{item}')]");

            for (int i = 0; i < 5; i++)
            {
                if (!Driver.IsElementDisplayed(expandedItems))
                {
                    Driver.FindElement(splitByDdl).Click();
                    Thread.Sleep(500);
                }
                else
                {
                    Driver.FindElement(itemToBeSelected).Click();
                    break;
                }
            }
        }
    }
}