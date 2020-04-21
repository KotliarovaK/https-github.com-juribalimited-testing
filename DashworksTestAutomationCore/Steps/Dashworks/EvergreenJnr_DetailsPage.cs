using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AutomationUtils.Utils;
using DashworksTestAutomation.DTO.RuntimeVariables;
using DashworksTestAutomation.Extensions;
using DashworksTestAutomation.Pages.Evergreen;
using DashworksTestAutomation.Pages.Evergreen.AdminDetailsPages;
using DashworksTestAutomation.Pages.Evergreen.Base;
using DashworksTestAutomation.Pages.Evergreen.DetailsTabsMenu;
using DashworksTestAutomation.Pages.Evergreen.ItemDetails;
using DashworksTestAutomation.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AutomationUtils.Extensions;

namespace DashworksTestAutomation.Steps.Dashworks
{
    [Binding]
    internal class EvergreenJnr_DetailsPage : SpecFlowContext
    {
        private readonly RemoteWebDriver _driver;
        private readonly ElementCoordinates _elementCoordinates;

        public EvergreenJnr_DetailsPage(RemoteWebDriver driver, ElementCoordinates elementCoordinates)
        {
            _driver = driver;
            _elementCoordinates = elementCoordinates;
        }

        [Then(@"Details object page is displayed to the user")]
        public void ThenDetailsObjectPageIsDisplayedToTheUser()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            _driver.WaitForDataLoading();
            Verify.IsTrue(detailsPage.GroupIcon.Displayed(), "Group con is not displayed to the user!");
            Verify.IsTrue(detailsPage.ItemDetailsContainer.Displayed(), "Details object page is not displayed to the user!");
        }

        #region Column dropdown filter

        [Then(@"string filter is displayed for '(.*)' column")]
        public void ThenStringFilterIsDisplayedForColumn(string columnName)
        {
            var detailsPage = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            Verify.IsFalse(Convert.ToBoolean(detailsPage.GetFilterByColumnName(columnName).GetAttribute("readonly")), $"String filter is not displayed for {columnName} column!");
        }

        //	| Values |
        [Then(@"following checkboxes are contained in the filter dropdown menu for the '(.*)' column:")]
        public void ThenFollowingStringValuesAreContainedInTheFilterDropdownForTheColumn(string columnName, Table table)
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.BodyContainer.Click();
            page.OpenColumnFilter(columnName);

            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            var actualList = filterElement.FilterCheckboxValuesForColumn.Select(value => value.Text).ToList();
            foreach (var row in table.Rows)
            {
                Verify.Contains(row["Values"], actualList, $"{row["Values"]} String values are not contained in the filter!");
            }

            page.BodyContainer.Click();
        }

        [Then(@"All text is not displayed for ""(.*)"" column in the String Filter")]
        public void ThenAllTextIsNotDisplayedForColumnInTheStringFilter(string columnName)
        {
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            Verify.IsFalse(filterElement.GetStringFilterTextByColumnName(columnName),
                $"All text is displayed for {columnName} column");
        }

        [When(@"User clicks following checkboxes from Column Settings panel for the '(.*)' column:")]
        public void WhenUserClicksFollowingCheckboxesFromColumnSettingsPanelForTheColumn(string columnName, Table table)
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.BodyContainer.Click();
            page.OpenColumnSettings(columnName);

            var menu = _driver.NowAt<ApplicationsDetailsTabsMenu>();

            if (!menu.ColumnPanelInColumnSettings.Displayed())
                menu.ColumnButton.Click();

            foreach (var row in table.Rows)
            {
                menu.GetColumnCheckbox(row["checkboxes"]).Click();
            }
            page.BodyContainer.Click();
        }

        [Then(@"'(.*)' checkbox is checked in the filter dropdown for the '(.*)' column")]
        public void ThenCheckboxIsCheckedInTheFilterDropdownForTheColumn(string checkboxName, string columnName)
        {
            var page = _driver.NowAt<BaseGridPage>();
            page.BodyContainer.Click();
            page.OpenColumnFilter(columnName);

            Verify.IsTrue(page.GetCheckedFilterByCheckboxName(checkboxName).Displayed(), $"{checkboxName} Checkbox is not selected");

            page.BodyContainer.Click();
        }

        #endregion

        #region Fields content

        [Then(@"Item content is displayed to the User")]
        public void ThenItemContentIsDisplayedToTheUser()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Verify.IsTrue(detailsPage.ItemDetailsContainer.Displayed(), "Item content is not displayed");
        }

        //	| Field | Data |
        [Then(@"User verifies data in the fields on details page")]
        public void ThenUserVerifiesDataInTheFieldsOnDetailsPage(Table table)
        {
            var detailsPage = _driver.NowAt<BaseDetailsPage>();
            foreach (TableRow row in table.Rows)
            {
                var field = row["Field"];
                var value = row["Data"];
                Verify.AreEqual(detailsPage.GetFieldContentByTitleName(field), value,
                    $"Incorrect data in the '{field}' field");
            }
        }

        //	| Title | Value |
        [Then(@"following content is displayed on the Details Page")]
        public void ThenFollowingContentIsDisplayedOnTheDetailsPage(Table table)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            _driver.WaitForDataLoading();
            foreach (var row in table.Rows)
            {
                Verify.IsTrue(detailsPage.GetCompareContentOnTheDetailsPage(row["Title"], row["Value"]).Displayed(),
                    $"{row["Title"]} does not match the {row["Value"]}");
            }
        }

        //	| Fields |
        [Then(@"following fields are displayed in the open section:")]
        public void ThenFollowingFieldsAreDisplayedInTheOpenSection(Table table)
        {
            var fields = _driver.NowAt<DetailsPage>();

            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = fields.FieldListOnDetailsPage.Select(value => value.Text).ToList();
            _driver.WaitForElementsToBeDisplayed(fields.FieldListOnDetailsPage);
            Verify.AreEqual(expectedList.Count, actualList.Count, "Incorrect items count in the table");
            Verify.AreEqual(expectedList, actualList, "Fields in the open section are different");
        }

        [Then(@"empty value is displayed for ""(.*)"" field on the Details Page")]
        public void ThenEmptyValueIsDisplayedForFieldOnTheDetailsPage(string fieldName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Verify.AreEqual(detailsPage.GetFieldWithEmptyValueByName(fieldName), "", $"{fieldName} field must be empty!");
        }

        [Then(@"User sees '(.*)' tooltip for '(.*)' value in the field")]
        public void ThenUserSeesTooltipForValueInTheField(string tooltip, string value)
        {
            var fields = _driver.NowAt<DetailsPage>();
            _driver.MouseHover(fields.GetCellByTextFromKeyValueGrid(value));
            var tooltipText = _driver.GetTooltipText();
            Verify.AreEqual(tooltip, tooltipText, $"Incorrect tooltip is displayed for '{value}' value in the field");
        }

        #endregion

        #region Columns

        [Then(@"""(.*)"" column is displayed to the user")]
        public void ThenColumnIsDisplayedToTheUser(string columnName)
        {
            var columnHeader = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            Verify.IsTrue(columnHeader.ColumnIsDisplayed(columnName),
                $"{columnName} column is not displayed");
        }

        [Then(@"""(.*)"" column is not displayed to the user")]
        public void ThenColumnIsNotDisplayedToTheUser(string columnName)
        {
            var columnHeader = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            Verify.IsFalse(columnHeader.ColumnIsDisplayed(columnName),
                $"{columnName} column still displayed");
        }

        [Then(@"following columns are displayed on the Item details page:")]
        public void ThenFollowingColumnsAreDisplayedOnTheItemDetailsPage(Table table)
        {
            var column = _driver.NowAt<DetailsPage>();

            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var columnNames = column.ColumnHeadersList.Select(value => value.Text).ToList();
            Verify.AreEqual(expectedList, columnNames, "The column order is incorrect.");
        }

        #endregion

        [When(@"User clicks ""(.*)"" link on the Details Page")]
        public void WhenUserClicksLinkOnTheDetailsPage(string linkName)
        {
            var detailsPage = _driver.NowAt<BaseGridPage>();
            detailsPage.GetLinkByName(linkName).Click();
            _driver.WaitForDataLoading();
        }

        [Then(@"Highcharts graphic is displayed on the Details Page")]
        public void ThenHighchartsGraphicIsDisplayedOnTheDetailsPage()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            _driver.WaitForElementToBeDisplayed(detailsPage.GraphicInOpenedSection);
            Verify.IsTrue(detailsPage.GraphicInOpenedSection.Displayed(), "Graphic content is not displayed");
        }

        [Then(@"Image item from ""(.*)"" column is displayed to the user")]
        public void ThenImageItemFromColumnIsDisplayedToTheUser(string columnName)
        {
            _driver.WaitForDataLoading();
            var content = _driver.FindElements(By.XPath(DetailsPage.ColumnWithImageAndLinkSelector));
            foreach (var element in content)
            {
                var image = element.FindElement(By.XPath(DetailsPage.ItemImageSelector));
                Verify.IsTrue(_driver.IsElementExists(image), "Image item is not found");
            }
        }

        [Then(@"Links from ""(.*)"" column is displayed to the user on the Details Page")]
        public void ThenLinksFromColumnIsDisplayedToTheUserOnTheDetailsPage(string columnName)
        {
            var content = _driver.NowAt<DetailsPage>();
            Verify.IsTrue(content.GetHrefByColumnName(columnName) != null, $"Links from '{columnName}' column is not displayed to the user");
        }

        [Then(@"Links from ""(.*)"" column is NOT displayed to the user on the Details Page")]
        public void ThenLinksFromColumnIsNOTDisplayedToTheUserOnTheDetailsPage(string columnName)
        {
            var content = _driver.NowAt<DetailsPage>();
            Verify.IsFalse(content.GetHrefByColumnName(columnName) != null, $"Links from '{columnName}' column is displayed, but should not be displayed!");
        }

        [When(@"User clicks String Filter button for ""(.*)"" column")]
        public void WhenUserClicksStringFilterButtonForColumn(string columnName)
        {
            var filterElement = _driver.NowAt<BaseGridPage>();
            filterElement.BodyContainer.Click();
            filterElement.OpenColumnFilter(columnName);
        }

        [When(@"User closes Checkbox filter")]
        public void WhenUserClosesCheckboxFilter()
        {
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            filterElement.BodyContainer.Click();
        }

        [Then(@"Dropdown List is displayed correctly in the Filter on the Details Page")]
        public void ThenDropdownListIsDisplayedCorrectlyInTheFilterOnTheDetailsPage()
        {
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            if (filterElement.GetCheckboxes().Count() > 5)
            {
                Verify.IsTrue(filterElement.AllCheckboxesSelectedStringFilter.Displayed(), "All checkbox is unchecked");
                Verify.IsFalse(filterElement.UncheckedStringFilters.Displayed(), "Checkbox is selected");
            }
            else
            {
                Verify.IsFalse(filterElement.UncheckedStringFilters.Displayed(), "Checkbox is selected");
            }

            filterElement.BodyContainer.Click();
        }

        [When(@"User selects ""(.*)"" text from key value grid on the Details Page")]
        public void WhenUserSelectsFollowingTextFromKeyValueGridOnTheDetailsPage(string textToBeSelected)
        {
            var page = _driver.NowAt<DetailsPage>();
            page.Actions.Click(page.GetCellByTextFromKeyValueGrid(textToBeSelected)).DoubleClick().Build().Perform();
        }

        [When(@"User clicks Column button on the Column Settings panel")]
        public void WhenUserClicksColumnButtonOnTheColumnSettingsPanel()
        {
            var menu = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            _driver.WaitForElementToBeDisplayed(menu.ColumnButton);
            menu.ColumnButton.Click();
        }

        [When(@"User clicks Select All checkbox on Column Settings panel")]
        public void WhenUserClicksSelectAllCheckboxOnColumnSettingsPanel()
        {
            var menu = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            menu.SelectAllCheckboxOnColumnSettingsPanel.Click();
        }

        [Then(@"Column Settings was opened")]
        public void ThenColumnSettingsWasOpened()
        {
            var menu = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            Verify.IsTrue(menu.ColumnSettingsPanel.Displayed(), "Column Settings is not opened");
        }

        [When(@"User clicks Filter button on the Column Settings panel")]
        public void WhenUserClicksFilterButtonOnTheColumnSettingsPanel()
        {
            var menu = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            _driver.MouseHover(menu.FilterButton);
            _driver.WaitForElementToBeDisplayed(menu.FilterButton);
            menu.FilterButton.Click();
        }

        [When(@"User clicks the filter type dropdown on the Column Settings panel")]
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
            Verify.AreEqual(expectedList, actualList, "Filter type values are different");
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

            _elementCoordinates.Height = page.DateRegularValueFirst.Location.X;
            _elementCoordinates.Width = page.DateRegularValueFirst.Location.Y;
        }

        [Then(@"User checks that date input has same position")]
        public void ThenUserChecksThatHasSamePosition()
        {
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();

            Verify.That(page.DateRegularValueFirst.Location.X, Is.InRange(_elementCoordinates.Height - 10, _elementCoordinates.Height + 10)); // calibration
            Verify.That(page.DateRegularValueFirst.Location.Y, Is.InRange(_elementCoordinates.Width - 10, _elementCoordinates.Width + 10)); // calibration
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
            //Verify.IsTrue(tableElement.TableContent.Displayed(), "Table is empty");
            Verify.IsTrue(tableElement.TableRows.Count > 0, "Table is empty");
        }

        [Then(@"Site column has standard size")]
        public void ThenSiteColumnHasStandardSize()
        {
            var filterPanel = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            if (!_driver.IsElementDisplayed(By.XPath(ApplicationsDetailsTabsMenu.SiteColumnSelector)))
            { }
            else
                Verify.AreEqual("97px", filterPanel.PackageSiteColumnWidth(), "Column is not a standard size!");
        }

        [Then(@"Bucket pop-up has standard size on the Details Page")]
        public void ThenBucketPop_UpHasStandardSizeOnTheDetailsPage()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Verify.AreEqual("1536px", detailsPage.GetInstalledBucketWindowWidth().Split('.').First(), "Bucket pop-up is not a standard size!");
        }

        [When(@"User enters ""(.*)"" text in the Filter field")]
        public void ThenUserEntersTextInTheFilterField(string searchedText)
        {
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            _driver.WaitForElementToBeDisplayed(filterElement.FilterSearchTextBox);
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
            page.GetColumnCheckbox(checkboxName).Click();
        }

        //TODO:  change check logic for checkboxes
        [Then(@"Checkboxes are checked on the Column Settings panel for ""(.*)"" Column Settings panel:")]
        public void ThenCheckboxesAreCheckedOnTheColumnSettingsPanelForColumnSettingsPanel(string columnName,
            Table table)
        {
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            var column = _driver.NowAt<BaseGridPage>();
            column.OpenColumnSettings(columnName);

            foreach (var row in table.Rows)
            {
                Verify.IsTrue(page.GetColumnCheckbox(row["Checkbox"]).Selected(), $"'{row["Checkbox"]}' checkboxes are not checked on the Column Settings panel for '{columnName}' column");
            }
        }

        [Then(@"following columns added to the table:")]
        public void ThenFollowingColumnsAddedToTheTable(Table table)
        {
            CheckColumnDisplayedState(table, true);
        }

        [Then(@"content is present in the following newly added columns:")]
        public void ThenContentIsPresentInTheFollowingNewlyAddedColumns(Table table)
        {
            var page = _driver.NowAt<BaseGridPage>();

            foreach (var row in table.Rows)
                if (row["ColumnName"] != "Group Key" && row["ColumnName"] != "Category Key")
                {
                    var content = page.GetColumnContentByColumnName(row["ColumnName"]);
                    Verify.IsTrue(content.Count(x => !string.IsNullOrEmpty(x)) > 0, "Newly added column is empty");
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
                Verify.AreEqual(expectedList, columnNames, "Columns order is incorrect");
            }
        }

        [Then(@"Content is present in the column of the Details Page table")]
        public void ThenContentIsPresentInTheColumnOfTheDetailsPageTable(Table table)
        {
            var page = _driver.NowAt<BaseGridPage>();

            foreach (var row in table.Rows)
            {
                var content = page.GetColumnContentByColumnName(row["ColumnName"]);
                //Check that at least 1 cell has some content
                Verify.IsTrue(content.Count(x => !string.IsNullOrEmpty(x)) > 0, "Column is empty");
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

                Verify.IsTrue(!string.IsNullOrEmpty(pair.Value),
                    $"'Unknown' text is not displayed for {pair.Key} field ");
            }
        }

        [Then(@"Group Icon for Group Details page is displayed")]
        public void ThenGroupIconForPageIsDisplayed()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Verify.IsTrue(detailsPage.GroupIcon.Displayed(), "Group Icon for Group Details page is not displayed");
        }

        [Then(@"""(.*)"" text is displayed for opened tab")]
        public void ThenTextIsDisplayedForOpenedTab(string textMessage)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            _driver.WaitForElementToBeDisplayed(detailsPage.NoFoundContent);
            Verify.AreEqual(textMessage, detailsPage.NoFoundContent.Text,
                $"{textMessage} is not displayed");
        }

        [Then(@"User sees ""(.*)"" Evergreen Bucket in Project Summary section on the Details Page")]
        public void ThenUserSeesEvergreenBucketInProjectSummarySectionOnTheDetailsPage(string bucketName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();

            Verify.That(detailsPage.ProjectSummaryBucketValue.Text, Is.EqualTo(bucketName));
        }

        [Then(@"""(.*)"" field display state is ""(.*)"" on Details tab")]
        public void ThenFieldDisplayStateIsOnDetailsTab(string fieldName, bool state)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Verify.AreEqual(state, detailsPage.IsFieldPresent(fieldName), $"Incorrect display state for {fieldName}");
        }

        [Then(@"Empty rows are displayed if the data is unknown")]
        public void ThenEmptyRowsAreDisplayedIfTheDataIsUnknown()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            if (!detailsPage.TableRowDetails.Any())
                throw new Exception($"Details table is not visible");

            foreach (var element in detailsPage.TableRowDetails)
                Verify.DoesNotContain("Unknown", element.Text,
                    "Unknown text is displayed");
        }

        [Then(@"Rows do not have unknown values")]
        public void ThenRowsDoNotHaveUnknownValues()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            foreach (var element in page.GridRows)
                Verify.DoesNotContain("Unknown", element.Text,
                    "Unknown text is displayed");
        }

        [Then(@"Static list grid has ""(.*)"" rows")]
        [Then(@"Static list grid still has ""(.*)"" rows")]
        public void ThenAgGridHasRows(int rowsCount)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Verify.That(page.GridRows.Count, Is.EqualTo(rowsCount),
                $"Incorrect number of rows in agGrid.");
        }

        [Then(@"""(.*)"" rows found label displays on Details Page")]
        public void ThenCorrectFoundRowsLabelDisplaysOnTheDetailsPage(string numberOfRows)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            //Wait for rows label is displayed
            Thread.Sleep(2000);
            Verify.AreEqualIgnoringCase(numberOfRows == "1" ? $"{numberOfRows} row" : $"{numberOfRows} rows",
                detailsPage.RowsLabel.Text,
                "Incorrect rows count");
        }

        [Then(@"Name of colors are displayed in following order on the Details Page:")]
        public void ThenNameOfColorsAreDisplayedInFollowingOrderOnTheDetailsPage(Table table)
        {
            var columnElement = _driver.NowAt<DetailsPage>();
            var columnHeaders = columnElement.GetDetailsColorHeadersContentToList();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            Verify.AreEqual(expectedList, columnHeaders, "Column headers names are incorrect");
        }

        //TODO should be removed. All methods that check assertion methods should check errors below textbox elements or datepickers etch
        [Then(@"""(.*)"" rows are displayed in the agGrid on Capacity Units page")]
        [Then(@"""(.*)"" rows are displayed in the agGrid on Capacity Slots page")]
        [Then(@"""(.*)"" rows label displays in Action panel")]
        public void ThenRowsAreDisplayedInTheAgGridOnCapacityUnitsPage(string numberOfRows)
        {
            var detailsPage = _driver.NowAt<BaseDashboardPage>();
            //Wait for rows label is displayed
            Thread.Sleep(2000);
            Verify.AreEqualIgnoringCase(numberOfRows == "1" ? $"{numberOfRows} row" : $"{numberOfRows} rows",
                detailsPage.FoundRowsLabel.Text,
                "Incorrect rows count");
        }

        #region Edit/Pen button for field

        [When(@"User clicks on edit button for '(.*)' field")]
        public void WhenUserClicksOnEditButtonForField(string fieldName)
        {
            var page = _driver.NowAt<DetailsPage>();
            page.ClickEditFieldButton(fieldName);
        }

        [Then(@"button for editing the '(.*)' field is displayed")]
        public void ThenButtonForEditingTheFieldIsDisplayed(string fieldName)
        {
            var page = _driver.NowAt<DetailsPage>();
            Verify.IsTrue(page.EditFieldButtonDisplaying(fieldName), $"Edit button for '{fieldName}' field is not displayed");
        }

        [Then(@"button for editing the '(.*)' field is not displayed")]
        public void ThenButtonForEditingTheFieldIsNotDisplayed(string fieldName)
        {
            var page = _driver.NowAt<DetailsPage>();
            Verify.IsFalse(page.EditFieldButtonDisplaying(fieldName), $"Edit button for '{fieldName}' field is displayed");
        }

        [Then(@"arrow for editing the '(.*)' field is not displayed")]
        public void ThenArrowForEditingTheFieldIsNotDisplayed(string fieldName)
        {
            var page = _driver.NowAt<DetailsPage>();
            Verify.IsFalse(page.EditArrowDisplaying(fieldName), $"Edit arrow for '{fieldName}' field is displayed");
        }

        #endregion

        [Then(@"""(.*)"" link is displayed on the Details Page")]
        public void ThenLinkIsDisplayedOnTheDetailsPage(string linkName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Verify.IsTrue(detailsPage.LinkIsDisplayed(linkName).Displayed(), $"'{linkName}' link name was not changed");
        }

        private void CheckColumnDisplayedState(Table table, bool displayedState)
        {
            var listPageMenu = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            foreach (var row in table.Rows)
            {
                _driver.WaitForDataLoading();
                Verify.AreEqual(displayedState, listPageMenu.IsColumnPresent(row["ColumnName"]),
                    $"Column '{row["ColumnName"]}' displayed state should be {displayedState}");
            }
        }
    }
}