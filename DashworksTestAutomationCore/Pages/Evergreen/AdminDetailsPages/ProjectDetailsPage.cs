using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class ProjectDetailsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div/h1")]
        public IWebElement PageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='menu-wrapper']")]
        public IWebElement LanguageMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'add-language')]//div[@class='mat-select-arrow-wrapper']")]
        public IWebElement LanguageDropDown { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'add-language')]//i[contains(@class, 'check')]/ancestor::button")]
        public IWebElement CheckLanguageButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//span[contains(@class,'mat-button-wrapper') and contains(text(),'CONVERT TO EVERGREEN')]")]
        public IWebElement ConvertToEvergreen { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'inline-buttons')]//span[contains(text(),'CONVERT')]")]
        public IWebElement ConfirmConvertToEvergreenButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[contains(@class,'inline-buttons')]//span[contains(text(),'CANCEL')]")]
        public IWebElement CancelConvertToEvergreenButton { get; set; }

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
