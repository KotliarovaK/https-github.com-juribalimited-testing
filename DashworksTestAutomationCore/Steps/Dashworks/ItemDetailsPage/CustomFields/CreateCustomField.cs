using System.Linq;
using System.Threading;
using DashworksTestAutomation.DTO.ItemDetails;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomationCore.Pages.Evergreen.Base.BaseDialog;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage.CustomFields
{
    [Binding]
    class CreateCustomField : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly DTO.RuntimeVariables.ItemDetails.CustomFields _customFields;

        public CreateCustomField(RemoteWebDriver driver, DTO.RuntimeVariables.ItemDetails.CustomFields customFields)
        {
            _driver = driver;
            _customFields = customFields;
        }

        //| List | ObjectId | FieldName | Value | FieldIndex |
        [When(@"User creates Custom Field")]
        public void WhenUserCreatesCustomFieldViaAPI(Table table)
        {
            var customFields = table.CreateSet<CustomFieldDto>().ToList();
            _customFields.Value.AddRange(customFields);

            foreach (CustomFieldDto customField in customFields)
            {
                var page = _driver.NowAt<BaseDashboardPage>();

                page.ClickButton("ADD CUSTOM FIELD");
                page.AutocompleteSelect("Custom Field", customField.FieldName, string.Empty, true);
                page.PopulateTextbox("Value", customField.Value);

                var dialogContainer = _driver.NowAt<BaseDialogDashboardPage>();
                dialogContainer.GetButton("ADD").Click();
                //Sleep to wait for counter to be updated by JS
                Thread.Sleep(1500);
                _driver.WaitForDataLoading();
            }
        }
    }
}
