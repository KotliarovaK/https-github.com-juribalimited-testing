using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using DashworksTestAutomation.Utils;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.ItemDetailsPage
{
    [Binding]
    class ItemDetailsPageOffboardElements : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public ItemDetailsPageOffboardElements (RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Offboard Pop-up is displayed on the Item Details page")]
        public void ThenOffboardPop_UpIsDisplayedOnTheItemDetailsPage()
        {
            var page = _driver.NowAt<ItemDetailsOffboardElementsPage>();
            Utils.Verify.IsTrue(page.OffboardPopUp.Displayed(), "Offboard Pop-up is not displayed");
        }

        [Then(@"following text '(.*)' is displayed in Offboard Pop-up")]
        public void ThenFollowingTextIsDisplayedInOffboardPop_Up(string text)
        {
            var page = _driver.NowAt<ItemDetailsOffboardElementsPage>();
            var actualText = page.GetPopupText().Replace("\r\n", " ");
            Verify.Contains(text, actualText, $"'{text}' in Offboard Pop-up is not displayed");
        }

        [Then(@"'(.*)' checkbox is checked in Offboard Pop-up")]
        public void ThenCheckboxIsCheckedInOffboardPop_Up(string checkbox)
        {
            var filterElement = _driver.NowAt<ItemDetailsOffboardElementsPage>();
            Verify.IsTrue(filterElement.GetOffboardPopUpCheckbox(checkbox).Selected, $"{checkbox} Checkbox is not checked");
        }
    }
}