using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DashworksTestAutomation.Pages.ManagementConsole.CustomFields
{
    //Page on senior
    class CustomFieldsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//input[contains(@id,'FieldName')]")]
        public IWebElement FieldNameTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id,'Label')]")]
        public IWebElement FieldLabelTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id,'ExternalUpdate')]")]
        public IWebElement AllowExternalUpdateCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id,'Enabled')]")]
        public IWebElement EnabledCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id,'User')]")]
        public IWebElement UserCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id,'Computer')]")]
        public IWebElement ComputerCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id,'Application')]")]
        public IWebElement ApplicationCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id,'Mailbox')]")]
        public IWebElement MailboxCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id,'Create')]")]
        public IWebElement CreateButton { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.CreateButton),
                SelectorFor(this, p => p.FieldNameTextbox)
            };
        }
    }
}
