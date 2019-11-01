using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.Base;
using DashworksTestAutomation.DTO.Evergreen.Admin.Readiness;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Forms;
using DashworksTestAutomation.Pages.Evergreen.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks.AdminPage.Project.Readiness
{
    [Binding]
    internal class ReadinessSteps : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly DTO.RuntimeVariables.Readiness.Readiness _readiness;
        private readonly ReadinessDto readinessDto = new ReadinessDto();

        public ReadinessSteps(RemoteWebDriver driver, DTO.RuntimeVariables.Readiness.Readiness readiness)
        {
            _driver = driver;
            _readiness = readiness;
        }

        [When(@"User updates readiness properties on Edit Readiness")]
        public void WhenUserUpdatesReadinessPropertiesOnEditReadiness(Table table)
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();
            var bpage = _driver.NowAt<BaseDashboardPage>();
            foreach (var row in table.Rows)
            {
                if (!string.IsNullOrEmpty(row["Readiness"]))
                {
                    bpage.PopulateTextbox("Readiness", row["Readiness"]);
                    _readiness.Value.Add(new ReadinessDto() { ReadinessName = row["Readiness"], ProjectId = Int32.Parse(DatabaseHelper.GetProjectId(row["ProjectName"])) });
                }

                if (!string.IsNullOrEmpty(row["Tooltip"]))
                {
                    bpage.PopulateTextbox("Tooltip", row["Tooltip"]);
                }

                if (!string.IsNullOrEmpty(row["Ready"]))
                {
                    bpage.GetCheckbox("Ready").SetCheckboxState(bool.Parse(row["Ready"].ToLower()));
                }

                if (!string.IsNullOrEmpty(row["DefaultForApplications"]))
                {
                    bpage.GetCheckbox("Default").SetCheckboxState(bool.Parse(row["DefaultForApplications"].ToLower()));
                }

                if (!string.IsNullOrEmpty(row["ColourTemplate"]))
                {
                    createReadiness.ColourDropbox.Click();
                    createReadiness.SelectObjectForReadinessCreation(row["ColourTemplate"]);
                }
            }
        }

        [When(@"User clicks Default for Applications checkbox on Edit Readiness")]
        public void WhenUserClicksDefaultForApplicationsCheckboxOnEditReadiness()
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();
            createReadiness.DefaultForAppCheckBox.Click();
        }

        [When(@"User clicks Colour Template field on Edit Readiness")]
        public void WhenClicksColourTemplateFieldOnEditReadiness()
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();
            createReadiness.ColourDropbox.Click();
        }

        [Then(@"User sees following options for Colour Template selector on Create Readiness page:")]
        public void WhenUserSeesFollowingOptionsForColourTemplateSelectorOnCreateReadinessPage(Table items)
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            Utils.Verify.AreEqual(items.Rows.SelectMany(row => row.Values).ToList(),
                createReadiness.ColourPicker.Select(x => x.Text).ToList(), "Incorrect options in lists dropdown");
        }

        [Then(@"List of available colours displayed to user on Edit Readiness")]
        public void ThenListOfAvailableColoursDisplayedToUserOnEditReadiness()
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            Utils.Verify.That(createReadiness.GetColourStatusNumber(), Is.GreaterThan(0));
            Utils.Verify.That(createReadiness.GetColourStatusTextNumber(), Is.GreaterThan(0));
            Utils.Verify.That(createReadiness.GetColourStatusTextNumber(), Is.EqualTo(createReadiness.GetColourStatusTextNumber()));
        }

        [Then(@"List of available colours is not displayed to user on Edit Readiness")]
        public void ThenListOfAvailableColoursIsNotDisplayedToUserOnEditReadiness()
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            Utils.Verify.That(createReadiness.GetColourStatusTextNumber(), Is.EqualTo(0));
        }

        [When(@"User remembers opened Readiness data on Edit Readiness")]
        public void WhenUserRemembersReadinessDataOnEditReadiness()
        {
            var bpage = _driver.NowAt<BaseDashboardPage>();
            readinessDto.ReadinessName = bpage.GetTextbox("Readiness").GetAttribute("value");
            readinessDto.Tooltip = bpage.GetTextbox("Tooltip").GetAttribute("value");
            readinessDto.Ready = bpage.GetCheckbox("Ready").Selected();
            readinessDto.DefaultForApplications = bpage.GetCheckbox("Default").Selected();
        }

        [When(@"User enters stored readiness name in Search field for ""(.*)"" column")]
        public void WhenUserEntersStoredReadinessNameInTheSearchFieldForColumn(string columnName)
        {
            var searchElement = _driver.NowAt<BaseGridPage>();
            searchElement.PopulateSearchFieldByColumnName(columnName, readinessDto.ReadinessName);
        }

        [Then(@"User checks that opened readiness name is the same as stored one")]
        public void ThenUserChecksThatOpenedReadinessNameIsTheSameAsStoredOne()
        {
            var page = _driver.NowAt<BaseDashboardPage>();

            Utils.Verify.That(readinessDto.ReadinessName, Is.EqualTo(page.GetTextbox("Readiness").GetAttribute("value")), "Name is different from stored one");
        }

        [Then(@"Filtered readiness item equals to stored one")]
        public void ThenFilteredReadinessItemEqualsToStoredOne()
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();

            var tooltip = page.GetColumnContentByColumnName("Tooltip").First();
            var defaultFor = page.GetColumnContentByColumnName("Default for Applications").First();

            Utils.Verify.That(readinessDto.Tooltip, Is.EqualTo(tooltip), "Tooltip is different from stored one");
            Utils.Verify.That(readinessDto.DefaultForApplications.ToString(), Is.EqualTo(defaultFor).IgnoreCase, "Default For state different from stored one");
        }

        [Then(@"Readiness ""(.*)"" displayed before None")]
        public void ThenReadinessDisplayedBeforeNone(string title)
        {
            var readiness = _driver.NowAt<ReadinessPage>();
            List<string> labels = readiness.GetListOfReadinessLabel();

            Utils.Verify.That(labels.FindIndex(x => x.Equals(title)) + 1, Is.EqualTo(labels.FindIndex(x => x.Equals("NONE"))));
        }

        [When(@"User clicks ""(.*)"" button in the Readiness dialog screen")]
        public void WhenUserClicksButtonInTheReadinessDialogScreen(string buttonName)
        {
            var button = _driver.NowAt<ReadinessPage>();
            button.GetReadinessDialogContainerButtonByName(buttonName).Click();
        }

        [Then(@"""(.*)"" text is displayed in the Readiness Dialog Container")]
        public void ThenTextIsDisplayedInTheReadinessDialogContainer(string text)
        {
            var page = _driver.NowAt<ReadinessPage>();

            Utils.Verify.IsTrue(page.GetReadinessDialogContainerText(text).Displayed(), $"{text} title is not displayed in the Readiness Dialog Container");
        }

        [Then(@"""(.*)"" title is displayed in the Readiness Dialog Container")]
        public void ThenTitleIsDisplayedInTheReadinessDialogContainer(string text)
        {
            var page = _driver.NowAt<ReadinessPage>();

            Utils.Verify.IsTrue(page.GetReadinessDialogContainerTitle(text).Displayed(), $"{text} title is not displayed in the Readiness Dialog Container");
        }

        [Then(@"Readiness Dialog Container is displayed to the User")]
        public void ThenReadinessDialogContainerIsDisplayedToTheUser()
        {
            var page = _driver.NowAt<ReadinessPage>();

            Utils.Verify.IsTrue(page.ReadinessDialogContainer.Displayed(), "Readiness Dialog Container is displayed");
        }
    }
}