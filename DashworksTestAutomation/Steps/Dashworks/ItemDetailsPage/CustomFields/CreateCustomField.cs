using System;
using System.Linq;
using System.Net;
using DashworksTestAutomation.DTO.ItemDetails;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails.CustomFields;
using DashworksTestAutomation.Providers;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage.CustomFields
{
    [Binding]
    class CreateCustomField : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly DTO.RuntimeVariables.CustomFields _customFields;

        public CreateCustomField(RemoteWebDriver driver, DTO.RuntimeVariables.CustomFields customFields)
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
                var grid = _driver.NowAt<AggridHeaderCounterPage>();

                _driver.WaitForElementToBeDisplayed(grid.CreateCustomFieldsButton);
                grid.CreateCustomFieldsButton.Click();

                var popup = _driver.NowAt<CustomFieldPopup>();

                var action = _driver.NowAt<BaseDashboardPage>();
                var dropdown = _driver.NowAt<BaseGridPage>();
                dropdown.GetDropdownByName(CustomFieldPopup.TextBoxes.CustomFields.GetValue()).Click();
                action.GetOptionByName(customField.FieldName).Click();

                var projectElement = _driver.NowAt<ProjectsPage>();
                projectElement.SendKeysToTheNamedTextbox(customField.Value, CustomFieldPopup.TextBoxes.Value.GetValue());

                popup.AddCustomFieldButton.Click();
                _driver.WaitForElementToBeNotDisplayed(popup.AddCustomFieldButton);
                _driver.WaitForDataLoading();
            }
        }
    }
}
