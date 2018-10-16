using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.CreatingProjects
{
    internal class RequestType_DetailsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains(@id,'DefaultRequestType')]")]
        public IWebElement DefaultRequestTypeCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Update Details']")]
        public IWebElement UpdateDetailsButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.DefaultRequestTypeCheckbox),
                SelectorFor(this, p => p.UpdateDetailsButton)
            };
        }
    }
}