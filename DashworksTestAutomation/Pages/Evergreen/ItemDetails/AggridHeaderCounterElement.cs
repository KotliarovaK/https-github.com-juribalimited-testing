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
    //TODO looks like this should be moved to BaseGrid
    public class AggridHeaderCounterElement : SeleniumBasePage
    {
        //Commented selector point to the GroupBy button on the grid.
        //But if greed is empty than those controls will not appears
        //[FindsBy(How = How.XPath, Using = ".//div[contains(@class, 'aggrid-container wrapper-flexbox')]")]

        [FindsBy(How = How.XPath, Using = ".//div[@class = 'details-aggrid']//div[@class='top-tools']")]
        public IWebElement AgGridToolbar { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='aggrid-container']")]
        public IWebElement PageIdentitySelectors { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@automation='create custom-field']")]
        public IWebElement CreateCustomFieldsButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='aggridHeaderActions']//button[@aria-label='ResetFilters']")]
        public IWebElement ResetFiltersButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='aggridHeaderActions']//button[@aria-label='GroupBy']")]
        public IWebElement GroupByButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='aggridHeaderActions']//button[@aria-label='reload']")]
        public IWebElement RefreshButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='aggridHeaderActions']//button[@aria-label='Export']")]
        public IWebElement ExportButton { get; set; }

       
        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                //SelectorFor(this, p => p.PageIdentitySelectors)
            };
        }

        public IList<IWebElement> GetGroupByValues()
        {
            return Driver.FindElements(By.XPath(".//span[@class='mat-checkbox-label']"));
        }

        public IWebElement GetValueInGroupByFilterOnDetailsPage(string value)
        {
            var selector = By.XPath($"//*[text()='{value}']/ancestor::label[contains(@class, 'checkbox')]");
            Driver.WaitForElementToBeDisplayed(selector);
            return Driver.FindElement(selector);
        }
    }
}
