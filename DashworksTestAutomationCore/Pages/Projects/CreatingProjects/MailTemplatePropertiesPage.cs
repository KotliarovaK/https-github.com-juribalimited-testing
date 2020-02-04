﻿using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.CreatingProjects
{
    internal class MailTemplatePropertiesPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'Name')]")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'Description')]")]
        public IWebElement Description { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'Subject')]")]
        public IWebElement SubjectLine { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[contains(@id, 'Body')]")]
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