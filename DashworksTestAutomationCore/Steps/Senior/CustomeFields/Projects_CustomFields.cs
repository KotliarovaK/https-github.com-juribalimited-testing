using System;
using System.Linq;
using System.Net;
using AutomationUtils.Extensions;
using DashworksTestAutomation.DTO;
using DashworksTestAutomation.DTO.ManagementConsole;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.ManagementConsole.CustomFields;
using DashworksTestAutomation.Providers;
using OpenQA.Selenium.Remote;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Senior.Senior_CreatingProject.CustomFields
{
    [Binding]
    public class Projects_CustomFields : SpecFlowContext
    {
        private readonly SeniorCustomFields _customFields;
        private readonly RemoteWebDriver _driver;

        public Projects_CustomFields(SeniorCustomFields customFields, RemoteWebDriver driver)
        {
            _customFields = customFields;
            _driver = driver;
        }

        [When(@"User creates new Custom Field")]
        public void WhenUserCreatesNewCustomField(Table table)
        {
            var customFields = table.CreateSet<SeniorCustomFieldDto>().ToList();
            _customFields.Value.AddRange(customFields);

            foreach (SeniorCustomFieldDto customField in customFields)
            {
                var managePage = _driver.NowAt<ManageCustomFieldsPage>();
                managePage.CreateNewCustomField.Click();

                var page = _driver.NowAt<CustomFieldsPage>();

                page.FieldNameTextbox.SendKeys(customField.FieldName); 
                page.FieldLabelTextbox.SendKeys(customField.FieldLabel);

                page.AllowExternalUpdateCheckbox.SetCheckboxState(customField.AllowExternalUpdate);
                page.EnabledCheckbox.SetCheckboxState(customField.Enabled);

                page.UserCheckbox.SetCheckboxState(customField.User);
                page.ComputerCheckbox.SetCheckboxState(customField.Computer);
                page.ApplicationCheckbox.SetCheckboxState(customField.Application);
                page.MailboxCheckbox.SetCheckboxState(customField.Mailbox);

                page.CreateButton.Click();
            }
        }

        [When(@"User removes Custom Field with '(.*)' label")]
        public void WhenUserRemovesCustomFieldWithLabel(string cfLabel)
        {
            DatabaseHelper.DeleteCustomField(new SeniorCustomFieldDto() { FieldLabel = cfLabel }.Id);
        }
    }
}
