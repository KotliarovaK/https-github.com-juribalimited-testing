using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu
{
    internal class ApplicationsDetailsTabsMenu : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using =".//span[text()='Application Summary']/ancestor::div[@class='field-category no-side-padding collapsed']")]
        public IWebElement ApplicationSummarySection { get; set; }

        [FindsBy(How = How.XPath, Using =".//span[text()='Application Detail']/ancestor::div[@class='field-category no-side-padding collapsed']")]
        public IWebElement ApplicationDetailSection { get; set; }

        [FindsBy(How = How.XPath, Using =".//span[text()='Advertisements']/ancestor::div[@class='field-category no-side-padding collapsed']")]
        public IWebElement AdvertisementsSection { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Collections']/ancestor::div[@class='field-category no-side-padding collapsed']")]
        public IWebElement CollectionsSection { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-icon ag-icon-columns']")]
        public IWebElement ColumnButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='ag-column-select-column ag-toolpanel-indent-0']//span[contains(text(),'')]")]
        public IWebElement Checkbox { get; set; }

        public void OpenColumnSettingsByName(string columnName)
        {
            string columnSettingsSelector = 
                $".//div[@role='presentation']/span[text()='{columnName}']/ancestor::div[@class='ag-header-cell ag-header-cell-sortable']//span[@ref='eMenu']";
            Driver.MouseHover(By.XPath(columnSettingsSelector));
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(columnSettingsSelector));
            Driver.FindElement(By.XPath(columnSettingsSelector)).Click();
        }

        public bool IsColumnPresent(string columnName)
        {
            var selector = string.Empty;
            if (columnName.Contains("'"))
            {
                var strings = columnName.Split('\'');
                selector = $".//div[@role='presentation']/span[contains(text(),'{strings[0]}')][contains(text(), '{strings[1]}')]";
            }
            else
            {
                selector = $".//div[@role='presentation']/span[text()='{columnName}']";
            }
            return Driver.IsElementDisplayed(By.XPath(selector));
        }

        public void GetCheckboxByName(string columnName)
        {
            string columnSettingsSelector = $".//div[@class='ag-column-select-panel']//span[text()='Key']";
            Driver.MouseHover(By.XPath(columnSettingsSelector));
            Driver.WaitWhileControlIsNotDisplayed(By.XPath(columnSettingsSelector));
            Driver.FindElement(By.XPath(columnSettingsSelector)).Click();
        }

    }
}
