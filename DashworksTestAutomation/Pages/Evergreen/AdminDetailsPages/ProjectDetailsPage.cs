using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class ProjectDetailsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div/h1")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='menu-wrapper']")]
        public IWebElement LanguageMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'add-language')]//div[@class='mat-select-arrow-wrapper']")]
        public IWebElement LanguageDropDown { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'add-language')]//i[contains(@class, 'check')]/ancestor::button")]
        public IWebElement CheckLanguageButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.PageTitle)
            };
        }
    }
}
