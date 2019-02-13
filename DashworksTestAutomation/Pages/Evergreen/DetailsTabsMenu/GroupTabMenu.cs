using System.Collections.Generic;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu
{
    internal class GroupTabMenu : BaseTabSectionElements
    {
        [FindsBy(How = How.XPath,
            Using =
                ".//span[text()='Application Summary']/ancestor::div[@class='field-category no-side-padding collapsed']")]
        public IWebElement ApplicationSummarySection { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                ".//span[text()='Application Detail']/ancestor::div[@class='field-category no-side-padding collapsed']")]
        public IWebElement ApplicationDetailSection { get; set; }

        [FindsBy(How = How.XPath,
            Using =
                ".//span[text()='Advertisements']/ancestor::div[@class='field-category no-side-padding collapsed']")]
        public IWebElement AdvertisementsSection { get; set; }

        [FindsBy(How = How.XPath,
            Using = ".//span[text()='Collections']/ancestor::div[@class='field-category no-side-padding collapsed']")]
        public IWebElement CollectionsSection { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-icon ag-icon-columns']")]
        public IWebElement ColumnButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='ag-column-select-label']")]
        public IList<IWebElement> ColumnCheckboxName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Application Summary']")]
        public IList<IWebElement> ApplicationSummarySectionHeader { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Advertisements']")]
        public IList<IWebElement> AdvertisementsSectionHeader { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Collections']")]
        public IWebElement CollectionsSectionHeader { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Application Detail']")]
        public IWebElement ApplicationDetailSectionHeader { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();

            return new List<By>
            {
                SelectorFor(this, p => p.ApplicationSummarySectionHeader),
                SelectorFor(this,
                    p => p.ApplicationDetailSectionHeader),
                SelectorFor(this,
                    p => p.AdvertisementsSectionHeader),
                SelectorFor(this,
                    p => p.CollectionsSectionHeader)
            };
        }
    }
}