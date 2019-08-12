using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Automations;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Automations
{
    [Binding]
    internal class AutomationsGrid : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public AutomationsGrid(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User selects ""(.*)"" checkbox on the Automation Page")]
        public void WhenUserSelectsCheckboxOnTheAutomationPage(string checkboxName)
        {
            var checkbox = _driver.NowAt<CreateAutomationsPage>();
            checkbox.SelectCheckboxByName(checkboxName).Click();
        }

        [Then(@"""(.*)"" text is displayed in ""(.*)"" field")]
        public void ThenTextIsDisplayedInField(string text, string fieldName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            Utils.Verify.IsTrue(page.GetFieldByFieldName(fieldName).GetAttribute("value").Contains(text),
                $"Text in {fieldName} field is different");
        }

        [Then(@"""(.*)"" value is displayed in the ""(.*)"" dropdown for Automation")]
        public void ThenValueIsDisplayedInTheDropdownForAutomation(string value, string dropdownName)
        {
            var dropdown = _driver.NowAt<BaseGridPage>();
            var dropdownValue = dropdown.GetDropdownByNameForAutomations(dropdownName).GetAttribute("value");
            Utils.Verify.AreEqual(dropdownValue, value, $"{value} is not displayed in the {dropdownName}");
        }
    }
}
