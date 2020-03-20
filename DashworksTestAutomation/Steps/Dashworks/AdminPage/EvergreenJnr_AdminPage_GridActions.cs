using System.IO;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Utils;
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
            var tableElement = _driver.NowAtWithoutWait<BaseGridPage>();
            _driver.WaitForDataLoading();
            tableElement.ClickContentByColumnName(columnName);
            _driver.WaitForDataLoading();
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