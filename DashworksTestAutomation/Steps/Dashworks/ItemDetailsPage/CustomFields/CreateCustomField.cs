using System;
using System.Linq;
using System.Net;
using System.Threading;
using DashworksTestAutomation.DTO.ItemDetails;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails.CustomFields;
using DashworksTestAutomation.Providers;
using DashworksTestAutomation.Utils;
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
                var grid = _driver.NowAt<AggridHeaderCounterElement>();

                _driver.WaitForElementToBeDisplayed(grid.CreateCustomFieldsButton);

                //Check that button has correct name
                Verify.IsTrue(grid.CreateCustomFieldsButton.Text.Contains("ADD CUSTOM FIELD"), "Incorrect text is displayed for 'ADD CUSTOM FIELD' button");

                grid.CreateCustomFieldsButton.Click();

                var popup = _driver.NowAt<CustomFieldPopup>();

                var page = _driver.NowAt<BaseDashboardPage>();
                page.AutocompleteSelect(CustomFieldPopup.TextBoxes.CustomField.GetValue(), customField.FieldName, true);

                page.PopulateTextbox(CustomFieldPopup.TextBoxes.Value.GetValue(), customField.Value);

                popup.AddCustomFieldButton.Click();
                _driver.WaitForElementToBeNotDisplayed(popup.AddCustomFieldButton);
                //Sleep to wait for counter to be updated by JS
                Thread.Sleep(2000);
                _driver.WaitForDataLoading();
            }
        }

        [When(@"User clicks Cancel button on Add Custom Field popup")]
        public void WhenUserClicksCancelButtonOnAddCustomFieldPopup()
        {
            var popup = _driver.NowAt<CustomFieldPopup>();

            popup.CancelCustomFieldButton.Click();
            _driver.WaitForElementToBeNotDisplayed(popup.CancelCustomFieldButton);
        }

        [When(@"User clicks Add button on Add Custom Field popup")]
        public void WhenUserClicksAddButtonOnAddCustomFieldPopup()
        {
            var popup = _driver.NowAt<CustomFieldPopup>();

            popup.AddCustomFieldButton.Click();
            _driver.WaitForElementToBeNotDisplayed(popup.AddCustomFieldButton);
        }
    }
}
