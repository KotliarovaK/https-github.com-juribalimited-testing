using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.CreatingProjects.SelfService
{
    internal class SelfService_DetailsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'EnableSelfService')]")]
        public IWebElement EnableSelfServicePortal { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'AllowAnonymousUsers')]")]
        public IWebElement AllowAnonymousUsers { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'ProjectDefault')]")]
        public IWebElement ThisProjectDefault { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'SelfServiceMode_0')]")]
        public IWebElement Mode1 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'SelfServiceMode_1')]")]
        public IWebElement Mode2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'BaseUrl')]")]
        public IWebElement BaseUrl { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'LogoUrlType_0')]")]
        public IWebElement NoLink { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'LogoUrlType_1')]")]
        public IWebElement DashworksProjectHomepage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'LogoUrlType_2')]")]
        public IWebElement CustomUrl { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'HeaderLogoUrl')]")]
        public IWebElement CustomUrlTextField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='TB_BackgroundColor']")]
        public IWebElement BackgroundColor { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='TB_PrimaryColor']")]
        public IWebElement PrimaryColor { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='TB_SecondaryColor']")]
        public IWebElement SecondaryColor { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='TB_HighlightFontColour']")]
        public IWebElement HighlightFontColor { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='TB_MenuHeaderFontColour']")]
        public IWebElement MenuHeaderFontColor { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.EnableSelfServicePortal),
                SelectorFor(this, p => p.AllowAnonymousUsers),
                SelectorFor(this, p => p.ThisProjectDefault),
                SelectorFor(this, p => p.BaseUrl),
                SelectorFor(this, p => p.BackgroundColor),
                SelectorFor(this, p => p.PrimaryColor),
                SelectorFor(this, p => p.SecondaryColor),
                SelectorFor(this, p => p.HighlightFontColor),
                SelectorFor(this, p => p.MenuHeaderFontColor),
            };
        }
    }
}