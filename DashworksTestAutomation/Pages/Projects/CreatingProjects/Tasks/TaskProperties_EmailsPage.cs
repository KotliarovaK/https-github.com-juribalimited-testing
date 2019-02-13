using System.Collections.Generic;
using DashworksTestAutomation.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DashworksTestAutomation.Pages.Projects.CreatingProjects.Tasks
{
    internal class TaskProperties_EmailsPage : SeleniumBasePage
    {
        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'DaysSelect')]")]
        public IWebElement Days { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'FutureOrPastSelect')]")]
        public IWebElement TaskDue { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'MailTriggerOffsetFlag')]")]
        public IWebElement CountDays { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'MailTemplatesList')]")]
        public IWebElement MailTemplate { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'EmailImportance')]")]
        public IWebElement Importance { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'SendOnlyOnce')]")]
        public IWebElement SendOnceOnly { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'AllRequestTypes')]")]
        public IWebElement RequestTypesAll { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'AllGroups')]")]
        public IWebElement ApplyEmailToAll { get; set; }

        [FindsBy(How = How.XPath, Using = ".//select[contains(@id, 'GroupTypeId')]")]
        public IWebElement GroupType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@id, 'EmailRecipient')]")]
        public IWebElement To { get; set; }

        public override List<By> GetPageIdentitySelectors()
        {
            return new List<By>
            {
                SelectorFor(this, p => p.Days),
                SelectorFor(this, p => p.TaskDue),
                SelectorFor(this, p => p.CountDays),
                SelectorFor(this, p => p.MailTemplate),
                SelectorFor(this, p => p.Importance),
                SelectorFor(this, p => p.SendOnceOnly),
                SelectorFor(this, p => p.RequestTypesAll),
                SelectorFor(this, p => p.ApplyEmailToAll),
                SelectorFor(this, p => p.GroupType),
                SelectorFor(this, p => p.To)
            };
        }
    }
}