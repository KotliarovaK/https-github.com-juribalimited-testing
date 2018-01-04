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
    class GlobalSearchElement : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@aria-label='Search everything']")]
        public IWebElement SearchEverythingField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='result-table']")]
        public IWebElement SearchResults { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[@class='no-result']")]
        public IWebElement NoResultFound { get; set; }

        [FindsBy(How = How.XPath, Using = ".//button[@class='btn input-toggle mat-icon-button ng-star-inserted']")]
        public IWebElement SearchTextboxResetButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.SearchEverythingField),
            };
        }
    }
}