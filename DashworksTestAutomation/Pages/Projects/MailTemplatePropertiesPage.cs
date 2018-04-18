﻿using System.Collections.Generic;
using DashworksTestAutomation.Pages.Evergreen;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects
{
    internal class MailTemplatePropertiesPage : BaseDashboardPage
    {
        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_Name']")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_Description']")]
        public IWebElement Description { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_Subject']")]
        public IWebElement SubjectLine { get; set; }

        [FindsBy(How = How.XPath, Using = ".//textarea[@id='ctl00_MainContent_Body']")]
        public IWebElement BodyText { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@class='uploadAttachment']")]
        public IWebElement UploadAttachmentButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@id='ctl00_MainContent_Btn_Create']")]
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