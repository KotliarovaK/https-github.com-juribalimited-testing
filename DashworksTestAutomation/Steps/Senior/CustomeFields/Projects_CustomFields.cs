using System;
using System.Linq;
using System.Net;
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
        private readonly RestWebClient _client;
        protected readonly AuthObject _authObject;

        public Projects_CustomFields(SeniorCustomFields customFields, RemoteWebDriver driver, RestWebClient client, AuthObject authObject)
        {
            _customFields = customFields;
            _driver = driver;
            _client = client;
            _authObject = authObject;
        }

        [When(@"User creates new Custom Field")]
        public void WhenUserCreatesNewCustomField(Table table)
        {
            var customFields = table.CreateSet<SeniorCustomFieldDto>().ToList();
            _customFields.Value.AddRange(customFields);
            RestClient Value = new RestClient();
            var requestUri = "http://autorelease.corp.juriba.com/Manage/CustomFieldAdd.aspx";

            foreach (SeniorCustomFieldDto customField in customFields)
            {
                var request = new RestRequest(requestUri);
                request.AddHeader("Host", "autorelease.corp.juriba.com");
                request.AddHeader("Referer", "http://autorelease.corp.juriba.com/Manage/CustomFieldAdd.aspx");
                request.AddParameter("__EVENTTARGET", null);
                request.AddParameter("__EVENTARGUMENT", null);
                request.AddParameter("__VIEWSTATE", _authObject.Viewstate);
                request.AddParameter("__VIEWSTATEGENERATOR", _authObject.ViewstateGenerator);
                request.AddParameter("__EVENTVALIDATION", _authObject.Eventvalidation);
                request.AddParameter("ctl00$MainContent$TB_FieldName", customField.FieldName);
                request.AddParameter("ctl00$MainContent$TB_Label", customField.FieldLabel);
                request.AddParameter("ctl00$MainContent$CB_ExternalUpdate", "on");
                request.AddParameter("ctl00$MainContent$CB_Enabled", "on");
                request.AddParameter("ctl00$MainContent$CB_User", "on");
                request.AddParameter("ctl00$MainContent$CB_Computer", "on");
                request.AddParameter("ctl00$MainContent$Btn_Create", "Create Field");
                request.AddParameter("ctl00$DwFooter1$HF_PageLanguageId", 0);

                var response = _client.SinValue.Post(request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception($"Unable to create user via API");
                }

                //var managePage = _driver.NowAt<ManageCustomFieldsPage>();
                //managePage.CreateNewCustomField.Click();

                //var page = _driver.NowAt<CustomFieldsPage>();

                //page.FieldNameTextbox.SendKeys(customField.FieldName);
                //page.FieldLabelTextbox.SendKeys(customField.FieldLabel);

                //page.AllowExternalUpdateCheckbox.SetCheckboxState(customField.AllowExternalUpdate);
                //page.EnabledCheckbox.SetCheckboxState(customField.Enabled);

                //page.UserCheckbox.SetCheckboxState(customField.User);
                //page.ComputerCheckbox.SetCheckboxState(customField.Computer);
                //page.ApplicationCheckbox.SetCheckboxState(customField.Application);
                //page.MailboxCheckbox.SetCheckboxState(customField.Mailbox);

                //page.CreateButton.Click();
            }
        }

        [When(@"User removes Custom Field with '(.*)' label")]
        public void WhenUserRemovesCustomFieldWithLabel(string cfLabel)
        {
            DatabaseHelper.DeleteCustomField(new SeniorCustomFieldDto() { FieldLabel = cfLabel }.Id);
        }
    }
}
