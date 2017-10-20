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
    class ActionsElement : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@class='device-context-panel']/div[@class='device-context-header']/span[text()='Actions']")]
        public IWebElement ActionsPanel { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            Driver.WaitForDataLoading();
            return new List<By>
            {
                SelectorFor(this, p=> p.ActionsPanel)
            };
        }
    }
}
