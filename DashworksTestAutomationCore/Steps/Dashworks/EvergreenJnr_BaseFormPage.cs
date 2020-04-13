using System;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Forms;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_BaseFormPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_BaseFormPage(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User selects following items in ""(.*)"" dropdown:")]
        public void WhenUserSelectsFollowingItemsInDropdown(string dropdownName, Table items)
        {
            var page = _driver.NowAt<BaseFormtPage>();
            page.GetDropdownByName(dropdownName).Click();

            foreach (var item in items.Rows)
            {
                page.GetDropdownCheckboxByName(item.Values.FirstOrDefault()).Click();
            }
        }
    }
}