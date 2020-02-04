using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.DTO.ManagementConsole;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Senior.CustomeFields.CreateCustomFields
{
    class CreateCustomFieldMethods
    {
        private readonly RestWebClient _client;
        private readonly SeniorCustomFields _customFields;

        public CreateCustomFieldMethods(RestWebClient client, SeniorCustomFields customFields)
        {
            _client = client;
            _customFields = customFields;
        }

        public void Create(List<SeniorCustomFieldDto> customFields)
        {
            _customFields.Value.AddRange(customFields);

            foreach (SeniorCustomFieldDto customField in customFields)
            {
                var requestUri = $"{UrlProvider.Url}Manage/CustomFieldAdd.aspx";
                var request = _client.Senior.GenerateSeniorRequest(requestUri);
                request.AddParameter("ctl00$MainContent$TB_FieldName", customField.FieldName);
                request.AddParameter("ctl00$MainContent$TB_Label", customField.FieldLabel);
                if (customField.AllowExternalUpdate)
                    request.AddParameter("ctl00$MainContent$CB_ExternalUpdate", "on");
                if (customField.Enabled)
                    request.AddParameter("ctl00$MainContent$CB_Enabled", "on");
                if (customField.User)
                    request.AddParameter("ctl00$MainContent$CB_User", "on");
                if (customField.Computer)
                    request.AddParameter("ctl00$MainContent$CB_Computer", "on");
                if (customField.Application)
                    request.AddParameter("ctl00$MainContent$CB_Application", "on");
                if (customField.Mailbox)
                    request.AddParameter("ctl00$MainContent$CB_Mailbox", "on");
                request.AddParameter("ctl00$MainContent$Btn_Create", "Create Field");
                request.AddParameter("ctl00$DwFooter1$HF_PageLanguageId", 0);

                var response = _client.Senior.Post(request);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception($"Unable to create Custom Field via API");
                }
            }
        }
    }
}
