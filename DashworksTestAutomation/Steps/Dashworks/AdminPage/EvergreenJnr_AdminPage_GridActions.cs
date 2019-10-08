using System.IO;
using System.Linq;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage
{
    [Binding]
    internal class EvergreenJnr_AdminPage_GridActions : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly DownloadedFileName _downloadedFileName;

        public EvergreenJnr_AdminPage_GridActions (RemoteWebDriver driver, DownloadedFileName downloadedFileName)
        {
            _driver = driver;
            _downloadedFileName = downloadedFileName;
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
            Utils.Verify.AreEqual("rgba(236, 237, 239, 1)", getColor, "Cancel button is colored incorrect");
        }

        [Then(@"Delete button in the pop up is colored amber")]
        public void ThenDeleteButtonInThePopUpIsColoredAmber()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            var getColor = page.DeleteButtonInPopUp.GetCssValue("background-color");
            Utils.Verify.AreEqual("rgba(242, 88, 49, 1)", getColor, "Delete button is colored incorrect");
        }

        [Then(@"User checks that file ""(.*)"" was downloaded")]
        public void ThenUserChecksThatFileWasDownloaded(string fileName)
        {
            _driver.WaitForDataLoading();
            FileSystemHelper.WaitForFileWithNameContainingToBeDownloaded(fileName);
            _downloadedFileName.Value.Add(fileName);
        }

        [Then(@"User verifies ""(.*)"" column content in the ""(.*)"" downloaded file")]
        public void ThenUserVerifiesColumnContentInTheDownloadedFile(string columnName, string fileName, Table table)
        {
            var filePath = FileSystemHelper.WaitForFileWithNameContainingToBeDownloaded(fileName);
            var content = File.ReadAllText(filePath);
            var actualTable = content.CsvToTable().GetDataByKey($"{columnName}");
            var expectedTable = table.GetDataByKey("ColumnContent");
            Verify.AreEqual(actualTable, expectedTable, "PLEASE ADD EXCEPTION MESSAGE");
        }
    }
}