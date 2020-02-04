using System;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO.ManagementConsole;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Providers;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Senior.CustomeFields.CreateCustomFields
{
    [Binding]
    class Projects_CreateCustomFieldsViaApi : SpecFlowContext
    {
        private readonly CreateCustomFieldMethods _createCustomFieldMethods;

        public Projects_CreateCustomFieldsViaApi(RestWebClient client, SeniorCustomFields customFields)
        {
            _createCustomFieldMethods = new CreateCustomFieldMethods(client, customFields);
        }

        [When(@"User creates new Custom Field via API")]
        public void WhenUserCreatesNewCustomFieldViaApi(Table table)
        {
            var customFields = table.CreateSet<SeniorCustomFieldDto>().ToList();
            _createCustomFieldMethods.Create(customFields);
        }
    }
}
