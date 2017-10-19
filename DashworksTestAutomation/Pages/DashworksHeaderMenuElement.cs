using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages
{
    class DashworksHeaderMenuElement : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//div[@id='maincontent']/descendant::h1[position()=1]")]
        public IWebElement PageHeader { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_DwTopBar1_DwLogin1_UserLink")]
        public IWebElement LoginLink { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_DwTopBar1_DwLogin1_LogoutLink")]
        public IWebElement LogoutLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@title='Switch Sites']")]
        public IWebElement AnalysisLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[@title='Evergreen']")]
        public IWebElement EvergreenLink { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p=> p.PageHeader),
                SelectorFor(this, p=> p.AnalysisLink)
            };
        }
    }
}
