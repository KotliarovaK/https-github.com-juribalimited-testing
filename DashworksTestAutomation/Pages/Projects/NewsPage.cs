using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    class NewsPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@id='NewsTitle']")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[@id='NewsText']")]
        public IWebElement Text { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.Title),
                SelectorFor(this, p => p.Text)
            };
        }
    }
}