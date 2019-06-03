using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_DetailsPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;

        public EvergreenJnr_DetailsPage(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        [When(@"User opens ""(.*)"" section on the Details Page")]
        public void WhenUserOpensSectionOnTheDetailsPage(string sectionName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            _driver.WaitWhileControlIsNotDisplayed<DetailsPage>(() => detailsPage.PopupChangesPanel);
            if (!detailsPage.OpenedSection.Displayed())
            {
                _driver.MouseHover(detailsPage.NavigateToSectionByName(sectionName));
                detailsPage.NavigateToSectionByName(sectionName).Click();
            }
            else
                Assert.IsTrue(detailsPage.OpenedSection.Displayed(), "Section content is not loaded");
        }

        [When(@"User clicks ""(.*)"" link on the Details Page")]
        public void WhenUserClicksLinkOnTheDetailsPage(string linkName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            if (!detailsPage.GetLinkByName(linkName).Displayed)
                try
                {
                    Thread.Sleep(30000);
                    _driver.Navigate().Refresh();
                    detailsPage.GetLinkByName(linkName).Click();
                }
                catch (Exception)
                {
                    Thread.Sleep(50000);
                    _driver.Navigate().Refresh();
                    detailsPage.GetLinkByName(linkName).Click();
                }
            else
                detailsPage.GetLinkByName(linkName).Click();
        }

        [Then(@"""(.*)"" title matches the ""(.*)"" value")]
        public void ThenTitleMatchesTheValue(string title, string value)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Assert.IsTrue(detailsPage.GetCompareTitleWithValueOnTheDetailsPage(title, value).Displayed(),
                $"{title} does not match the {value}");
        }

        [Then(@"""(.*)"" content is displayed in ""(.*)"" field on Item Details page")]
        public void ThenContentIsDisplayedInFieldOnItemDetailsPage(string text, string fieldName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Assert.IsTrue(detailsPage.FieldContentByName(text, fieldName).Displayed(),
                $"'{fieldName}' field does not contain the '{text}' content");
        }

        [Then(@"following content is displayed on the Details Page")]
        public void ThenFollowingContentIsDisplayedOnTheDetailsPage(Table table)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            _driver.WaitForDataLoading();
            foreach (var row in table.Rows)
            {
                Assert.IsTrue(detailsPage.GetCompareContentOnTheDetailsPage(row["Title"], row["Value"]).Displayed(),
                    $"{row["Title"]} does not match the {row["Value"]}");
            }
        }

        [Then(@"following fields are displayed in the open section:")]
        public void ThenFollowingFieldsAreDisplayedInTheOpenSection(Table table)
        {
            var fields = _driver.NowAt<DetailsPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = fields.FieldListOnDetailsPage.Select(value => value.Text).ToList();
            Assert.AreEqual(expectedList, actualList, "Fields in the open section are different");
        }

        [Then(@"empty value is displayed for ""(.*)"" field on the Details Page")]
        public void ThenEmptyValueIsDisplayedForFieldOnTheDetailsPage(string text)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Assert.AreEqual(detailsPage.GetFildWithEmptyValueByName(text), "");

        }

        [Then(@"Highcharts graphic is displayed on the Details Page")]
        public void ThenHighchartsGraphicIsDisplayedOnTheDetailsPage()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            _driver.WaitWhileControlIsNotDisplayed<DetailsPage>(() => detailsPage.GraphicInOpenedSection);
            Assert.IsTrue(detailsPage.GraphicInOpenedSection.Displayed(), "Graphic content is not displayed");
        }

        [Then(@"""(.*)"" message is displayed on the Details Page")]
        public void ThenMessageIsDisplayedOnTheDetailsPage(string message)
        {
            var listElement = _driver.NowAt<DetailsPage>();
            _driver.WaitWhileControlIsNotDisplayed<DetailsPage>(() => listElement.NoFoundMessage);
            Assert.AreEqual(message, listElement.NoFoundMessage.Text, $"{message} is not displayed");
        }

        [Then(@"Item content is displayed to the User")]
        public void ThenItemContentIsDisplayedToTheUser()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Assert.IsTrue(detailsPage.ItemDetailsContainer.Displayed(), "Item content is not displayed");
        }

        [Then(@"Details object page is displayed to the user")]
        public void ThenDetailsObjectPageIsDisplayedToTheUser()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            _driver.WaitForDataLoading();
            Assert.IsTrue(detailsPage.GroupIcon.Displayed());
            Assert.IsTrue(detailsPage.ItemDetailsContainer.Displayed());
        }

        [Then(@"Details page for ""(.*)"" item is displayed correctly")]
        public void ThenDetailsPageForItemIsDisplayedCorrectly(string itemName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Assert.IsTrue(detailsPage.GetItemDetailsPageByName(itemName).Displayed(), $"Details page for {itemName} item is not loaded");
        }

        [Then(@"Image item from ""(.*)"" column is displayed to the user")]
        public void ThenImageItemFromColumnIsDisplayedToTheUser(string columnName)
        {
            _driver.WaitForDataLoading();
            var content = _driver.FindElements(By.XPath(DetailsPage.ColumnWithImageAndLinkSelector));
            foreach (var element in content)
            {
                var image = element.FindElement(By.XPath(DetailsPage.ItemImageSelector));
                Assert.IsTrue(_driver.IsElementExists(image), "Image item is not found");
            }
        }

        [Then(@"Links from ""(.*)"" column is displayed to the user on the Details Page")]
        public void ThenLinksFromColumnIsDisplayedToTheUserOnTheDetailsPage(string columnName)
        {
            var content = _driver.NowAt<DetailsPage>();
            content.GetHrefByColumnName(columnName);
            Assert.IsTrue(content.GetHrefByColumnName(columnName) != null);
        }

        [Then(@"expanded section is displayed to the User")]
        public void ThenExpandedSectionIsDisplayedToTheUser()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Assert.IsTrue(detailsPage.SectionContainer.Displayed(), "Section is not displayed");
        }

        [Then(@"""(.*)"" column is displayed to the user")]
        public void ThenColumnIsDisplayedToTheUser(string columnName)
        {
            var columnHeader = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            Assert.IsTrue(columnHeader.ColumnIsDisplayed(columnName),
                $"{columnName} column is not displayed");
        }

        [Then(@"""(.*)"" column is not displayed to the user")]
        public void ThenColumnIsNotDisplayedToTheUser(string columnName)
        {
            var columnHeader = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            Assert.IsFalse(columnHeader.ColumnIsDisplayed(columnName),
                $"{columnName} column still displayed");
        }

        [Then(@"following columns are displayed on the Item details page:")]
        public void ThenFollowingColumnsAreDisplayedOnTheItemDetailsPage(Table table)
        {
            var column = _driver.NowAt<DetailsPage>();

            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var columnNames = column.ColumnHeadersList.Select(value => value.Text).ToList();
            Assert.AreEqual(expectedList, columnNames, "Columns order on Item details page is incorrect");
        }

        [When(@"User clicks String Filter button for ""(.*)"" column")]
        public void WhenUserClicksStringFilterButtonForColumn(string columnName)
        {
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            filterElement.BodyContainer.Click();
            filterElement.GetStringFilterByColumnName(columnName);
        }

        [When(@"User closes Checkbox filter for ""(.*)"" column")]
        public void WhenUserClosesCheckboxFilterForColumn(string columnName)
        {
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            filterElement.BodyContainer.Click();
        }

        [Then(@"All text is displayed for ""(.*)"" column in the String Filter")]
        public void ThenAllTextIsDisplayedForColumnInTheStringFilter(string columnName)
        {
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            Assert.IsTrue(filterElement.GetStringFilterTextByColumnName(columnName),
                $"All text is not displayed for {columnName} column");
        }

        [Then(@"All text is not displayed for ""(.*)"" column in the String Filter")]
        public void ThenAllTextIsNotDisplayedForColumnInTheStringFilter(string columnName)
        {
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            Assert.IsFalse(filterElement.GetStringFilterTextByColumnName(columnName),
                $"All text is displayed for {columnName} column");
        }

        [When(@"User enters ""(.*)"" text in the Search field for ""(.*)"" column on the Details Page")]
        public void WhenUserEntersTextInTheSearchFieldForColumnOnTheDetailsPage(string text, string columnName)
        {
            var searchElement = _driver.NowAt<DetailsPage>();
            searchElement.GetSearchFieldByColumnName(columnName, text);
        }

        [Then(@"Dropdown List is displayed correctly in the Filter on the Details Page")]
        public void ThenDropdownListIsDisplayedCorrectlyInTheFilterOnTheDetailsPage()
        {
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            if (filterElement.GetCheckboxes().Count() > 5)
            {
                Assert.IsTrue(filterElement.AllCheckboxesSelectedStringFilter.Displayed(), "All checkbox is unchecked");
                Assert.IsFalse(filterElement.UncheckedStringFilters.Displayed(), "Checkbox is selected");
            }
            else
            {
                Assert.IsFalse(filterElement.UncheckedStringFilters.Displayed(), "Checkbox is selected");
            }

            filterElement.BodyContainer.Click();
        }

        [When(@"User clicks Reset Filters button on the Details Page")]
        public void WhenUserClicksResetFiltersButtonOnTheDetailsPage()
        {
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            filterElement.BodyContainer.Click();
            _driver.WaitWhileControlIsNotDisplayed<ApplicationsDetailsTabsMenu>(() => filterElement.ResetFiltersButton);
            filterElement.ResetFiltersButton.Click();
        }

        [When(@"User selects ""(.*)"" text from key value grid on the Details Page")]
        public void WhenUserSelectsFollowingTextFromKeyValueGridOnTheDetailsPage(string textToBeSelected)
        {
            var page = _driver.NowAt<DetailsPage>();
            page.Actions.Click(page.GetCellByTextFromKeyValueGrid(textToBeSelected)).DoubleClick().Build().Perform();
        }

        [Then(@"""(.*)"" text selected from key value grid on the Details Page")]
        public void ThenTextSelectedFromKeyValueGridOnTheDetailsPage(string textSelected)
        {
            var page = _driver.NowAt<DetailsPage>();

            Assert.That(page.GetSelectedText(), Is.EqualTo(textSelected));
        }

        [Then(@"following Values are displayed in the filter on the Details Page")]
        public void ThenFollowingValuesAreDisplayedInTheFilterOnTheDetailsPage(Table table)
        {
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            var expectedList = table.Rows.SelectMany(row => row.Values);
            var actualList = filterElement.FilterCheckboxValues.Select(value => value.Text);
            Assert.AreEqual(expectedList, actualList, "Filter checkbox values are different");
        }

        [When(@"User have opened Column Settings for ""(.*)"" column in the Details Page table")]
        public void WhenUserHaveOpenedColumnSettingsForColumnInTheDetailsPageTable(string columnName)
        {
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.OpenColumnSettingsByName(columnName);
        }

        [When(@"User have select ""(.*)"" option from column settings on the Details Page")]
        public void WhenUserHaveSelectOptionFromColumnSettingsOnTheDetailsPage(string settingName)
        {
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.GetSettingByNameDetailsPage(settingName).Click();
        }

        [When(@"User clicks Column button on the Column Settings panel")]
        public void WhenUserClicksColumnButtonOnTheColumnSettingsPanel()
        {
            var menu = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            _driver.WaitWhileControlIsNotDisplayed<ApplicationsDetailsTabsMenu>(() => menu.ColumnButton);
            menu.ColumnButton.Click();
        }

        [Then(@"Column Settings was opened")]
        public void ThenColumnSettingsWasOpened()
        {
            var menu = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            Assert.IsTrue(menu.ColumnSettingsPanel.Displayed(), "Column Settings is not opened");
        }

        [When(@"User clicks Filter button on the Column Settings panel")]
        public void WhenUserClicksFilterButtonOnTheColumnSettingsPanel()
        {
            var menu = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            _driver.MouseHover(menu.FilterButton);
            _driver.WaitWhileControlIsNotDisplayed<ApplicationsDetailsTabsMenu>(() => menu.FilterButton);
            menu.FilterButton.Click();
        }

        [When(@"User clicks the  filter type dropdown on the Column Settings panel")]
        public void WhenUserClicksTheFilterTypeDropdownOnTheColumnSettingsPanel()
        {
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            filterElement.FilterTypeDropdownOnTheColumnPanel.Click();
        }

        [Then(@"following Values are displayed in the filter type dropdown")]
        public void ThenFollowingValuesAreDisplayedInTheFilterTypeDropdown(Table table)
        {
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            var expectedList = table.Rows.SelectMany(row => row.Values);
            var actualList = filterElement.FilterTypeValues.Select(value => value.Text);
            Assert.AreEqual(expectedList, actualList, "Filter type values are different");
        }

        [When(@"User select In Range value with following date:")]
        public void WhenUserSelectInRangeValueWithFollowingDate(Table table)
        {
            var menu = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            menu.SelectValueForDateColumn("In range");
            foreach (var row in table.Rows)
            {
                menu.DateFromValue.SendKeys(row["DateFrom"]);
                menu.DateToValue.SendKeys(row["DateTo"]);
            }
            var body = _driver.NowAt<BaseGridPage>();
            body.BodyContainer.Click();
        }

        [When(@"User select criteria with following date:")]
        public void WhenUserSelectFilterCriteriaAndFollowingDate(Table table)
        {
            var menu = _driver.NowAt<ApplicationsDetailsTabsMenu>();

            foreach (var row in table.Rows)
            {
                menu.SelectConditionForDateColumn(row["Criteria"]);

                menu.DateRegularValueFirst.Clear();


                if (!string.IsNullOrEmpty(row["Date"]))
                    menu.DateRegularValueFirst.SendKeys(row["Date"]);

                menu.DateRegularValueFirst.SendKeys(OpenQA.Selenium.Keys.Enter);
            }
        }

        [When(@"User remembers the date input position")]
        public void WhenUserRemembersInputPosition()
        {
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.Storage.SessionStorage.SetItem("date_input_X", page.DateRegularValueFirst.Location.X.ToString());
            page.Storage.SessionStorage.SetItem("date_input_Y", page.DateRegularValueFirst.Location.Y.ToString());
        }

        [Then(@"User checks that date input has same position")]
        public void ThenUserChecksThatHasSamePosition()
        {
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            int xCoord = Int32.Parse(page.Storage.SessionStorage.GetItem("date_input_X"));
            int yCoord = Int32.Parse(page.Storage.SessionStorage.GetItem("date_input_Y"));

            Assert.That(page.DateRegularValueFirst.Location.X, Is.InRange(xCoord - 10, xCoord + 10)); // calibration
            Assert.That(page.DateRegularValueFirst.Location.Y, Is.InRange(yCoord - 10, yCoord + 10)); // calibration
        }


        [Then(@"User select ""(.*)"" checkbox from filter on the Details Page")]
        public void ThenUserSelectCheckboxFromFilterOnTheDetailsPage(string filterName)
        {
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.GetFilterByName(filterName).Click();
        }

        [When(@"User clicks ""(.*)"" checkbox from String Filter on the Details Page")]
        public void WhenUserClicksCheckboxFromStringFilterOnTheDetailsPage(string filterName)
        {
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            if (page.CheckboxesStringFilter.Displayed())
                page.GetStringFilterByName(filterName).Click();
            else
                page.GetBooleanStringFilterByName(filterName).Click();
        }

        [When(@"User selects ""(.*)"" checkbox from String Filter on the Details Page")]
        public void WhenUserSelectsCheckboxFromStringFilterOnTheDetailsPage(string filterName)
        {
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.GetCheckboxStringFilterByName(filterName);
            page.BodyContainer.Click();
        }

        [Then(@"""(.*)"" checkbox is checked on the Details Page")]
        public void ThenCheckboxIsCheckedOnTheDetailsPage(string checkboxName)
        {
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            Assert.IsTrue(filterElement.ColumnCheckboxChecked.Displayed(), $"{checkboxName} Checkbox is not selected");
        }

        [When(@"User selects following date filter on the Details Page")]
        public void WhenUserSelectsFollowingDateFilterOnTheDetailsPage(Table table)
        {
            var filter = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            _driver.WaitForDataLoading();
            filter.ResetFiltersButton.Click();
            foreach (var row in table.Rows) filter.DateFilterValue.SendKeys(row["FilterData"]);

            _driver.WaitForDataLoading();
        }

        [Then(@"Content is present in the table on the Details Page")]
        public void ThenContentIsPresentInTheTableOnTheDetailsPage()
        {
            var tableElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            //Assert.IsTrue(tableElement.TableContent.Displayed(), "Table is empty");
            Assert.IsTrue(tableElement.TableRows.Count > 0, "Table is empty");
        }

        [Then(@"Filter panel has standard size")]
        public void ThenFilterPanelHasStandardSize()
        {
            var filterPanel = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            Assert.AreEqual("124.734px", filterPanel.GetInstalledFilterPanelHeight());
            Assert.AreEqual("152px", filterPanel.GetInstalledFilterPanelWidth());
        }

        [Then(@"Site column has standard size")]
        public void ThenSiteColumnHasStandardSize()
        {
            var filterPanel = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            if (!_driver.IsElementDisplayed(By.XPath(ApplicationsDetailsTabsMenu.SiteColumnSelector)))
            { }
            else
                Assert.AreEqual("97px", filterPanel.PackageSiteColumnWidth());
        }

        [Then(@"Bucket pop-up has standard size on the Details Page")]
        public void ThenBucketPop_UpHasStandardSizeOnTheDetailsPage()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Assert.AreEqual("1536px", detailsPage.GetInstalledBucketWindowWidth().Split('.').First());
        }

        [When(@"User enters ""(.*)"" text in the Filter field")]
        public void ThenUserEntersTextInTheFilterField(string searchedText)
        {
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            _driver.WaitWhileControlIsNotDisplayed<ApplicationsDetailsTabsMenu>(() =>
                filterElement.FilterSearchTextBox);
            filterElement.FilterSearchTextBox.SendKeys(searchedText);
        }

        [When(@"User clears Filter field")]
        public void WhenUserClearsFilterField()
        {
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            Thread.Sleep(500);
            page.FilterSearchTextBox.ClearWithHomeButton(_driver);
            page.BodyContainer.Click();
        }

        [When(@"User select ""(.*)"" checkbox on the Column Settings panel")]
        public void WhenUserSelectCheckboxOnTheColumnSettingsPanel(string checkboxName)
        {
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            page.GetCheckboxByName(checkboxName);
        }

        [Then(@"Checkboxes are checked on the Column Settings panel for ""(.*)"" Column Settings panel:")]
        public void ThenCheckboxesAreCheckedOnTheColumnSettingsPanelForColumnSettingsPanel(string columnName,
            Table table)
        {
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            page.OpenColumnSettingsByName(columnName);
            Assert.AreEqual(expectedList, page.GetCheckedElementsText(), "Checkbox is not selected");
        }

        [Then(@"Checkboxes are checked on the Column Settings panel:")]
        public void ThenCheckboxesAreCheckedOnTheColumnSettingsPanel(Table table)
        {
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            Assert.AreEqual(expectedList, page.GetCheckedElementsText(), "Checkbox is not selected");
        }

        [Then(@"following columns added to the table:")]
        public void ThenFollowingColumnsAddedToTheTable(Table table)
        {
            CheckColumnDisplayedState(table, true);
        }

        [Then(@"content is present in the following newly added columns:")]
        public void ThenContentIsPresentInTheFollowingNewlyAddedColumns(Table table)
        {
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();

            foreach (var row in table.Rows)
                if (row["ColumnName"] != "Group Key" && row["ColumnName"] != "Category Key")
                {
                    var content = page.GetColumnIdContent(row["ColumnName"]);
                    Assert.IsTrue(content.Count(x => !string.IsNullOrEmpty(x)) > 0, "Newly added column is empty");
                }
        }

        [Then(@"ColumnName is displayed in following order on the Details page:")]
        public void ThenColumnNameIsDisplayedInFollowingOrderOnTheDetailsPage(Table table)
        {
            {
                var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
                _driver.WaitForDataLoading();

                var columnNames = page.GetAllColumnHeadersOnTheDetailsPage()
                    .Select(column => column.Text).ToList();
                var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
                Assert.AreEqual(expectedList, columnNames, "Columns order is incorrect");
            }
        }

        [Then(@"Content is present in the column of the Details Page table")]
        public void ThenContentIsPresentInTheColumnOfTheDetailsPageTable(Table table)
        {
            var page = _driver.NowAt<BaseDashboardPage>();

            foreach (var row in table.Rows)
            {
                var content = page.GetColumnContent(row["ColumnName"]);
                //Check that at least 1 cell has some content
                Assert.IsTrue(content.Count(x => !string.IsNullOrEmpty(x)) > 0, "Column is empty");
            }
        }

        [Then(@"Fields with empty information are displayed")]
        public void ThenFieldsWithEmptyInformationAreDisplayed()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            detailsPage.ExpandAllSections();
            detailsPage.CheckThatAllContentIsNotEmpty();
        }

        [Then(@"Unknown text is displayed for empty fields for ""(.*)"" section")]
        public void ThenUnknownTextIsDisplayedForEmptyFieldsForSection(string sectionName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            detailsPage.ExpandAllSections();
            var table = detailsPage.GetFieldsWithContent(sectionName);
            foreach (var pair in table)
            {
                if (pair.Key.Equals("Address 2") || pair.Key.Equals("Address 3") || pair.Key.Equals("Address 4"))
                    continue;

                Assert.IsTrue(!string.IsNullOrEmpty(pair.Value),
                    $"'Unknown' text is not displayed for {pair.Key} field ");
            }
        }

        [Then(@"Group Icon for Group Details page is displayed")]
        public void ThenGroupIconForPageIsDisplayed()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Assert.IsTrue(detailsPage.GroupIcon.Displayed());
        }

        [Then(@"""(.*)"" text is displayed for opened tab")]
        public void ThenTextIsDisplayedForOpenedTab(string textMessage)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            _driver.WaitWhileControlIsNotDisplayed<DetailsPage>(() => detailsPage.NoFoundContent);
            Assert.AreEqual(textMessage, detailsPage.NoFoundContent.Text,
                $"{textMessage} is not displayed");
        }

        [Then(@"string filter is displayed for ""(.*)"" column on the Details Page")]
        public void ThenStringFilterIsDisplayedForColumnOnTheDetailsPage(string columnName)
        {
            var detailsPage = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            Assert.IsFalse(Convert.ToBoolean(detailsPage.GetFilterByColumnName(columnName).GetAttribute("readonly")));
        }

        [Then(@"User sees ""(.*)"" Evergreen Bucket in Project Summary section on the Details Page")]
        public void ThenUserSeesEvergreenBucketInProjectSummarySectionOnTheDetailsPage(string bucketName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();

            Assert.That(detailsPage.ProjectSummaryBucketValue.Text, Is.EqualTo(bucketName));
        }

        [When(@"User clicks content of Evergreen Ring in Project Summary section on the Details Page")]
        public void WhenUserClicksEvergreenRingInProjectSummarySectionOnTheDetailsPage()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            _driver.WaitWhileControlIsNotDisplayed<DetailsPage>(() => detailsPage.ProjectSummaryRingValue);
            detailsPage.ProjectSummaryRingValue.Click();
        }

        [When(@"User clicks New Ring ddl in popup of Project Summary section on the Details Page")]
        public void WhenUserClicksNewRingDdlOfInProjectSummarySectionOnTheDetailsPage()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            _driver.WaitWhileControlIsNotDisplayed<DetailsPage>(() => detailsPage.ProjectSummaryRingPopupDDL);
            detailsPage.ProjectSummaryRingPopupDDL.Click();
        }

        [Then(@"Rings ddl contains data on Project Summary section of the Details Page")]
        public void ThenRingDdlContainsOptionsInProjectSummarySectionOnTheDetailsPage()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Assert.That(detailsPage.OperatorOptions.Select(value => value.Text).ToList().All(x => x.Contains("Ring") || x.Contains("[Unassigned]")),
                "Some options are not available for selected filter");
        }

        [Then(@"""(.*)"" field display state is ""(.*)"" on Details tab")]
        public void ThenFieldDisplayStateIsOnDetailsTab(string fieldName, bool state)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Assert.AreEqual(state, detailsPage.IsFieldPresent(fieldName), $"Incorrect display state for {fieldName}");
        }

        [Then(@"Empty rows are displayed if the data is unknown")]
        public void ThenEmptyRowsAreDisplayedIfTheDataIsUnknown()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            foreach (var element in detailsPage.TableRowDetails)
                StringAssert.DoesNotContain("Unknown", element.Text,
                    "Unknown text is displayed");
        }

        [Then(@"Rows do not have unknown values")]
        public void ThenRowsDoNotHaveUnknownValues()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            foreach (var element in page.GridRows)
                StringAssert.DoesNotContain("Unknown", element.Text,
                    "Unknown text is displayed");
        }

        [Then(@"Static list grid has ""(.*)"" rows")]
        [Then(@"Static list grid still has ""(.*)"" rows")]
        public void ThenAgGridHasRows(int rowsCount)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Assert.That(page.GridRows.Count, Is.EqualTo(rowsCount),
                $"Incorrect number of rows in agGrid.");
        }


        [Then(@"""(.*)"" rows found label displays on Details Page")]
        public void ThenCorrectFoundRowsLabelDisplaysOnTheDetailsPage(string numberOfRows)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            //Wait for rows label is displayed
            Thread.Sleep(2000);
            StringAssert.AreEqualIgnoringCase(numberOfRows == "1" ? $"{numberOfRows} row" : $"{numberOfRows} rows",
                detailsPage.RowsLabel.Text,
                "Incorrect rows count");
        }

        [Then(@"Name of colors are displayed in following order on the Details Page:")]
        public void ThenNameOfColorsAreDisplayedInFollowingOrderOnTheDetailsPage(Table table)
        {
            var columnElement = _driver.NowAt<DetailsPage>();
            var columnHeaders = columnElement.GetDetailsColorHeadersContentToList();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            Assert.AreEqual(expectedList, columnHeaders, "Column headers names are incorrect");
        }

        [Then(@"""(.*)"" rows are displayed in the agGrid on Capacity Units page")]
        [Then(@"""(.*)"" rows are displayed in the agGrid on Capacity Slots page")]
        [Then(@"""(.*)"" rows label displays in Action panel")]
        public void ThenRowsAreDisplayedInTheAgGridOnCapacityUnitsPage(string numberOfRows)
        {
            var detailsPage = _driver.NowAt<BaseDashboardPage>();
            //Wait for rows label is displayed
            Thread.Sleep(2000);
            StringAssert.AreEqualIgnoringCase(numberOfRows == "1" ? $"{numberOfRows} row" : $"{numberOfRows} rows",
                detailsPage.FoundRowsLabel.Text,
                "Incorrect rows count");
        }

        [When(@"User clicks on ""(.*)"" link on the Details Page")]
        public void WhenUserClicksOnLinkOnTheDetailsPage(string link)
        {
            var page = _driver.NowAt<DetailsPage>();
            _driver.WaitForDataLoading();
            page.GetLinkOnTheDetailsPageByName(link).Click();
        }

        [When(@"User clicks on ""(.*)"" link for Evergreen Bucket field")]
        public void WhenUserClicksOnLinkForEvergreenBucketField(string linkName)
        {
            var page = _driver.NowAt<DetailsPage>();
            _driver.WaitForDataLoading();
            page.GetEvergreenBucketLinkByFieldName(linkName).Click();
        }

        [When(@"User clicks on ""(.*)"" link for Evergreen Ring field")]
        public void WhenUserClicksOnLinkForEvergreenRingField(string linkName)
        {
            var page = _driver.NowAt<DetailsPage>();
            _driver.WaitForDataLoading();
            page.GetEvergreenRingLinkByFieldName(linkName).Click();
        }

        [When(@"User clicks on ""(.*)"" link for Evergreen Capacity Unit field")]
        public void WhenUserClicksOnLinkForEvergreenCapacityUnitField(string linkName)
        {
            var page = _driver.NowAt<DetailsPage>();
            _driver.WaitForDataLoading();
            page.GetEvergreenCapacityUnitLinkByFieldName(linkName).Click();
        }

        [Then(@"""(.*)"" link is displayed on the Details Page")]
        public void ThenLinkIsDisplayedOnTheDetailsPage(string bucketName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Assert.IsTrue(detailsPage.GetBucketLinkByName(bucketName).Displayed(), "Bucket link name was not changed");
        }

        [Then(@"popup changes window opened")]
        public void ThenPopupChangesWindowOpened()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            _driver.WaitWhileControlIsNotDisplayed<DetailsPage>(() => detailsPage.PopupChangesPanel);
            Assert.IsTrue(detailsPage.PopupChangesPanel.Displayed(), "Popup changes panel is not loaded");
        }

        [Then(@"User clicks on ""(.*)"" dropdown")]
        [When(@"User clicks on ""(.*)"" dropdown")]
        public void ThenUserClicksOnDropdown(string value)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            detailsPage.GetChangeValueInPopUpByName(value).Click();
        }

        [When(@"User select ""(.*)"" value on the Details Page")]
        public void WhenUserSelectValueOnTheDetailsPage(string bucketName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            _driver.WaitForDataLoading();
            detailsPage.GetValueByName(bucketName).Click();
        }

        [When(@"User selects all rows on the grid on the Details Page for ""(.*)""")]
        public void WhenUserSelectsAllRowsOnTheGridOnTheDetailsPageFor(string fieldName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            if (!detailsPage.OpenedPanelForUpdatingItems.Displayed())
            {
                var button = detailsPage.GetFieldToOpenTheTableByName(fieldName);
                _driver.MouseHover(button);
                button.Click();
                _driver.WaitForDataLoading();
                _driver.WaitWhileControlIsNotDisplayed<DetailsPage>(() => detailsPage.SelectAllCheckBox);
                detailsPage.SelectAllCheckBox.Click();
            }
            else
                detailsPage.SelectAllCheckBox.Click();
        }

        private void CheckColumnDisplayedState(Table table, bool displayedState)
        {
            var listPageMenu = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            foreach (var row in table.Rows)
            {
                _driver.WaitForDataLoading();
                Assert.AreEqual(displayedState, listPageMenu.IsColumnPresent(row["ColumnName"]),
                    $"Column '{row["ColumnName"]}' displayed state should be {displayedState}");
            }
        }
    }
}