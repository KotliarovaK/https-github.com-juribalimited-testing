using System;
using System.Collections.Generic;
using System.Linq;
using DashworksTestAutomation.DTO.Evergreen.Admin.Readiness;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Forms;
using DashworksTestAutomation.Pages.Evergreen.Base;
using NUnit.Framework;
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

            foreach (var row in table.Rows)
            {
                if (!string.IsNullOrEmpty(row["Readiness"]))
                {
                    createReadiness.ReadinessField.Clear();
                    createReadiness.ReadinessField.SendKeys(row["Readiness"]);
                    _readiness.Value.Add(new ReadinessDto() { ReadinessName = row["Readiness"], ProjectId = Int32.Parse(DatabaseHelper.GetProjectId(row["ProjectName"])) });
                }

                if (!string.IsNullOrEmpty(row["Tooltip"]))
                {
                    createReadiness.TooltipField.Clear();
                    createReadiness.TooltipField.SendKeys(row["Tooltip"]);
                }

                if (!string.IsNullOrEmpty(row["Ready"]))
                {
                    if (row["Ready"].ToLower().Equals("true"))
                    {
                        if (!createReadiness.ReadyCheckboxState.Selected)
                            createReadiness.ReadyCheckbox.Click();
                    }
                    if (row["Ready"].ToLower().Equals("false"))
                    {
                        if (createReadiness.ReadyCheckboxState.Selected)
                            createReadiness.ReadyCheckbox.Click();
                    }
                }

                if (!string.IsNullOrEmpty(row["DefaultForApplications"]))
                {
                    if (row["DefaultForApplications"].ToLower().Equals("true"))
                    {
                        if (!createReadiness.DefaultCheckBoxState.Selected)
                            createReadiness.DefaultForAppCheckBox.Click();
                    }
                    if (row["DefaultForApplications"].ToLower().Equals("false"))
                    {
                        if (createReadiness.DefaultCheckBoxState.Selected)
                            createReadiness.DefaultForAppCheckBox.Click();
                    }
                }

                if (!string.IsNullOrEmpty(row["ColourTemplate"]))
                {
                    createReadiness.ColourDropbox.Click();
                    createReadiness.SelectObjectForReadinessCreation(row["ColourTemplate"]);
                }
            }
        }

        [When(@"User enters ""(.*)"" in Readiness input on Edit Readiness")]
        public void WhenUserEntersInReadinessInputOnEditReadiness(string text)
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            if (!string.IsNullOrEmpty(text))
            {
                createReadiness.ReadinessField.Clear();
                createReadiness.ReadinessField.SendKeys(text);
            }
        }

        [Then(@"User sees ""(.*)"" in Readiness input on Edit Readiness")]
        public void ThenUserSeesInReadinessInputOnEditReadiness(string text)
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            Utils.Verify.That(createReadiness.ReadinessField.GetAttribute("value"), Is.EqualTo(text));
        }

        [Then(@"Readiness input displayed disabled on Edit Readiness")]
        public void ThenReadinessInputDisplayedDisabledOnEditReadiness()
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            Utils.Verify.That(createReadiness.ReadinessField.Enabled,
                Is.EqualTo(false), "Readiness input is in different state");
        }

        [When(@"User enters ""(.*)"" in Tooltip input on Edit Readiness")]
        public void WhenUserEntersInTooltipInputOnEditReadiness(string text)
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            if (!string.IsNullOrEmpty(text))
            {
                createReadiness.TooltipField.Clear();
                createReadiness.TooltipField.SendKeys(text);
            }
        }

        [Then(@"User sees ""(.*)"" in Tooltip input on Edit Readiness")]
        public void ThenUserSeesInTooltipInputOnEditReadiness(string text)
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            Utils.Verify.That(createReadiness.TooltipField.GetAttribute("value"), Is.EqualTo(text));
        }

        [Then(@"User sees Tooltip field not equal to ""(.*)"" on Edit Readiness")]
        public void ThenUserSeesTooltipFieldNotEqualToOnEditReadiness(string text)
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            Utils.Verify.That(createReadiness.TooltipField.GetAttribute("value"), Is.Not.EqualTo(text));
        }

        [When(@"User sets Ready checkbox in ""(.*)"" on Edit Readiness")]
        public void WhenUserSetsReadyCheckboxInOnEditReadiness(string state)
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            if (state.ToLower().Equals("true"))
            {
                if (!createReadiness.ReadyCheckboxState.Selected)
                    createReadiness.ReadyCheckbox.Click();
            }
            if (state.ToLower().Equals("false"))
            {
                if (createReadiness.ReadyCheckboxState.Selected)
                    createReadiness.ReadyCheckbox.Click();
            }
        }

        [Then(@"User sees Ready checkbox in ""(.*)"" state on Edit Readiness")]
        public void ThenUserSeesReadyCheckboxInStateOnEditReadiness(string state)
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            Utils.Verify.That(createReadiness.ReadyCheckboxState.Selected.ToString().ToLower(),
                Is.EqualTo(state.ToLower()), "Readiness ready state is different");
        }

        [When(@"User sets Default for Applications checkbox in ""(.*)"" on Edit Readiness")]
        public void WhenUserSetsDefaultForApplicationsCheckboxInOnEditReadiness(string state)
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            if (state.ToLower().Equals("true"))
            {
                if (!createReadiness.DefaultCheckBoxState.Selected)
                    createReadiness.DefaultForAppCheckBox.Click();
            }
            if (state.ToLower().Equals("false"))
            {
                if (createReadiness.DefaultCheckBoxState.Selected)
                    createReadiness.DefaultForAppCheckBox.Click();
            }
        }

        [When(@"User clicks Default for Applications checkbox on Edit Readiness")]
        public void WhenUserClicksDefaultForApplicationsCheckboxOnEditReadiness()
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();
            createReadiness.DefaultForAppCheckBox.Click();
        }

        [Then(@"User sees Default for Applications checkbox in ""(.*)"" state on Edit Readiness")]
        public void ThenUserSeesDefaultForApplicationsCheckboxInStateOnEditReadiness(string state)
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            Utils.Verify.That(createReadiness.DefaultCheckBoxState.Selected.ToString().ToLower(),
                Is.EqualTo(state.ToLower()), "Readiness default state is different");
        }

        [Then(@"User sees Default for Applications checkbox disabled on Edit Readiness")]
        public void ThenUserSeesDefaultForApplicationsCheckboxDisabledOnEditReadiness()
        {
            var createReadiness = _driver.NowAt<CreateReadinessPage>();

            Utils.Verify.That(createReadiness.DefaultCheckBoxState.Enabled, Is.EqualTo(false), "Readiness default state is enabled");
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
            var page = _driver.NowAt<CreateReadinessPage>();
            readinessDto.ReadinessName = page.ReadinessField.GetAttribute("value");
            readinessDto.Tooltip = page.TooltipField.GetAttribute("value");
            readinessDto.Ready = page.ReadyCheckboxState.Selected;
            readinessDto.DefaultForApplications = page.DefaultCheckBoxState.Selected;
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
            var page = _driver.NowAt<CreateReadinessPage>();

            Utils.Verify.That(readinessDto.ReadinessName, Is.EqualTo(page.ReadinessField.GetAttribute("value")), "Name is different from stored one");
        }

        [Then(@"Filtered readiness item equals to stored one")]
        public void ThenFilteredReadinessItemEqualsToStoredOne()
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();

            var tooltip = page.GetRowContentByColumnName("Tooltip");
            var defaultFor = page.GetRowContentByColumnName("Default for Applications");

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