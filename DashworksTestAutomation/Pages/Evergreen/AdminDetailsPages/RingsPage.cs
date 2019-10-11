using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages
{
    internal class RingsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//button//span[text()='CREATE PROJECT RING']")]
        public IWebElement CreateProjectRingButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p => p.CreateProjectRingButton)
            };
        }
    }
}

