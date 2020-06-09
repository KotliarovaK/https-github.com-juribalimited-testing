using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Helpers;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Capacity;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Forms;
using DashworksTestAutomation.Providers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using AutomationUtils.Extensions;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.Projects.Tasks;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages.Automations;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Utils;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_AdminPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly DTO.RuntimeVariables.Projects _projects;
        private readonly LastUsedBucket _lastUsedBucket;
        private readonly Tasks _tasks;
        private readonly ElementCoordinates _elementCoordinates;

        public EvergreenJnr_AdminPage(RemoteWebDriver driver, DTO.RuntimeVariables.Projects projects,
            LastUsedBucket lastUsedBucket, Tasks tasks, ElementCoordinates elementCoordinates)
        {
            _driver = driver;
            _projects = projects;
            _lastUsedBucket = lastUsedBucket;
            _tasks = tasks;
            _elementCoordinates = elementCoordinates;
        }

        //TODO: AnnI 3/25/20 Can we replace with WhenUserChecksFollowingCheckboxesInTheFilterDropdownMenuForTheColumn and delete this step?
        [When(@"User selects ""(.*)"" checkbox from String Filter on the Admin page")]
        public void WhenUserSelectsCheckboxFromStringFilterOnTheAdminPage(string filterName)
        {
            var page = _driver.NowAt<ProjectsPage>();
            page.GetCheckboxStringFilterByName(filterName);
             _driver.ClickByActions(page.BodyContainer);
        }

        [Then(@"'(.*)' text is displayed in the filter dropdown for the '(.*)' column")]
        public void ThenTextIsDisplayedInTheFilterDropdownForTheColumn(string text, string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            Verify.IsTrue(page.GetDropdownFilterTextByColumnName(columnName, text).Displayed(), $"'{text}' text is not displayed in the dropdown filter for the'{columnName}'");
        }

        [Then(@"'(.*)' text is not displayed in the filter dropdown for the '(.*)' column")]
        public void ThenTextIsNotDisplayedInTheFilterDropdownForTheColumn(string text, string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            Verify.IsFalse(page.GetDropdownFilterTextByColumnName(columnName, text).Displayed(), $"'{text}' text is not displayed in the dropdown filter for the'{columnName}'");
        }
     
        [Then(@"User Scope checkboxes are disabled")]
        public void ThenUserScopeCheckboxesAreDisabled()
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            Verify.IsFalse(projectsPage.UserScopeCheckboxes.Displayed(), "User Scope checkboxes are active");
        }

        [Then(@"User Scope checkboxes are active")]
        public void ThenUserScopeCheckboxesAreActive()
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            Verify.IsTrue(projectsPage.UserScopeCheckboxes.Displayed(), "User Scope checkboxes are disabled");
        }

        [Then(@"Application Scope checkboxes are disabled")]
        public void ThenApplicationScopeCheckboxesAreDisabled()
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            Verify.IsTrue(projectsPage.ApplicationScopeCheckboxes.Displayed(),
                "Application Scope checkboxes are active");
        }

        [Then(@"Application Scope checkboxes are active")]
        public void ThenApplicationScopeCheckboxesAreActive()
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            Verify.IsFalse(projectsPage.ApplicationScopeCheckboxes.Displayed(),
                "Application Scope checkboxes are disabled");
        }

        [Then(@"""(.*)"" checkbox is not displayed on the Admin page")]
        public void ThenCheckboxIsNotDisplayedOnTheAdminPage(string checkboxName)
        {
            var filterElement = _driver.NowAt<ProjectsPage>();
            Verify.IsFalse(filterElement.GetCheckboxByName(checkboxName), "PLEASE ADD EXCEPTION MESSAGE");
            Logger.Write($"{checkboxName} checkbox is displayed");
        }

        [Then(@"""(.*)"" checkbox is displayed on the Admin page")]
        public void ThenCheckboxIsDisplayedOnTheAdminPage(string checkboxName)
        {
            var filterElement = _driver.NowAt<ProjectsPage>();
            Verify.IsTrue(filterElement.GetCheckboxByName(checkboxName), $"{checkboxName} checkbox is not displayed");
        }

        [Then(@"Application Scope tab is hidden")]
        public void ThenApplicationScopeTabIsHidden()
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            Verify.IsFalse(projectsPage.ApplicationScopeTab.Displayed(), "Application Scope tab is displayed");
        }

        [Then(@"Application Scope tab is displayed")]
        public void ThenApplicationScopeTabIsDisplayed()
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            Verify.IsTrue(projectsPage.ApplicationScopeTab.Displayed(), "Application Scope tab is not displayed");
        }

        [When(@"User changes Path to ""(.*)""")]
        public void WhenUserChangesPathTo(string pathName)
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            _driver.WaitForElementToBeDisplayed(projectsPage.PathDropdown);
            projectsPage.PathDropdown.Click();
            projectsPage.SelectPathByName(pathName).Click();
        }

        //TODO should be replaced by common method
        [When(@"User changes Category to ""(.*)""")]
        public void WhenUserChangesCategoryTo(string CategoryName)
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            projectsPage.CategoryDropdown.Click();
            projectsPage.SelectCategoryByName(CategoryName).Click();
        }

        [Then(@"""(.*)"" Path is displayed to the user")]
        public void ThenPathIsDisplayedToTheUser(string pathName)
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            Verify.IsTrue(projectsPage.GetPathOrCategory(pathName).Displayed(),
                "Incorrect Path is displayed");
        }

        [Then(@"""(.*)"" Category is displayed to the user")]
        public void ThenCategoryIsDisplayedToTheUser(string categoryName)
        {
            var projectsPage = _driver.NowAt<ProjectsPage>();
            Verify.IsTrue(projectsPage.GetPathOrCategory(categoryName).Displayed(),
                "Incorrect Category is displayed");
        }

        [Then(@"""(.*)"" is displayed to the user in the Project Scope Changes section")]
        public void ThenIsDisplayedToTheUserInTheProjectScopeChangesSection(string text)
        {
            ProjectsPage page;
            try
            {
                page = _driver.NowAt<ProjectsPage>();
            }
            catch (WebDriverTimeoutException)
            {
                page = _driver.NowAt<ProjectsPage>();
            }

            _driver.WaitForDataLoading();
            Verify.IsTrue(page.SelectedItemInProjectScopeChangesSection(text),
                $"{text} is not displayed in the Project Scope Changes section");
        }

        [When(@"User selects ""(.*)"" checkbox on the Project details page")]
        public void WhenUserSelectCheckboxOnTheProjectDetailsPage(string radioButtonName)
        {
            var checkbox = _driver.NowAt<ProjectsPage>();
            checkbox.SelectRadioButtonByName(radioButtonName).Click();
        }

        [Then(@"""(.*)"" checkbox is disabled on the Admin page")]
        public void ThenCheckboxIsDisabledOnTheAdminPage(string checkboxName)
        {
            var checkbox = _driver.NowAt<ProjectsPage>();
            Verify.IsTrue(checkbox.GetdisabledCheckboxByName(checkboxName).Displayed(), $"{checkboxName} is active");
        }

        [Then(@"""(.*)"" checkbox is checked and cannot be unchecked")]
        [Then(@"""(.*)"" associated checkbox is checked and cannot be unchecked")]
        public void ThenAssociatedCheckboxIsCheckedAndCannotBeUnchecked(string radioButtonName)
        {
            var page = _driver.NowAt<ProjectsPage>();
            var checkbox = page.GetAssociatedCheckboxByName(radioButtonName);
            Verify.AreEqual(true, checkbox.Selected, "Checkbox Selected state is incorrect");
            Verify.AreEqual(true, Convert.ToBoolean(checkbox.GetAttribute("disabled")), "Checkbox state is incorrect");
        }

        [Then(@"""(.*)"" associated checkbox is checked")]
        public void ThenAssociatedCheckboxIsChecked(string radioButtonName)
        {
            var checkbox = _driver.NowAt<ProjectsPage>();
            Verify.AreEqual(true, checkbox.GetAssociatedCheckboxByName(radioButtonName).Selected,
                "Checkbox state is incorrect");
        }

        [When(@"User selects ""(.*)"" file to upload on Import Project page")]
        public void WhenUserSelectsFileToUploadOnImportProjectPage(string fileNameAndExtension)
        {
            var page = _driver.NowAt<ImportProjectPage>();
            IAllowsFileDetection allowsDetection = _driver;
            allowsDetection.FileDetector = new LocalFileDetector();

            try
            {
                var file = FileSystemHelper.GeneratePathToEmbeddedResource(fileNameAndExtension,
                    FileSystemHelper.DataFolder.Resources);
                page.ButtonChooseFile.SendKeys(file);
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to locate file in Resources folder: {e}");
            }
        }

        [When(@"User enters ""(.*)"" in the Team Description field")]
        public void WhenUserEntersInTheTeamDescriptionField(string descriptionText)
        {
            var teamName = _driver.NowAt<CreateTeamPage>();
            teamName.TeamDescriptionField.Clear();
            teamName.TeamDescriptionField.SendKeys(descriptionText);
        }

        //TODO remove this. Replace by already created generic method
        [Then(@"""(.*)"" content is displayed in ""(.*)"" field")]
        public void ThenContentIsDisplayedInField(string text, string fieldName)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.IsTrue(page.GetTextbox(fieldName).GetAttribute("value").Contains(text),
                $"Text in {fieldName} field is different");
        }

        [Then(@"Capacity Units value is displayed for Capacity Mode field")]
        public void ThenCapacityUnitsValueIsDisplayedForCapacityModeField()
        {
            var page = _driver.NowAt<BaseGridPage>();
            Verify.IsTrue(page.DefaultCapacityMode.Displayed, "Default value is not displayed for Capacity Mode");
        }

        [When(@"User clicks Default Team checkbox")]
        public void WhenUserClicksDefaultTeamCheckbox()
        {
            var teamElement = _driver.NowAt<TeamsPage>();
            teamElement.DefaultTeamCheckbox.Click();
        }

        [When(@"User changes Percentage to reach before showing amber to ""(.*)""")]
        public void WhenUserChangesPercentageToReachBeforeShowingAmberTo(string value)
        {
            var capacityElement = _driver.NowAt<Capacity_DetailsPage>();
            capacityElement.SetCapacityToReachBeforeShowAmber(value);
        }

        [Then(@"Default Team checkbox is not active")]
        public void ThenDefaultTeamCheckboxIsNotActive()
        {
            var teamElement = _driver.NowAt<TeamsPage>();
            Verify.IsTrue(teamElement.DefaultTeamCheckbox.Displayed(), "Default Team checkbox is active");
        }

        [When(@"User selects ""(.*)"" tab on the Team details page")]
        public void WhenUserSelectsTabOnTheTeamDetailsPage(string tabName)
        {
            var projectTabs = _driver.NowAt<TeamsPage>();
            projectTabs.NavigateToTeamTabByName(tabName);
            _driver.WaitForDataLoading();
        }

        #region Column Settings

        [When(@"User clicks Filter button in the Column Settings panel on the Teams Page")]
        public void WhenUserClicksFilterButtonInTheColumnSettingsPanelOnTheTeamsPage()
        {
            var menu = _driver.NowAt<TeamsPage>();
            _driver.WaitForElementToBeDisplayed(menu.FilterButton);
            menu.FilterButton.Click();
        }

        #endregion

        [Then(@"Content is present in the table on the Admin page")]
        public void ThenContentIsPresentInTheTableOnTheAdminPage()
        {
            var tableElement = _driver.NowAt<BaseGridPage>();
            _driver.WaitForElementToBeDisplayed(tableElement.TableContent);
            Verify.IsTrue(tableElement.TableContent.Displayed(), "Table is empty");
        }

        [Then(@"Panel of available members is displayed to the user")]
        public void ThenPanelOfAvailableMembersIsDisplayedToTheUser()
        {
            var panel = _driver.NowAt<TeamsPage>();
            _driver.WaitForElementToBeDisplayed(panel.TeamMembersPanel);
            Verify.IsTrue(panel.TeamMembersPanel.Displayed(), "Team Members Panel is not displayed on the Teams page");
        }

        [Then(@"Create Team button is disabled")]
        public void ThenCreateTeamButtonIsDisabled()
        {
            var button = _driver.NowAt<CreateTeamPage>();
            _driver.WaitForElementToBeDisplayed(button.CreateTeamButton);
            Verify.IsTrue(Convert.ToBoolean(button.CreateTeamButton.GetAttribute("disabled")),
                "Create Team button is active");
        }

        [Then(@"""(.*)"" is displayed on the Admin page")]
        public void ThenIsDisplayedOnTheAdminPage(string name)
        {
            var page = _driver.NowAt<Capacity_CapacityUnitsPage>();
            Verify.IsTrue(page.GetMovingElementByName(name).Displayed(), $"{name} Page is not displayed to the user");
        }

        [Then(@"Actions dropdown is disabled")]
        public void ThenActionsDropdownIsDisabled()
        {
            var button = _driver.NowAt<BaseGridPage>();
            Verify.IsTrue(button.ActionsSelectBox.GetAttribute("class").Contains("disabled"), "Actions dropdown is active");
        }

        [When(@"User selects all objects to the Project")]
        [When(@"User cancels the selection objects in the Project")]
        public void WhenUserSelectsAllObjects()
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            projectElement.AllItemCheckbox.Click();
            _driver.WaitForDataLoading();
        }

        #region Adding Objects

        [Then(@"following Objects are displayed in ""(.*)"" tab on the Capacity Units page:")]
        public void ThenFollowingObjectsAreDisplayedInTabOnTheCapacityUnitsPage(string tabName, Table table)
        {
            try
            {
                if (tabName.Equals("Applications"))
                {
                    var page = _driver.NowAt<Capacity_CapacityUnitsPage>();

                    var expectedRowList = table.Rows.SelectMany(row => row.Values).ToList();
                    var actualRowList = page.ApplicationsRowsList.Select(value => value.Text).ToList();
                    Verify.AreEqual(expectedRowList, actualRowList, "Rows value in the lists are different");
                }
                else
                {
                    var page = _driver.NowAt<BaseGridPage>();

                    var expectedRowList = table.Rows.SelectMany(row => row.Values).ToList();
                    var actualRowList = page.RowsList.Select(value => value.Text).ToList();
                    Verify.AreEqual(expectedRowList, actualRowList, "Rows value in the lists are different");
                }
            }
            catch (Exception)
            {
                if (tabName.Equals("Applications"))
                {
                    var page = _driver.NowAt<Capacity_CapacityUnitsPage>();
                    _driver.Navigate().Refresh();
                    var expectedRowList = table.Rows.SelectMany(row => row.Values).ToList();
                    var actualRowList = page.ApplicationsRowsList.Select(value => value.Text).ToList();
                    Verify.AreEqual(expectedRowList, actualRowList, "Rows value in the lists are different");
                }
                else
                {
                    var page = _driver.NowAt<BaseGridPage>();
                    _driver.Navigate().Refresh();
                    var expectedRowList = table.Rows.SelectMany(row => row.Values).ToList();
                    var actualRowList = page.RowsList.Select(value => value.Text).ToList();
                    Verify.AreEqual(expectedRowList, actualRowList, "Rows value in the lists are different");
                }
            }
        }

        [When(@"User searches by ""(.*)"" column and selects following rows in the grid:")]
        public void WhenUserSearchesByColumnAndSelectsFollowingRowsInTheGrid(string columnName, Table table)
        {
            var dashboardPage = _driver.NowAt<BaseGridPage>();
            int iteration = 0;
            foreach (var row in table.Rows)
            {
                dashboardPage.PopulateSearchFieldByColumnName(columnName, row.Values.FirstOrDefault());
                _driver.WaitForDataLoading();
                dashboardPage.SelectAllCheckbox.Click();
                if (iteration != 0)
                {
                    dashboardPage.SelectAllCheckbox.Click();
                }
                iteration++;
            }
        }

        [When(@"User closes Tools panel")]
        public void WhenUserClosesToolsPanel()
        {
            var listPageElement = _driver.NowAt<BaseDashboardPage>();
            listPageElement.CloseToolsPanelButton.Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User clicks Search button and opens Search panel for agGrid")]
        public void WhenUserClicksSearchButtonAndOpensSearchPanelForAgGrid()
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            _driver.MouseHover(dashboardPage.TableSearchButton);
            dashboardPage.TableSearchButton.Click();
        }

        [When(@"User searches and selects following rows in the grid on Details page:")]
        public void WhenUserSearchesAndSelectsFollowingRowsInTheGridOnDetails(Table table)
        {
            var dashboardPage = _driver.NowAt<BaseDashboardPage>();
            if (dashboardPage.TableSearchTextBox.Displayed())
            {
                foreach (var row in table.Rows)
                {
                    dashboardPage.TableSearchTextBox.SendKeys(row["SelectedRowsName"]);
                    Thread.Sleep(5000);
                    _driver.WaitForDataLoading();
                    dashboardPage.SelectOneRowsCheckboxes.Click();
                    dashboardPage.TableSearchTextBox.Clear();
                }
            }
            else
            {
                dashboardPage.TableSearchButton.Click();
                _driver.WaitForElementToBeDisplayed(dashboardPage.TableSearchTextBox);
                foreach (var row in table.Rows)
                {
                    dashboardPage.TableSearchTextBox.SendKeys(row["SelectedRowsName"]);
                    Thread.Sleep(5000);
                    _driver.WaitForDataLoading();
                    dashboardPage.SelectOneRowsCheckboxes.Click();
                    dashboardPage.TableSearchTextBox.Clear();
                }
            }
        }

        [Then(@"Objects are displayed in alphabetical order on the Admin page")]
        public void ThenObjectsAreDisplayedInAlphabeticalOrderOnTheAdminPage()
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            var originalList = page.ObjectsList.Select(x => x.Text).ToList();
            SortingHelper.IsListSorted(originalList);
        }

        [Then(@"following Items are displayed in the History table")]
        [Then(@"additional onboarded Items are displayed in the History table")]
        public void ThenFollowingItemsAreDisplayedInTheHistoryTable(Table table)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            var secondsToWait = 80;
            foreach (var row in table.Rows)
            {
                Verify.IsTrue(projectElement.WaitForHistoryOnboardedObject(row["Items"], secondsToWait),
                    $"History onboarded object with '{row["Items"]}' text was not appears in the grid in {secondsToWait} seconds");
            }
        }

        [Then(@"Following items displayed in the History table")]
        public void ThenFollowingItemsDisplayedInTheHistoryTable(Table table)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            foreach (var row in table.Rows)
            {
                Verify.IsTrue(projectElement.WaitForHistoryOnboardedObject(row["Items"], 30),
                    $"History table doesn't contains '{row["Items"]}' item");
            }
        }

        [Then(@"following Items are displayed in the Queue table")]
        public void ThenFollowingItemsAreDisplayedInTheQueueTable(Table table)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            foreach (var row in table.Rows)
            {
                Verify.IsTrue(projectElement.QueueOnboardedObjectDisplayed(row["Items"]).Displayed,
                    $"{row["Items"]} is not displayed in Queue table");
            }
        }

        [When(@"User waits until Queue disappears")]
        public void WhenUserWaitsForQueueDisappears()
        {
            var refresh_icon = ".//i[@class='material-icons' and contains(text(),'refresh')]";
            var filter_label = ".//div[@class='top-tools-inner']//span[contains(text(),'row')]";

            _driver.WaitForElementToBeDisplayed(By.XPath(filter_label));

            for (int i = 0; i < 30; i++)
            {
                if (i == 29)
                {
                    throw new Exception("Queue processing took too much time: 90 sec");
                }

                if (!_driver.FindElement(By.XPath(filter_label)).Text.Equals("0 rows"))
                {
                    Thread.Sleep(3000);
                    _driver.FindElement(By.XPath(refresh_icon)).Click();
                    _driver.WaitForDataLoading();
                }
                else
                {
                    break;
                }

            }
        }

        [Then(@"following Items are displayed at the top of the list")]
        public void ThenFollowingItemsAreDisplayedAtTheTopOfTheList(Table table)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();

            for (var i = 0; i < table.RowCount; i++)
            {
                var row = table.Rows.ElementAt(i);
                Verify.AreEqual(projectElement.GetTableStringRowNumber(row["Items"]), i.ToString(),
                    $"{row["Items"]} is not displayed in History table");
            }
        }

        [Then(@"onboarded objects are displayed in the dropdown")]
        public void ThenOnboardedObjectsAreDisplayedInTheDropdown()
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            Verify.IsFalse(projectElement.ReonboardedItem.Displayed(), "Re-onboarded objects are displayed");
        }

        [Then(@"Add Objects panel is collapsed")]
        public void ThenAddObjectsPanelIsCollapsed()
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            Verify.IsTrue(projectElement.AddObjectsPanelCollapsed.Displayed(), "Panel is expanded");
        }

        #endregion

        [When(@"User tries to open same page with non existing item id")]
        public void WhenUserOpensSamePageForNotExistingItem()
        {
            string current = _driver.Url;
            Regex regex = new Regex("[0-9]");
            current = regex.Replace(current, "01");
            _driver.Navigate().GoToUrl(current);
            _driver.Navigate().Refresh();
        }

        [When(@"User tries to open not existing page")]
        public void WhenUserOpensNotExistingPage()
        {
            string current = _driver.Url;
            int index = current.LastIndexOf("/");

            if (index > 0)
                current = current.Substring(0, index) + "/project/52/scope/scopeChanges";
            _driver.Navigate().GoToUrl(current);
        }

        [Then(@"Page not found displayed for the user")]
        public void ThenPageNotFoundDisplayedForRingDetailsPage()
        {
            var page = _driver.NowAt<ProjectsPage>();
            _driver.WaitForElementToBeDisplayed(page.DetailsPageWasNotFound);
            Verify.That(page.DetailsPageWasNotFound.Text, Is.EqualTo("404"), "Page 404 was not opened");
        }

        [Then(@"Import Project button is not displayed")]
        public void ThenImportProjectButtonIsNotDisplayed()
        {
            var button = _driver.NowAt<BaseGridPage>();
            Verify.IsFalse(button.ImportProjectButton.Displayed(), "Import Project button is displayed");
        }

        [Then(@"Main lists are displayed correctly in the Scope dropdown")]
        public void ThenMainListsAreDisplayedCorrectlyInTheScopeDropdown(Table table)
        {
            var createProjectElement = _driver.NowAt<ProjectsPage>();
            createProjectElement.ScopeProjectField.Click();
            createProjectElement.ScopeProjectField.SendKeys("All ");
            var listNames = createProjectElement.ScopeDropdownSectionList.Select(x => x.Text).ToList();
            var expectedlistName = table.Rows.SelectMany(row => row.Values).ToList();
            Verify.AreEqual(listNames, expectedlistName, "Main lists are not displayed correctly");
        }

        [Then(@"following lists are displayed in the Scope dropdown:")]
        public void ThenFollowingListsAreDisplayedInTheScopeDropdown(Table table)
        {
            var createProjectElement = _driver.NowAt<ProjectsPage>();
            createProjectElement.ScopeProjectField.Click();
            foreach (var row in table.Rows)
            {
                Verify.IsTrue(createProjectElement.GetListByNameInScopeDropdown(row["Lists"]).Displayed(), "PLEASE ADD EXCEPTION MESSAGE");
            }
        }

        //TODO should be deleted and replaced by WhenUserSelectsValueForDropdownOnActionPanel
        [When(@"User selects ""(.*)"" in the Scope Project details")]
        public void WhenUserSelectsInTheScopeProjectDetails(string listName)
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            projectElement.ScopeListDropdown.Click();
            projectElement.SelectObjectForProjectCreation(listName);
            Thread.Sleep(5000);
        }

        [Then(@"Scope List dropdown displayed with ""(.*)"" value")]
        public void ScopeListDropdownDisplayedWithListValue(string listName)
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            Verify.That(projectElement.ScopeListDropdownValue.Text, Is.EqualTo(listName), $"Wrong scope value displayed");
        }

        [Then(@"Scope List dropdown is disabled")]
        public void ThenScopeListDropdownIsDisabled()
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            Verify.IsTrue(projectElement.DisabledScopeListDropdown.Displayed(), "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"""(.*)"" is displayed in the disabled Project Type field")]
        public void ThenIsDisplayedInTheDisabledProjectTypeField(string projectType)
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            Verify.IsTrue(Convert.ToBoolean(projectElement.ProjectType.GetAttribute("disabled")),
                "Project Type field is active");
            Verify.AreEqual(projectType, projectElement.ProjectType.GetAttribute("value"), "Project Type is incorrect");
        }

        [Then(@"Scope List dropdown is active")]
        public void ThenScopeListDropdownIsActive()
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            Verify.IsTrue(projectElement.ActiveScopeListDropdown.Displayed(), "PLEASE ADD EXCEPTION MESSAGE");
        }

        [When(@"User clicks in the Scope field on the Admin page")]
        public void WhenUserClicksInTheScopeFieldOnTheAdminPage()
        {
            var createProjectElement = _driver.NowAt<ProjectsPage>();
            createProjectElement.ScopeProjectField.Click();
        }

        [Then(@"Scope DDL have the ""(.*)"" Width")]
        public void ThenScopeDDLHaveTheWidth(string width)
        {
            var panelSize = _driver.NowAt<ProjectsPage>();
            Verify.AreEqual(width, panelSize.GetDllPanelWidth().Split('.').First(), "PLEASE ADD EXCEPTION MESSAGE");
        }

        [When(@"User selects ""(.*)"" in the Buckets Project dropdown")]
        public void WhenUserSelectsInTheBucketsProjectDropdown(string objectName)
        {
            var createProjectElement = _driver.NowAt<ProjectsPage>();
            createProjectElement.BucketsProjectField.Click();
            createProjectElement.SelectObjectForProjectCreation(objectName);
            //Waiting for bucket change
            Thread.Sleep(3000);
        }

        [When(@"User selects ""(.*)"" in the Mode Project dropdown")]
        public void WhenUserSelectsInTheModeProjectDropdown(string optionName)
        {
            var createProjectElement = _driver.NowAt<ProjectsPage>();
            createProjectElement.ModeProjectField.Click();
            createProjectElement.SelectProjectsMode(optionName);
            //Waiting for option change
            Thread.Sleep(3000);
        }

        [When(@"User changes Project Name to ""(.*)""")]
        public void WhenUserChangesProjectNameTo(string projectName)
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            projectElement.ProjectName.ClearWithBackspaces();
            projectElement.ProjectName.SendKeys(projectName);
            _projects.Value.Add(projectName);
            _driver.WaitForDataLoading();
        }

        [When(@"User selects ""(.*)"" language on the Project details page")]
        public void WhenUserSelectsLanguageOnTheProjectDetailsPage(string language)
        {
            var projectPage = _driver.NowAt<ProjectDetailsPage>();
            projectPage.LanguageDropDown.Click();
            var page = _driver.NowAt<BaseDashboardPage>();
            page.GetDropdownValueByName(language).Click();
            projectPage.CheckLanguageButton.Click();
        }

        [When(@"User opens menu for selected language")]
        public void WhenUserOpensMenuForSelectedLanguage()
        {
            var projectPage = _driver.NowAt<ProjectDetailsPage>();
            _driver.WaitForDataLoading();
            projectPage.Click(() => projectPage.LanguageMenu);
        }

        [Then(@"User selects ""(.*)"" option for selected language")]
        public void ThenUserSelectsOptionForSelectedLanguage(string optionName)
        {
            var projectPage = _driver.NowAt<ProjectsPage>();
            projectPage.GetLanguageMenuOptionByName(optionName).Click();
        }

        [When(@"User converts project to evergreen project")]
        public void WhenUserConvertsProjectOnTheProjectDetailsPage()
        {
            var projectPage = _driver.NowAt<ProjectDetailsPage>();
            projectPage.ConvertToEvergreen.Click();
            _driver.WaitForElementToBeDisplayed(projectPage.ConfirmConvertToEvergreenButton);
            projectPage.ConfirmConvertToEvergreenButton.Click();
            _driver.WaitForDataLoading();
        }

        [When(@"User clicks Converts to Evergreen button")]
        public void WhenUserClicksConvertsToEvergreenButtonOnDetailsPage()
        {
            var projectPage = _driver.NowAt<ProjectDetailsPage>();
            projectPage.ConvertToEvergreen.Click();
            _driver.WaitForElementToBeDisplayed(projectPage.ConfirmConvertToEvergreenButton);
        }

        [Then(@"Cancel button is displayed in warning message")]
        public void ThenCancelButtonIsDisplayedInWarning()
        {
            var projectPage = _driver.NowAt<ProjectDetailsPage>();
            Verify.IsTrue(projectPage.CancelConvertToEvergreenButton.Displayed(),
                "Cancel button is not displayed in warning");
        }

        [When(@"User confirms converting to Evergreen process")]
        public void WhenUserConfirmsConvertingToEvergreenProcess()
        {
            var projectPage = _driver.NowAt<ProjectDetailsPage>();
            projectPage.ConfirmConvertToEvergreenButton.Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"Convert to Evergreen button is not displayed")]
        public void ThenConvertsToEvergreenButtonIsNotDisplayed()
        {
            var projectPage = _driver.NowAt<ProjectDetailsPage>();
            Verify.IsFalse(projectPage.ConvertToEvergreen.Displayed(),
                "Convert to Evergreen button is displayed");
        }

        [When(@"User removes ""(.*)"" on the Project details page")]
        public void WhenUserRemovesTaskFromCapacityEditPage(string taskName)
        {
            var slot = _driver.NowAt<Capacity_SlotsPage>();
            slot.RemoveTaskIcon(taskName).Click();
        }

        [Then(@"CapacityEnabled flag is equal to ""(.*)""")]
        public void ThenCapacityEnabledFlagIsEqualTo(string flagState)
        {
            var slot = _driver.NowAt<Capacity_SlotsPage>();

            if (!_tasks.Value.Any())
                throw new Exception("No tasks were created!");

            Verify.That(GetTaskCapacityEnabledFlag(_tasks.Value.Last().Id),
                Is.EqualTo(flagState), $"Flag state is in different state");
        }

        [When(@"User changes Project Short Name to ""(.*)""")]
        public void WhenUserChangesProjectShortNameTo(string shortProjectName)
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            projectElement.ProjectShortName.Clear();
            projectElement.ProjectShortName.SendKeys(shortProjectName);
        }

        [When(@"User changes Project Description to ""(.*)""")]
        public void WhenUserChangesProjectDescriptionTo(string descriptionName)
        {
            var projectElement = _driver.NowAt<ProjectsPage>();
            projectElement.ProjectDescription.Clear();
            projectElement.ProjectDescription.SendKeys(descriptionName);
        }

        [When(@"User changes project language to ""(.*)""")]
        public void WhenUserChangesProjectLanguageTo(string language)
        {
            var page = _driver.NowAt<ProjectsPage>();
            page.DefaultLanguage.Click();
            page.SelectProjectLanguage(language);
        }

        [When(@"User click on Back button")]
        public void WhenUserClickOnBackButton()
        {
            var button = _driver.NowAt<BaseGridPage>();
            button.BackToTableButton.Click();
        }

        [When(@"User resets Search fields for columns")]
        public void WhenUserResetsSearchFieldsForColumns()
        {
            var searchElement = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            searchElement.ResetFiltersButton.Click();
        }

        [When(@"User enters ""(.*)"" text in the Search field for ""(.*)"" column")]
        public void WhenUserEntersTextInTheSearchFieldForColumn(string text, string columnName)
        {
            var searchElement = _driver.NowAt<BaseGridPage>();
            searchElement.PopulateSearchFieldByColumnName(columnName, text);
            //TODO why we store bucket that was used just for search?
            //Store bucket name for further usage
            if (columnName.Equals("Bucket"))
                _lastUsedBucket.Value = text;
        }

        [When(@"User enters '(.*)' text in the Search field for '(.*)' datepicker")]
        public void WhenUserEntersTextInTheSearchFieldForDatepicker(string text, string columnName)
        {
            var searchElement = _driver.NowAt<BaseGridPage>();
            searchElement.PopulateDatepickerByColumnName(columnName, text);
        }

        [When(@"User changes value to ""(.*)"" for ""(.*)"" column")]
        public void WhenUserChangesValueToForColumn(string value, string columnName)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            page.EnterValueByColumnName(value, columnName);
        }

        [When(@"User changes value to ""(.*)"" for ""(.*)"" day column")]
        public void WhenUserChangesValueToForDayColumn(string value, string columnName)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            page.EnterValueByDayName(value, columnName);
        }

        [Then(@"Tasks are displayed in the following order on Action panel:")]
        public void ThenTasksAreDisplayedInTheFollowingOrderOnActionPanel(Table table)
        {
            var page = _driver.NowAt<BaseGridPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = page.DropdownTaskItemsList.Select(value => value.Text).ToList();
            Verify.AreEqual(expectedList, actualList, "Tasks are different");
        }

        [When(@"User enters ""(.*)"" value in Move to position dialog")]
        public void WhenUserEntersValueInMoveToPositionDialog(string value)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            page.MoveToPositionInput.Clear();
            page.MoveToPositionInput.SendKeys(value);
        }

        [When(@"User remembers the Move to position dialog size")]
        public void WhenUserRemembersMoveToPositionDialogSize()
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            _elementCoordinates.Height = page.MoveToPositionDialog.Size.Height;
            _elementCoordinates.Width = page.MoveToPositionDialog.Size.Width;
        }

        [Then(@"User checks that Move to position dialog has the same size")]
        public void ThenUserChecksThatMoveToPositionDialogHasTheSameSize()
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();

            Verify.That(page.MoveToPositionDialog.Size.Height, Is.InRange(_elementCoordinates.Height, _elementCoordinates.Height + 5)); // 5pxls is max height allowed scaling
            Verify.That(page.MoveToPositionDialog.Size.Width, Is.EqualTo(_elementCoordinates.Width));
        }

        [When(@"User moves ""(.*)"" slot to ""(.*)"" slot")]
        public void WhenUserMovesSlotToSlot(string slot, string moveToSlot)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            var slotFrom = page.GetMoveButtonBySlotName(slot);
            var slotTo = page.GetMoveButtonBySlotName(moveToSlot);
            _driver.DragAndDrop(slotFrom, slotTo);
        }

        [When(@"User moves ""(.*)"" automation to ""(.*)"" automation")]
        public void WhenUserMovesAutomationToAutomation(string automation, string moveToautomation)
        {
            var page = _driver.NowAt<AutomationsGridPage>();
            var automationFrom = page.GetMoveButtonByAutomationName(automation);
            var automationTo = page.GetMoveButtonByAutomationName(moveToautomation);
            _driver.DragAndDrop(automationFrom, automationTo);
        }

        [Then(@"Alert message is displayed and contains ""(.*)"" text")]
        public void ThenAlertMessageIsDisplayedAndContainsText(string text)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            _driver.WaitForElementToBeDisplayed(page.MoveToPositionAlert);
            Verify.Contains(text, page.MoveToPositionAlert.Text, "Alert Message is not displayed");
        }

        [Then(@"Create Override Date is displayed correctly")]
        public void ThenCreateOverrideDateIsDisplayedCorrectly()
        {
            var page = _driver.NowAt<Capacity_OverrideDatesPage>();
            Verify.IsTrue(page.CreateOverrideDatePageTitle.Displayed, "Create Override Date title is not displayed");
        }

        [Then(@"""(.*)"" text in search field is displayed correctly for ""(.*)"" column")]
        public void ThenTextInSearchFieldIsDisplayedCorrectlyForColumn(string searchText, string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            Verify.AreEqual(page.GetTextInSearchFieldByColumnName(columnName).GetAttribute("value"), searchText,
                "Text in search field is different");
        }

        [Then(@"""(.*)"" checkbox in the ""(.*)"" field are not available to select")]
        public void ThenCheckboxInTheFieldAreNotAvailableToSelect(string checkbox, string fieldName)
        {
            var field = _driver.NowAt<ProjectsPage>();
            field.GetFieldByName(fieldName).SendKeys(checkbox);
            var page = _driver.NowAt<Capacity_SlotsPage>();
            Verify.IsTrue(page.NoValuesAvailableInDropDown.Displayed(), $"'{checkbox}' is available for select");
        }

        //TODO: AnnI 12/18/19 replace with WhenUserSelectsFollowingCheckboxesInTheFilterDropdownMenuForTheColumn remove this step
        [When(@"User clicks String Filter button for ""(.*)"" column on the Admin page")]
        public void WhenUserClicksStringFilterButtonForColumnOnTheAdminPage(string columnName)
        {
            var filterElement = _driver.NowAt<BaseGridPage>();
            _driver.ClickByActions(filterElement.BodyContainer);
            filterElement.OpenColumnFilter(columnName);
        }

        [Then(@"""(.*)"" is not displayed in the filter dropdown")]
        public void ThenIsNotDisplayedInTheFilterDropdown(string filterName)
        {
            var filterElement = _driver.NowAt<BaseGridPage>();
            Verify.IsFalse(filterElement.GetDisplayStateForStringFilterByName(filterName), "PLEASE ADD EXCEPTION MESSAGE");
        }

        [Then(@"options are sorted in alphabetical order in dropdown for '(.*)' column")]
        public void ThenOptionsAreSortedInAlphabeticalOrderInTheDropdownForColumn(string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.OpenColumnFilter(columnName);

            List<String> list = page.OptionsListInFilterDropdown.Select(x => x.Text).ToList();
            list.Remove("Select All"); //Remove 'Select All' checkbox that can be present on some filters (ALWAYS IN THE TOP)
            list.Remove("Evergreen"); //Remove 'Evergreen' checkbox that can be present on some filters (ALWAYS IN THE TOP)

             _driver.ClickByActions(page.BodyContainer);
            Verify.AreEqual(list.OrderBy(s => s, StringComparer.OrdinalIgnoreCase), list, $"Values in '{columnName}'column are not in alphabetical order");
        }

        [Then(@"Search fields for ""(.*)"" column contain correctly value")]
        public void ThenSearchFieldsForColumnContainCorrectlyValue(string columnName)
        {
            var searchField = _driver.NowAt<BaseGridPage>();
            Verify.IsTrue(searchField.GetSearchFieldTextByColumnName(columnName).Displayed(),
                "Incorrect contain value for search field");
        }

        [When(@"User clicks Reset Filters button on the Admin page")]
        public void WhenUserClicksResetFiltersButtonOnTheAdminPage()
        {
            var button = _driver.NowAt<BaseGridPage>();
            Thread.Sleep(1000);
            _driver.WaitForDataLoading();
            button.ResetFiltersButton.Click();
        }

        [When(@"User clicks Export button on the Admin page")]
        public void WhenUserClicksExportButtonOnTheAdminPage()
        {
            var button = _driver.NowAt<BaseGridPage>();
            button.ExportButton.Click();
        }

        [When(@"User clicks Refresh button on the Admin page")]
        public void WhenUserClicksRefreshButtonOnTheAdminPage()
        {
            var button = _driver.NowAt<BaseGridPage>();
            button.RefreshButton.Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"""(.*)"" Onboarded objects are displayed")]
        public void ThenOnboardedObjectsAreDisplayed(string objectsNumber)
        {
            var projectElement = _driver.NowAt<BaseGridPage>();
            projectElement.OnboardedObjectNumber(objectsNumber);
        }

        [When(@"User removes selected item")]
        public void WhenUserRemovesSelectedItem()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            page.SelectDropdown("Delete", "Actions");
            page.ClickButton("DELETE");

            var inlineTipBanner = _driver.NowAt<BaseInlineBannerElement>();
            inlineTipBanner.VerifyColor(MessageType.Tip);
            _driver.WaitForDataLoading();
            inlineTipBanner.GetButton(MessageType.Tip, "DELETE").Click();
        }

        [Then(@"Counter shows ""(.*)"" found rows")]
        public void ThenRowsAreDisplayedInTheAgGrid(string numberOfRows)
        {
            var foundRowsCounter = _driver.NowAt<BaseGridPage>();
            _driver.WaitForElementToBeDisplayed(foundRowsCounter.RowsCounter);
            Verify.AreEqualIgnoringCase(numberOfRows == "1" ? $"{numberOfRows} row" : $"{numberOfRows} rows",
                foundRowsCounter.RowsCounter.Text, "Incorrect rows count");
        }

        [Then(@"Rows counter shows ""(.*)"" of ""(.*)"" rows")]
        public void ThenRowsCounterShowsOfRows(string selectedRows, string ofRows)
        {
            var foundRowsCounter = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(foundRowsCounter.RowsCounter);
            Verify.AreEqualIgnoringCase(
                ofRows.Equals("1") ? $"{selectedRows} of {ofRows} row" : $"{selectedRows} of {ofRows} rows",
                foundRowsCounter.RowsCounter.Text, "Incorrect rows count");
        }

        [Then(@"Rows counter contains ""(.*)"" found row of all rows")]
        [Then(@"Rows counter contains ""(.*)"" found rows of all rows")]
        public void ThenRowsCounterContainsFoundRowsOfAllRows(int foundRows)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(page.RowsCounter);
            Verify.That(page.RowsCounter.Text, Does.Contain(foundRows + " of "),
                $"Found rows counter doesn't contain {foundRows} found rows");
        }

        [Then(@"Rows counter shows more than ""(.*)"" found rows of all rows")]
        public void ThenRowsCounterShowsMoreThanFoundRowsOfAllRows(int foundRows)
        {
            var page = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(page.RowsCounter);
            var foundRowsOfAllRowsLabel = page.RowsCounter.Text;
            var foundRowsInt = Int32.Parse(foundRowsOfAllRowsLabel.Substring(0, foundRowsOfAllRowsLabel.IndexOf("of")).Replace(",", string.Empty));
            Verify.That(foundRowsInt, Is.GreaterThanOrEqualTo(foundRows),
                $"Found rows counter {foundRowsInt} is not greater or equal to expected {foundRows}");
        }

        [Then(@"User sees ""(.*)"" of ""(.*)"" rows selected label")]
        public void ThenUserSeesRowsSelectedLabel(int selectedRows, int ofRows)
        {
            var foundRowsCounter = _driver.NowAt<BaseGridPage>();
            _driver.WaitForDataLoading();
            _driver.WaitForElementToBeDisplayed(foundRowsCounter.RowsCounter);
            Verify.AreEqualIgnoringCase($"{selectedRows} of {ofRows} selected",
                foundRowsCounter.RowsCounter.Text, "Incorrect rows count");
        }

        [Then(@"User sees following tiles selected in the ""(.*)"" field:")]
        public void ThenUserSeesFollowingTilesSelectedInTheField(string dropdownName, Table items)
        {
            var page = _driver.NowAt<Capacity_SlotsPage>();
            _driver.WaitForDataLoading();
            foreach (var row in items.Rows)
            {
                Verify.IsTrue(page.GetTilesByDropdownName(row["Items"]).Displayed,
                    $"{row["Items"]} is not displayed in {dropdownName} dropdown");
            }
        }

        [Then(@"Delete ""(.*)"" Project in the Administration")]
        public void ThenDeleteProjectInTheAdministration(string projectName)
        {
            var projectId = GetProjectId(projectName);
            DatabaseHelper.ExecuteQuery($"delete from[PM].[dbo].[EvergreenProjects] where[ProjectId] = '{projectId}'");
            DatabaseHelper.ExecuteQuery($"delete from[PM].[dbo].[ProjectGroups] where[ProjectID] = '{projectId}'");
            DatabaseHelper.ExecuteQuery(
                $"delete from[PM].[dbo].[SelfServiceScreenValueLanguage] where[ProjectId] = '{projectId}'");
            DatabaseHelper.ExecuteQuery($"delete from[PM].[dbo].[SelfService] where[ProjectID] = '{projectId}'");
            DatabaseHelper.ExecuteQuery(
                $"delete from[PM].[dbo].[SelfServiceScreenValues] where[ProjectID] = '{projectId}'");
            DatabaseHelper.ExecuteQuery($"delete from[PM].[dbo].[Projects] where[ProjectID] = '{projectId}'");
            DatabaseHelper.ExecuteQuery($"delete from[PM].[dbo].[Projects] where[ProjectID] = '{projectId}'");
        }

        [Then(@"""(.*)"" button is displayed in the warning message")]
        public void ThenButtonIsDisplayedInTheWarningMessageOnProjectPage(string text)
        {
            var page = _driver.NowAt<ProjectsPage>();

            Verify.IsTrue(page.GetButtonOnWarningContainerByName(text).Displayed(), $"{text} button is not displayed in the Warning message");
        }

        [Then(@"User sees following Display order on the Automation page")]
        public void ThenUserSeesFollowingDisplayOrderOnTheAutomationPage(Table displayOrder)
        {
            var page = _driver.NowAt<ProjectsPage>();
            _driver.WaitForDataLoading();
            for (var i = 0; i < displayOrder.RowCount; i++)
                Verify.That(page.DisplayOrderValues[i].Text, Is.EqualTo(displayOrder.Rows[i].Values.FirstOrDefault()),
                    "Display order values are displayed in the wrong order");
        }

        [When(@"User navigates to ""(.*)"" project details")]
        public void WhenUserNavigatesToProjectDetails(string projectName)
        {
            //Just wait for header to be displayed and loading to be finished
            //In other case GoToUrl sometimes doesn't work
            _driver.NowAt<BaseHeaderElement>();

            var projectId = GetProjectId(projectName);
            _driver.Navigate().GoToUrl($"{UrlProvider.EvergreenUrl}#/admin/project/{projectId}/details");

            var header = _driver.NowAt<BaseHeaderElement>();
            header.CheckPageHeader(projectName);
        }

        [When(@"User navigates to '(.*)' automation details")]
        public void WhenUserNavigatesToAutomationDetails(string automation)
        {
            _driver.NowAt<BaseHeaderElement>();

            var automationId = DatabaseHelper.GetAutomationId(automation);
            _driver.Navigate().GoToUrl($"{UrlProvider.EvergreenUrl}#/admin/automation/{automationId}/details");

            var header = _driver.NowAt<BaseHeaderElement>();
            header.CheckPageHeader(automation);
        }

        [When(@"User hides side panel in project details page")]
        public void WhenUserHidesSidePanelInProjectDetails()
        {
            var page = _driver.NowAt<ProjectsPage>();

            page.CloseSidePanelCross.Click();
            _driver.WaitForElementToBeNotDisplayed(page.CloseSidePanelCross);
        }

        [Then(@"Button toggle zindex is greater than tab zindex")]
        public void ThenButtonToggleZindexIsGreaterThanTabZindex()
        {
            var page = _driver.NowAt<ProjectsPage>();
            _driver.WaitForDataLoading();

            int zIndexExpend = Convert.ToInt32(page.SidePanelIcon.GetCssValue("z-index"));

            Verify.That(zIndexExpend, Is.GreaterThan(2),
                $"Wrong overlapping: zIndex: {zIndexExpend} < zIndex: {2}");
        }

        private string GetProjectId(string projectName)
        {
            var projectId =
                DatabaseHelper.ExecuteReader(
                    $"SELECT [ProjectID] FROM [PM].[dbo].[Projects] where [ProjectName] = '{projectName}' AND [IsDeleted] = 0",
                    0).LastOrDefault();
            return projectId;
        }

        private string GetTaskCapacityEnabledFlag(string taskId)
        {
            var flagState =
                DatabaseHelper.ExecuteReader(
                    $"SELECT [CapacityEnabled] FROM [PM].[dbo].[ProjectTasks] where [TaskID] = '{taskId}'", 0).LastOrDefault();
            return flagState;
        }
    }
}