using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu
{
    internal class GroupTabMenu : SeleniumBasePage
    {
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