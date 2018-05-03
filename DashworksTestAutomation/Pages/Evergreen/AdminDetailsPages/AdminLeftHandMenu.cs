using System.Collections.Generic;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class AdminLeftHandMenu : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='title-container']")]
        public IWebElement AdminTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='submenu ps']")]
        public IWebElement AdminSubMenu { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@aria-describedby='cdk-describedby-message-7']")]
        public IWebElement Projects { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Teams']")]
        public IWebElement Teams { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[text()='Buckets']")]
        public IWebElement Buckets { get; set; }

        [FindsBy(How = How.XPath, Using = ".//h1[text()='Projects']")]
        public IWebElement ProjectsPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//h1[text()='Teams']")]
        public IWebElement TeamsPage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//h1[text()='Buckets']")]
        public IWebElement BucketsPage { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.AdminTitle),
                SelectorFor(this, p => p.Projects),
                SelectorFor(this, p => p.Teams),
                SelectorFor(this, p => p.Buckets)
            };
        }
    }
}