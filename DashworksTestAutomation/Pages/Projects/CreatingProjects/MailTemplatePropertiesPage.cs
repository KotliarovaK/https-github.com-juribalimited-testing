using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class MailTemplatePropertiesPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'Name')]")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'Description')]")]
        public IWebElement Description { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'Subject')]")]
        public IWebElement SubjectLine { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[contains(@id, 'MainContent_Body')]")]
        public IWebElement BodyText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@value='Create Mail Template']")]
        public IWebElement ConfirmCreateMailTemplateButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.Name),
                SelectorFor(this, p => p.Description),
                SelectorFor(this, p => p.SubjectLine),
                SelectorFor(this, p => p.BodyText)
            };
        }
    }
}