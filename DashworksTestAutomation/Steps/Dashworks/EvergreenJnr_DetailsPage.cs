using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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

        [When(@"User opens ""(.*)"" section on the Details Page")]
        public void WhenUserOpensSectionOnTheDetailsPage(string sectionName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            _driver.WaitForElementToBeDisplayed(detailsPage.PopupChangesPanel);
            if (!detailsPage.OpenedSection.Displayed())
            {
                _driver.MouseHover(detailsPage.NavigateToSectionByName(sectionName));
                detailsPage.NavigateToSectionByName(sectionName).Click();
            }
            else
                Utils.Verify.IsTrue(detailsPage.OpenedSection.Displayed(), "Section content is not loaded");
        }

        [When(@"User clicks ""(.*)"" link on the Details Page")]
        public void WhenUserClicksLinkOnTheDetailsPage(string linkName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            if (!_driver.IsElementDisplayed(detailsPage.GetLinkByNameSelector(linkName), WebDriverExtensions.WaitTime.Short))
                _driver.WaitForElementToBeDisplayedAfterRefresh(detailsPage.GetLinkByNameSelector(linkName), true, 50);
            detailsPage.GetLinkByName(linkName).Click();
            _driver.WaitForDataLoading();
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
                Utils.Verify.AreEqual(detailsPage.GetFieldContentByTitleName(field), value,
                    $"Incorrect data in the '{field}' field");
            }
        }

        [Then(@"""(.*)"" content is displayed in ""(.*)"" field on Item Details page")]
        public void ThenContentIsDisplayedInFieldOnItemDetailsPage(string text, string fieldName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Utils.Verify.IsTrue(detailsPage.FieldContentByName(text, fieldName).Displayed(),
                $"'{fieldName}' field does not contain the '{text}' content");
        }

        [Then(@"following content is displayed on the Details Page")]
        public void ThenFollowingContentIsDisplayedOnTheDetailsPage(Table table)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            _driver.WaitForDataLoading();
            foreach (var row in table.Rows)
            {
                Utils.Verify.IsTrue(detailsPage.GetCompareContentOnTheDetailsPage(row["Title"], row["Value"]).Displayed(),
                    $"{row["Title"]} does not match the {row["Value"]}");
            }
        }

        [Then(@"following fields are displayed in the open section:")]
        public void ThenFollowingFieldsAreDisplayedInTheOpenSection(Table table)
        {
            var fields = _driver.NowAt<DetailsPage>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var actualList = fields.FieldListOnDetailsPage.Select(value => value.Text).ToList();
            Utils.Verify.AreEqual(expectedList, actualList, "Fields in the open section are different");
        }

        [Then(@"empty value is displayed for ""(.*)"" field on the Details Page")]
        public void ThenEmptyValueIsDisplayedForFieldOnTheDetailsPage(string fieldName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Utils.Verify.AreEqual(detailsPage.GetFildWithEmptyValueByName(fieldName), "", $"{fieldName} field must be empty!");

        }

        [Then(@"Highcharts graphic is displayed on the Details Page")]
        public void ThenHighchartsGraphicIsDisplayedOnTheDetailsPage()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            _driver.WaitForElementToBeDisplayed(detailsPage.GraphicInOpenedSection);
            Utils.Verify.IsTrue(detailsPage.GraphicInOpenedSection.Displayed(), "Graphic content is not displayed");
        }

        [Then(@"""(.*)"" message is displayed on the Details Page")]
        public void ThenMessageIsDisplayedOnTheDetailsPage(string message)
        {
            var listElement = _driver.NowAt<DetailsPage>();
            if (!_driver.IsElementDisplayed(listElement.NoFoundMessage, WebDriverExtensions.WaitTime.Long))
                throw new Exception($"'{message}' was not displayed");
            Utils.Verify.AreEqual(message, listElement.NoFoundMessage.Text, $"{message} is not displayed");
        }

        [Then(@"Item content is displayed to the User")]
        public void ThenItemContentIsDisplayedToTheUser()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Utils.Verify.IsTrue(detailsPage.ItemDetailsContainer.Displayed(), "Item content is not displayed");
        }

        [Then(@"Details object page is displayed to the user")]
        public void ThenDetailsObjectPageIsDisplayedToTheUser()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            _driver.WaitForDataLoading();
            Utils.Verify.IsTrue(detailsPage.GroupIcon.Displayed(), "Group con is not displayed to the user!");
            Utils.Verify.IsTrue(detailsPage.ItemDetailsContainer.Displayed(), "Details object page is not displayed to the user!");
        }

        [Then(@"Image item from ""(.*)"" column is displayed to the user")]
        public void ThenImageItemFromColumnIsDisplayedToTheUser(string columnName)
        {
            _driver.WaitForDataLoading();
            var content = _driver.FindElements(By.XPath(DetailsPage.ColumnWithImageAndLinkSelector));
            foreach (var element in content)
            {
                var image = element.FindElement(By.XPath(DetailsPage.ItemImageSelector));
                Utils.Verify.IsTrue(_driver.IsElementExists(image), "Image item is not found");
            }
        }

        [Then(@"Links from ""(.*)"" column is displayed to the user on the Details Page")]
        public void ThenLinksFromColumnIsDisplayedToTheUserOnTheDetailsPage(string columnName)
        {
            var content = _driver.NowAt<DetailsPage>();
            Utils.Verify.IsTrue(content.GetHrefByColumnName(columnName) != null, $"Links from '{columnName}' column is not displayed to the user");
        }

        [Then(@"Links from ""(.*)"" column is NOT displayed to the user on the Details Page")]
        public void ThenLinksFromColumnIsNOTDisplayedToTheUserOnTheDetailsPage(string columnName)
        {
            var content = _driver.NowAt<DetailsPage>();
            Utils.Verify.IsFalse(content.GetHrefByColumnName(columnName) != null, $"Links from '{columnName}' column is displayed, but should not be displayed!");
        }

        [Then(@"expanded section is displayed to the User")]
        public void ThenExpandedSectionIsDisplayedToTheUser()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Utils.Verify.IsTrue(detailsPage.SectionContainer.Displayed(), "Section is not displayed");
        }

        [Then(@"""(.*)"" column is displayed to the user")]
        public void ThenColumnIsDisplayedToTheUser(string columnName)
        {
            var columnHeader = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            Utils.Verify.IsTrue(columnHeader.ColumnIsDisplayed(columnName),
                $"{columnName} column is not displayed");
        }

        [Then(@"""(.*)"" column is not displayed to the user")]
        public void ThenColumnIsNotDisplayedToTheUser(string columnName)
        {
            var columnHeader = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            Utils.Verify.IsFalse(columnHeader.ColumnIsDisplayed(columnName),
                $"{columnName} column still displayed");
        }

        [Then(@"following columns are displayed on the Item details page:")]
        public void ThenFollowingColumnsAreDisplayedOnTheItemDetailsPage(Table table)
        {
            var column = _driver.NowAt<DetailsPage>();

            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var columnNames = column.ColumnHeadersList.Select(value => value.Text).ToList();
            Utils.Verify.AreEqual(expectedList, columnNames, "Columns order on Item details page is incorrect");
        }

        [When(@"User clicks String Filter button for ""(.*)"" column")]
        public void WhenUserClicksStringFilterButtonForColumn(string columnName)
        {
            var filterElement = _driver.NowAt<BaseGridPage>();
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
            Utils.Verify.IsTrue(filterElement.GetStringFilterTextByColumnName(columnName),
                $"All text is not displayed for {columnName} column");
        }

        [Then(@"All text is not displayed for ""(.*)"" column in the String Filter")]
        public void ThenAllTextIsNotDisplayedForColumnInTheStringFilter(string columnName)
        {
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            Utils.Verify.IsFalse(filterElement.GetStringFilterTextByColumnName(columnName),
                $"All text is displayed for {columnName} column");
        }

        [Then(@"Dropdown List is displayed correctly in the Filter on the Details Page")]
        public void ThenDropdownListIsDisplayedCorrectlyInTheFilterOnTheDetailsPage()
        {
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            if (filterElement.GetCheckboxes().Count() > 5)
            {
                Utils.Verify.IsTrue(filterElement.AllCheckboxesSelectedStringFilter.Displayed(), "All checkbox is unchecked");
                Utils.Verify.IsFalse(filterElement.UncheckedStringFilters.Displayed(), "Checkbox is selected");
            }
            else
            {
                Utils.Verify.IsFalse(filterElement.UncheckedStringFilters.Displayed(), "Checkbox is selected");
            }

            filterElement.BodyContainer.Click();
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

            Utils.Verify.That(page.GetSelectedText(), Is.EqualTo(textSelected));
        }

        [Then(@"following Boolean Values are displayed in the filter on the Details Page")]
        public void ThenFollowingBooleanValuesAreDisplayedInTheFilterOnTheDetailsPage(Table table)
        {
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            var expectedList = table.Rows.SelectMany(row => row.Values);
            var actualList = filterElement.FilterCheckboxBooleanValues.Select(value => value.Text);
            Utils.Verify.AreEqual(expectedList, actualList, "Filter checkbox Boolean values are different");
        }

        [Then(@"following String Values are displayed in the filter on the Details Page")]
        public void ThenFollowingValuesAreDisplayedInTheFilterOnTheDetailsPage(Table table)
        {
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            var expectedList = table.Rows.SelectMany(row => row.Values);
            var actualList = filterElement.FilterCheckboxStringValues.Select(value => value.Text);
            Utils.Verify.AreEqual(expectedList, actualList, "Filter checkbox String values are different!");
        }

        [Then(@"following String Values are contained in the filter on the Details Page")]
        public void ThenFollowingStringValuesAreContainedInTheFilterOnTheDetailsPage(Table table)
        {
            var filterElement = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            var actualList = filterElement.FilterCheckboxStringValues.Select(value => value.Text).ToList();
            foreach (var row in table.Rows)
            {
                Utils.Verify.Contains(row["Values"], actualList, $"{row["Values"]} String values are not contained in the filter!");
            }
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
            Utils.Verify.IsTrue(menu.ColumnSettingsPanel.Displayed(), "Column Settings is not opened");
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
            Utils.Verify.AreEqual(expectedList, actualList, "Filter type values are different");
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

            Utils.Verify.That(page.DateRegularValueFirst.Location.X, Is.InRange(_elementCoordinates.Height - 10, _elementCoordinates.Height + 10)); // calibration
            Utils.Verify.That(page.DateRegularValueFirst.Location.Y, Is.InRange(_elementCoordinates.Width - 10, _elementCoordinates.Width + 10)); // calibration
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
            Utils.Verify.IsTrue(filterElement.ColumnCheckboxChecked.Displayed(), $"{checkboxName} Checkbox is not selected");
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
            //Utils.Verify.IsTrue(tableElement.TableContent.Displayed(), "Table is empty");
            Utils.Verify.IsTrue(tableElement.TableRows.Count > 0, "Table is empty");
        }

        [Then(@"Site column has standard size")]
        public void ThenSiteColumnHasStandardSize()
        {
            var filterPanel = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            if (!_driver.IsElementDisplayed(By.XPath(ApplicationsDetailsTabsMenu.SiteColumnSelector)))
            { }
            else
                Utils.Verify.AreEqual("97px", filterPanel.PackageSiteColumnWidth(), "Column is not a standard size!");
        }

        [Then(@"Bucket pop-up has standard size on the Details Page")]
        public void ThenBucketPop_UpHasStandardSizeOnTheDetailsPage()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Utils.Verify.AreEqual("1536px", detailsPage.GetInstalledBucketWindowWidth().Split('.').First(), "Bucket pop-up is not a standard size!");
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
            page.GetCheckboxByName(checkboxName);
        }
        //TODO change check logic for checkboxes
        [Then(@"Checkboxes are checked on the Column Settings panel for ""(.*)"" Column Settings panel:")]
        public void ThenCheckboxesAreCheckedOnTheColumnSettingsPanelForColumnSettingsPanel(string columnName,
            Table table)
        {
            var page = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            var expectedList = table.Rows.SelectMany(row => row.Values).ToList();
            var column = _driver.NowAt<BaseGridPage>();
            column.OpenColumnSettingsByName(columnName);
            Verify.AreEqual(expectedList, page.GetCheckedElementsText(), "Checkbox is not selected");
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
                    Utils.Verify.IsTrue(content.Count(x => !string.IsNullOrEmpty(x)) > 0, "Newly added column is empty");
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
                Utils.Verify.AreEqual(expectedList, columnNames, "Columns order is incorrect");
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
                Utils.Verify.IsTrue(content.Count(x => !string.IsNullOrEmpty(x)) > 0, "Column is empty");
            }
        }

        [Then(@"Custom fields agGrid columns are displayed fully")]
        public void CustomFieldsAgGridColumnsAreDisplayedFully()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            int totalHeaderWidth = page.GetTotalWidthOfGridHeaders();

            var grid = _driver.NowAt<AggridHeaderCounterElement>();
            int toolbar = grid.AgGridToolbar.Size.Width;

            Verify.That((toolbar - totalHeaderWidth), Is.EqualTo(0),
                $"Check Toolbar: {toolbar} VS Grid headers: {totalHeaderWidth} size");
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

                Utils.Verify.IsTrue(!string.IsNullOrEmpty(pair.Value),
                    $"'Unknown' text is not displayed for {pair.Key} field ");
            }
        }

        [Then(@"Group Icon for Group Details page is displayed")]
        public void ThenGroupIconForPageIsDisplayed()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Utils.Verify.IsTrue(detailsPage.GroupIcon.Displayed(), "Group Icon for Group Details page is not displayed");
        }

        [Then(@"""(.*)"" text is displayed for opened tab")]
        public void ThenTextIsDisplayedForOpenedTab(string textMessage)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            _driver.WaitForElementToBeDisplayed(detailsPage.NoFoundContent);
            Utils.Verify.AreEqual(textMessage, detailsPage.NoFoundContent.Text,
                $"{textMessage} is not displayed");
        }

        [Then(@"string filter is displayed for ""(.*)"" column on the Details Page")]
        public void ThenStringFilterIsDisplayedForColumnOnTheDetailsPage(string columnName)
        {
            var detailsPage = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            Utils.Verify.IsFalse(Convert.ToBoolean(detailsPage.GetFilterByColumnName(columnName).GetAttribute("readonly")), $"String filter is not displayed for {columnName} column!");
        }

        [Then(@"User sees ""(.*)"" Evergreen Bucket in Project Summary section on the Details Page")]
        public void ThenUserSeesEvergreenBucketInProjectSummarySectionOnTheDetailsPage(string bucketName)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();

            Utils.Verify.That(detailsPage.ProjectSummaryBucketValue.Text, Is.EqualTo(bucketName));
        }

        [When(@"User clicks content of Evergreen Ring in Project Summary section on the Details Page")]
        public void WhenUserClicksEvergreenRingInProjectSummarySectionOnTheDetailsPage()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            _driver.WaitForElementToBeDisplayed(detailsPage.ProjectSummaryRingValue);
            detailsPage.ProjectSummaryRingValue.Click();
        }

        [When(@"User clicks New Ring ddl in popup of Project Summary section on the Details Page")]
        public void WhenUserClicksNewRingDdlOfInProjectSummarySectionOnTheDetailsPage()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            _driver.WaitForElementToBeDisplayed(detailsPage.ProjectSummaryRingPopupDDL);
            detailsPage.ProjectSummaryRingPopupDDL.Click();
        }

        [Then(@"Rings ddl contains data on Project Summary section of the Details Page")]
        public void ThenRingDdlContainsOptionsInProjectSummarySectionOnTheDetailsPage()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Utils.Verify.That(detailsPage.OperatorOptions.Select(value => value.Text).ToList().All(x => x.Contains("Ring") || x.Contains("Unassigned")),
                "Some options are not available for selected filter");
        }

        [Then(@"""(.*)"" field display state is ""(.*)"" on Details tab")]
        public void ThenFieldDisplayStateIsOnDetailsTab(string fieldName, bool state)
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            Utils.Verify.AreEqual(state, detailsPage.IsFieldPresent(fieldName), $"Incorrect display state for {fieldName}");
        }

        [Then(@"Empty rows are displayed if the data is unknown")]
        public void ThenEmptyRowsAreDisplayedIfTheDataIsUnknown()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            if (!detailsPage.TableRowDetails.Any())
                throw new Exception($"Details table is not visible");

            foreach (var element in detailsPage.TableRowDetails)
                Utils.Verify.DoesNotContain("Unknown", element.Text,
                    "Unknown text is displayed");
        }

        [Then(@"Rows do not have unknown values")]
        public void ThenRowsDoNotHaveUnknownValues()
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            foreach (var element in page.GridRows)
                Utils.Verify.DoesNotContain("Unknown", element.Text,
                    "Unknown text is displayed");
        }

        [Then(@"Static list grid has ""(.*)"" rows")]
        [Then(@"Static list grid still has ""(.*)"" rows")]
        public void ThenAgGridHasRows(int rowsCount)
        {
            var page = _driver.NowAt<BaseDashboardPage>();
            Utils.Verify.That(page.GridRows.Count, Is.EqualTo(rowsCount),
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
            Utils.Verify.AreEqual(expectedList, columnHeaders, "Column headers names are incorrect");
        }

        [Then(@"""(.*)"" rows are displayed in the agGrid on Capacity Units page")]
        [Then(@"""(.*)"" rows are displayed in the agGrid on Capacity Slots page")]
        [Then(@"""(.*)"" rows label displays in Action panel")]
        public void ThenRowsAreDisplayedInTheAgGridOnCapacityUnitsPage(string numberOfRows)
        {
            var detailsPage = _driver.NowAt<BaseDashboardPage>();
            //Wait for rows label is displayed
            Thread.Sleep(2000);
            Utils.Verify.AreEqualIgnoringCase(numberOfRows == "1" ? $"{numberOfRows} row" : $"{numberOfRows} rows",
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
            _driver.WaitForElementToBeDisplayed(detailsPage.GetBucketLinkByName(bucketName));
            Utils.Verify.IsTrue(detailsPage.GetBucketLinkByName(bucketName).Displayed(), "Bucket link name was not changed");
        }

        [Then(@"popup changes window opened")]
        public void ThenPopupChangesWindowOpened()
        {
            var detailsPage = _driver.NowAt<DetailsPage>();
            _driver.WaitForElementToBeDisplayed(detailsPage.PopupChangesPanel);
            Utils.Verify.IsTrue(detailsPage.PopupChangesPanel.Displayed(), "Popup changes panel is not loaded");
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
                _driver.WaitForElementToBeDisplayed(detailsPage.SelectAllCheckBox);
                detailsPage.SelectAllCheckBox.Click();
            }
            else
                _driver.WaitForElementToBeDisplayed(detailsPage.SelectAllCheckBox);
            detailsPage.SelectAllCheckBox.Click();
        }

        private void CheckColumnDisplayedState(Table table, bool displayedState)
        {
            var listPageMenu = _driver.NowAt<ApplicationsDetailsTabsMenu>();
            foreach (var row in table.Rows)
            {
                _driver.WaitForDataLoading();
                Utils.Verify.AreEqual(displayedState, listPageMenu.IsColumnPresent(row["ColumnName"]),
                    $"Column '{row["ColumnName"]}' displayed state should be {displayedState}");
            }
        }
    }
}