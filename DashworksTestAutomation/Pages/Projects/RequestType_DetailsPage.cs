using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class RequestType_DetailsPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains (@id, 'DefaultRequestType')]")]
        public IWebElement DefaultRequestType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Update Details']")]
        public IWebElement UpdateDetailsButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.DefaultRequestType),
                SelectorFor(this, p => p.UpdateDetailsButton),
            };
        }
    }
}