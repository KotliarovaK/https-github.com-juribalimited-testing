using System.Linq;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage
{
    [Binding]
    internal class EvergreenJnr_AdminPage_GridActions : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_AdminPage_GridActions (RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User click on ""(.*)"" column header on the Admin page")]
        public void WhenUserClickOnColumnHeaderOnTheAdminPage(string columnName)
        {
            var adminTable = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            adminTable.GetColumnHeaderByName(columnName).Click();
        }

        [When(@"User clicks content from ""(.*)"" column")]
        public void WhenUserClicksContentFromColumn(string columnName)
        {
            //var tableElement = _driver.NowAtWithoutWait<BaseGridPage>();
            //tableElement.ClickContentByColumnName(columnName);
            //_driver.WaitForDataLoading(); //TODO: remove if below code works for all lists

            var tableElement = _driver.NowAtWithoutWait<BaseDashboardPage>();
            _driver.WaitForDataLoading();
            tableElement.ClickContentByColumnName(columnName);
            _driver.WaitForDataLoading();
        }

        [Then(@"Cancel button in the pop up is colored gray")]
        public void ThenCancelButtonInThePopUpIsColoredGray()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var getColor = page.CancelButtonInPopUp.GetCssValue("background-color");
            Assert.AreEqual("rgba(236, 237, 239, 1)", getColor, "Cancel button is colored incorrect");
        }

        [Then(@"Delete button in the pop up is colored amber")]
        public void ThenDeleteButtonInThePopUpIsColoredAmber()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var getColor = page.DeleteButtonInPopUp.GetCssValue("background-color");
            Assert.AreEqual("rgba(242, 88, 49, 1)", getColor, "Delete button is colored incorrect");
        }

    }
}
