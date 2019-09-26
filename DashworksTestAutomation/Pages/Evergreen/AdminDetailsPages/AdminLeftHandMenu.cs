using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class AdminLeftHandMenu : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='title-container']")]
        public IWebElement AdminTitle { get; set; }

        //TODO remove this. Used like an indicator that we have opened Admin page but this is just breadcrumbs
        [FindsBy(How = How.XPath, Using = ".//mat-sidenav[@role='navigation']")]
        public IWebElement AdminSubMenu { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[text()='Projects']/ancestor::mat-tree-node")]
        public IWebElement Projects { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[text()='Teams']")]
        public IWebElement Teams { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Buckets']")]
        public IWebElement Buckets { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div/a[text()='Automations']")]
        public IWebElement Automations { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div/a[text()='Evergreen']")]
        public IWebElement EvergreenSectionTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div/a[text()='Capacity']")]
        public IWebElement CapacitySectionTab { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Capacity Units']")]
        public IWebElement CapacityUnits { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Rings']")]
        public IWebElement Rings { get; set; }

        [FindsBy(How = How.XPath, Using = ".//h1[text()='Projects']")]
        public IWebElement ProjectsPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//h1[text()='Teams']")]
        public IWebElement TeamsPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//h1[text()='Buckets']")]
        public IWebElement BucketsPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//h1[text()='Capacity Units']")]
        public IWebElement CapacityUnitsPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//h1[text()='Rings']")]
        public IWebElement RingsPage { get; set; }

        //TODO should be moved to generic page
        [FindsBy(How = How.XPath, Using = ".//button[contains(@class, 'buttonToggleSubmenu')]")]
        public IWebElement ExpandSidePanelIcon { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By> { };
        }
    }
}