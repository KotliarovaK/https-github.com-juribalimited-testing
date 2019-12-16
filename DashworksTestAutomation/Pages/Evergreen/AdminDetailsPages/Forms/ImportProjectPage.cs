using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Forms
{
    internal class ImportProjectPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'action-container')]/h2")]
        public IWebElement ImportProjectFormTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//mat-option[contains(@class, 'mat-option ng-star-inserted')]/span")]
        public IList<IWebElement> DropdownOptions { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='form']/div[contains(@class,'input')]/input")]
        public IWebElement ButtonChooseFile { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.ImportProjectFormTitle)
            };
        }
    }
}