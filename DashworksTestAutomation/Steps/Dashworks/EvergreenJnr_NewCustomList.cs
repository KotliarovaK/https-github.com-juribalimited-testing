using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    class EvergreenJnr_NewCustomList : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_NewCustomList(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"Save to New Custom List element should NOT be displayed")]
        public void ThenSaveToNewCustomListElementShouldNOTBeDisplayed()
        {
            var page = _driver.NowAt<BaseDashbordPage>();

            Assert.IsFalse(page.SaveCustomListButton.Displayed(),
                "Save Custom list is displayed when the user just performs an agGrid search");

            Logger.Write("The Save to Custom List Element was NOT displayed");
        }

        [When(@"User create custom list with ""(.*)"" name")]
        public void WhenUserCreateCustomListWithName(string listName)
        {
            var listElement = _driver.NowAt<CustomListElemnt>();

            _driver.WaitWhileControlIsNotDisplayed<CustomListElemnt>(() => listElement.CreateNewListButton);
            listElement.CreateNewListButton.Click();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElemnt>(() => listElement.SaveButton);
            listElement.ListNameTextbox.SendKeys(listName);
            listElement.SaveButton.Click();
        }

        [Then(@"""(.*)"" is displayed to user")]
        public void ThenIsDisplayedToUser(string listName)
        {
            var page = _driver.NowAt<BaseDashbordPage>();

            Assert.AreEqual(listName, page.ActiveCustomListName());
        }

        [When(@"User is removed custom list with ""(.*)"" name")]
        public void WhenUserIsRemovedCustomListWithName(string listName)
        {
            var listElement = _driver.NowAt<CustomListElemnt>();

            _driver.MouseHover(listElement.GetSettingsButtonByListName(listName));
            listElement.GetSettingsButtonByListName(listName).Click();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElemnt>(() => listElement.DeleteButton);
            listElement.DeleteButton.Click();
            _driver.WaitWhileControlIsNotDisplayed<CustomListElemnt>(() => listElement.DeleteConfirmationMessage);
            listElement.ConfirmDeleteButton.Click();
        }
    }
}