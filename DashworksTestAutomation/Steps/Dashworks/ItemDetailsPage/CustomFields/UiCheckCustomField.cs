using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails.CustomFields;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage.CustomFields
{
    [Binding]
    class UiCheckCustomField : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public UiCheckCustomField(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Add button is displayed on Add Custom Field popup")]
        public void ThenAddButtonIsDisplayedOnAddCustomFieldPopup()
        {
            var popup = _driver.NowAt<CustomFieldPopup>();

            Verify.IsTrue(popup.AddCustomFieldButton.Disabled(), "Add Custom Field button is not disabled");

            _driver.MouseHover(popup.AddCustomFieldButton);

            Verify.AreEqual(_driver.GetTooltipText(), "Some values are missing or invalid", "Incorrect tooltip for Add Custom Field button");
        }

        [Then(@"Cancel button is enabled on Add Custom Field popup")]
        public void ThenCancelButtonIsEnabledOnAddCustomFieldPopup()
        {
            var popup = _driver.NowAt<CustomFieldPopup>();

            Verify.IsTrue(popup.CancelCustomFieldButton.Disabled(), "Cancel Custom Field button is not disabled");
        }
    }
}
